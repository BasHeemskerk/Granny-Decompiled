using System;
using UnityEngine;

[Serializable]
public class tapcontrol : MonoBehaviour
{
	public GameObject cameraObject;

	public Transform cameraPivot;

	public GUITexture jumpButton;

	public float speed;

	public float jumpSpeed;

	public float inAirMultiplier;

	public float minimumDistanceToMove;

	public float minimumTimeUntilMove;

	public bool zoomEnabled;

	public float zoomEpsilon;

	public float zoomRate;

	public bool rotateEnabled;

	public float rotateEpsilon;

	private ZoomCamera zoomCamera;

	private Camera cam;

	private Transform thisTransform;

	private CharacterController character;

	private AnimationController animationController;

	private Vector3 targetLocation;

	private bool moving;

	private float rotationTarget;

	private float rotationVelocity;

	private Vector3 velocity;

	private ControlState state;

	private int[] fingerDown;

	private Vector2[] fingerDownPosition;

	private int[] fingerDownFrame;

	private float firstTouchTime;

	public tapcontrol()
	{
		inAirMultiplier = 0.25f;
		minimumDistanceToMove = 1f;
		minimumTimeUntilMove = 0.25f;
		rotateEpsilon = 1f;
		state = ControlState.WaitingForFirstTouch;
		fingerDown = new int[2];
		fingerDownPosition = new Vector2[2];
		fingerDownFrame = new int[2];
	}

	public virtual void Start()
	{
		thisTransform = base.transform;
		zoomCamera = (ZoomCamera)cameraObject.GetComponent(typeof(ZoomCamera));
		cam = cameraObject.GetComponent<Camera>();
		character = (CharacterController)GetComponent(typeof(CharacterController));
		animationController = (AnimationController)GetComponent(typeof(AnimationController));
		animationController.maxForwardSpeed = speed;
		ResetControlState();
		GameObject gameObject = GameObject.Find("PlayerSpawn");
		if ((bool)gameObject)
		{
			thisTransform.position = gameObject.transform.position;
		}
	}

	public virtual void OnEndGame()
	{
		base.enabled = false;
	}

	public virtual void FaceMovementDirection()
	{
		Vector3 vector = character.velocity;
		vector.y = 0f;
		if (vector.magnitude > 0.1f)
		{
			thisTransform.forward = vector.normalized;
		}
	}

	public virtual void CameraControl(Touch touch0, Touch touch1)
	{
		if (rotateEnabled && state == ControlState.RotatingCamera)
		{
			Vector2 vector = touch1.position - touch0.position;
			Vector2 lhs = vector / vector.magnitude;
			Vector2 vector2 = touch1.position - touch1.deltaPosition - (touch0.position - touch0.deltaPosition);
			Vector2 rhs = vector2 / vector2.magnitude;
			float num = Vector2.Dot(lhs, rhs);
			if (num < 1f)
			{
				Vector3 lhs2 = new Vector3(vector.x, vector.y);
				Vector3 rhs2 = new Vector3(vector2.x, vector2.y);
				float z = Vector3.Cross(lhs2, rhs2).normalized.z;
				float num2 = Mathf.Acos(num);
				rotationTarget += num2 * 57.29578f * z;
				if (rotationTarget < 0f)
				{
					rotationTarget += 360f;
				}
				else if (rotationTarget >= 360f)
				{
					rotationTarget -= 360f;
				}
			}
		}
		else if (zoomEnabled && state == ControlState.ZoomingCamera)
		{
			float magnitude = (touch1.position - touch0.position).magnitude;
			float magnitude2 = (touch1.position - touch1.deltaPosition - (touch0.position - touch0.deltaPosition)).magnitude;
			float num3 = magnitude - magnitude2;
			zoomCamera.zoom += num3 * zoomRate * Time.deltaTime;
		}
	}

	public virtual void CharacterControl()
	{
		RaycastHit hitInfo = default(RaycastHit);
		int touchCount = Input.touchCount;
		if (touchCount == 1 && state == ControlState.MovingCharacter)
		{
			Touch touch = Input.GetTouch(0);
			if (character.isGrounded && jumpButton.HitTest(touch.position))
			{
				velocity = character.velocity;
				velocity.y = jumpSpeed;
			}
			else if (!jumpButton.HitTest(touch.position) && touch.phase != 0)
			{
				Ray ray = cam.ScreenPointToRay(new Vector3(touch.position.x, touch.position.y));
				if (Physics.Raycast(ray, out hitInfo))
				{
					float magnitude = (base.transform.position - hitInfo.point).magnitude;
					if (magnitude > minimumDistanceToMove)
					{
						targetLocation = hitInfo.point;
					}
					moving = true;
				}
			}
		}
		Vector3 motion = Vector3.zero;
		if (moving)
		{
			motion = targetLocation - thisTransform.position;
			motion.y = 0f;
			float magnitude2 = motion.magnitude;
			if (magnitude2 < 1f)
			{
				moving = false;
			}
			else
			{
				motion = motion.normalized * speed;
			}
		}
		if (!character.isGrounded)
		{
			velocity.y += Physics.gravity.y * Time.deltaTime;
			motion.x *= inAirMultiplier;
			motion.z *= inAirMultiplier;
		}
		motion += velocity;
		motion += Physics.gravity;
		motion *= Time.deltaTime;
		character.Move(motion);
		if (character.isGrounded)
		{
			velocity = Vector3.zero;
		}
		FaceMovementDirection();
	}

	public virtual void ResetControlState()
	{
		state = ControlState.WaitingForFirstTouch;
		fingerDown[0] = -1;
		fingerDown[1] = -1;
	}

	public virtual void Update()
	{
		int num = 0;
		Touch touch = default(Touch);
		Touch touch2 = default(Touch);
		Touch touch3 = default(Touch);
		int touchCount = Input.touchCount;
		if (touchCount == 0)
		{
			ResetControlState();
		}
		else
		{
			Touch[] touches = Input.touches;
			bool flag = false;
			bool flag2 = false;
			if (state == ControlState.WaitingForFirstTouch)
			{
				for (num = 0; num < touchCount; num++)
				{
					touch = touches[num];
					if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
					{
						state = ControlState.WaitingForSecondTouch;
						firstTouchTime = Time.time;
						fingerDown[0] = touch.fingerId;
						fingerDownPosition[0] = touch.position;
						fingerDownFrame[0] = Time.frameCount;
						break;
					}
				}
			}
			if (state == ControlState.WaitingForSecondTouch)
			{
				for (num = 0; num < touchCount; num++)
				{
					touch = touches[num];
					if (touch.phase == TouchPhase.Canceled)
					{
						continue;
					}
					if (touchCount >= 2 && touch.fingerId != fingerDown[0])
					{
						state = ControlState.WaitingForMovement;
						fingerDown[1] = touch.fingerId;
						fingerDownPosition[1] = touch.position;
						fingerDownFrame[1] = Time.frameCount;
						break;
					}
					if (touchCount == 1)
					{
						Vector2 vector = touch.position - fingerDownPosition[0];
						if (touch.fingerId == fingerDown[0] && (Time.time > firstTouchTime + minimumTimeUntilMove || touch.phase == TouchPhase.Ended))
						{
							state = ControlState.MovingCharacter;
							break;
						}
					}
				}
			}
			if (state == ControlState.WaitingForMovement)
			{
				for (num = 0; num < touchCount; num++)
				{
					touch = touches[num];
					if (touch.phase == TouchPhase.Began)
					{
						if (touch.fingerId == fingerDown[0] && fingerDownFrame[0] == Time.frameCount)
						{
							touch2 = touch;
							flag = true;
						}
						else if (touch.fingerId != fingerDown[0] && touch.fingerId != fingerDown[1])
						{
							fingerDown[1] = touch.fingerId;
							touch3 = touch;
							flag2 = true;
						}
					}
					if (touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Ended)
					{
						if (touch.fingerId == fingerDown[0])
						{
							touch2 = touch;
							flag = true;
						}
						else if (touch.fingerId == fingerDown[1])
						{
							touch3 = touch;
							flag2 = true;
						}
					}
				}
				if (flag)
				{
					if (flag2)
					{
						Vector2 vector2 = fingerDownPosition[1] - fingerDownPosition[0];
						Vector2 vector3 = touch3.position - touch2.position;
						Vector2 lhs = vector2 / vector2.magnitude;
						Vector2 rhs = vector3 / vector3.magnitude;
						float num2 = Vector2.Dot(lhs, rhs);
						if (num2 < 1f)
						{
							float num3 = Mathf.Acos(num2);
							if (num3 > rotateEpsilon * ((float)Math.PI / 180f))
							{
								state = ControlState.RotatingCamera;
							}
						}
						if (state == ControlState.WaitingForMovement)
						{
							float f = vector2.magnitude - vector3.magnitude;
							if (Mathf.Abs(f) > zoomEpsilon)
							{
								state = ControlState.ZoomingCamera;
							}
						}
					}
				}
				else
				{
					state = ControlState.WaitingForNoFingers;
				}
			}
			if (state == ControlState.RotatingCamera || state == ControlState.ZoomingCamera)
			{
				for (num = 0; num < touchCount; num++)
				{
					touch = touches[num];
					if (touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Ended)
					{
						if (touch.fingerId == fingerDown[0])
						{
							touch2 = touch;
							flag = true;
						}
						else if (touch.fingerId == fingerDown[1])
						{
							touch3 = touch;
							flag2 = true;
						}
					}
				}
				if (flag)
				{
					if (flag2)
					{
						CameraControl(touch2, touch3);
					}
				}
				else
				{
					state = ControlState.WaitingForNoFingers;
				}
			}
		}
		CharacterControl();
	}

	public virtual void LateUpdate()
	{
		float y = Mathf.SmoothDampAngle(cameraPivot.eulerAngles.y, rotationTarget, ref rotationVelocity, 0.3f);
		Vector3 eulerAngles = cameraPivot.eulerAngles;
		eulerAngles.y = y;
		cameraPivot.eulerAngles = eulerAngles;
	}
}

using System;
using UnityEngine;

[Serializable]
[RequireComponent(typeof(CharacterController))]
public class FPSControllerNEW : MonoBehaviour
{
	public Joystick moveTouchPad;

	public Joystick rotateTouchPad;

	public Transform cameraPivot;

	public float forwardSpeed;

	public float backwardSpeed;

	public float sidestepSpeed;

	public float jumpSpeed;

	public float inAirMultiplier;

	public Vector2 rotationSpeed;

	public float tiltPositiveYAxis;

	public float tiltNegativeYAxis;

	public float tiltXAxisMinimum;

	private Transform thisTransform;

	private CharacterController character;

	private Vector3 cameraVelocity;

	private Vector3 velocity;

	private bool canJump;

	public GameObject rotateControll;

	public GameObject footstepScriptHolder;

	public GameObject headBobAnimHolder;

	public bool day2;

	public bool day3;

	public bool playerCrouch;

	public bool PlayerIsGrounded;

	public bool fallTimerStarted;

	public float timeInAir;

	public GameObject soundHolder;

	public GameObject FallsoundHolder;

	public GameObject granny;

	public GameObject Player;

	public GameObject checkGround;

	public int startingPitch;

	public FPSControllerNEW()
	{
		forwardSpeed = 4f;
		backwardSpeed = 1f;
		sidestepSpeed = 1f;
		jumpSpeed = 8f;
		inAirMultiplier = 0.25f;
		rotationSpeed = new Vector2(50f, 25f);
		tiltPositiveYAxis = 0.6f;
		tiltNegativeYAxis = 0.4f;
		tiltXAxisMinimum = 0.1f;
		canJump = true;
		PlayerIsGrounded = true;
		startingPitch = 4;
	}

	public virtual void Start()
	{
		timeInAir = 0f;
		thisTransform = (Transform)GetComponent(typeof(Transform));
		character = (CharacterController)GetComponent(typeof(CharacterController));
		GameObject gameObject = GameObject.Find("PlayerSpawn");
		if ((bool)gameObject)
		{
			thisTransform.position = gameObject.transform.position;
		}
	}

	public virtual void OnEndGame()
	{
		moveTouchPad.Disable();
		if ((bool)rotateTouchPad)
		{
			rotateTouchPad.Disable();
		}
		base.enabled = false;
	}

	public virtual void FixedUpdate()
	{
		RaycastHit hitInfo = default(RaycastHit);
		Vector3 motion = thisTransform.TransformDirection(new Vector3(moveTouchPad.position.x, 0f, moveTouchPad.position.y));
		int num = 0;
		Vector3 eulerAngles = base.transform.eulerAngles;
		eulerAngles.x = num;
		base.transform.eulerAngles = eulerAngles;
		int num2 = 0;
		Vector3 eulerAngles2 = base.transform.eulerAngles;
		eulerAngles2.z = num2;
		base.transform.eulerAngles = eulerAngles2;
		motion.y = 0f;
		motion.Normalize();
		Vector2 vector = new Vector2(Mathf.Abs(moveTouchPad.position.x), Mathf.Abs(moveTouchPad.position.y));
		if (vector.y > vector.x)
		{
			if (moveTouchPad.position.y > -0.3f && moveTouchPad.position.y < 0.4f)
			{
				motion *= forwardSpeed * vector.y;
				if (day2)
				{
					headBobAnimHolder.GetComponent<Animation>()["HeadBobAnimation2"].speed = 0.6f;
				}
				else if (day3)
				{
					headBobAnimHolder.GetComponent<Animation>()["HeadBobAnimation3"].speed = 0.6f;
				}
				else
				{
					headBobAnimHolder.GetComponent<Animation>()["HeadBobAnimation"].speed = 0.6f;
				}
			}
			else if (moveTouchPad.position.y >= 0.4f && moveTouchPad.position.y < 0.8f)
			{
				motion *= forwardSpeed * vector.y;
				if (playerCrouch)
				{
					if (day2)
					{
						headBobAnimHolder.GetComponent<Animation>()["HeadBobAnimation2"].speed = 0.6f;
					}
					else if (day3)
					{
						headBobAnimHolder.GetComponent<Animation>()["HeadBobAnimation3"].speed = 0.6f;
					}
					else
					{
						headBobAnimHolder.GetComponent<Animation>()["HeadBobAnimation"].speed = 0.6f;
					}
				}
				else if (day2)
				{
					headBobAnimHolder.GetComponent<Animation>()["HeadBobAnimation2"].speed = 0.7f;
				}
				else if (day3)
				{
					headBobAnimHolder.GetComponent<Animation>()["HeadBobAnimation3"].speed = 0.7f;
				}
				else
				{
					headBobAnimHolder.GetComponent<Animation>()["HeadBobAnimation"].speed = 0.7f;
				}
			}
			else if (moveTouchPad.position.y >= 0.8f && moveTouchPad.position.y < 1.5f)
			{
				motion *= forwardSpeed * vector.y;
				if (playerCrouch)
				{
					if (day2)
					{
						headBobAnimHolder.GetComponent<Animation>()["HeadBobAnimation2"].speed = 0.6f;
					}
					else if (day3)
					{
						headBobAnimHolder.GetComponent<Animation>()["HeadBobAnimation3"].speed = 0.6f;
					}
					else
					{
						headBobAnimHolder.GetComponent<Animation>()["HeadBobAnimation"].speed = 0.6f;
					}
				}
				else if (day2)
				{
					headBobAnimHolder.GetComponent<Animation>()["HeadBobAnimation2"].speed = 1f;
				}
				else if (day3)
				{
					headBobAnimHolder.GetComponent<Animation>()["HeadBobAnimation3"].speed = 1f;
				}
				else
				{
					headBobAnimHolder.GetComponent<Animation>()["HeadBobAnimation"].speed = 1f;
				}
			}
			else if (moveTouchPad.position.y > -1.5f && moveTouchPad.position.y < -0.3f)
			{
				motion *= backwardSpeed * vector.y;
				if (day2)
				{
					headBobAnimHolder.GetComponent<Animation>()["HeadBobAnimation2"].speed = 0.6f;
				}
				else if (day3)
				{
					headBobAnimHolder.GetComponent<Animation>()["HeadBobAnimation3"].speed = 0.6f;
				}
				else
				{
					headBobAnimHolder.GetComponent<Animation>()["HeadBobAnimation"].speed = 0.6f;
				}
			}
		}
		else if (vector.y < vector.x)
		{
			motion *= sidestepSpeed * vector.x;
			if (playerCrouch)
			{
				if (day2)
				{
					headBobAnimHolder.GetComponent<Animation>()["HeadBobAnimation2"].speed = 0.6f;
				}
				else if (day3)
				{
					headBobAnimHolder.GetComponent<Animation>()["HeadBobAnimation3"].speed = 0.6f;
				}
				else
				{
					headBobAnimHolder.GetComponent<Animation>()["HeadBobAnimation"].speed = 0.6f;
				}
			}
			else if (day2)
			{
				headBobAnimHolder.GetComponent<Animation>()["HeadBobAnimation2"].speed = 0.7f;
			}
			else if (day3)
			{
				headBobAnimHolder.GetComponent<Animation>()["HeadBobAnimation3"].speed = 0.7f;
			}
			else
			{
				headBobAnimHolder.GetComponent<Animation>()["HeadBobAnimation"].speed = 0.7f;
			}
		}
		else if (vector.y != 1f && moveTouchPad.position.y != 0f)
		{
		}
		if (character.isGrounded)
		{
			bool flag = false;
			Joystick joystick = null;
			joystick = ((!rotateTouchPad) ? moveTouchPad : rotateTouchPad);
			if (!joystick.IsFingerDown())
			{
				canJump = true;
			}
			if (canJump && joystick.tapCount >= 2)
			{
				flag = true;
				canJump = false;
			}
			if (flag)
			{
				velocity = character.velocity;
				velocity.y = jumpSpeed;
			}
		}
		else
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
			PlayerIsGrounded = true;
			velocity = Vector3.zero;
			((playerFallingSound)FallsoundHolder.GetComponent(typeof(playerFallingSound))).playerFallingNot();
			if (timeInAir > 0.5f)
			{
				timeInAir = 0f;
				fallTimerStarted = false;
				((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).playerLandSound();
				((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerGetCaught = true;
				((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerFallDeath = true;
				StartCoroutine(((playerCaught)Player.GetComponent(typeof(playerCaught))).fallingDead());
				forwardSpeed = 0f;
				backwardSpeed = 0f;
				sidestepSpeed = 0f;
			}
		}
		else
		{
			PlayerIsGrounded = false;
			if (fallTimerStarted)
			{
				timeInAir += Time.deltaTime;
				((playerFallingSound)FallsoundHolder.GetComponent(typeof(playerFallingSound))).playerFalling();
			}
		}
		if (character.isGrounded)
		{
			Vector2 vector2 = Vector2.zero;
			if ((bool)rotateTouchPad)
			{
				vector2 = rotateTouchPad.position;
			}
			else
			{
				Vector3 acceleration = Input.acceleration;
				float num3 = Mathf.Abs(acceleration.x);
				if (acceleration.z < 0f && acceleration.x < 0f)
				{
					if (num3 >= tiltPositiveYAxis)
					{
						vector2.y = (num3 - tiltPositiveYAxis) / (1f - tiltPositiveYAxis);
					}
					else if (num3 <= tiltNegativeYAxis)
					{
						vector2.y = (0f - (tiltNegativeYAxis - num3)) / tiltNegativeYAxis;
					}
				}
				if (Mathf.Abs(acceleration.y) >= tiltXAxisMinimum)
				{
					vector2.x = (0f - (acceleration.y - tiltXAxisMinimum)) / (1f - tiltXAxisMinimum);
				}
			}
			vector2.x *= rotationSpeed.x;
			vector2.y *= rotationSpeed.y;
			vector2 *= Time.deltaTime;
			thisTransform.Rotate(0f, vector2.x, 0f, Space.World);
			cameraPivot.Rotate(0f - vector2.y, 0f, 0f);
		}
		CharacterController component = GetComponent<CharacterController>();
		Vector3 vector3 = component.velocity;
		vector3 = new Vector3(component.velocity.x, 0f, component.velocity.z);
		float magnitude = vector3.magnitude;
		if (magnitude > 0f)
		{
			((Footsteps)footstepScriptHolder.GetComponent(typeof(Footsteps))).isWalking = true;
		}
		else
		{
			((Footsteps)footstepScriptHolder.GetComponent(typeof(Footsteps))).isWalking = false;
		}
		Vector3 vector4 = new Vector3(0f, -1f, 0f);
		if (Physics.Raycast(checkGround.transform.position, vector4, out hitInfo, 5f))
		{
			Debug.DrawRay(checkGround.transform.position, vector4, Color.yellow);
			if (hitInfo.collider.gameObject.tag == "grus")
			{
				((Footsteps)footstepScriptHolder.GetComponent(typeof(Footsteps))).walkGrus = true;
			}
			if (hitInfo.collider.gameObject.tag == "golv")
			{
				((Footsteps)footstepScriptHolder.GetComponent(typeof(Footsteps))).walkGrus = false;
			}
		}
	}
}

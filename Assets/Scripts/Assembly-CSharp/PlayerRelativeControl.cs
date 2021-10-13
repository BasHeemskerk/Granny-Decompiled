using System;
using UnityEngine;

[Serializable]
[RequireComponent(typeof(CharacterController))]
public class PlayerRelativeControl : MonoBehaviour
{
	public Joystick moveJoystick;

	public Joystick rotateJoystick;

	public Transform cameraPivot;

	public float forwardSpeed;

	public float backwardSpeed;

	public float sidestepSpeed;

	public float jumpSpeed;

	public float inAirMultiplier;

	public Vector2 rotationSpeed;

	private Transform thisTransform;

	private CharacterController character;

	private AnimationController animationController;

	private Vector3 cameraVelocity;

	private Vector3 velocity;

	public PlayerRelativeControl()
	{
		forwardSpeed = 4f;
		backwardSpeed = 1f;
		sidestepSpeed = 1f;
		jumpSpeed = 8f;
		inAirMultiplier = 0.25f;
		rotationSpeed = new Vector2(50f, 25f);
	}

	public virtual void Start()
	{
		thisTransform = (Transform)GetComponent(typeof(Transform));
		character = (CharacterController)GetComponent(typeof(CharacterController));
		animationController = (AnimationController)GetComponent(typeof(AnimationController));
		animationController.maxForwardSpeed = forwardSpeed;
		animationController.maxBackwardSpeed = backwardSpeed;
		animationController.maxSidestepSpeed = sidestepSpeed;
		GameObject gameObject = GameObject.Find("PlayerSpawn");
		if ((bool)gameObject)
		{
			thisTransform.position = gameObject.transform.position;
		}
	}

	public virtual void OnEndGame()
	{
		moveJoystick.Disable();
		rotateJoystick.Disable();
		base.enabled = false;
	}

	public virtual void Update()
	{
		Vector3 motion = thisTransform.TransformDirection(new Vector3(moveJoystick.position.x, 0f, moveJoystick.position.y));
		motion.y = 0f;
		motion.Normalize();
		Vector3 zero = Vector3.zero;
		Vector2 vector = new Vector2(Mathf.Abs(moveJoystick.position.x), Mathf.Abs(moveJoystick.position.y));
		if (vector.y > vector.x)
		{
			if (moveJoystick.position.y > 0f)
			{
				motion *= forwardSpeed * vector.y;
			}
			else
			{
				motion *= backwardSpeed * vector.y;
				zero.z = moveJoystick.position.y * 0.75f;
			}
		}
		else
		{
			motion *= sidestepSpeed * vector.x;
			zero.x = (0f - moveJoystick.position.x) * 0.5f;
		}
		if (character.isGrounded)
		{
			if (rotateJoystick.tapCount == 2)
			{
				velocity = character.velocity;
				velocity.y = jumpSpeed;
			}
		}
		else
		{
			velocity.y += Physics.gravity.y * Time.deltaTime;
			zero.z = (0f - jumpSpeed) * 0.25f;
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
		Vector3 localPosition = cameraPivot.localPosition;
		localPosition.x = Mathf.SmoothDamp(localPosition.x, zero.x, ref cameraVelocity.x, 0.3f);
		localPosition.z = Mathf.SmoothDamp(localPosition.z, zero.z, ref cameraVelocity.z, 0.5f);
		cameraPivot.localPosition = localPosition;
		if (character.isGrounded)
		{
			Vector2 position = rotateJoystick.position;
			position.x *= rotationSpeed.x;
			position.y *= rotationSpeed.y;
			position *= Time.deltaTime;
			thisTransform.Rotate(0f, position.x, 0f, Space.World);
			cameraPivot.Rotate(position.y, 0f, 0f);
		}
	}
}

using System;
using UnityEngine;

[Serializable]
[RequireComponent(typeof(CharacterController))]
public class SidescrollControl : MonoBehaviour
{
	public Joystick moveTouchPad;

	public Joystick jumpTouchPad;

	public float forwardSpeed;

	public float backwardSpeed;

	public float jumpSpeed;

	public float inAirMultiplier;

	private Transform thisTransform;

	private CharacterController character;

	private Vector3 velocity;

	private bool canJump;

	public SidescrollControl()
	{
		forwardSpeed = 4f;
		backwardSpeed = 4f;
		jumpSpeed = 16f;
		inAirMultiplier = 0.25f;
		canJump = true;
	}

	public virtual void Start()
	{
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
		jumpTouchPad.Disable();
		base.enabled = false;
	}

	public virtual void Update()
	{
		Vector3 motion = Vector3.zero;
		motion = ((!(moveTouchPad.position.x > 0f)) ? (Vector3.right * backwardSpeed * moveTouchPad.position.x) : (Vector3.right * forwardSpeed * moveTouchPad.position.x));
		if (character.isGrounded)
		{
			bool flag = false;
			Joystick joystick = jumpTouchPad;
			if (!joystick.IsFingerDown())
			{
				canJump = true;
			}
			if (canJump && joystick.IsFingerDown())
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
		}
		motion += velocity;
		motion += Physics.gravity;
		motion *= Time.deltaTime;
		character.Move(motion);
		if (character.isGrounded)
		{
			velocity = Vector3.zero;
		}
	}
}

using System;
using UnityEngine;

[Serializable]
public class AnimationController : MonoBehaviour
{
	public Animation animationTarget;

	public float maxForwardSpeed;

	public float maxBackwardSpeed;

	public float maxSidestepSpeed;

	private CharacterController character;

	private Transform thisTransform;

	private bool jumping;

	private int minUpwardSpeed;

	public AnimationController()
	{
		maxForwardSpeed = 6f;
		maxBackwardSpeed = 3f;
		maxSidestepSpeed = 4f;
		minUpwardSpeed = 2;
	}

	public virtual void Start()
	{
		character = (CharacterController)GetComponent(typeof(CharacterController));
		thisTransform = base.transform;
		animationTarget.wrapMode = WrapMode.Loop;
		animationTarget["jump"].wrapMode = WrapMode.ClampForever;
		animationTarget["jump-land"].wrapMode = WrapMode.ClampForever;
		animationTarget["run-land"].wrapMode = WrapMode.ClampForever;
		animationTarget["LOSE"].wrapMode = WrapMode.ClampForever;
	}

	public virtual void OnEndGame()
	{
		base.enabled = false;
	}

	public virtual void Update()
	{
		Vector3 velocity = character.velocity;
		Vector3 rhs = velocity;
		rhs.y = 0f;
		float magnitude = rhs.magnitude;
		float num = Vector3.Dot(thisTransform.up, velocity);
		if (!character.isGrounded && num > (float)minUpwardSpeed)
		{
			jumping = true;
		}
		if (animationTarget.IsPlaying("run-land") && animationTarget["run-land"].normalizedTime < 1f && magnitude > 0f)
		{
			return;
		}
		if (animationTarget.IsPlaying("jump-land"))
		{
			if (animationTarget["jump-land"].normalizedTime >= 1f)
			{
				animationTarget.Play("idle");
			}
		}
		else if (jumping)
		{
			if (character.isGrounded)
			{
				if (magnitude > 0f)
				{
					animationTarget.Play("run-land");
				}
				else
				{
					animationTarget.Play("jump-land");
				}
				jumping = false;
			}
			else
			{
				animationTarget.Play("jump");
			}
		}
		else if (magnitude > 0f)
		{
			float num2 = Vector3.Dot(thisTransform.forward, rhs);
			float num3 = Vector3.Dot(thisTransform.right, rhs);
			float num4 = 0f;
			if (Mathf.Abs(num2) > Mathf.Abs(num3))
			{
				if (num2 > 0f)
				{
					num4 = Mathf.Clamp(Mathf.Abs(magnitude / maxForwardSpeed), 0f, maxForwardSpeed);
					animationTarget["run"].speed = Mathf.Lerp(0.25f, 1f, num4);
					if (animationTarget.IsPlaying("run-land") || animationTarget.IsPlaying("idle"))
					{
						animationTarget.Play("run");
					}
					else
					{
						animationTarget.CrossFade("run");
					}
				}
				else
				{
					num4 = Mathf.Clamp(Mathf.Abs(magnitude / maxBackwardSpeed), 0f, maxBackwardSpeed);
					animationTarget["runback"].speed = Mathf.Lerp(0.25f, 1f, num4);
					animationTarget.CrossFade("runback");
				}
			}
			else
			{
				num4 = Mathf.Clamp(Mathf.Abs(magnitude / maxSidestepSpeed), 0f, maxSidestepSpeed);
				if (num3 > 0f)
				{
					animationTarget["runright"].speed = Mathf.Lerp(0.25f, 1f, num4);
					animationTarget.CrossFade("runright");
				}
				else
				{
					animationTarget["runleft"].speed = Mathf.Lerp(0.25f, 1f, num4);
					animationTarget.CrossFade("runleft");
				}
			}
		}
		else
		{
			animationTarget.CrossFade("idle");
		}
	}
}

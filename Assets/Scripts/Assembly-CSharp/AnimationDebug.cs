using System;
using System.Collections;
using UnityEngine;

[Serializable]
[RequireComponent(typeof(AnimationController))]
public class AnimationDebug : MonoBehaviour
{
	private AnimationController animationController;

	private CharacterController character;

	public virtual void Start()
	{
		character = (CharacterController)GetComponent(typeof(CharacterController));
		animationController = (AnimationController)GetComponent(typeof(AnimationController));
		if (!Application.isEditor)
		{
			UnityEngine.Object.Destroy(this);
		}
	}

	public virtual void OnGUI()
	{
		GUI.skin.font = null;
		float num = 0f;
		AnimationState animationState = null;
		IEnumerator enumerator = animationController.animationTarget.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				AnimationState animationState2 = (AnimationState)enumerator.Current;
				if (animationState2.weight > num)
				{
					num = animationState2.weight;
					animationState = animationState2;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		Vector3 velocity = character.velocity;
		Vector3 vector = velocity;
		vector.y = 0f;
		float magnitude = vector.magnitude;
		if ((bool)animationState)
		{
			GUI.Label(new Rect(10f, 70f, 400f, 60f), string.Format("Vel: {5}  Speed: {0:0.000}\nAnimation: {1}\n  * weight {2:0.00}  speed {3:0.00} time {4:0.00}", magnitude, animationState.name, animationState.weight, animationState.speed, animationState.normalizedTime, velocity));
		}
	}
}

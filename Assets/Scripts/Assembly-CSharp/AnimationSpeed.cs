using System;
using UnityEngine;

[Serializable]
public class AnimationSpeed : MonoBehaviour
{
	public Animation animationTarget;

	public float speed;

	public AnimationSpeed()
	{
		speed = 1f;
	}

	public virtual void Start()
	{
		animationTarget[animationTarget.clip.name].speed = speed;
	}
}
[Serializable]
public class animationSpeed : MonoBehaviour
{
	public GameObject slendrina;

	public virtual void Start()
	{
		slendrina.GetComponent<Animation>()["Attack"].speed = 0.1f;
	}

	public virtual void Update()
	{
	}
}

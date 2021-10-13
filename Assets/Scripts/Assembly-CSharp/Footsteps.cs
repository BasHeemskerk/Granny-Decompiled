using System;
using UnityEngine;

[Serializable]
public class Footsteps : MonoBehaviour
{
	public AudioClip[] footstepConcrete;

	public AudioClip[] footstepGrus;

	public bool isWalking;

	public bool walkGrus;

	public GameObject headBob;

	public bool day2;

	public bool day3;

	public bool playerDie;

	public bool playerCrouching;

	public Footsteps()
	{
		isWalking = true;
	}

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
	}

	public virtual void step()
	{
		if (isWalking)
		{
			if (!walkGrus)
			{
				int num = UnityEngine.Random.Range(0, footstepConcrete.Length);
				GetComponent<AudioSource>().PlayOneShot(footstepConcrete[num]);
			}
			else if (walkGrus)
			{
				int num2 = UnityEngine.Random.Range(0, footstepGrus.Length);
				GetComponent<AudioSource>().PlayOneShot(footstepGrus[num2]);
			}
		}
	}

	public virtual void walk()
	{
		if (playerDie || headBob.GetComponent<Animation>().IsPlaying("playerHurt"))
		{
			return;
		}
		if (isWalking)
		{
			if (day2)
			{
				headBob.GetComponent<Animation>().Play("HeadBobAnimation2");
				if (playerCrouching)
				{
					headBob.GetComponent<Animation>()["HeadBobAnimation2"].speed = 0.6f;
				}
				else
				{
					headBob.GetComponent<Animation>()["HeadBobAnimation2"].speed = 1f;
				}
			}
			else if (day3)
			{
				headBob.GetComponent<Animation>().Play("HeadBobAnimation3");
				if (playerCrouching)
				{
					headBob.GetComponent<Animation>()["HeadBobAnimation3"].speed = 0.6f;
				}
				else
				{
					headBob.GetComponent<Animation>()["HeadBobAnimation3"].speed = 1f;
				}
			}
			else
			{
				headBob.GetComponent<Animation>().Play("HeadBobAnimation");
				if (playerCrouching)
				{
					headBob.GetComponent<Animation>()["HeadBobAnimation"].speed = 0.6f;
				}
				else
				{
					headBob.GetComponent<Animation>()["HeadBobAnimation"].speed = 1f;
				}
			}
		}
		else if (day2)
		{
			headBob.GetComponent<Animation>().Stop("HeadBobAnimation2");
			if (playerCrouching)
			{
				headBob.GetComponent<Animation>()["HeadBobAnimation2"].speed = 0.6f;
			}
			else
			{
				headBob.GetComponent<Animation>()["HeadBobAnimation2"].speed = 1f;
			}
		}
		else if (day3)
		{
			headBob.GetComponent<Animation>().Stop("HeadBobAnimation3");
			if (playerCrouching)
			{
				headBob.GetComponent<Animation>()["HeadBobAnimation3"].speed = 0.6f;
			}
			else
			{
				headBob.GetComponent<Animation>()["HeadBobAnimation3"].speed = 1f;
			}
		}
		else
		{
			headBob.GetComponent<Animation>().Stop("HeadBobAnimation");
			if (playerCrouching)
			{
				headBob.GetComponent<Animation>()["HeadBobAnimation"].speed = 0.6f;
			}
			else
			{
				headBob.GetComponent<Animation>()["HeadBobAnimation"].speed = 1f;
			}
		}
	}

	public virtual void stopwalk()
	{
		GetComponent<AudioSource>().Stop();
		if (day2)
		{
			headBob.GetComponent<Animation>().Stop("HeadBobAnimation2");
		}
		else if (day3)
		{
			headBob.GetComponent<Animation>().Stop("HeadBobAnimation3");
		}
		else
		{
			headBob.GetComponent<Animation>().Stop("HeadBobAnimation");
		}
	}
}

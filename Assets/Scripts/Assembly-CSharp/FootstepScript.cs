using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class FootstepScript : MonoBehaviour
{
	public AudioClip[] footstepConcrete;

	public bool step;

	public bool startWalking;

	public float audioStepLengthWalk;

	public FootstepScript()
	{
		step = true;
		startWalking = true;
		audioStepLengthWalk = 0.45f;
	}

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (startWalking && !step)
		{
			step = true;
			StartCoroutine(Playerwalk());
		}
	}

	public virtual void walk()
	{
		startWalking = true;
	}

	public virtual IEnumerator Playerwalk()
	{
		if (step)
		{
			step = false;
			GetComponent<AudioSource>().clip = footstepConcrete[UnityEngine.Random.Range(0, footstepConcrete.Length)];
			GetComponent<AudioSource>().volume = 1f;
			GetComponent<AudioSource>().Play();
			yield return new WaitForSeconds(audioStepLengthWalk);
			step = true;
		}
	}

	public virtual void stopwalk()
	{
		startWalking = false;
		step = false;
		GetComponent<AudioSource>().Stop();
	}
}

using System;
using UnityEngine;

[Serializable]
public class GrannyFootstep : MonoBehaviour
{
	public AudioClip[] footstepGranny;

	public AudioClip[] footstepGrusGranny;

	public bool walkGrus;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
	}

	public virtual void step()
	{
		if (!walkGrus)
		{
			int num = UnityEngine.Random.Range(0, footstepGranny.Length);
			GetComponent<AudioSource>().PlayOneShot(footstepGranny[num]);
		}
		else if (walkGrus)
		{
			int num2 = UnityEngine.Random.Range(0, footstepGrusGranny.Length);
			GetComponent<AudioSource>().PlayOneShot(footstepGrusGranny[num2]);
		}
	}
}

using System;
using UnityEngine;

[Serializable]
public class soundEffectsBeds : MonoBehaviour
{
	public AudioClip PCaught;

	public virtual void Start()
	{
	}

	public virtual void playerCaught()
	{
		GetComponent<AudioSource>().PlayOneShot(PCaught);
	}
}

using System;
using UnityEngine;

[Serializable]
public class SoundEffectsPlayerInBed : MonoBehaviour
{
	public AudioClip startText;

	public virtual void Start()
	{
	}

	public virtual void startTextSound()
	{
		GetComponent<AudioSource>().clip = startText;
		GetComponent<AudioSource>().Play();
	}
}

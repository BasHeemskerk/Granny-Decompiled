using System;
using UnityEngine;

[Serializable]
public class maniacBreath : MonoBehaviour
{
	public AudioClip breathSlow;

	public AudioClip breathFast;

	public AudioClip hurt;

	public AudioClip freezed;

	public virtual void Start()
	{
		AudioSource component = GetComponent<AudioSource>();
		GetComponent<AudioSource>().Play();
		component.clip = breathSlow;
	}

	public virtual void stopAudio()
	{
	}

	public virtual void maniacBreathSlow()
	{
		GetComponent<AudioSource>().clip = breathSlow;
		GetComponent<AudioSource>().Play();
	}

	public virtual void maniacBreathFast()
	{
		GetComponent<AudioSource>().clip = breathFast;
		GetComponent<AudioSource>().Play();
	}

	public virtual void maniachurt()
	{
		GetComponent<AudioSource>().clip = hurt;
		GetComponent<AudioSource>().Play();
	}

	public virtual void maniafreezed()
	{
		GetComponent<AudioSource>().clip = freezed;
		GetComponent<AudioSource>().Play();
	}
}

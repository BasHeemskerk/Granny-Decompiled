using System;
using UnityEngine;

[Serializable]
public class PlayMusic : MonoBehaviour
{
	public AudioClip screenSound;

	public float volume;

	public bool fading;

	public virtual void Start()
	{
		GetComponent<AudioSource>().Play();
	}

	public virtual void fadeUp()
	{
		GetComponent<AudioSource>().volume = GetComponent<AudioSource>().volume + 0.2f * Time.deltaTime;
	}

	public virtual void fadeDown()
	{
		GetComponent<AudioSource>().volume = GetComponent<AudioSource>().volume - 0.2f * Time.deltaTime;
	}

	public virtual void stopAudio()
	{
		GetComponent<AudioSource>().Stop();
	}
}

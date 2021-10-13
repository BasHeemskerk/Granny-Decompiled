using System;
using UnityEngine;

[Serializable]
public class fadeMusic : MonoBehaviour
{
	public AudioClip Music;

	public AudioClip BookMusic;

	public float volume;

	public bool fading;

	public bool playMusic;

	public bool musicOn;

	public bool momHunting;

	public bool stopFade;

	public virtual void Update()
	{
		if (playMusic)
		{
			if (!musicOn)
			{
				musicOn = true;
				GetComponent<AudioSource>().Play();
			}
		}
		else if (!playMusic && musicOn)
		{
			musicOn = false;
			GetComponent<AudioSource>().Stop();
		}
		if (momHunting)
		{
			if (!stopFade)
			{
				GetComponent<AudioSource>().volume = GetComponent<AudioSource>().volume - 0.2f * Time.deltaTime;
				if (GetComponent<AudioSource>().volume <= 0f)
				{
					stopFade = true;
					GetComponent<AudioSource>().volume = 0f;
					playMusic = false;
				}
			}
		}
		else if (!momHunting && stopFade)
		{
			playMusic = true;
			GetComponent<AudioSource>().volume = GetComponent<AudioSource>().volume + 0.2f * Time.deltaTime;
			if (GetComponent<AudioSource>().volume > 0.3f)
			{
				stopFade = false;
				GetComponent<AudioSource>().volume = 0.3f;
			}
		}
	}
}

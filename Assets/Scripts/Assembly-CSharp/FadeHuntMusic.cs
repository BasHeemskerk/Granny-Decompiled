using System;
using UnityEngine;

[Serializable]
public class FadeHuntMusic : MonoBehaviour
{
	public AudioClip huntingMusic;

	public AudioClip fightSlendrinaMusic;

	public AudioClip headHuntMusic;

	public AudioClip bookMusic;

	public float volume;

	public bool fading;

	public bool playMusic;

	public bool musicOn;

	public bool momHunt;

	public bool stopFade;

	public GameObject musicHolder;

	public virtual void Start()
	{
		GetComponent<AudioSource>().clip = huntingMusic;
	}

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
		if (momHunt)
		{
			if (!stopFade)
			{
				playMusic = true;
				((fadeMusic)musicHolder.GetComponent(typeof(fadeMusic))).momHunting = true;
				GetComponent<AudioSource>().volume = GetComponent<AudioSource>().volume + 0.3f * Time.deltaTime;
				if (GetComponent<AudioSource>().volume > 0.5f)
				{
					stopFade = true;
					GetComponent<AudioSource>().volume = 0.5f;
				}
			}
		}
		else if (!momHunt && stopFade)
		{
			((fadeMusic)musicHolder.GetComponent(typeof(fadeMusic))).momHunting = false;
			GetComponent<AudioSource>().volume = GetComponent<AudioSource>().volume - 0.1f * Time.deltaTime;
			if (GetComponent<AudioSource>().volume <= 0f)
			{
				stopFade = false;
				GetComponent<AudioSource>().volume = 0f;
				playMusic = false;
			}
		}
	}

	public virtual void fightSlendrina()
	{
		GetComponent<AudioSource>().clip = fightSlendrinaMusic;
	}

	public virtual void NotfightSlendrina()
	{
		GetComponent<AudioSource>().clip = huntingMusic;
	}

	public virtual void headHuntStarts()
	{
		GetComponent<AudioSource>().clip = headHuntMusic;
	}

	public virtual void bookMusicStarts()
	{
		GetComponent<AudioSource>().clip = bookMusic;
		GetComponent<AudioSource>().loop = false;
	}
}

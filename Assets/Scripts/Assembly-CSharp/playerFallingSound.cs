using System;
using UnityEngine;

[Serializable]
public class playerFallingSound : MonoBehaviour
{
	public AudioClip fallWindSound;

	public bool soundPlaying;

	public bool fadingSound;

	public virtual void Update()
	{
		if (!soundPlaying)
		{
			GetComponent<AudioSource>().volume = GetComponent<AudioSource>().volume - 2f * Time.deltaTime;
		}
		if (soundPlaying && fadingSound)
		{
			GetComponent<AudioSource>().volume = GetComponent<AudioSource>().volume + 2.2f * Time.deltaTime;
			if (GetComponent<AudioSource>().volume >= 1f)
			{
				fadingSound = false;
			}
		}
	}

	public virtual void playerFalling()
	{
		if (!soundPlaying)
		{
			GetComponent<AudioSource>().clip = fallWindSound;
			GetComponent<AudioSource>().Play();
			soundPlaying = true;
			fadingSound = true;
		}
	}

	public virtual void playerFallingNot()
	{
		if (soundPlaying)
		{
			soundPlaying = false;
		}
	}
}

using System;
using UnityEngine;

[Serializable]
public class fadeUpDownTeddyMusic : MonoBehaviour
{
	public bool playerCaught;

	public bool startFade;

	public bool musicOn;

	public bool startMusic;

	public bool stopMusic;

	public float volume;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (!playerCaught)
		{
			if (startFade)
			{
				if (!musicOn)
				{
					GetComponent<AudioSource>().volume = GetComponent<AudioSource>().volume + 0.2f * Time.deltaTime;
					if (GetComponent<AudioSource>().volume >= 0.7f)
					{
						musicOn = true;
						GetComponent<AudioSource>().volume = 0.7f;
					}
				}
				if (!startMusic)
				{
					startMusic = true;
					GetComponent<AudioSource>().Play();
				}
			}
			else if (!startFade)
			{
				musicOn = false;
				startMusic = false;
				GetComponent<AudioSource>().volume = GetComponent<AudioSource>().volume - 0.1f * Time.deltaTime;
				if (GetComponent<AudioSource>().volume == 0f)
				{
					startFade = false;
					GetComponent<AudioSource>().volume = 0f;
					GetComponent<AudioSource>().Stop();
				}
			}
		}
		else
		{
			musicOn = false;
			startMusic = false;
			GetComponent<AudioSource>().volume = GetComponent<AudioSource>().volume - 0.05f * Time.deltaTime;
			if (GetComponent<AudioSource>().volume == 0f)
			{
				startFade = false;
				GetComponent<AudioSource>().volume = 0f;
				GetComponent<AudioSource>().Stop();
				playerCaught = false;
			}
		}
	}
}

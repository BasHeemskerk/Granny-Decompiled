using System;
using UnityEngine;

[Serializable]
public class vevarBrunnLjud : MonoBehaviour
{
	public AudioSource audioSource;

	public AudioClip vevLjud;

	public bool PlayerVevar;

	public bool soundPlaying;

	public virtual void Start()
	{
		audioSource = GetComponent<AudioSource>();
	}

	public virtual void Update()
	{
		if (PlayerVevar)
		{
			if (!soundPlaying)
			{
				soundPlaying = true;
				audioSource.clip = vevLjud;
				audioSource.Play();
			}
		}
		else if (!PlayerVevar)
		{
			audioSource.Stop();
			soundPlaying = false;
		}
	}

	public virtual void vevar()
	{
		if (!PlayerVevar)
		{
			PlayerVevar = true;
			GetComponent<AudioSource>().clip = vevLjud;
			GetComponent<AudioSource>().Play();
		}
	}

	public virtual void vevarInte()
	{
		if (PlayerVevar)
		{
			PlayerVevar = false;
			GetComponent<AudioSource>().Stop();
		}
	}
}

using System;
using UnityEngine;

[Serializable]
public class backgroundSound : MonoBehaviour
{
	public bool fadeUp;

	public bool fadeDown;

	public AudioClip knappLjud;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (fadeUp)
		{
			GetComponent<AudioSource>().volume = GetComponent<AudioSource>().volume + Time.deltaTime * 0.3f;
			if (GetComponent<AudioSource>().volume > 0.5f)
			{
				fadeUp = false;
				GetComponent<AudioSource>().volume = 0.5f;
			}
		}
		if (fadeDown)
		{
			GetComponent<AudioSource>().volume = GetComponent<AudioSource>().volume - Time.deltaTime * 0.3f;
			if (GetComponent<AudioSource>().volume == 0f)
			{
				fadeDown = false;
				GetComponent<AudioSource>().volume = 0f;
			}
		}
		if (fadeUp)
		{
			fadeDown = false;
		}
		else if (fadeDown)
		{
			fadeUp = false;
		}
	}

	public virtual void buttonClick()
	{
		GetComponent<AudioSource>().PlayOneShot(knappLjud);
	}
}

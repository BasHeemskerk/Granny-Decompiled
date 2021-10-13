using System;
using UnityEngine;

[Serializable]
public class soundEffectsMenu : MonoBehaviour
{
	public AudioClip knappLjud;

	public virtual void Start()
	{
		Time.timeScale = 1f;
		AudioListener.pause = false;
		AudioListener.volume = 1f;
	}

	public virtual void buttonClick()
	{
		GetComponent<AudioSource>().PlayOneShot(knappLjud);
	}
}

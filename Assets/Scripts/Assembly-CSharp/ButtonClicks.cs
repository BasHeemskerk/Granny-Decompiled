using System;
using UnityEngine;

[Serializable]
public class ButtonClicks : MonoBehaviour
{
	public AudioClip buttonclick;

	public AudioClip bearTrap;

	public virtual void clickButton()
	{
		GetComponent<AudioSource>().PlayOneShot(buttonclick);
	}

	public virtual void beartrap()
	{
		GetComponent<AudioSource>().PlayOneShot(bearTrap);
	}
}

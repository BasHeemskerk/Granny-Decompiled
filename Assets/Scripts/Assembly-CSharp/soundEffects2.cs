using System;
using UnityEngine;

[Serializable]
public class soundEffects2 : MonoBehaviour
{
	public AudioClip sword;

	public AudioClip pain;

	public AudioClip die;

	public virtual void Start()
	{
		AudioSource component = GetComponent<AudioSource>();
		component.clip = sword;
	}

	public virtual void swordSwing()
	{
		GetComponent<AudioSource>().clip = sword;
		GetComponent<AudioSource>().Play();
	}

	public virtual void slendrinaPain()
	{
		GetComponent<AudioSource>().clip = pain;
		GetComponent<AudioSource>().Play();
	}

	public virtual void slendrinaDie()
	{
		GetComponent<AudioSource>().clip = die;
		GetComponent<AudioSource>().Play();
	}
}

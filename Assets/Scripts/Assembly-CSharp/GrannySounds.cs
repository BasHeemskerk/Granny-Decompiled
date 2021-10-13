using System;
using UnityEngine;

[Serializable]
public class GrannySounds : MonoBehaviour
{
	public AudioClip[] Glaugh;

	public AudioClip skratt;

	public virtual void Start()
	{
	}

	public virtual void startGrannySound()
	{
		GetComponent<AudioSource>().clip = Glaugh[UnityEngine.Random.Range(0, Glaugh.Length)];
		GetComponent<AudioSource>().Play();
	}

	public virtual void grannySkrattar()
	{
		AudioSource.PlayClipAtPoint(skratt, base.transform.position);
	}
}

using System;
using UnityEngine;

[Serializable]
public class playEndMusic : MonoBehaviour
{
	public virtual void Start()
	{
	}

	public virtual void play()
	{
		GetComponent<AudioSource>().Play();
	}
}

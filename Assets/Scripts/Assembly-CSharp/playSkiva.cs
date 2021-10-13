using System;
using UnityEngine;

[Serializable]
public class playSkiva : MonoBehaviour
{
	public AudioClip scarySound;

	public virtual void Start()
	{
	}

	public virtual void SkivLjud()
	{
		GetComponent<AudioSource>().PlayOneShot(scarySound);
	}
}

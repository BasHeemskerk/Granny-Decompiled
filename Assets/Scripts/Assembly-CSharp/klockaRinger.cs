using System;
using UnityEngine;

[Serializable]
public class klockaRinger : MonoBehaviour
{
	public bool startKlock;

	public AudioClip klockljud;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (startKlock)
		{
			startKlock = false;
			GetComponent<AudioSource>().PlayOneShot(klockljud);
			base.gameObject.GetComponent<Animation>().Play("Klocka");
		}
	}
}

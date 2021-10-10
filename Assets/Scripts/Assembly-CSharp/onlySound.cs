using System;
using UnityEngine;

[Serializable]
public class onlySound : MonoBehaviour
{
	public AudioClip ObjectLjud;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "golv")
		{
			GetComponent<AudioSource>().PlayOneShot(ObjectLjud);
		}
	}
}

using System;
using UnityEngine;

[Serializable]
public class boxFall : MonoBehaviour
{
	public AudioClip boxLjud;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Terrain")
		{
			GetComponent<AudioSource>().PlayOneShot(boxLjud);
		}
	}
}

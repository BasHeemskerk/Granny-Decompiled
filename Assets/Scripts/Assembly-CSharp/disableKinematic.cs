using System;
using UnityEngine;

[Serializable]
public class disableKinematic : MonoBehaviour
{
	public AudioClip sound;

	public bool done;

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player" && !done)
		{
			done = true;
			((Rigidbody)base.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
			GetComponent<AudioSource>().PlayOneShot(sound);
		}
	}
}

using System;
using UnityEngine;

[Serializable]
public class TriggerNightSoundHigh : MonoBehaviour
{
	public GameObject nightSoundHolder;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			((FadeNightSound)nightSoundHolder.GetComponent(typeof(FadeNightSound))).fadeUp();
		}
	}
}

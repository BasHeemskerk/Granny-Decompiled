using System;
using UnityEngine;

[Serializable]
public class maniacScream : MonoBehaviour
{
	public AudioClip seePlayerSound;

	public AudioClip hitSword;

	public AudioClip scream;

	public bool screamNow;

	public virtual void Start()
	{
		AudioSource component = GetComponent<AudioSource>();
	}

	public virtual void Update()
	{
	}

	public virtual void maniacSeePlayer()
	{
		GetComponent<AudioSource>().clip = seePlayerSound;
		GetComponent<AudioSource>().Play();
	}

	public virtual void swordHit()
	{
		AudioSource.PlayClipAtPoint(hitSword, base.transform.position);
	}

	public virtual void ManiacScream()
	{
		AudioSource.PlayClipAtPoint(scream, base.transform.position);
	}
}

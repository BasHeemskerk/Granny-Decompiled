using System;
using UnityEngine;

[Serializable]
public class spiderSoundEffects : MonoBehaviour
{
	public AudioClip spiderSee;

	public AudioClip SpiderAttack;

	public AudioClip SpiderDie;

	public virtual void Start()
	{
	}

	public virtual void spiderSeePlayer()
	{
		GetComponent<AudioSource>().PlayOneShot(spiderSee);
	}

	public virtual void spiderAttackPlayer()
	{
		GetComponent<AudioSource>().PlayOneShot(SpiderAttack);
	}

	public virtual void spiderDie()
	{
		GetComponent<AudioSource>().PlayOneShot(SpiderDie);
	}
}

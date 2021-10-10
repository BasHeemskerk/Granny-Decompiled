using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class generatorSound : MonoBehaviour
{
	public AudioClip generatorStart;

	public AudioClip generatorRun;

	public virtual void Start()
	{
	}

	public virtual void startGen()
	{
		GetComponent<AudioSource>().PlayOneShot(generatorStart);
		StartCoroutine(genTimer());
	}

	public virtual void runGen()
	{
		GetComponent<AudioSource>().Play();
	}

	public virtual IEnumerator genTimer()
	{
		yield return new WaitForSeconds(2f);
		runGen();
	}
}

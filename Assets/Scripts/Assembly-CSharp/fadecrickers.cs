using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class fadecrickers : MonoBehaviour
{
	public float volume;

	public bool startFade;

	public virtual IEnumerator Start()
	{
		yield return new WaitForSeconds(60f);
		startFade = true;
	}

	public virtual void Update()
	{
		if (startFade)
		{
			GetComponent<AudioSource>().volume = GetComponent<AudioSource>().volume - 0.2f * Time.deltaTime;
		}
	}
}

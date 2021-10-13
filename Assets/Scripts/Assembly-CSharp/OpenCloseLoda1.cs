using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class OpenCloseLoda1 : MonoBehaviour
{
	public bool DoorOpen;

	public AudioClip LodaUt;

	public AudioClip LodaIn;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (!DoorOpen && GetComponent<Animation>().IsPlaying("Loda1Open"))
		{
			GetComponent<AudioSource>().PlayOneShot(LodaUt);
			DoorOpen = true;
			base.gameObject.tag = "Untagged";
			StartCoroutine(timerDooropen());
		}
		if (DoorOpen && GetComponent<Animation>().IsPlaying("Loda1Close"))
		{
			GetComponent<AudioSource>().PlayOneShot(LodaIn);
			DoorOpen = false;
			base.gameObject.tag = "Untagged";
			StartCoroutine(timerDoorclosed());
		}
	}

	public virtual IEnumerator timerDooropen()
	{
		yield return new WaitForSeconds(0.5f);
		base.gameObject.tag = "loda1Open";
	}

	public virtual IEnumerator timerDoorclosed()
	{
		yield return new WaitForSeconds(0.5f);
		base.gameObject.tag = "loda1Closed";
	}
}

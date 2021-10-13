using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class OpenCloseLoda2 : MonoBehaviour
{
	public bool DoorOpen;

	public AudioClip LodaUt;

	public AudioClip LodaIn;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (!DoorOpen && GetComponent<Animation>().IsPlaying("Loda2Open"))
		{
			GetComponent<AudioSource>().PlayOneShot(LodaUt);
			DoorOpen = true;
			base.gameObject.tag = "Untagged";
			StartCoroutine(timerDooropen());
		}
		if (DoorOpen && GetComponent<Animation>().IsPlaying("Loda2Close"))
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
		base.gameObject.tag = "loda2Open";
	}

	public virtual IEnumerator timerDoorclosed()
	{
		yield return new WaitForSeconds(0.5f);
		base.gameObject.tag = "loda2Closed";
	}
}

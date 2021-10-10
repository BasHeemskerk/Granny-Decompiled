using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class OpenCloseKitchenDoor2 : MonoBehaviour
{
	public bool DoorOpen;

	public AudioClip doorLjud;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (!DoorOpen && GetComponent<Animation>().IsPlaying("KitchenDoor2Open"))
		{
			GetComponent<AudioSource>().PlayOneShot(doorLjud);
			GetComponent<Collider>().enabled = false;
			DoorOpen = true;
			base.gameObject.tag = "Untagged";
			StartCoroutine(timerDooropen());
		}
		if (DoorOpen && GetComponent<Animation>().IsPlaying("KitchenDoor2Close"))
		{
			GetComponent<AudioSource>().PlayOneShot(doorLjud);
			GetComponent<Collider>().enabled = false;
			DoorOpen = false;
			base.gameObject.tag = "Untagged";
			StartCoroutine(timerDoorclosed());
		}
	}

	public virtual IEnumerator timerDooropen()
	{
		yield return new WaitForSeconds(0.5f);
		base.gameObject.tag = "kitchenDoor2Open";
		GetComponent<Collider>().enabled = true;
	}

	public virtual IEnumerator timerDoorclosed()
	{
		yield return new WaitForSeconds(0.5f);
		base.gameObject.tag = "kitchenDoor2Closed";
		GetComponent<Collider>().enabled = true;
	}
}

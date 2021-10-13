using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class openCloseBaklucka : MonoBehaviour
{
	public bool DoorOpen;

	public bool DoorMoving;

	public AudioClip doorOpen;

	public AudioClip doorClose;

	public AudioClip doorLockedLjud;

	public AudioClip doorUnLockedLjud;

	public bool doorLocked;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (!DoorOpen && GetComponent<Animation>().IsPlaying("bakluckaOpen"))
		{
			GetComponent<AudioSource>().PlayOneShot(doorOpen);
			DoorOpen = true;
			DoorMoving = true;
			base.gameObject.tag = "Untagged";
			StartCoroutine(timerDooropen());
		}
		if (DoorOpen && GetComponent<Animation>().IsPlaying("bakluckaClose"))
		{
			GetComponent<AudioSource>().PlayOneShot(doorClose);
			DoorOpen = false;
			DoorMoving = true;
			base.gameObject.tag = "Untagged";
			StartCoroutine(timerDoorclosed());
		}
	}

	public virtual IEnumerator timerDooropen()
	{
		yield return new WaitForSeconds(1f);
		base.gameObject.tag = "bakluckaOpen";
		DoorMoving = false;
	}

	public virtual IEnumerator timerDoorclosed()
	{
		yield return new WaitForSeconds(1f);
		base.gameObject.tag = "bakluckaClosed";
		doorLocked = false;
		DoorMoving = false;
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (DoorMoving)
		{
			if (other.gameObject.tag == "Player")
			{
				Physics.IgnoreCollision(GetComponent<Collider>(), other.GetComponent<Collider>(), true);
			}
		}
		else if (!DoorMoving)
		{
			Physics.IgnoreCollision(GetComponent<Collider>(), other.GetComponent<Collider>(), false);
		}
	}
}

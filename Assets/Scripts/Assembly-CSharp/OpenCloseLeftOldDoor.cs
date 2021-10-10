using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class OpenCloseLeftOldDoor : MonoBehaviour
{
	public bool DoorOpen;

	public GameObject doorStop;

	public bool DoorBlocked;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (!DoorOpen && GetComponent<Animation>().IsPlaying("InnerdoorLeftOpen"))
		{
			DoorOpen = true;
			base.gameObject.tag = "Untagged";
			((enableDisableCarve)doorStop.GetComponent(typeof(enableDisableCarve))).doorOpenCarve = true;
			GetComponent<Collider>().enabled = false;
			StartCoroutine(timerDooropen());
		}
		if (DoorOpen && GetComponent<Animation>().IsPlaying("InnerdoorLeftClose"))
		{
			DoorOpen = false;
			base.gameObject.tag = "Untagged";
			((enableDisableCarve)doorStop.GetComponent(typeof(enableDisableCarve))).doorOpenCarve = false;
			GetComponent<Collider>().enabled = false;
			StartCoroutine(timerDoorclosed());
		}
		if (DoorBlocked)
		{
			base.gameObject.tag = "doorLockedNoKey";
		}
	}

	public virtual IEnumerator timerDooropen()
	{
		yield return new WaitForSeconds(2f);
		base.gameObject.tag = "doorLeftOpen";
		GetComponent<Collider>().enabled = true;
	}

	public virtual IEnumerator timerDoorclosed()
	{
		if (!DoorBlocked)
		{
			yield return new WaitForSeconds(2f);
			base.gameObject.tag = "doorLeftClosed";
			GetComponent<Collider>().enabled = true;
		}
		else
		{
			yield return new WaitForSeconds(1f);
			GetComponent<Collider>().enabled = true;
		}
	}
}

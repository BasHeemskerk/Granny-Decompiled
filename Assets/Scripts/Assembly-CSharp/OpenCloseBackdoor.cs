using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;

[Serializable]
public class OpenCloseBackdoor : MonoBehaviour
{
	public bool DoorOpen;

	public bool DoorMoving;

	public NavMeshObstacle Innerdoor;

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
		if (!DoorOpen && GetComponent<Animation>().IsPlaying("BackDoorOpen"))
		{
			if (base.gameObject.tag == "innerdoorLocked")
			{
				GetComponent<AudioSource>().PlayOneShot(doorUnLockedLjud);
			}
			else
			{
				GetComponent<AudioSource>().PlayOneShot(doorOpen);
			}
			DoorOpen = true;
			DoorMoving = true;
			base.gameObject.tag = "Untagged";
			Innerdoor.carving = base.enabled;
			StartCoroutine(timerDooropen());
		}
		if (DoorOpen && GetComponent<Animation>().IsPlaying("BackDoorClose"))
		{
			GetComponent<AudioSource>().PlayOneShot(doorClose);
			DoorOpen = false;
			DoorMoving = true;
			base.gameObject.tag = "Untagged";
			StartCoroutine(timerDoorclosed());
		}
		if (!DoorOpen && GetComponent<Animation>().IsPlaying("BackDoorLocked") && !doorLocked)
		{
			doorLocked = true;
			GetComponent<AudioSource>().PlayOneShot(doorLockedLjud);
			StartCoroutine(timerDoorlocked());
		}
	}

	public virtual IEnumerator timerDooropen()
	{
		yield return new WaitForSeconds(1f);
		base.gameObject.tag = "innerdoorOpen";
		DoorMoving = false;
		yield return new WaitForSeconds(3f);
		base.gameObject.GetComponent<Animation>().Play("InnerdoorClose");
	}

	public virtual IEnumerator timerDoorclosed()
	{
		yield return new WaitForSeconds(1f);
		base.gameObject.tag = "innerdoorLocked";
		Innerdoor.carving = !base.enabled;
		doorLocked = false;
		DoorMoving = false;
	}

	public virtual IEnumerator timerDoorlocked()
	{
		yield return new WaitForSeconds(1.3f);
		doorLocked = false;
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

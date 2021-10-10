using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;

[Serializable]
public class OpenCloseKyl : MonoBehaviour
{
	public bool DoorOpen;

	public NavMeshObstacle Innerdoor;

	public AudioClip doorLjud;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (!DoorOpen && GetComponent<Animation>().IsPlaying("KylOpen"))
		{
			GetComponent<AudioSource>().PlayOneShot(doorLjud);
			GetComponent<Collider>().enabled = false;
			DoorOpen = true;
			base.gameObject.tag = "Untagged";
			Innerdoor.carving = base.enabled;
			StartCoroutine(timerDooropen());
		}
		if (DoorOpen && GetComponent<Animation>().IsPlaying("KylClose"))
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
		base.gameObject.tag = "kylOpen";
		GetComponent<Collider>().enabled = true;
	}

	public virtual IEnumerator timerDoorclosed()
	{
		yield return new WaitForSeconds(0.5f);
		base.gameObject.tag = "kylClosed";
		Innerdoor.carving = !base.enabled;
		GetComponent<Collider>().enabled = true;
	}
}

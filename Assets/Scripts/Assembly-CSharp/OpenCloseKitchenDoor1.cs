using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;

[Serializable]
public class OpenCloseKitchenDoor1 : MonoBehaviour
{
	public bool DoorOpen;

	public NavMeshObstacle Innerdoor;

	public AudioClip doorLjud;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (!DoorOpen && GetComponent<Animation>().IsPlaying("KitchenDoor1Open"))
		{
			GetComponent<AudioSource>().PlayOneShot(doorLjud);
			GetComponent<Collider>().enabled = false;
			DoorOpen = true;
			base.gameObject.tag = "Untagged";
			Innerdoor.carving = base.enabled;
			StartCoroutine(timerDooropen());
		}
		if (DoorOpen && GetComponent<Animation>().IsPlaying("KitchenDoor1Close"))
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
		base.gameObject.tag = "kitchenDoor1Open";
		GetComponent<Collider>().enabled = true;
	}

	public virtual IEnumerator timerDoorclosed()
	{
		yield return new WaitForSeconds(0.5f);
		base.gameObject.tag = "kitchenDoor1Closed";
		Innerdoor.carving = !base.enabled;
		GetComponent<Collider>().enabled = true;
	}
}

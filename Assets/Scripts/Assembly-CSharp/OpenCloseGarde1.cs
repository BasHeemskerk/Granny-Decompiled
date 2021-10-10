using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;

[Serializable]
public class OpenCloseGarde1 : MonoBehaviour
{
	public bool DoorOpen;

	public NavMeshObstacle Innerdoor;

	public AudioClip doorLjud;

	public AudioClip doorLjud2;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (!DoorOpen && GetComponent<Animation>().IsPlaying("Garde1Open_0"))
		{
			GetComponent<AudioSource>().PlayOneShot(doorLjud);
			GetComponent<Collider>().enabled = false;
			DoorOpen = true;
			base.gameObject.tag = "Untagged";
			Innerdoor.carving = base.enabled;
			StartCoroutine(timerDooropen());
		}
		if (DoorOpen && GetComponent<Animation>().IsPlaying("Garde1Close_0"))
		{
			GetComponent<AudioSource>().PlayOneShot(doorLjud2);
			GetComponent<Collider>().enabled = false;
			DoorOpen = false;
			base.gameObject.tag = "Untagged";
			StartCoroutine(timerDoorclosed());
		}
	}

	public virtual IEnumerator timerDooropen()
	{
		yield return new WaitForSeconds(0.5f);
		base.gameObject.tag = "garde1Open";
		GetComponent<Collider>().enabled = true;
	}

	public virtual IEnumerator timerDoorclosed()
	{
		yield return new WaitForSeconds(0.5f);
		base.gameObject.tag = "garde1Closed";
		Innerdoor.carving = !base.enabled;
		GetComponent<Collider>().enabled = true;
	}
}

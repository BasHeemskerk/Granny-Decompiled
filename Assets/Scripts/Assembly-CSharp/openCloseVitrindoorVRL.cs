using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;

[Serializable]
public class openCloseVitrindoorVRL : MonoBehaviour
{
	public bool DoorOpen;

	public NavMeshObstacle Innerdoor;

	public AudioClip doorLjud;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (!DoorOpen && GetComponent<Animation>().IsPlaying("VitrindoorVRLOpen"))
		{
			GetComponent<AudioSource>().PlayOneShot(doorLjud);
			GetComponent<Collider>().enabled = false;
			DoorOpen = true;
			base.gameObject.tag = "Untagged";
			Innerdoor.carving = base.enabled;
			StartCoroutine(timerDooropen());
		}
		if (DoorOpen && GetComponent<Animation>().IsPlaying("VitrindoorVRLClose"))
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
		yield return new WaitForSeconds(1f);
		base.gameObject.tag = "vitrindoorVRLopen";
		GetComponent<Collider>().enabled = true;
	}

	public virtual IEnumerator timerDoorclosed()
	{
		yield return new WaitForSeconds(1f);
		base.gameObject.tag = "vitrindoorVRLclosed";
		Innerdoor.carving = !base.enabled;
		GetComponent<Collider>().enabled = true;
	}
}

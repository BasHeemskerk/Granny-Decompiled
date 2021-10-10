using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class prisonDoorOpenClose : MonoBehaviour
{
	public bool DoorOpen;

	public bool DoorMoving;

	public AudioClip doorOpen;

	public AudioClip doorClose;

	public AudioClip doorLockedLjud;

	public bool doorLocked;

	public bool sprint1Bort;

	public bool sprint2Bort;

	public GameObject sprint1;

	public GameObject sprint2;

	public bool doorFree;

	public GameObject sparcle1;

	public GameObject sparcle2;

	public GameObject galler;

	public GameObject gallerColliders;

	public GameObject doorTrigger;

	public GameObject camSeeTrigger;

	public GameObject camSound;

	public GameObject bottomCollider;

	public bool doorOpenAgain;

	public GameObject granny;

	public prisonDoorOpenClose()
	{
		DoorOpen = true;
	}

	public virtual void Start()
	{
		DoorOpen = true;
	}

	public virtual void Update()
	{
		if (!sprint1Bort || !sprint2Bort)
		{
			if (!DoorOpen)
			{
				if (GetComponent<Animation>().IsPlaying("prisondoorOpen"))
				{
					GetComponent<AudioSource>().PlayOneShot(doorOpen);
					DoorOpen = true;
					DoorMoving = true;
					base.gameObject.tag = "Untagged";
					StartCoroutine(timerDooropen());
				}
				else
				{
					DoorMoving = false;
				}
			}
			if (DoorOpen)
			{
				if (GetComponent<Animation>().IsPlaying("prisondoorClose"))
				{
					GetComponent<AudioSource>().PlayOneShot(doorClose);
					DoorOpen = false;
					DoorMoving = true;
					base.gameObject.tag = "Untagged";
					StartCoroutine(timerDoorclosed());
				}
				else
				{
					DoorMoving = false;
				}
			}
			if (!DoorOpen && GetComponent<Animation>().IsPlaying("prisondoorLocked") && !doorLocked)
			{
				doorLocked = true;
				timerDoorlocked();
			}
		}
		if (sprint1Bort && sprint2Bort && !doorFree)
		{
			doorFree = true;
			StartCoroutine(doorLoose());
		}
	}

	public virtual IEnumerator timerDooropen()
	{
		yield return new WaitForSeconds(1f);
		DoorMoving = false;
		if (GameObject.Find("Sprint1") != null)
		{
			sprint1.gameObject.tag = "Untagged";
		}
		if (GameObject.Find("Sprint2") != null)
		{
			sprint2.gameObject.tag = "Untagged";
		}
		if (GameObject.Find("Sparkle1") != null)
		{
			sparcle1.SetActive(false);
		}
		if (GameObject.Find("Sparkle2") != null)
		{
			sparcle2.SetActive(false);
		}
	}

	public virtual IEnumerator timerDoorclosed()
	{
		yield return new WaitForSeconds(1f);
		base.gameObject.tag = "prisondoorlocked";
		doorTrigger.SetActive(true);
		if (GameObject.Find("Sprint1") != null)
		{
			sprint1.gameObject.tag = "sprint1";
		}
		if (GameObject.Find("Sprint2") != null)
		{
			sprint2.gameObject.tag = "sprint2";
		}
		doorLocked = false;
		DoorMoving = false;
		yield return new WaitForSeconds(30f);
		if (base.gameObject.tag == "prisondoorlocked")
		{
			if (GameObject.Find("Sprint1") != null)
			{
				sparcle1.SetActive(true);
			}
			if (GameObject.Find("Sprint2") != null)
			{
				sparcle2.SetActive(true);
			}
		}
	}

	public virtual void timerDoorlocked()
	{
	}

	public virtual IEnumerator doorLoose()
	{
		galler.GetComponent<Collider>().enabled = true;
		gallerColliders.SetActive(false);
		camSeeTrigger.SetActive(false);
		yield return new WaitForSeconds(2f);
		base.gameObject.AddComponent(typeof(Rigidbody));
		doorTrigger.SetActive(false);
		((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerInPrison = false;
		((Rigidbody)GetComponent(typeof(Rigidbody))).isKinematic = false;
		((MeshCollider)GetComponent(typeof(MeshCollider))).convex = true;
		base.gameObject.tag = "Untagged";
		if (GameObject.Find("Kameralampa") != null)
		{
			((camLampBlink)camSound.GetComponent(typeof(camLampBlink))).soundOff = true;
		}
		yield return new WaitForSeconds(15f);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "granny" && (((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).seePlayer || ((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).grannyIsFollow || ((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).grannyHearObject) && !doorFree && !doorOpenAgain)
		{
			doorOpenAgain = true;
			GetComponent<Animation>().Play("prisondoorOpen");
			doorTrigger.SetActive(false);
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerInPrison = false;
			camSeeTrigger.SetActive(false);
		}
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

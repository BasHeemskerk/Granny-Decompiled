using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class OpenCloseDoorV : MonoBehaviour
{
	public bool doorOpen;

	public float doorHealth;

	public bool doorDead;

	public GameObject doorStop;

	public AudioClip doorDeadLjud;

	public virtual void Start()
	{
		doorHealth = 100f;
	}

	public virtual void Update()
	{
		if (doorHealth <= 0f && !doorDead)
		{
			doorDead = true;
			GetComponent<Animation>().Play("InnerDoorVSmash");
			base.gameObject.tag = "Untagged";
			GetComponent<Collider>().enabled = false;
			doorStop.SetActive(false);
			AudioSource.PlayClipAtPoint(doorDeadLjud, base.transform.position);
			StartCoroutine(removeDoor());
		}
		if (!doorOpen && GetComponent<Animation>().IsPlaying("InnerDoorHOpen"))
		{
			doorOpen = true;
			base.gameObject.tag = null;
			StartCoroutine(timerDooropen());
		}
		if (doorOpen && GetComponent<Animation>().IsPlaying("InnerDoorHClose"))
		{
			doorOpen = false;
			base.gameObject.tag = null;
			StartCoroutine(timerDoorclosed());
		}
		if (!doorOpen && GetComponent<Animation>().IsPlaying("InnerDoorVOpen"))
		{
			doorOpen = true;
			base.gameObject.tag = null;
			StartCoroutine(timerDoorVopen());
		}
		if (doorOpen && GetComponent<Animation>().IsPlaying("InnerDoorVClose"))
		{
			doorOpen = false;
			base.gameObject.tag = null;
			StartCoroutine(timerDoorVclosed());
		}
	}

	public virtual IEnumerator timerDooropen()
	{
		yield return new WaitForSeconds(1f);
		base.gameObject.tag = "innerdoorHOpen";
	}

	public virtual IEnumerator timerDoorclosed()
	{
		yield return new WaitForSeconds(1f);
		base.gameObject.tag = "innerdoorHClosed";
	}

	public virtual IEnumerator timerDoorVopen()
	{
		yield return new WaitForSeconds(1f);
		base.gameObject.tag = "innerdoorVOpen";
	}

	public virtual IEnumerator timerDoorVclosed()
	{
		yield return new WaitForSeconds(1f);
		base.gameObject.tag = "innerdoorVClosed";
	}

	public virtual IEnumerator removeDoor()
	{
		yield return new WaitForSeconds(10f);
		UnityEngine.Object.Destroy(base.gameObject);
	}
}

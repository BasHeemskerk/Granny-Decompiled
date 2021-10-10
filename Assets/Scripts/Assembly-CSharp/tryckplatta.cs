using System;
using UnityEngine;

[Serializable]
public class tryckplatta : MonoBehaviour
{
	public GameObject slideDoor;

	public bool ironKlumpOnPlace;

	public Texture bildVit;

	public Texture bildGreen;

	public GameObject standOnPlatta;

	public AudioClip tryckplattaLjud;

	public GameObject soundHolder;

	public virtual void Update()
	{
		if (ironKlumpOnPlace)
		{
			((doorSlide)slideDoor.GetComponent(typeof(doorSlide))).plattaTryck = true;
		}
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player" && !ironKlumpOnPlace)
		{
			((doorSlide)slideDoor.GetComponent(typeof(doorSlide))).plattaTryck = true;
			((haveObjects)standOnPlatta.GetComponent(typeof(haveObjects))).playerStandOnPlatta = true;
			AudioSource.PlayClipAtPoint(tryckplattaLjud, base.transform.position);
			((doorSlide)soundHolder.GetComponent(typeof(doorSlide))).StartSound();
		}
	}

	public virtual void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Player" && !ironKlumpOnPlace)
		{
			((doorSlide)slideDoor.GetComponent(typeof(doorSlide))).plattaTryck = false;
			((haveObjects)standOnPlatta.GetComponent(typeof(haveObjects))).playerStandOnPlatta = false;
			((doorSlide)soundHolder.GetComponent(typeof(doorSlide))).StartSound();
		}
	}
}

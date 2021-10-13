using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class placePlanka : MonoBehaviour
{
	public GameObject holdingPlanka;

	public GameObject highlightPlanka;

	public bool holeOpen;

	public bool startText;

	public GameObject PlaceButton;

	public GameObject text;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (!(other.gameObject.tag == "Player"))
		{
			return;
		}
		if (((PickUp)holdingPlanka.GetComponent(typeof(PickUp))).haveplanka)
		{
			highlightPlanka.SetActive(true);
			((PickUp)holdingPlanka.GetComponent(typeof(PickUp))).plankaHighlighted = true;
			PlaceButton.SetActive(true);
			return;
		}
		highlightPlanka.SetActive(false);
		((PickUp)holdingPlanka.GetComponent(typeof(PickUp))).plankaHighlighted = false;
		if ((bool)GameObject.FindWithTag("plankawalk") && holeOpen && !startText)
		{
			startText = true;
			StartCoroutine(textTimer());
		}
	}

	public virtual void OnTriggerStay(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			if (((PickUp)holdingPlanka.GetComponent(typeof(PickUp))).haveplanka)
			{
				highlightPlanka.SetActive(true);
				((PickUp)holdingPlanka.GetComponent(typeof(PickUp))).plankaHighlighted = true;
				PlaceButton.SetActive(true);
			}
			else
			{
				highlightPlanka.SetActive(false);
				((PickUp)holdingPlanka.GetComponent(typeof(PickUp))).plankaHighlighted = false;
			}
		}
	}

	public virtual void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			highlightPlanka.SetActive(false);
			((PickUp)holdingPlanka.GetComponent(typeof(PickUp))).plankaHighlighted = false;
			PlaceButton.SetActive(false);
		}
	}

	public virtual IEnumerator textTimer()
	{
		yield return new WaitForSeconds(3f);
		text.SetActive(true);
		yield return new WaitForSeconds(3f);
		text.SetActive(false);
	}
}

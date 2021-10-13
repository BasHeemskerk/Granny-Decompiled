using System;
using UnityEngine;

[Serializable]
public class tavelbitTrigger : MonoBehaviour
{
	public GameObject checkTavelbitar;

	public GameObject checkTavla;

	public GameObject tb1Ram;

	public GameObject tb2Ram;

	public GameObject tb3Ram;

	public GameObject tb4Ram;

	public GameObject tb1Hand;

	public GameObject tb2Hand;

	public GameObject tb3Hand;

	public GameObject tb4Hand;

	public GameObject dropObjectButton;

	public GameObject mittenRing;

	public GameObject soundHolder;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
	}

	public virtual void OnTriggerStay(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			if (((PickUp)checkTavelbitar.GetComponent(typeof(PickUp))).havetb1)
			{
				((PickUp)checkTavelbitar.GetComponent(typeof(PickUp))).havetb1 = false;
				((startNewDay)checkTavla.GetComponent(typeof(startNewDay))).tavelbit1 = true;
				tb1Ram.SetActive(true);
				tb1Hand.SetActive(false);
				dropObjectButton.SetActive(false);
				mittenRing.SetActive(false);
				((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).tavelbitPlace();
			}
			else if (((PickUp)checkTavelbitar.GetComponent(typeof(PickUp))).havetb2)
			{
				((PickUp)checkTavelbitar.GetComponent(typeof(PickUp))).havetb2 = false;
				((startNewDay)checkTavla.GetComponent(typeof(startNewDay))).tavelbit2 = true;
				tb2Ram.SetActive(true);
				tb2Hand.SetActive(false);
				dropObjectButton.SetActive(false);
				mittenRing.SetActive(false);
				((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).tavelbitPlace();
			}
			else if (((PickUp)checkTavelbitar.GetComponent(typeof(PickUp))).havetb3)
			{
				((PickUp)checkTavelbitar.GetComponent(typeof(PickUp))).havetb3 = false;
				((startNewDay)checkTavla.GetComponent(typeof(startNewDay))).tavelbit3 = true;
				tb3Ram.SetActive(true);
				tb3Hand.SetActive(false);
				dropObjectButton.SetActive(false);
				mittenRing.SetActive(false);
				((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).tavelbitPlace();
			}
			else if (((PickUp)checkTavelbitar.GetComponent(typeof(PickUp))).havetb4)
			{
				((PickUp)checkTavelbitar.GetComponent(typeof(PickUp))).havetb4 = false;
				((startNewDay)checkTavla.GetComponent(typeof(startNewDay))).tavelbit4 = true;
				tb4Ram.SetActive(true);
				tb4Hand.SetActive(false);
				dropObjectButton.SetActive(false);
				mittenRing.SetActive(false);
				((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).tavelbitPlace();
			}
		}
	}
}

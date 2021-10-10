using System;
using UnityEngine;

[Serializable]
public class DeliverShotgunParts : MonoBehaviour
{
	public GameObject Player;

	public bool shotgunPart1;

	public bool shotgunPart2;

	public bool shotgunPart3;

	public GameObject shotgunPart1Table;

	public GameObject shotgunPart2Table;

	public GameObject shotgunPart3Table;

	public GameObject shotgunPart1Hand;

	public GameObject shotgunPart2Hand;

	public GameObject shotgunPart3Hand;

	public GameObject dropObjectButton;

	public GameObject Shotgun;

	public GameObject moreAmmo;

	public AudioClip placeObjectSound;

	public virtual void OnTriggerStay(Collider other)
	{
		if (!(other.gameObject.tag == "Player"))
		{
			return;
		}
		if (((PickUp)Player.GetComponent(typeof(PickUp))).havegunDel1)
		{
			shotgunPart1Table.SetActive(true);
			shotgunPart1Hand.SetActive(false);
			dropObjectButton.SetActive(false);
			((PickUp)Player.GetComponent(typeof(PickUp))).havegunDel1 = false;
			shotgunPart1 = true;
			GetComponent<AudioSource>().PlayOneShot(placeObjectSound);
			if (shotgunPart2 && shotgunPart3)
			{
				Shotgun.SetActive(true);
				moreAmmo.SetActive(true);
				shotgunPart1Table.SetActive(false);
				shotgunPart2Table.SetActive(false);
				shotgunPart3Table.SetActive(false);
			}
		}
		if (((PickUp)Player.GetComponent(typeof(PickUp))).havegunDel2)
		{
			shotgunPart2Table.SetActive(true);
			shotgunPart2Hand.SetActive(false);
			dropObjectButton.SetActive(false);
			((PickUp)Player.GetComponent(typeof(PickUp))).havegunDel2 = false;
			shotgunPart2 = true;
			GetComponent<AudioSource>().PlayOneShot(placeObjectSound);
			if (shotgunPart1 && shotgunPart3)
			{
				Shotgun.SetActive(true);
				moreAmmo.SetActive(true);
				shotgunPart1Table.SetActive(false);
				shotgunPart2Table.SetActive(false);
				shotgunPart3Table.SetActive(false);
			}
		}
		if (((PickUp)Player.GetComponent(typeof(PickUp))).havegunDel3)
		{
			shotgunPart3Table.SetActive(true);
			shotgunPart3Hand.SetActive(false);
			dropObjectButton.SetActive(false);
			((PickUp)Player.GetComponent(typeof(PickUp))).havegunDel3 = false;
			shotgunPart3 = true;
			GetComponent<AudioSource>().PlayOneShot(placeObjectSound);
			if (shotgunPart1 && shotgunPart2)
			{
				Shotgun.SetActive(true);
				moreAmmo.SetActive(true);
				shotgunPart1Table.SetActive(false);
				shotgunPart2Table.SetActive(false);
				shotgunPart3Table.SetActive(false);
			}
		}
	}
}

using System;
using UnityEngine;

[Serializable]
public class resetDay : MonoBehaviour
{
	public GameObject door1;

	public GameObject door2;

	public GameObject door3;

	public GameObject door4;

	public GameObject door5;

	public GameObject door6;

	public GameObject door7;

	public GameObject door8;

	public GameObject door9;

	public GameObject door10;

	public GameObject loda1;

	public GameObject loda2;

	public GameObject loda3;

	public GameObject loda4;

	public GameObject loda5;

	public GameObject loda6;

	public GameObject loda7;

	public GameObject loda8;

	public GameObject loda9;

	public GameObject loda10;

	public GameObject loda11;

	public GameObject loda12;

	public GameObject kylDoor;

	public GameObject kitchenDoor1;

	public GameObject kitchenDoor2;

	public GameObject kitchenDoor3;

	public GameObject kitchenDoor4;

	public GameObject kitchenDoor5;

	public GameObject kitchenDoor6;

	public GameObject vitrinDoor1;

	public GameObject vitrinDoor2;

	public GameObject vitrinDoor3;

	public GameObject vitrinDoor4;

	public virtual void resetDays()
	{
		door1.GetComponent<Animation>().Play("InnerdoorClose");
		door2.GetComponent<Animation>().Play("InnerdoorClose");
		door3.GetComponent<Animation>().Play("InnerdoorClose");
		door4.GetComponent<Animation>().Play("InnerdoorClose");
		door5.GetComponent<Animation>().Play("SmallDoorClose");
		door6.GetComponent<Animation>().Play("SmallDoorClose");
		door7.GetComponent<Animation>().Play("Garde1Close");
		door8.GetComponent<Animation>().Play("Garde1Close");
		door9.GetComponent<Animation>().Play("Garde1Close");
		door10.GetComponent<Animation>().Play("SmallDoorClose");
		loda1.GetComponent<Animation>().Play("Loda1Close");
		loda2.GetComponent<Animation>().Play("Loda1Close");
		loda3.GetComponent<Animation>().Play("Loda2Close");
		loda4.GetComponent<Animation>().Play("Loda2Close");
		loda5.GetComponent<Animation>().Play("Loda2Close");
		loda6.GetComponent<Animation>().Play("Loda2Close");
		loda7.GetComponent<Animation>().Play("Loda2Close");
		loda8.GetComponent<Animation>().Play("Loda2Close");
		loda9.GetComponent<Animation>().Play("Loda2Close");
		loda10.GetComponent<Animation>().Play("Loda2Close");
		loda11.GetComponent<Animation>().Play("Loda1Close");
		loda12.GetComponent<Animation>().Play("Loda1Close");
		kylDoor.GetComponent<Animation>().Play("KylClose");
		kitchenDoor1.GetComponent<Animation>().Play("KitchenDoor1Close");
		kitchenDoor2.GetComponent<Animation>().Play("KitchenDoor1Close");
		kitchenDoor3.GetComponent<Animation>().Play("KitchenDoor1Close");
		kitchenDoor4.GetComponent<Animation>().Play("KitchenDoor1Close");
		kitchenDoor5.GetComponent<Animation>().Play("KitchenDoor2Close");
		kitchenDoor6.GetComponent<Animation>().Play("KitchenDoor2Close");
		vitrinDoor1.GetComponent<Animation>().Play("VitrindoorVRLClose");
		vitrinDoor2.GetComponent<Animation>().Play("VitrindoorVRRClose");
		vitrinDoor3.GetComponent<Animation>().Play("VitrindoorHallLClose");
		vitrinDoor4.GetComponent<Animation>().Play("VitrindoorHallClose");
	}
}

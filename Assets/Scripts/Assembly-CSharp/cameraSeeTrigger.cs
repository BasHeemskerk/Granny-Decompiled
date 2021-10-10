using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class cameraSeeTrigger : MonoBehaviour
{
	public GameObject noiceObject1;

	public GameObject noiceObject2;

	public GameObject noiceObject3;

	public GameObject noiceObject4;

	public bool camSee;

	public bool camActivated;

	public bool doorClosed;

	public GameObject Granny;

	public GameObject player;

	public GameObject doorTrigger;

	public GameObject planka1;

	public GameObject planka2;

	public GameObject planka3;

	public GameObject cameraAlarm;

	public GameObject galler;

	public GameObject gallerColliders;

	public GameObject prisonDoor;

	public virtual void Start()
	{
	}

	public virtual IEnumerator OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player" && !camSee)
		{
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerInPrison = true;
			((PickUp)player.GetComponent(typeof(PickUp))).playerInPrison = true;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHiding = true;
			doorTrigger.SetActive(true);
			if (!camActivated)
			{
				camActivated = true;
				((camLampBlink)cameraAlarm.GetComponent(typeof(camLampBlink))).startBlink = true;
			}
			if (!doorClosed)
			{
				doorClosed = true;
				prisonDoor.GetComponent<Animation>().Play("prisondoorClose");
				((prisonDoorOpenClose)prisonDoor.GetComponent(typeof(prisonDoorOpenClose))).doorLocked = true;
			}
			if (GameObject.Find("PlankaVind") != null)
			{
				planka1.SetActive(false);
			}
			if (GameObject.Find("PlankaVind2") != null)
			{
				planka2.SetActive(false);
			}
			if (GameObject.Find("PlankaVind3") != null)
			{
				planka3.SetActive(false);
			}
			camSee = true;
			noiceObject1.SetActive(true);
			yield return new WaitForSeconds(15f);
			noiceObject2.SetActive(true);
			yield return new WaitForSeconds(15f);
			noiceObject3.SetActive(true);
			yield return new WaitForSeconds(15f);
			noiceObject4.SetActive(true);
			((camLampBlink)cameraAlarm.GetComponent(typeof(camLampBlink))).soundOff = true;
		}
		if (other.gameObject.tag == "granny")
		{
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerInPrison = false;
		}
	}
}

using System;
using UnityEngine;

[Serializable]
public class grannyClosePrisondoor : MonoBehaviour
{
	public GameObject prisonDoor;

	public GameObject granny;

	public GameObject grannyEyes;

	public GameObject noiceObjects;

	public GameObject planka1;

	public GameObject planka2;

	public GameObject planka3;

	public bool doorClosed;

	public GameObject camSound;

	public bool firstTime;

	public bool playerEscaped;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "granny")
		{
			if (!playerEscaped && !((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).seePlayer)
			{
				if (!firstTime)
				{
					firstTime = true;
					((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).prisondoorClosed = true;
					((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).grannyHearObject = false;
					((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).startTimerSearch = true;
					((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).timerSearch = 4f;
					noiceObjects.SetActive(false);
					((camLampBlink)camSound.GetComponent(typeof(camLampBlink))).soundOff = true;
				}
				else if (firstTime)
				{
					((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).prisondoorClosed = false;
				}
			}
		}
		else if (other.gameObject.tag == "Player")
		{
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerInPrison = false;
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerHiding = false;
			playerEscaped = true;
		}
	}

	public virtual void OnTriggerStay(Collider other)
	{
		if (other.gameObject.tag == "granny" && ((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).seePlayer && doorClosed)
		{
			doorClosed = false;
		}
	}
}

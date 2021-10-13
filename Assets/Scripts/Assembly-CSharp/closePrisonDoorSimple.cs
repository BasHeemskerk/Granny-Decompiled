using System;
using UnityEngine;

[Serializable]
public class closePrisonDoorSimple : MonoBehaviour
{
	public GameObject granny;

	public GameObject prisonDoor;

	public bool doorClosed;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerHiding = true;
		}
	}

	public virtual void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerHiding = false;
		}
	}
}

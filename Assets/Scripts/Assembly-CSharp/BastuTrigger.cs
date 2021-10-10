using System;
using UnityEngine;

[Serializable]
public class BastuTrigger : MonoBehaviour
{
	public GameObject granny;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerHiding = true;
		}
		if (other.gameObject.tag == "granny")
		{
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).grannyInBastu = true;
		}
	}

	public virtual void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerHiding = false;
		}
		if (other.gameObject.tag == "granny")
		{
			if (!((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).bastuBomNere)
			{
				((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).grannyInBastu = false;
			}
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).bastuTimer = 15f;
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).bastuDoorTimer = 20f;
		}
	}
}

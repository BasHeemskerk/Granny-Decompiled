using System;
using UnityEngine;

[Serializable]
public class hideTrigger : MonoBehaviour
{
	public GameObject granny;

	public GameObject grannyEye;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerHiding = true;
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerInHole = true;
		}
	}

	public virtual void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerHiding = false;
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerInHole = false;
		}
	}
}

using System;
using UnityEngine;

[Serializable]
public class gardeTrigger : MonoBehaviour
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
	}

	public virtual void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerHiding = false;
		}
	}
}

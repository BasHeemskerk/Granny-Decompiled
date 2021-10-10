using System;
using UnityEngine;

[Serializable]
public class grannyStandCarTrigger : MonoBehaviour
{
	public GameObject granny;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "granny")
		{
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).grannyStandBesideCar = true;
		}
	}

	public virtual void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "granny")
		{
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).grannyStandBesideCar = false;
		}
	}
}

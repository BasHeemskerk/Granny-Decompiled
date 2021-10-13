using System;
using UnityEngine;

[Serializable]
public class floor3Trigger : MonoBehaviour
{
	public GameObject gameController;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			((checkMapFloor)gameController.GetComponent(typeof(checkMapFloor))).playerFloor3 = true;
			((checkMapFloor)gameController.GetComponent(typeof(checkMapFloor))).playerFloor1 = false;
			((checkMapFloor)gameController.GetComponent(typeof(checkMapFloor))).playerFloor2 = false;
		}
	}
}

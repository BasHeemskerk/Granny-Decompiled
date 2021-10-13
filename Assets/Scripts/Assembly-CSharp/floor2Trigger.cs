using System;
using UnityEngine;

[Serializable]
public class floor2Trigger : MonoBehaviour
{
	public GameObject gameController;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			((checkMapFloor)gameController.GetComponent(typeof(checkMapFloor))).playerFloor2 = true;
			((checkMapFloor)gameController.GetComponent(typeof(checkMapFloor))).playerFloor1 = false;
			((checkMapFloor)gameController.GetComponent(typeof(checkMapFloor))).playerFloor3 = false;
		}
	}
}

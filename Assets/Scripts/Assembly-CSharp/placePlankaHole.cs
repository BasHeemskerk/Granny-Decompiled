using System;
using UnityEngine;

[Serializable]
public class placePlankaHole : MonoBehaviour
{
	public GameObject handHolder;

	public virtual void Update()
	{
		if (Input.GetKeyDown(KeyCode.F))
		{
			((PickUp)handHolder.GetComponent(typeof(PickUp))).placeObject = true;
		}
	}
}

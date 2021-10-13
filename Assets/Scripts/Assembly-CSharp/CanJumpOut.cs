using System;
using UnityEngine;

[Serializable]
public class CanJumpOut : MonoBehaviour
{
	public GameObject player;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			((openDoors)player.GetComponent(typeof(openDoors))).canJumpOut = true;
		}
	}

	public virtual void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			((openDoors)player.GetComponent(typeof(openDoors))).canJumpOut = false;
		}
	}
}

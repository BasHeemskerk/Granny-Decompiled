using System;
using UnityEngine;

[Serializable]
public class playerResetFloor : MonoBehaviour
{
	public GameObject player;

	public Transform playerResetPos;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "resetfloor")
		{
			player.transform.position = playerResetPos.position;
		}
	}
}

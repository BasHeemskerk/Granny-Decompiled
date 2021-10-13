using System;
using UnityEngine;

[Serializable]
public class teddyFalls : MonoBehaviour
{
	public Transform objectResetPos;

	public GameObject ParentObject;

	public Transform player;

	public virtual void Start()
	{
		objectResetPos = GameObject.Find("ObjectResetPoint").transform;
		if ((bool)GameObject.Find("Player"))
		{
			player = GameObject.Find("Player").transform;
			Physics.IgnoreCollision(ParentObject.GetComponent<Collider>(), player.GetComponent<CharacterController>(), true);
		}
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			Physics.IgnoreCollision(ParentObject.GetComponent<Collider>(), other.GetComponent<CharacterController>(), true);
		}
		else if (other.gameObject.tag == "resetfloor")
		{
			ParentObject.transform.position = objectResetPos.position;
		}
	}
}

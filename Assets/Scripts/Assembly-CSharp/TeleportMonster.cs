using System;
using UnityEngine;

[Serializable]
public class TeleportMonster : MonoBehaviour
{
	public GameObject monster;

	public Transform teleportPoint;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player" && !((AIfollow)monster.GetComponent(typeof(AIfollow))).seePlayer)
		{
			monster.SetActive(false);
			monster.transform.position = teleportPoint.position;
			monster.SetActive(true);
		}
	}
}

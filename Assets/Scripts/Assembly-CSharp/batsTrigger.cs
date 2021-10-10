using System;
using UnityEngine;

[Serializable]
public class batsTrigger : MonoBehaviour
{
	public GameObject NOS;

	public GameObject nextTrigger;

	public GameObject bats;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			((AIfollow)NOS.GetComponent(typeof(AIfollow))).seePlayer = true;
			((AIfollow)NOS.GetComponent(typeof(AIfollow))).FollowPlayer = true;
			bats.SetActive(true);
			nextTrigger.SetActive(true);
			base.gameObject.SetActive(false);
		}
	}
}

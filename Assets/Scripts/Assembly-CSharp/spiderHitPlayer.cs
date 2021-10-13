using System;
using UnityEngine;

[Serializable]
public class spiderHitPlayer : MonoBehaviour
{
	public GameObject Spider;

	public GameObject Player;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			((spiderControll)Spider.GetComponent(typeof(spiderControll))).huntPlayer = false;
			((spiderControll)Spider.GetComponent(typeof(spiderControll))).playerDead();
			((playerCaught)Player.GetComponent(typeof(playerCaught))).spiderBitePlayer = true;
		}
	}
}

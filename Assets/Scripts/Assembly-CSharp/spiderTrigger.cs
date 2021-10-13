using System;
using UnityEngine;

[Serializable]
public class spiderTrigger : MonoBehaviour
{
	public GameObject Spider;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
	}

	public virtual void OnTriggerStay(Collider other)
	{
		if (other.gameObject.tag == "Player" && !((spiderControll)Spider.GetComponent(typeof(spiderControll))).SpiderBitePlayer)
		{
			((spiderControll)Spider.GetComponent(typeof(spiderControll))).huntPlayer = true;
		}
	}
}

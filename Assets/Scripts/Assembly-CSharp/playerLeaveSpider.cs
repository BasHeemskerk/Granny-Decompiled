using System;
using UnityEngine;

[Serializable]
public class playerLeaveSpider : MonoBehaviour
{
	public GameObject Spider;

	public GameObject SpiderTrigger1;

	public GameObject SpiderTrigger2;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player" && !((spiderControll)Spider.GetComponent(typeof(spiderControll))).SpiderBitePlayer && !((spiderControll)Spider.GetComponent(typeof(spiderControll))).spiderInNest)
		{
			((spiderControll)Spider.GetComponent(typeof(spiderControll))).huntPlayer = false;
			((spiderControll)Spider.GetComponent(typeof(spiderControll))).spiderResetNow = true;
			SpiderTrigger1.SetActive(true);
			SpiderTrigger2.SetActive(false);
		}
	}
}

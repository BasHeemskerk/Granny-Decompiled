using System;
using UnityEngine;

[Serializable]
public class resetSpider : MonoBehaviour
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
		if (other.gameObject.tag == "Spider")
		{
			((spiderControll)Spider.GetComponent(typeof(spiderControll))).spiderInNest = true;
			((spiderControll)Spider.GetComponent(typeof(spiderControll))).spiderResetNow = false;
			((spiderControll)Spider.GetComponent(typeof(spiderControll))).foodTime = false;
			((spiderControll)Spider.GetComponent(typeof(spiderControll))).idle();
			SpiderTrigger1.SetActive(true);
			SpiderTrigger2.SetActive(false);
		}
	}
}

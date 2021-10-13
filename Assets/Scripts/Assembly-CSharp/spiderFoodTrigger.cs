using System;
using UnityEngine;

[Serializable]
public class spiderFoodTrigger : MonoBehaviour
{
	public GameObject Spider;

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
			((spiderControll)Spider.GetComponent(typeof(spiderControll))).foodTime = false;
			((spiderControll)Spider.GetComponent(typeof(spiderControll))).idle();
			((spiderControll)Spider.GetComponent(typeof(spiderControll))).spiderStartEat = true;
		}
	}
}

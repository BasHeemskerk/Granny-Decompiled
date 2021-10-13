using System;
using UnityEngine;

[Serializable]
public class shootSpiderButton : MonoBehaviour
{
	public bool buttonShot;

	public GameObject luckaAnim;

	public GameObject spider;

	public GameObject spiderTrigger1;

	public GameObject spiderTrigger2;

	public GameObject leaveTrigger;

	public GameObject shootbutton;

	public GameObject foodPos;

	public GameObject spiderNestpos;

	public AudioClip luckaFaller;

	public virtual void Start()
	{
	}

	public virtual void closeSpiderlucka()
	{
		if (buttonShot)
		{
			return;
		}
		if (!((spiderControll)spider.GetComponent(typeof(spiderControll))).spiderInNest)
		{
			if (!((spiderControll)spider.GetComponent(typeof(spiderControll))).SpiderBitePlayer)
			{
				((spiderControll)spider.GetComponent(typeof(spiderControll))).huntPlayer = true;
				((spiderControll)spider.GetComponent(typeof(spiderControll))).foodTime = false;
				spiderTrigger1.SetActive(false);
				spiderTrigger2.SetActive(false);
				leaveTrigger.SetActive(false);
			}
		}
		else
		{
			buttonShot = true;
			luckaAnim.GetComponent<Animation>().Play("SpiderLuckaClose");
			luckaAnim.GetComponent<AudioSource>().PlayOneShot(luckaFaller);
			spider.SetActive(false);
			spiderTrigger1.SetActive(false);
			spiderTrigger2.SetActive(false);
			leaveTrigger.SetActive(false);
			foodPos.SetActive(false);
			spiderNestpos.SetActive(false);
			shootbutton.SetActive(false);
		}
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (buttonShot || !(other.gameObject.tag == "arrow"))
		{
			return;
		}
		if (!((spiderControll)spider.GetComponent(typeof(spiderControll))).spiderInNest)
		{
			if (!((spiderControll)spider.GetComponent(typeof(spiderControll))).SpiderBitePlayer)
			{
				((spiderControll)spider.GetComponent(typeof(spiderControll))).huntPlayer = true;
				((spiderControll)spider.GetComponent(typeof(spiderControll))).foodTime = false;
				spiderTrigger1.SetActive(false);
				spiderTrigger2.SetActive(false);
				leaveTrigger.SetActive(false);
			}
		}
		else
		{
			buttonShot = true;
			luckaAnim.GetComponent<Animation>().Play("SpiderLuckaClose");
			luckaAnim.GetComponent<AudioSource>().PlayOneShot(luckaFaller);
			spider.SetActive(false);
			spiderTrigger1.SetActive(false);
			spiderTrigger2.SetActive(false);
			leaveTrigger.SetActive(false);
			foodPos.SetActive(false);
			spiderNestpos.SetActive(false);
			shootbutton.SetActive(false);
		}
	}
}

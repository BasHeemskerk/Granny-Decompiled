using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class giljotinTrigger : MonoBehaviour
{
	public GameObject melon;

	public GameObject deladMelon;

	public GameObject Granny;

	public Transform spawnObject;

	public GameObject ParentObject;

	public AudioClip ObjectLjud;

	public bool touchGround;

	public bool meloninPlace;

	public GameObject spak;

	public GameObject keyShow;

	public virtual void Start()
	{
	}

	public virtual IEnumerator OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "giljotinklinga")
		{
			spak.gameObject.tag = "Untagged";
			if (meloninPlace)
			{
				melon.SetActive(false);
				deladMelon.SetActive(true);
				keyShow.SetActive(true);
				meloninPlace = false;
				GetComponent<AudioSource>().PlayOneShot(ObjectLjud);
			}
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).timerSearch = 0f;
			if ((bool)GameObject.Find("TempNavObjects(Clone)"))
			{
				GameObject.Find("TempNavObjects(Clone)").transform.name = "TempNavObjects(Clone)Old";
				UnityEngine.Object.Instantiate(spawnObject, base.transform.position, base.transform.rotation);
				yield return new WaitForSeconds(0.5f);
				UnityEngine.Object.Destroy(GameObject.Find("TempNavObjects(Clone)Old"));
			}
			else if ((bool)GameObject.Find("TempNavObjects(Clone)Old"))
			{
				UnityEngine.Object.Destroy(GameObject.Find("TempNavObjects(Clone)Old"));
			}
			else
			{
				UnityEngine.Object.Instantiate(spawnObject, base.transform.position, base.transform.rotation);
				GetComponent<AudioSource>().PlayOneShot(ObjectLjud);
			}
			StartCoroutine(giljoTimer());
		}
	}

	public virtual IEnumerator giljoTimer()
	{
		yield return new WaitForSeconds(1.6f);
		spak.gameObject.tag = "giljotinspak";
	}
}

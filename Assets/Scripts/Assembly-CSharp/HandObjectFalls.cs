using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class HandObjectFalls : MonoBehaviour
{
	public GameObject Granny;

	public Transform spawnObject;

	public GameObject ParentObject;

	public AudioClip ObjectLjud;

	public Transform objectResetPos;

	public virtual void Start()
	{
		Granny = GameObject.Find("GrannyParent");
		objectResetPos = GameObject.Find("ObjectResetPoint").transform;
	}

	public virtual IEnumerator OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "golv")
		{
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).resetSafeTimer = false;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).timerSearch = 0f;
			if ((bool)GameObject.Find("TempNavObjects(Clone)"))
			{
				GameObject.Find("TempNavObjects(Clone)").transform.name = "TempNavObjects(Clone)Old";
				UnityEngine.Object.Instantiate(spawnObject, base.transform.position, base.transform.rotation);
				GetComponent<AudioSource>().PlayOneShot(ObjectLjud);
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
		}
		else if (other.gameObject.tag == "Player")
		{
			Physics.IgnoreCollision(ParentObject.GetComponent<Collider>(), other.GetComponent<CharacterController>(), true);
		}
		else if (other.gameObject.tag == "resetfloor")
		{
			ParentObject.transform.position = objectResetPos.position;
		}
	}
}

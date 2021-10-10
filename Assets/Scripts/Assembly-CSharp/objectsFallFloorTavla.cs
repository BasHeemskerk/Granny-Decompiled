using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class objectsFallFloorTavla : MonoBehaviour
{
	public GameObject Granny;

	public Transform spawnObject;

	public GameObject ParentObject;

	public AudioClip[] ObjectLjud;

	public bool notMore;

	public virtual void Start()
	{
		Granny = GameObject.Find("GrannyParent");
	}

	public virtual IEnumerator OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "golv")
		{
			int random = UnityEngine.Random.Range(0, ObjectLjud.Length);
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).resetSafeTimer = false;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).timerSearch = 0f;
			if ((bool)GameObject.Find("TempNavObjects(Clone)"))
			{
				GameObject.Find("TempNavObjects(Clone)").transform.name = "TempNavObjects(Clone)Old";
				UnityEngine.Object.Instantiate(spawnObject, base.transform.position, base.transform.rotation);
				GetComponent<AudioSource>().PlayOneShot(ObjectLjud[random]);
				yield return new WaitForSeconds(0.5f);
				UnityEngine.Object.Destroy(GameObject.Find("TempNavObjects(Clone)Old"));
			}
			else if ((bool)GameObject.Find("TempNavObjects(Clone)Old"))
			{
				UnityEngine.Object.Destroy(GameObject.Find("TempNavObjects(Clone)Old"));
				GetComponent<AudioSource>().PlayOneShot(ObjectLjud[random]);
			}
			else
			{
				UnityEngine.Object.Instantiate(spawnObject, base.transform.position, base.transform.rotation);
				GetComponent<AudioSource>().PlayOneShot(ObjectLjud[random]);
			}
			yield return new WaitForSeconds(6f);
			((Collider)ParentObject.GetComponent(typeof(Collider))).enabled = false;
			((Rigidbody)ParentObject.GetComponent(typeof(Rigidbody))).isKinematic = true;
			nameIt();
		}
	}

	public virtual void nameIt()
	{
		if (!notMore)
		{
			notMore = true;
			ParentObject.transform.name = ParentObject.transform.name + "(Clone)";
		}
	}
}

using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class ObjectFallFloorDestroys : MonoBehaviour
{
	public GameObject Granny;

	public Transform spawnObject;

	public GameObject ParentObject;

	public AudioClip ObjectLjud;

	public bool touchGround;

	public virtual void Start()
	{
		Granny = GameObject.Find("GrannyParent");
	}

	public virtual IEnumerator OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "golv" && !touchGround)
		{
			touchGround = true;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
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
				UnityEngine.Object.Instantiate(spawnObject, base.transform.position, base.transform.rotation);
				GetComponent<AudioSource>().PlayOneShot(ObjectLjud);
			}
			else
			{
				UnityEngine.Object.Instantiate(spawnObject, base.transform.position, base.transform.rotation);
				GetComponent<AudioSource>().PlayOneShot(ObjectLjud);
			}
			((Collider)base.gameObject.GetComponent(typeof(Collider))).enabled = false;
			yield return new WaitForSeconds(3f);
			((Collider)ParentObject.GetComponent(typeof(Collider))).enabled = false;
			((Rigidbody)ParentObject.GetComponent(typeof(Rigidbody))).isKinematic = true;
			ParentObject.transform.name = ParentObject.transform.name + "(Clone)";
			yield return new WaitForSeconds(10f);
			UnityEngine.Object.Destroy(ParentObject);
		}
	}
}

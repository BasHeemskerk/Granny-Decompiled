using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class noiceObjectFalls : MonoBehaviour
{
	public GameObject Granny;

	public Transform spawnObject;

	public virtual void Start()
	{
		Granny = GameObject.Find("GrannyParent");
	}

	public virtual IEnumerator OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "golv" || other.gameObject.tag == "grus")
		{
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
			}
			((Rigidbody)base.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = true;
			StartCoroutine(destroy());
		}
	}

	public virtual IEnumerator destroy()
	{
		yield return new WaitForSeconds(5f);
		UnityEngine.Object.Destroy(base.gameObject);
	}
}

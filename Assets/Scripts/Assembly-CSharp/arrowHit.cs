using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class arrowHit : MonoBehaviour
{
	public bool timer;

	public bool noMoreHit;

	public float depth;

	public GameObject Granny;

	public Transform arrow;

	public virtual IEnumerator Start()
	{
		yield return new WaitForSeconds(2f);
		timer = true;
	}

	public virtual void Update()
	{
		Granny = GameObject.Find("GrannyParent");
	}

	public virtual IEnumerator OnTriggerEnter(Collider other)
	{
		if (!timer && other.gameObject.tag == "granny" && !noMoreHit)
		{
			noMoreHit = true;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).hitByArrow = true;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).spiderIsDead = false;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
			((Rigidbody)base.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = true;
			base.transform.Translate(depth * Vector3.forward);
			base.transform.rotation = Quaternion.LookRotation(Vector3.right);
			UnityEngine.Object.Destroy(base.gameObject.GetComponent<Collider>());
			base.transform.parent = other.transform;
			((arrowHit)base.gameObject.GetComponent(typeof(arrowHit))).enabled = false;
			yield return new WaitForSeconds(2f);
			UnityEngine.Object.Instantiate(arrow, base.transform.position, base.transform.rotation);
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}

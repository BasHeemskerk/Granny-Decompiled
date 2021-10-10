using System;
using UnityEngine;

[Serializable]
public class carHitGranny : MonoBehaviour
{
	public bool noMoreHit;

	public GameObject Granny;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		Granny = GameObject.Find("GrannyParent");
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "granny" && !noMoreHit)
		{
			noMoreHit = true;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).hitByCar = true;
		}
	}
}

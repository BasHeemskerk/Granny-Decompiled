using System;
using UnityEngine;

[Serializable]
public class plankaHitSpot : MonoBehaviour
{
	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			Physics.IgnoreCollision(GetComponent<Collider>(), other.GetComponent<Collider>(), true);
		}
		else
		{
			Physics.IgnoreCollision(GetComponent<Collider>(), other.GetComponent<Collider>(), false);
		}
	}
}

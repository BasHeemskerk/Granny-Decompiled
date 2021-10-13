using System;
using UnityEngine;

[Serializable]
public class rivNerTavla : MonoBehaviour
{
	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			((Rigidbody)base.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
		}
		else if (other.gameObject.tag == "arrow")
		{
			((Rigidbody)base.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
		}
	}
}

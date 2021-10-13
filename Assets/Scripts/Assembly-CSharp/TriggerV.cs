using System;
using UnityEngine;

[Serializable]
public class TriggerV : MonoBehaviour
{
	public GameObject plattaV;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "platta")
		{
			((plattaflyttas)plattaV.GetComponent(typeof(plattaflyttas))).V = false;
		}
	}

	public virtual void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "platta")
		{
			((plattaflyttas)plattaV.GetComponent(typeof(plattaflyttas))).V = true;
		}
	}
}

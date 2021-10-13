using System;
using UnityEngine;

[Serializable]
public class TriggerN : MonoBehaviour
{
	public GameObject plattaN;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "platta")
		{
			((plattaflyttas)plattaN.GetComponent(typeof(plattaflyttas))).Ner = false;
		}
	}

	public virtual void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "platta")
		{
			((plattaflyttas)plattaN.GetComponent(typeof(plattaflyttas))).Ner = true;
		}
	}
}

using System;
using UnityEngine;

[Serializable]
public class TriggerH : MonoBehaviour
{
	public GameObject plattaH;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "platta")
		{
			((plattaflyttas)plattaH.GetComponent(typeof(plattaflyttas))).H = false;
		}
	}

	public virtual void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "platta")
		{
			((plattaflyttas)plattaH.GetComponent(typeof(plattaflyttas))).H = true;
		}
	}
}

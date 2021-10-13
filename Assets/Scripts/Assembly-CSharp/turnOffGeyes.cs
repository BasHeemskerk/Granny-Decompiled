using System;
using UnityEngine;

[Serializable]
public class turnOffGeyes : MonoBehaviour
{
	public bool Onvinden;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			Onvinden = true;
		}
	}

	public virtual void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			Onvinden = false;
		}
	}
}

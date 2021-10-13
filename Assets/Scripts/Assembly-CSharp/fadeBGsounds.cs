using System;
using UnityEngine;

[Serializable]
public class fadeBGsounds : MonoBehaviour
{
	public GameObject Sound1;

	public GameObject Sound2;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			((backgroundSound)Sound1.GetComponent(typeof(backgroundSound))).fadeDown = true;
			((backgroundSound)Sound2.GetComponent(typeof(backgroundSound))).fadeUp = true;
		}
	}
}

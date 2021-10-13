using System;
using UnityEngine;

[Serializable]
public class TriggerBastuOff : MonoBehaviour
{
	public GameObject bastuSteam;

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			bastuSteam.SetActive(false);
		}
	}
}

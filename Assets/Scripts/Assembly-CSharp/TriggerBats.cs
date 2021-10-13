using System;
using UnityEngine;

[Serializable]
public class TriggerBats : MonoBehaviour
{
	public GameObject bats;

	public GameObject triggerHolder;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "floor")
		{
			bats.SetActive(true);
			UnityEngine.Object.Destroy(triggerHolder);
		}
	}
}

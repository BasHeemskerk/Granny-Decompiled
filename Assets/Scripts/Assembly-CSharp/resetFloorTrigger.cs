using System;
using UnityEngine;

[Serializable]
public class resetFloorTrigger : MonoBehaviour
{
	public GameObject bats;

	public GameObject triggerHolder;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			bats.SetActive(true);
			UnityEngine.Object.Destroy(triggerHolder);
		}
	}
}

using System;
using UnityEngine;

[Serializable]
public class openSecretDoorTrigger : MonoBehaviour
{
	public GameObject door;

	public GameObject doorljud;

	public GameObject doorTrigger;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			door.gameObject.GetComponent<Animation>().Play("SecretDoorOpen");
			doorljud.SetActive(true);
			UnityEngine.Object.Destroy(doorTrigger);
		}
	}
}

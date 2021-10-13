using System;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

[Serializable]
public class hideCrouchButton : MonoBehaviour
{
	public GameObject player;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).playerInhole = true;
		}
	}

	public virtual void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).playerInhole = false;
		}
	}
}

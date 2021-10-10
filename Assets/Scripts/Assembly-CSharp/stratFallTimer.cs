using System;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

[Serializable]
public class stratFallTimer : MonoBehaviour
{
	public GameObject player;

	public GameObject Sound1;

	public GameObject Sound2;

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).fallTimerStarted = true;
			((backgroundSound)Sound1.GetComponent(typeof(backgroundSound))).fadeDown = true;
			((backgroundSound)Sound2.GetComponent(typeof(backgroundSound))).fadeUp = true;
		}
	}
}

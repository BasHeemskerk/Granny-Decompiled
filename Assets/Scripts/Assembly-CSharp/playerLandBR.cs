using System;
using UnityEngine;

[Serializable]
public class playerLandBR : MonoBehaviour
{
	public GameObject soundHolder;

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).playerLandBRSound();
			base.gameObject.SetActive(false);
		}
	}
}

using System;
using UnityEngine;

[Serializable]
public class triggerFallFloor : MonoBehaviour
{
	public GameObject bit1;

	public GameObject bit2;

	public GameObject bit3;

	public GameObject bit4;

	public GameObject soundHolder;

	public GameObject placePlankTrigger;

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			((Rigidbody)bit1.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
			((Rigidbody)bit2.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
			((Rigidbody)bit3.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
			((Rigidbody)bit4.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
			((placePlanka)placePlankTrigger.GetComponent(typeof(placePlanka))).holeOpen = true;
			((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).playerFallFloor();
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}

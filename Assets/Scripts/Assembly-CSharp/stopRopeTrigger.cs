using System;
using UnityEngine;

[Serializable]
public class stopRopeTrigger : MonoBehaviour
{
	public GameObject vevaHolder;

	public GameObject vev;

	public GameObject vevButton;

	public GameObject brunnsLjud;

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "stoprope")
		{
			((playerVevar)vevaHolder.GetComponent(typeof(playerVevar))).noMoreVev = true;
			((playerVevar)vevaHolder.GetComponent(typeof(playerVevar))).playerHoldButton = false;
			vev.gameObject.tag = "Untagged";
			vevButton.SetActive(false);
			((vevarBrunnLjud)brunnsLjud.GetComponent(typeof(vevarBrunnLjud))).PlayerVevar = false;
		}
	}
}

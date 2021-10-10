using System;
using UnityEngine;

[Serializable]
public class triggerCloseGarderobdoor : MonoBehaviour
{
	public GameObject doorV;

	public GameObject doorH;

	public bool playerInLocker;

	public GameObject doorButton;

	public GameObject nos;

	public GameObject player;

	public AudioClip gardeDoorsClose;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			playerInLocker = true;
			doorButton.SetActive(true);
			doorV.GetComponent<Animation>().Play("VgarderobDoorClose");
			doorH.GetComponent<Animation>().Play("HgarderobDoorClose");
			((IfgarderobDoorOpens)doorV.GetComponent(typeof(IfgarderobDoorOpens))).doorsClosed = true;
			((IfHgarderobDoorOpens)doorH.GetComponent(typeof(IfHgarderobDoorOpens))).doorsClosed = true;
			((FPSControllerNEW)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 1f;
			((FPSControllerNEW)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 1f;
			((AIfollow)nos.GetComponent(typeof(AIfollow))).playerHiding = true;
			doorV.gameObject.tag = "garderobDoorV";
			doorH.gameObject.tag = "garderobDoorH";
			AudioSource.PlayClipAtPoint(gardeDoorsClose, base.transform.position);
		}
	}
}

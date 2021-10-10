using System;
using UnityEngine;

[Serializable]
public class IfHgarderobDoorOpens : MonoBehaviour
{
	public GameObject gardeDoorV;

	public GameObject doorButton;

	public GameObject nos;

	public GameObject doorV;

	public GameObject doorH;

	public bool doorsClosed;

	public GameObject player;

	public IfHgarderobDoorOpens()
	{
		doorsClosed = true;
	}

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (doorsClosed && GetComponent<Animation>().IsPlaying("HgarderobDoorOpen"))
		{
			gardeDoorV.GetComponent<Animation>().Play("VgarderobDoorOpen");
			doorsClosed = false;
			doorV.gameObject.tag = "Untagged";
			doorH.gameObject.tag = "Untagged";
			((AIfollow)nos.GetComponent(typeof(AIfollow))).playerHiding = false;
			((FPSControllerNEW)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 6f;
			((FPSControllerNEW)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 8f;
			doorButton.SetActive(false);
		}
	}
}

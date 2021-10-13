using System;
using UnityEngine;

[Serializable]
public class lockerdoorscript : MonoBehaviour
{
	public bool doorOpen;

	public virtual void Update()
	{
		if (!doorOpen && GetComponent<Animation>().IsPlaying("LockerDoorOpen"))
		{
			doorOpen = true;
			base.gameObject.tag = "Untagged";
		}
		if (doorOpen && GetComponent<Animation>().IsPlaying("LockerDoorClose"))
		{
			doorOpen = false;
		}
	}
}

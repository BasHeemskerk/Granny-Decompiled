using System;
using UnityEngine;

[Serializable]
public class pressOpenDoor : MonoBehaviour
{
	public GameObject doorScriptHolder;

	public virtual void Update()
	{
		Touch[] touches = Input.touches;
		for (int i = 0; i < touches.Length; i++)
		{
			Touch touch = touches[i];
			if (touch.phase == TouchPhase.Began && GetComponent<GUITexture>().HitTest(touch.position))
			{
				((openDoors)doorScriptHolder.GetComponent(typeof(openDoors))).openTheDoor = true;
				((openDoors)doorScriptHolder.GetComponent(typeof(openDoors))).playSound = false;
			}
		}
	}
}

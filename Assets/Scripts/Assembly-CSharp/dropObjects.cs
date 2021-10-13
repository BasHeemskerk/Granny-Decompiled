using System;
using UnityEngine;

[Serializable]
public class dropObjects : MonoBehaviour
{
	public GameObject handHolder;

	public virtual void Update()
	{
		Touch[] touches = Input.touches;
		for (int i = 0; i < touches.Length; i++)
		{
			Touch touch = touches[i];
			if (touch.phase == TouchPhase.Began && GetComponent<GUITexture>().HitTest(touch.position))
			{
				((PickUp)handHolder.GetComponent(typeof(PickUp))).dropObject = true;
			}
		}
	}
}

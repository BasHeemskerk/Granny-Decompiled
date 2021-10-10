using System;
using UnityEngine;

[Serializable]
public class shootArrowButton : MonoBehaviour
{
	public GameObject shootHolder;

	public virtual void Update()
	{
		Touch[] touches = Input.touches;
		for (int i = 0; i < touches.Length; i++)
		{
			Touch touch = touches[i];
			if (touch.phase == TouchPhase.Began && GetComponent<GUITexture>().HitTest(touch.position))
			{
				((ShootArrow)shootHolder.GetComponent(typeof(ShootArrow))).shooting = true;
			}
		}
	}
}

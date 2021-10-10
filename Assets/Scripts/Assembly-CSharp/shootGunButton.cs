using System;
using UnityEngine;

[Serializable]
public class shootGunButton : MonoBehaviour
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
				((shootGun)shootHolder.GetComponent(typeof(shootGun))).shooting = true;
			}
		}
	}
}

using System;
using UnityEngine;

[Serializable]
public class clickRemoveAdsButton : MonoBehaviour
{
	public GameObject ljudHolder;

	public virtual void Update()
	{
		Touch[] touches = Input.touches;
		for (int i = 0; i < touches.Length; i++)
		{
			Touch touch = touches[i];
			if (touch.phase == TouchPhase.Began && GetComponent<GUITexture>().HitTest(touch.position))
			{
				((ButtonClicks)ljudHolder.GetComponent(typeof(ButtonClicks))).clickButton();
			}
		}
	}
}

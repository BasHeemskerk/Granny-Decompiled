using System;
using UnityEngine;

[Serializable]
public class ClickMoregamesButton : MonoBehaviour
{
	public GameObject ljudHolder;

	public bool buttonPressed;

	public bool buttonsounds;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (Input.touchCount > 0)
		{
			Vector2 position = Input.GetTouch(0).position;
			if (GetComponent<GUITexture>().HitTest(position))
			{
				buttonPressed = true;
				base.transform.localPosition = new Vector3(-0.25f, -0.17f, 2f);
				if (!buttonsounds)
				{
					buttonsounds = true;
					((ButtonClicks)ljudHolder.GetComponent(typeof(ButtonClicks))).clickButton();
				}
			}
			else
			{
				base.transform.localPosition = new Vector3(-0.28f, -0.17f, 2f);
				buttonsounds = false;
				buttonPressed = false;
			}
		}
		else if (buttonPressed)
		{
			base.transform.localPosition = new Vector3(-0.28f, -0.17f, 2f);
			buttonPressed = false;
			buttonsounds = false;
			Application.OpenURL("http://play.google.com/store/apps/developer?id=DVloper");
		}
	}
}

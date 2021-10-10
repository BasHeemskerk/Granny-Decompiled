using System;
using UnityEngine;

[Serializable]
public class ClickOptionButton : MonoBehaviour
{
	public GameObject ljudHolder;

	private bool buttonPressed;

	private bool buttonsounds;

	public GameObject OptionsMenu;

	public GameObject MenuButtons;

	public GameObject noAdsButton;

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
				base.transform.localPosition = new Vector3(-0.25f, -0.04f, 2f);
				if (!buttonsounds)
				{
					buttonsounds = true;
					((ButtonClicks)ljudHolder.GetComponent(typeof(ButtonClicks))).clickButton();
				}
			}
			else
			{
				base.transform.localPosition = new Vector3(-0.28f, -0.04f, 2f);
				buttonPressed = false;
				buttonsounds = false;
			}
		}
		else if (buttonPressed)
		{
			base.transform.localPosition = new Vector3(-0.28f, -0.04f, 2f);
			buttonPressed = false;
			OptionsMenu.SetActive(true);
			MenuButtons.SetActive(false);
			if (PlayerPrefs.GetInt("ADSon") == 0)
			{
				noAdsButton.SetActive(true);
			}
		}
	}
}

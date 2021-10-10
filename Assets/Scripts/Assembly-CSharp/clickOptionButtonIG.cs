using System;
using UnityEngine;

[Serializable]
public class clickOptionButtonIG : MonoBehaviour
{
	public GameObject optionMenu;

	public GameObject optionButton;

	public GameObject joystick;

	public GameObject crouchButton;

	public GameObject bedButtons;

	public GameObject soundHolder;

	public GameObject carControls;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		Touch[] touches = Input.touches;
		for (int i = 0; i < touches.Length; i++)
		{
			Touch touch = touches[i];
			if (touch.phase == TouchPhase.Ended && GetComponent<GUITexture>().HitTest(touch.position))
			{
				Time.timeScale = 0f;
				optionMenu.SetActive(true);
				optionButton.SetActive(false);
				joystick.SetActive(false);
				crouchButton.SetActive(false);
				bedButtons.SetActive(false);
				carControls.SetActive(false);
				((backgroundSound)soundHolder.GetComponent(typeof(backgroundSound))).buttonClick();
			}
		}
	}
}

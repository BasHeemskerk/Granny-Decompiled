using System;
using UnityEngine;

[Serializable]
public class closeOptionMenuIG : MonoBehaviour
{
	public GameObject optionMenu;

	public GameObject optionButton;

	public GameObject joystick;

	public GameObject crouchButton;

	public GameObject bedButtons;

	public GameObject savedValue;

	public GameObject soundHolder;

	public GameObject carControls;

	public virtual void Start()
	{
		saveSensitivityData saveSensitivityData = (saveSensitivityData)savedValue.GetComponent(typeof(saveSensitivityData));
	}

	public virtual void Update()
	{
		Touch[] touches = Input.touches;
		for (int i = 0; i < touches.Length; i++)
		{
			Touch touch = touches[i];
			if (touch.phase == TouchPhase.Ended && GetComponent<GUITexture>().HitTest(touch.position))
			{
				saveSensitivityData saveSensitivityData = (saveSensitivityData)savedValue.GetComponent(typeof(saveSensitivityData));
				Time.timeScale = 1f;
				optionMenu.SetActive(false);
				optionButton.SetActive(true);
				joystick.SetActive(true);
				crouchButton.SetActive(true);
				bedButtons.SetActive(true);
				carControls.SetActive(true);
				PlayerPrefs.SetInt("slideData", (int)saveSensitivityData.sliderValue);
				((backgroundSound)soundHolder.GetComponent(typeof(backgroundSound))).buttonClick();
			}
		}
	}
}

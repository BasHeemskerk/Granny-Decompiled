using System;
using UnityEngine;

[Serializable]
public class backToMenu : MonoBehaviour
{
	public virtual void Start()
	{
		Time.timeScale = 1f;
		AudioListener.volume = 1f;
	}

	public virtual void Update()
	{
	}
}
[Serializable]
public class BackToMenu : MonoBehaviour
{
	public GameObject savedValue;

	public GameObject soundHolder;

	public GameObject gameController;

	public bool buttonClicked;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		Touch[] touches = Input.touches;
		for (int i = 0; i < touches.Length; i++)
		{
			Touch touch = touches[i];
			if (touch.phase == TouchPhase.Ended && GetComponent<GUITexture>().HitTest(touch.position) && !buttonClicked)
			{
				buttonClicked = true;
				saveSensitivityData saveSensitivityData = (saveSensitivityData)savedValue.GetComponent(typeof(saveSensitivityData));
				PlayerPrefs.SetInt("slideData", (int)saveSensitivityData.sliderValue);
				((backgroundSound)soundHolder.GetComponent(typeof(backgroundSound))).buttonClick();
				((FetchAds)gameController.GetComponent(typeof(FetchAds))).toMainMenu();
				PlayerPrefs.SetInt("teddyInPlace", 0);
			}
		}
	}
}

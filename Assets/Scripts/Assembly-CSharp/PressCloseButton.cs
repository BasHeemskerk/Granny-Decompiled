using System;
using UnityEngine;

[Serializable]
public class PressCloseButton : MonoBehaviour
{
	public GameObject HelpMenu;

	public GameObject playButton;

	public GameObject quitButton;

	public GameObject helpButton;

	public GameObject ljudHolder;

	public GameObject moreGamesButton;

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
				((soundEffectsMenu)ljudHolder.GetComponent(typeof(soundEffectsMenu))).buttonClick();
				HelpMenu.SetActive(false);
				playButton.SetActive(true);
			}
		}
	}
}

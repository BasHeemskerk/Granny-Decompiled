using System;
using UnityEngine;

[Serializable]
public class pressBackButtonHelpmenu : MonoBehaviour
{
	public GameObject HelpMenu;

	public GameObject playButton;

	public GameObject quitButton;

	public GameObject helpButton;

	public GameObject ljudHolder;

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
				quitButton.SetActive(true);
				helpButton.SetActive(true);
			}
		}
	}
}

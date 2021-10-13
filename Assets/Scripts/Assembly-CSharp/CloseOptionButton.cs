using System;
using UnityEngine;

[Serializable]
public class CloseOptionButton : MonoBehaviour
{
	public GameObject optionMenu;

	public GameObject joystick;

	public GameObject joystickRing;

	public GameObject mapButton;

	public GameObject swordButton;

	public GameObject allapapperslappar;

	public GameObject pianoCollider;

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
				optionMenu.SetActive(false);
				joystick.SetActive(true);
				joystickRing.SetActive(true);
				mapButton.SetActive(true);
				swordButton.SetActive(true);
				allapapperslappar.SetActive(true);
				pianoCollider.SetActive(true);
				Time.timeScale = 1f;
			}
		}
	}
}

using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[Serializable]
public class ClickContinueButton : MonoBehaviour
{
	public GameObject LoadingScreen;

	public GameObject allButtons;

	public GameObject ljudHolder;

	public GameObject Optionbackground;

	private bool buttonPressed;

	private bool buttonsounds;

	public Button btn1;

	public virtual void Start()
	{
		btn1.onClick.AddListener(TaskOnClick);
	}

	private void TaskOnClick()
	{
		if (!buttonPressed)
		{
			buttonPressed = true;
			SceneManager.LoadScene("ForestScene");
			LoadingScreen.SetActive(true);
			allButtons.SetActive(false);
			Optionbackground.SetActive(false);
			((ButtonClicks)ljudHolder.GetComponent(typeof(ButtonClicks))).clickButton();
			Cursor.visible = false;
		}
	}
}

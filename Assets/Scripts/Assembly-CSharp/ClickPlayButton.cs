using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class ClickPlayButton : MonoBehaviour
{
	public GameObject animHolder;

	public GameObject allButtons;

	public GameObject ljudHolder;

	public GameObject OptionButtons;

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
			animHolder.GetComponent<Animation>().Play("camAnimOptions");
			buttonPressed = true;
			allButtons.SetActive(false);
			((ButtonClicks)ljudHolder.GetComponent(typeof(ButtonClicks))).clickButton();
			StartCoroutine("optionMenu");
		}
	}

	private IEnumerator optionMenu()
	{
		yield return new WaitForSeconds(1.7f);
		OptionButtons.SetActive(true);
	}
}

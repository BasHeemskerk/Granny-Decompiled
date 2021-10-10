using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class clickQuitButton : MonoBehaviour
{
	public GameObject ljudHolder;

	public bool buttonPressed;

	public bool buttonsounds;

	public Button btn1;

	public virtual void Start()
	{
		btn1.onClick.AddListener(TaskOnClick);
	}

	private void TaskOnClick()
	{
		base.transform.localPosition = new Vector3(-0.28f, -0.3f, 2f);
		Application.Quit();
	}
}

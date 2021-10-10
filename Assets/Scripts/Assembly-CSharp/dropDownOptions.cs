using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class dropDownOptions : MonoBehaviour
{
	public bool easyModeOn;

	public bool normalModeOn;

	public bool hardModeOn;

	public bool extremeModeOn;

	public bool practiseModeOn;

	public Dropdown dropdownOptions;

	public virtual void Start()
	{
		Time.timeScale = 1f;
		Cursor.visible = true;
		Screen.lockCursor = false;
		if (PlayerPrefs.GetInt("DiffData") == 0)
		{
			dropdownOptions.value = 2;
		}
		else if (PlayerPrefs.GetInt("DiffData") == 1)
		{
			dropdownOptions.value = 3;
		}
		else if (PlayerPrefs.GetInt("DiffData") == 2)
		{
			dropdownOptions.value = 1;
		}
		else if (PlayerPrefs.GetInt("DiffData") == 3)
		{
			dropdownOptions.value = 0;
		}
		else if (PlayerPrefs.GetInt("DiffData") == 4)
		{
			dropdownOptions.value = 4;
		}
	}

	public virtual void diffOptions()
	{
		if (dropdownOptions.value == 2)
		{
			normalModeOn = true;
			easyModeOn = false;
			hardModeOn = false;
			extremeModeOn = false;
			practiseModeOn = false;
			PlayerPrefs.SetInt("DiffData", 0);
			PlayerPrefs.SetInt("fogOnExtreme", 0);
		}
		else if (dropdownOptions.value == 3)
		{
			easyModeOn = true;
			normalModeOn = false;
			hardModeOn = false;
			extremeModeOn = false;
			practiseModeOn = false;
			PlayerPrefs.SetInt("DiffData", 1);
			PlayerPrefs.SetInt("fogOnExtreme", 0);
		}
		else if (dropdownOptions.value == 1)
		{
			hardModeOn = true;
			normalModeOn = false;
			easyModeOn = false;
			extremeModeOn = false;
			practiseModeOn = false;
			PlayerPrefs.SetInt("DiffData", 2);
			PlayerPrefs.SetInt("fogOnExtreme", 0);
		}
		else if (dropdownOptions.value == 0)
		{
			extremeModeOn = true;
			hardModeOn = false;
			normalModeOn = false;
			easyModeOn = false;
			practiseModeOn = false;
			PlayerPrefs.SetInt("DiffData", 3);
			PlayerPrefs.SetInt("fogOnExtreme", 1);
		}
		else if (dropdownOptions.value == 4)
		{
			practiseModeOn = true;
			hardModeOn = false;
			normalModeOn = false;
			easyModeOn = false;
			extremeModeOn = false;
			PlayerPrefs.SetInt("DiffData", 4);
			PlayerPrefs.SetInt("fogOnExtreme", 0);
		}
	}
}

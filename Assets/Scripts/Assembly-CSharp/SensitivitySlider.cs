using System;
using UnityEngine;

[Serializable]
public class SensitivitySlider : MonoBehaviour
{
	public float hSliderValue;

	public GUIStyle style;

	public GUIStyle style1;

	private Rect defaultRect;

	private GUITexture gui;

	public saveSensitivityData scriptC;

	public GameObject savedValue;

	public virtual void Start()
	{
		saveSensitivityData saveSensitivityData = (saveSensitivityData)savedValue.GetComponent(typeof(saveSensitivityData));
		if (PlayerPrefs.GetInt("slideData") == 0)
		{
			PlayerPrefs.SetInt("slideData", 150);
			hSliderValue = 150f;
		}
		else
		{
			hSliderValue = PlayerPrefs.GetInt("slideData");
		}
	}

	public virtual void Update()
	{
		saveSensitivityData saveSensitivityData = (saveSensitivityData)savedValue.GetComponent(typeof(saveSensitivityData));
		saveSensitivityData.sliderValue = hSliderValue;
	}

	public virtual void OnGUI()
	{
		int width = Screen.width;
		int height = Screen.height;
		GUI.skin.horizontalSlider = style;
		GUI.skin.horizontalSliderThumb = style1;
		hSliderValue = GUI.HorizontalSlider(new Rect((float)(width / 2) * 0.69f, height / 2, (float)(width / 2) * 0.607329845f, (float)(height / 2) * (17f / 166f)), hSliderValue, 10f, 600f);
		GUI.skin.horizontalSliderThumb.fixedWidth = (float)(width / 2) * 0.06f;
	}
}

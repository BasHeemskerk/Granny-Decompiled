using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resolution : MonoBehaviour
{
	public Dropdown resolutionDropdown;

	private Resolution[] resolutions;

	private void Start()
	{
		resolutions = Screen.resolutions;
		resolutionDropdown.ClearOptions();
		List<string> list = new List<string>();
		for (int i = 0; i < resolutions.Length; i++)
		{
			string item = resolutions[i].width + " x " + resolutions[i].height;
			list.Add(item);
		}
		resolutionDropdown.AddOptions(list);
	}

	private void Update()
	{
	}
}

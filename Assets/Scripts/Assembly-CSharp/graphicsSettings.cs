using UnityEngine;
using UnityEngine.UI;

public class graphicsSettings : MonoBehaviour
{
	public Dropdown dropdownOptions;

	public virtual void Start()
	{
		if (PlayerPrefs.GetInt("graphSettings") == 0)
		{
			dropdownOptions.value = 0;
		}
		else if (PlayerPrefs.GetInt("graphSettings") == 1)
		{
			dropdownOptions.value = 1;
		}
		else if (PlayerPrefs.GetInt("graphSettings") == 2)
		{
			dropdownOptions.value = 2;
		}
	}

	public void SetQuality(int qualityindex)
	{
		QualitySettings.SetQualityLevel(qualityindex);
		switch (qualityindex)
		{
		case 0:
			PlayerPrefs.SetInt("graphSettings", 0);
			break;
		case 1:
			PlayerPrefs.SetInt("graphSettings", 1);
			break;
		case 2:
			PlayerPrefs.SetInt("graphSettings", 2);
			break;
		}
	}

	private void Update()
	{
	}
}

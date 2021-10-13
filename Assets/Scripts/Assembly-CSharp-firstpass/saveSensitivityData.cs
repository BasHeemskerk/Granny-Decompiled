using UnityEngine;

public class saveSensitivityData : MonoBehaviour
{
	public float sliderValue;

	private void Start()
	{
		Object.DontDestroyOnLoad(base.transform.gameObject);
		if (PlayerPrefs.GetInt("slideData") == 0)
		{
			sliderValue = 150f;
		}
		else
		{
			sliderValue = PlayerPrefs.GetInt("slideData");
		}
	}
}

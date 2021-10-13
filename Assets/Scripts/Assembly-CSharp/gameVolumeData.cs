using UnityEngine;

public class gameVolumeData : MonoBehaviour
{
	public float volumeNumber;

	private void Start()
	{
		volumeNumber = PlayerPrefs.GetFloat("GameVolume", 1f);
		Object.DontDestroyOnLoad(base.gameObject);
	}

	private void Update()
	{
		PlayerPrefs.SetFloat("GameVolume", volumeNumber);
		PlayerPrefs.Save();
	}
}

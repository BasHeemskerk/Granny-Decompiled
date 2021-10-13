using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class InGameVolume : MonoBehaviour
{
	public AudioMixer audioMixer;

	public Slider m_slider;

	private void Start()
	{
		m_slider.value = PlayerPrefs.GetFloat("GameVolume", 0f);
	}

	public void SetVolume(float volume)
	{
		audioMixer.SetFloat("Volume", volume);
		PlayerPrefs.SetFloat("GameVolume", m_slider.value);
	}
}

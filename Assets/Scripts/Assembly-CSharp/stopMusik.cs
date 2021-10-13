using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class stopMusik : MonoBehaviour
{
	private Toggle m_Toggle;

	public GameObject musicHolder;

	private void Start()
	{
		m_Toggle = GetComponent<Toggle>();
		m_Toggle.onValueChanged.AddListener(delegate
		{
			ToggleValueChanged(m_Toggle);
		});
		if (PlayerPrefs.GetInt("musikOnOff") == 0)
		{
			m_Toggle.GetComponent<Toggle>().isOn = true;
		}
		else if (PlayerPrefs.GetInt("musikOnOff") == 1)
		{
			m_Toggle.GetComponent<Toggle>().isOn = false;
		}
	}

	private void ToggleValueChanged(Toggle change)
	{
		if (m_Toggle.isOn)
		{
			PlayerPrefs.SetInt("musikOnOff", 0);
			musicHolder.GetComponent<AudioSource>().Play();
		}
		else
		{
			PlayerPrefs.SetInt("musikOnOff", 1);
			musicHolder.GetComponent<AudioSource>().Stop();
		}
	}
}

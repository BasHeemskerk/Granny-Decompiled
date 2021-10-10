using UnityEngine;
using UnityEngine.UI;

public class imageEffectOnOff : MonoBehaviour
{
	public bool effectOnOff;

	private Toggle m_Toggle;

	public virtual void Start()
	{
		m_Toggle = GetComponent<Toggle>();
		m_Toggle.onValueChanged.AddListener(delegate
		{
			ToggleValueChanged(m_Toggle);
		});
		if (PlayerPrefs.GetInt("EffectsOnOff") == 0)
		{
			m_Toggle.GetComponent<Toggle>().isOn = false;
		}
		else if (PlayerPrefs.GetInt("EffectsOnOff") == 1)
		{
			m_Toggle.GetComponent<Toggle>().isOn = true;
		}
	}

	private void ToggleValueChanged(Toggle change)
	{
		if (m_Toggle.isOn)
		{
			m_Toggle.GetComponent<Toggle>().isOn = true;
			PlayerPrefs.SetInt("EffectsOnOff", 1);
		}
		else
		{
			m_Toggle.GetComponent<Toggle>().isOn = false;
			PlayerPrefs.SetInt("EffectsOnOff", 0);
		}
	}
}

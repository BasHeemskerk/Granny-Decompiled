using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class mouseSensitivity : MonoBehaviour
{
	public GameObject Player;

	public Slider m_slider;

	private void Start()
	{
		if (PlayerPrefs.GetFloat("MouseSens") != 0f)
		{
			m_slider.value = PlayerPrefs.GetFloat("MouseSens", 0f);
		}
		else
		{
			m_slider.value = 2f;
		}
	}

	public void MouseSens(float mouse)
	{
		((FirstPersonController_Egen)Player.GetComponent(typeof(FirstPersonController_Egen))).mouseSens = m_slider.value;
		PlayerPrefs.SetFloat("MouseSens", m_slider.value);
	}
}

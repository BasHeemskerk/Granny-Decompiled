using UnityEngine;
using UnityEngine.UI;

public class fadeEndText : MonoBehaviour
{
	public Image theEndText;

	private bool m_Fading;

	private void Start()
	{
		m_Fading = true;
	}

	private void Update()
	{
		if (m_Fading)
		{
			theEndText.CrossFadeAlpha(1f, 5f, false);
		}
	}
}

using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class DiffEasyTextCheck : MonoBehaviour
{
	public GameObject diffEasyText;

	public GameObject diffHardText;

	public GameObject diffNormalText;

	public GameObject diffExtremeText;

	public GameObject diffPractiseText;

	public Toggle extraLockToggle;

	public virtual void Start()
	{
		if (PlayerPrefs.GetInt("fogOnExtreme") == 1)
		{
			extraLockToggle.isOn = true;
			extraLockToggle.interactable = false;
		}
		else
		{
			extraLockToggle.interactable = true;
		}
	}

	public virtual void Update()
	{
		if (PlayerPrefs.GetInt("DiffData") == 0)
		{
			diffNormalText.SetActive(true);
			diffEasyText.SetActive(false);
			diffHardText.SetActive(false);
			diffExtremeText.SetActive(false);
			diffPractiseText.SetActive(false);
			extraLockToggle.interactable = true;
		}
		else if (PlayerPrefs.GetInt("DiffData") == 1)
		{
			diffEasyText.SetActive(true);
			diffHardText.SetActive(false);
			diffNormalText.SetActive(false);
			diffExtremeText.SetActive(false);
			diffPractiseText.SetActive(false);
			extraLockToggle.interactable = true;
		}
		else if (PlayerPrefs.GetInt("DiffData") == 2)
		{
			diffHardText.SetActive(true);
			diffEasyText.SetActive(false);
			diffNormalText.SetActive(false);
			diffExtremeText.SetActive(false);
			diffPractiseText.SetActive(false);
			extraLockToggle.interactable = true;
		}
		else if (PlayerPrefs.GetInt("DiffData") == 3)
		{
			diffExtremeText.SetActive(true);
			diffHardText.SetActive(false);
			diffEasyText.SetActive(false);
			diffNormalText.SetActive(false);
			diffPractiseText.SetActive(false);
			extraLockToggle.isOn = true;
			extraLockToggle.interactable = false;
		}
		else if (PlayerPrefs.GetInt("DiffData") == 4)
		{
			diffPractiseText.SetActive(true);
			diffExtremeText.SetActive(false);
			diffHardText.SetActive(false);
			diffEasyText.SetActive(false);
			diffNormalText.SetActive(false);
			extraLockToggle.interactable = true;
		}
	}
}

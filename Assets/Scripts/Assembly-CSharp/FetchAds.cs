using System;
using UnityEngine;
using UnityEngine.SceneManagement;

[Serializable]
public class FetchAds : MonoBehaviour
{
	public GameObject optionMenu;

	public GameObject granny;

	public virtual void Start()
	{
	}

	public virtual void toMainMenu()
	{
		Time.timeScale = 1f;
		optionMenu.SetActive(false);
		granny.SetActive(false);
		readyToMainMenu();
	}

	public virtual void readyToMainMenu()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene("Menu");
	}
}

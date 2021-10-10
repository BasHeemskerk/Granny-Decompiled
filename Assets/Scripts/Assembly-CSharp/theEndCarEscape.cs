using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

[Serializable]
public class theEndCarEscape : MonoBehaviour
{
	public GameObject GameController;

	public GameObject theEndTextImage;

	public bool startFading;

	public bool m_Fading;

	public float time;

	public float time2;

	public virtual IEnumerator Start()
	{
		yield return new WaitForSeconds(time);
		theEndTextImage.SetActive(true);
		yield return new WaitForSeconds(time2);
		PlayerPrefs.SetInt("teddyInPlace", 0);
		SceneManager.LoadScene("Menu");
	}
}

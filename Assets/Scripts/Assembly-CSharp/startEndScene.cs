using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[Serializable]
public class startEndScene : MonoBehaviour
{
	public float fadeBlackSpeed;

	public Image blackScreen;

	public float fogEndDistance;

	public bool fog;

	public GameObject granny1;

	public GameObject granny1Anim;

	public GameObject granny2;

	public GameObject granny2Gone;

	public GameObject granny3Home;

	public GameObject GrannyGoneTeddy;

	public GameObject teddy;

	public GameObject cam1;

	public GameObject cam2;

	public GameObject grannyAnim;

	public GameObject soundEffects;

	public GameObject slendrinaTexture;

	public float fadeSpeed;

	public bool slendrinaFade;

	public GameObject theEndText1;

	public GameObject theEndText2;

	public virtual void Start()
	{
		if (PlayerPrefs.GetInt("teddyInPlace") == 1)
		{
			StartCoroutine(startTheEnd2());
		}
		else
		{
			StartCoroutine(startTheEnd1());
		}
	}

	public virtual void Update()
	{
		if (fog)
		{
			RenderSettings.fogEndDistance -= Time.deltaTime * 9f;
			if (RenderSettings.fogEndDistance <= 0f)
			{
				fog = false;
				RenderSettings.fogEndDistance = 0f;
			}
		}
		if (slendrinaFade)
		{
			float a = slendrinaTexture.GetComponent<Renderer>().material.color.a - 0.3f * Time.deltaTime * fadeSpeed;
			Color color = slendrinaTexture.GetComponent<Renderer>().material.color;
			color.a = a;
			slendrinaTexture.GetComponent<Renderer>().material.color = color;
		}
	}

	public virtual IEnumerator startTheEnd1()
	{
		if (PlayerPrefs.GetInt("DiffData") == 4)
		{
			granny1.SetActive(false);
			granny3Home.SetActive(true);
			theEndText2.SetActive(true);
		}
		else
		{
			granny1.SetActive(true);
			theEndText1.SetActive(true);
		}
		cam1.SetActive(true);
		granny2.SetActive(false);
		cam2.SetActive(false);
		blackScreen.CrossFadeAlpha(0f, fadeBlackSpeed, false);
		yield return new WaitForSeconds(5f);
		if (PlayerPrefs.GetInt("DiffData") != 4)
		{
		}
		yield return new WaitForSeconds(5f);
		if (PlayerPrefs.GetInt("DiffData") != 4)
		{
			granny1Anim.GetComponent<Animation>().CrossFade("GrannyMoveCamera");
			grannyAnim.GetComponent<Animation>().CrossFade("idle");
		}
		yield return new WaitForSeconds(1.5f);
		if (PlayerPrefs.GetInt("DiffData") != 4)
		{
			soundEffects.SetActive(true);
			theEndText1.SetActive(false);
		}
		if (PlayerPrefs.GetInt("DiffData") == 4)
		{
			yield return new WaitForSeconds(7f);
		}
		yield return new WaitForSeconds(1.5f);
		fadeBlackSpeed = 0.6f;
		blackScreen.CrossFadeAlpha(1f, fadeBlackSpeed, false);
		yield return new WaitForSeconds(3f);
		readyToMainMenu();
	}

	public virtual IEnumerator startTheEnd2()
	{
		if (PlayerPrefs.GetInt("DiffData") == 4)
		{
			granny2.SetActive(true);
			GrannyGoneTeddy.SetActive(true);
			granny2Gone.SetActive(false);
			teddy.SetActive(false);
			granny3Home.SetActive(true);
			theEndText2.SetActive(true);
		}
		else
		{
			granny2.SetActive(true);
			theEndText1.SetActive(true);
			GrannyGoneTeddy.SetActive(false);
			teddy.SetActive(true);
		}
		cam2.SetActive(true);
		granny1.SetActive(false);
		cam1.SetActive(false);
		blackScreen.CrossFadeAlpha(0f, fadeBlackSpeed, false);
		yield return new WaitForSeconds(3f);
		yield return new WaitForSeconds(2f);
		slendrinaFade = true;
		if (PlayerPrefs.GetInt("DiffData") != 4)
		{
		}
		yield return new WaitForSeconds(7f);
		PlayerPrefs.SetInt("teddyInPlace", 0);
		fadeBlackSpeed = 0.6f;
		if (PlayerPrefs.GetInt("DiffData") == 4)
		{
			yield return new WaitForSeconds(8f);
		}
		blackScreen.CrossFadeAlpha(1f, fadeBlackSpeed, false);
		yield return new WaitForSeconds(3f);
		readyToMainMenu();
	}

	public virtual void readyToMainMenu()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene("Menu");
	}
}

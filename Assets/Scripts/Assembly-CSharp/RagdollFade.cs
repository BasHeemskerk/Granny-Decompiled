using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class RagdollFade : MonoBehaviour
{
	public GameObject gameController;

	public GameObject Granny;

	public bool ragdollFade;

	public Shader shader1;

	public Shader shader2;

	public Renderer rend;

	public GameObject ragdollTexture;

	public GameObject leg1Texture;

	public GameObject leg2Texture;

	public GameObject Hair;

	public GameObject Eyes;

	public GameObject Tand;

	public GameObject Bat;

	public float fadeStartTime;

	public float timerCount;

	public bool checkFadeEarly;

	public RagdollFade()
	{
		ragdollFade = true;
		timerCount = 5f;
		checkFadeEarly = true;
	}

	public virtual IEnumerator Start()
	{
		gameController = GameObject.Find("GameController");
		Granny = GameObject.Find("GrannyParent");
		shader2 = Shader.Find("Legacy Shaders/Transparent/Diffuse");
		if (PlayerPrefs.GetInt("DiffData") == 3)
		{
			yield return new WaitForSeconds(15f);
		}
		else
		{
			yield return new WaitForSeconds(fadeStartTime);
		}
		ragdollFade = true;
	}

	public virtual void Update()
	{
		if (((grannyRestart)gameController.GetComponent(typeof(grannyRestart))).playerFallDead || ((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerGetCaught)
		{
			ragdollFade = true;
		}
		if (ragdollFade)
		{
			timerCount -= Time.deltaTime;
			Bat.SetActive(false);
			Eyes.SetActive(false);
			Tand.SetActive(false);
			leg1Texture.SetActive(false);
			leg2Texture.SetActive(false);
			rend.GetComponent<Renderer>().material.shader = shader2;
			float a = ragdollTexture.GetComponent<Renderer>().material.color.a - 0.2f * Time.deltaTime;
			Color color = ragdollTexture.GetComponent<Renderer>().material.color;
			color.a = a;
			ragdollTexture.GetComponent<Renderer>().material.color = color;
			float a2 = Hair.GetComponent<Renderer>().material.color.a - 0.2f * Time.deltaTime;
			Color color2 = Hair.GetComponent<Renderer>().material.color;
			color2.a = a2;
			Hair.GetComponent<Renderer>().material.color = color2;
		}
		if (timerCount < 0f)
		{
			ragdollFade = false;
			((grannyRestart)gameController.GetComponent(typeof(grannyRestart))).setTime();
			((grannyRestart)gameController.GetComponent(typeof(grannyRestart))).startTimer = true;
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}

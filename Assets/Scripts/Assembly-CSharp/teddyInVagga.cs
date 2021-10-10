using System;
using UnityEngine;

[Serializable]
public class teddyInVagga : MonoBehaviour
{
	public GameObject slendrina;

	public GameObject teddyTexture;

	public GameObject gameController;

	public GameObject granny;

	public bool fadeDown;

	public Shader shader1;

	public Renderer rend;

	public Transform GrannyStartPos;

	public GameObject glow;

	public virtual void Start()
	{
		shader1 = Shader.Find("Legacy Shaders/Transparent/Diffuse");
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (!((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerGetCaught && other.gameObject.tag == "teddy")
		{
			other.gameObject.tag = "Untagged";
			fadeDown = true;
			granny.SetActive(false);
			granny.transform.position = GrannyStartPos.position;
			granny.SetActive(true);
			glow.SetActive(true);
			((startNewDay)gameController.GetComponent(typeof(startNewDay))).slendrinaAppeard = true;
		}
	}

	public virtual void Update()
	{
		if (fadeDown && !((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerGetCaught)
		{
			rend = GameObject.Find("Teddy(Clone)").GetComponent<Renderer>();
			teddyTexture = GameObject.Find("Teddy(Clone)");
			rend.GetComponent<Renderer>().material.shader = shader1;
			float a = teddyTexture.GetComponent<Renderer>().material.color.a - 0.3f * Time.deltaTime;
			Color color = teddyTexture.GetComponent<Renderer>().material.color;
			color.a = a;
			teddyTexture.GetComponent<Renderer>().material.color = color;
			if (teddyTexture.GetComponent<Renderer>().material.color.a <= 0f)
			{
				fadeDown = false;
				slendrina.SetActive(true);
				UnityEngine.Object.Destroy(teddyTexture);
				PlayerPrefs.SetInt("teddyInPlace", 1);
			}
		}
	}
}

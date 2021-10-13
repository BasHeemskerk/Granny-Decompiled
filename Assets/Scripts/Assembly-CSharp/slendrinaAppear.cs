using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class slendrinaAppear : MonoBehaviour
{
	public bool SlendrinaAppear;

	public bool fadeUpDown;

	public float fadeSpeed;

	public GameObject slendrinaTexture;

	public GameObject slendrinaHairTexture;

	public GameObject particleSys;

	public virtual IEnumerator Start()
	{
		SlendrinaAppear = true;
		yield return new WaitForSeconds(5f);
		fadeUpDown = true;
		yield return new WaitForSeconds(4f);
		fadeUpDown = false;
		yield return new WaitForSeconds(5f);
		fadeUpDown = true;
		yield return new WaitForSeconds(3f);
		particleSys.GetComponent<ParticleSystem>().enableEmission = false;
		particleSys.GetComponent<ParticleSystem>().Stop();
		yield return new WaitForSeconds(4f);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	public virtual void Update()
	{
		if (SlendrinaAppear)
		{
			if (!fadeUpDown)
			{
				float a = slendrinaTexture.GetComponent<Renderer>().material.color.a + 0.01f * Time.deltaTime * fadeSpeed;
				Color color = slendrinaTexture.GetComponent<Renderer>().material.color;
				color.a = a;
				slendrinaTexture.GetComponent<Renderer>().material.color = color;
				float a2 = slendrinaHairTexture.GetComponent<Renderer>().material.color.a + 0.01f * Time.deltaTime * fadeSpeed;
				Color color2 = slendrinaHairTexture.GetComponent<Renderer>().material.color;
				color2.a = a2;
				slendrinaHairTexture.GetComponent<Renderer>().material.color = color2;
			}
			if (fadeUpDown)
			{
				float a3 = slendrinaTexture.GetComponent<Renderer>().material.color.a - 0.01f * Time.deltaTime * fadeSpeed;
				Color color3 = slendrinaTexture.GetComponent<Renderer>().material.color;
				color3.a = a3;
				slendrinaTexture.GetComponent<Renderer>().material.color = color3;
				float a4 = slendrinaHairTexture.GetComponent<Renderer>().material.color.a - 0.01f * Time.deltaTime * fadeSpeed;
				Color color4 = slendrinaHairTexture.GetComponent<Renderer>().material.color;
				color4.a = a4;
				slendrinaHairTexture.GetComponent<Renderer>().material.color = color4;
			}
		}
	}
}

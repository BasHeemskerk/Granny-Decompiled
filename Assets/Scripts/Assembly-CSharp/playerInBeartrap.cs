using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class playerInBeartrap : MonoBehaviour
{
	public Image bloodScreen;

	public Image bloodScreenHit;

	public Image bloodScreenBiten;

	public GameObject bloodScreenTexture;

	public GameObject bloodScreenHitTexture;

	public GameObject bloodScreenBitenTexture;

	public CanvasRenderer cv;

	public bool bloodON;

	public bool bloodHitON;

	public bool bloodBitenON;

	public virtual void Update()
	{
		if (bloodON)
		{
			bloodScreen.CrossFadeAlpha(0f, 0.8f, false);
			if (bloodScreen.canvasRenderer.GetAlpha() < 0.1f)
			{
				bloodON = false;
				bloodScreenTexture.SetActive(false);
			}
		}
		if (bloodHitON)
		{
			bloodScreenHit.CrossFadeAlpha(0f, 0.8f, false);
			if (bloodScreenHit.canvasRenderer.GetAlpha() < 0.1f)
			{
				bloodHitON = false;
				bloodScreenHitTexture.SetActive(false);
			}
		}
		if (bloodBitenON)
		{
			bloodScreenBiten.CrossFadeAlpha(0f, 0.8f, false);
			if (bloodScreenBiten.canvasRenderer.GetAlpha() < 0.1f)
			{
				bloodBitenON = false;
				bloodScreenBitenTexture.SetActive(false);
			}
		}
	}

	public virtual void playerStuck()
	{
		StartCoroutine(stuckTimer());
		bloodScreen.canvasRenderer.SetAlpha(1f);
	}

	public virtual void playerHit()
	{
		StartCoroutine(hitTimer());
		bloodScreenHit.canvasRenderer.SetAlpha(1f);
	}

	public virtual void playerBiten()
	{
		StartCoroutine(bitenTimer());
		bloodScreenBiten.canvasRenderer.SetAlpha(1f);
	}

	public virtual IEnumerator stuckTimer()
	{
		bloodScreenTexture.SetActive(true);
		yield return new WaitForSeconds(3f);
		bloodON = true;
	}

	public virtual IEnumerator hitTimer()
	{
		yield return new WaitForSeconds(0.8f);
		bloodScreenHitTexture.SetActive(true);
		yield return new WaitForSeconds(3f);
		bloodHitON = true;
	}

	public virtual IEnumerator bitenTimer()
	{
		bloodScreenBitenTexture.SetActive(true);
		yield return new WaitForSeconds(3f);
		bloodBitenON = true;
	}
}

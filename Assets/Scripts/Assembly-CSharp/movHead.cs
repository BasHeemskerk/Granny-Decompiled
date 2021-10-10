using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class movHead : MonoBehaviour
{
	public Texture headR;

	public Texture headL;

	public GUITexture head;

	private bool headMove;

	public virtual IEnumerator Start()
	{
		head.GetComponent<GUITexture>().texture = headR;
		yield return new WaitForSeconds(10f);
		head.GetComponent<GUITexture>().texture = headL;
		yield return new WaitForSeconds(10f);
		head.GetComponent<GUITexture>().texture = headR;
		headMove = true;
	}

	public virtual void Update()
	{
		if (headMove)
		{
			headMove = false;
			StartCoroutine(moveHead());
		}
	}

	public virtual IEnumerator moveHead()
	{
		yield return new WaitForSeconds(10f);
		head.GetComponent<GUITexture>().texture = headL;
		yield return new WaitForSeconds(10f);
		head.GetComponent<GUITexture>().texture = headR;
		headMove = true;
	}
}

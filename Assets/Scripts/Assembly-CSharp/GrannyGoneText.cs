using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class GrannyGoneText : MonoBehaviour
{
	public bool textOnOff;

	public float timer;

	public Image text;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (textOnOff)
		{
			text.enabled = true;
			timer += Time.deltaTime;
			if (timer > 5f)
			{
				textOnOff = false;
				timer = 0f;
				text.enabled = false;
			}
		}
	}
}

using System;
using UnityEngine;

[Serializable]
public class HealthBarStretch : MonoBehaviour
{
	public float scaledWidth;

	public float scaledHeight;

	private Rect defaultRect;

	public GUITexture gui;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
	}
}

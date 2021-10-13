using System;
using UnityEngine;

[Serializable]
public class FPS : MonoBehaviour
{
	public float updateInterval;

	private float accum;

	private int frames;

	private float timeleft;

	public FPS()
	{
		updateInterval = 0.5f;
	}

	public virtual void Start()
	{
		if (!GetComponent<GUIText>())
		{
			MonoBehaviour.print("FramesPerSecond needs a GUIText component!");
			base.enabled = false;
		}
		else
		{
			timeleft = updateInterval;
		}
	}

	public virtual void Update()
	{
		timeleft -= Time.deltaTime;
		accum += Time.timeScale / Time.deltaTime;
		frames++;
		if (timeleft <= 0f)
		{
			GetComponent<GUIText>().text = string.Empty + (accum / (float)frames).ToString("f2");
			timeleft = updateInterval;
			accum = 0f;
			frames = 0;
		}
	}
}

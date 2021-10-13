using System.Collections;
using UnityEngine;

public class TestFPS : MonoBehaviour
{
	private int FramesPerSec;

	private float frequency = 1f;

	private string fps;

	private void Start()
	{
		StartCoroutine(FPS());
	}

	private IEnumerator FPS()
	{
		while (true)
		{
			int lastFrameCount = Time.frameCount;
			float lastTime = Time.realtimeSinceStartup;
			yield return new WaitForSeconds(frequency);
			float timeSpan = Time.realtimeSinceStartup - lastTime;
			int frameCount = Time.frameCount - lastFrameCount;
			fps = string.Format("FPS: {0}", (float)frameCount / timeSpan);
		}
	}

	private void OnGUI()
	{
		GUI.Label(new Rect(Screen.width - 100, 10f, 150f, 20f), fps);
	}
}

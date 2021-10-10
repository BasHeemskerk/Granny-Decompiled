using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

[Serializable]
public class ControlMenu : MonoBehaviour
{
	public Texture2D background;

	public bool display;

	public Font font;

	public ControllerScene[] controllers;

	public Transform[] destroyOnLoad;

	public GameObject launchIntro;

	public GameObject orbEmitter;

	private int selection;

	private bool displayBackground;

	public ControlMenu()
	{
		selection = -1;
	}

	public virtual void Start()
	{
		launchIntro.SetActive(false);
		orbEmitter.GetComponent<Renderer>().enabled = false;
	}

	public virtual void Update()
	{
		if (display || selection != -1 || Input.touchCount <= 0)
		{
			return;
		}
		for (int i = 0; i < Input.touchCount; i++)
		{
			Touch touch = Input.GetTouch(i);
			if (touch.phase == TouchPhase.Began && GetComponent<GUITexture>().HitTest(touch.position))
			{
				display = true;
				displayBackground = false;
				GetComponent<GUITexture>().enabled = false;
			}
		}
	}

	public virtual void OnGUI()
	{
		GUI.skin.font = font;
		if (displayBackground)
		{
			GUI.DrawTexture(new Rect(0f, 0f, Screen.width, Screen.height), background, ScaleMode.StretchToFill, false);
		}
		if (!display)
		{
			return;
		}
		int num = -1;
		int num2 = 60;
		int num3 = 400;
		GUILayout.BeginArea(new Rect((Screen.width - num3) / 2, (Screen.height - num2) / 2, num3, num2));
		GUILayout.BeginHorizontal();
		for (int i = 0; i < controllers.Length; i++)
		{
			if (GUILayout.Button(controllers[i].label, GUILayout.MinHeight(num2)))
			{
				num = i;
			}
		}
		if (num >= 0)
		{
			selection = num;
			GetComponent<GUITexture>().enabled = false;
			display = false;
			displayBackground = false;
			StartCoroutine(ChangeControls());
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	public virtual IEnumerator WaitUntilObjectDestroyed(object o)
	{
		while (o != null)
		{
			yield return new WaitForFixedUpdate();
		}
	}

	public virtual IEnumerator ChangeControls()
	{
		Transform[] array = destroyOnLoad;
		foreach (Transform transform in array)
		{
			UnityEngine.Object.Destroy(transform.gameObject);
		}
		launchIntro.SetActive(true);
		yield return StartCoroutine(WaitUntilObjectDestroyed(launchIntro));
		displayBackground = true;
		orbEmitter.GetComponent<Renderer>().enabled = true;
		SceneManager.LoadScene(controllers[selection].controlScene);
		UnityEngine.Object.Destroy(base.gameObject, 1f);
	}
}

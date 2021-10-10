using System;
using UnityEngine;

[Serializable]
public class gameOverScenes : MonoBehaviour
{
	public float GameOverScenes;

	public virtual void Awake()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.transform.gameObject);
	}
}

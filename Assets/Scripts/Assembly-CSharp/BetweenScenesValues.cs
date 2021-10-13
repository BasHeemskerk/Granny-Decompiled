using System;
using UnityEngine;

[Serializable]
public class BetweenScenesValues : MonoBehaviour
{
	public static bool difficultyEasy;

	public static bool difficultyMedium;

	public static bool difficultyHard;

	public virtual void Awake()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.transform.gameObject);
	}
}

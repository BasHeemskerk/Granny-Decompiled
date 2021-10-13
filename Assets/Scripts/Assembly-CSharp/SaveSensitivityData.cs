using System;
using UnityEngine;

[Serializable]
public class SaveSensitivityData : MonoBehaviour
{
	public static float sliderValue;

	public virtual void Awake()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.transform.gameObject);
	}
}

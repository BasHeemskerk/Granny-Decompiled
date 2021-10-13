using System;
using UnityEngine;

[Serializable]
public class SlowMotion : MonoBehaviour
{
	public virtual void Start()
	{
		Time.timeScale = 0.4f;
	}

	public virtual void Update()
	{
	}
}

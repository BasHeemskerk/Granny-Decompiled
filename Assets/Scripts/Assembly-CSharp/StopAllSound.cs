using System;
using UnityEngine;

[Serializable]
public class StopAllSound : MonoBehaviour
{
	public virtual void Start()
	{
	}

	public virtual void stopSounds()
	{
		AudioListener.pause = true;
	}

	public virtual void startSounds()
	{
		AudioListener.pause = false;
	}
}

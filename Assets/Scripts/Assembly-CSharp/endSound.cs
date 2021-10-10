using System;
using UnityEngine;

[Serializable]
public class endSound : MonoBehaviour
{
	public AudioClip playerEnd;

	public virtual void Start()
	{
		RenderSettings.fog = false;
	}

	public virtual void startEndSound()
	{
		AudioSource.PlayClipAtPoint(playerEnd, base.transform.position);
	}
}

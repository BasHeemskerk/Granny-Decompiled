using System;
using UnityEngine;

[Serializable]
public class WaterMovement : MonoBehaviour
{
	public Renderer waterSurface;

	public Renderer pipeWater;

	public virtual void Update()
	{
		float time = Time.time;
		float num = Mathf.PingPong(time * 0.2f, 1f) * 0.05f;
		waterSurface.material.mainTextureOffset = new Vector2(num, num);
		pipeWater.material.mainTextureOffset = new Vector2(time * 0.2f % 1f, time * 1.3f % 1f);
	}
}

using System.Collections.Generic;
using UnityEngine;

public class OccludeLights : MonoBehaviour
{
	private List<Light> Lights = new List<Light>();

	private const float OccludeDist = 100f;

	private void Start()
	{
	}

	private void Update()
	{
		foreach (Light light in Lights)
		{
			if ((base.transform.position - light.transform.position).sqrMagnitude > 10000f)
			{
				light.enabled = false;
			}
			else
			{
				light.enabled = true;
			}
		}
	}
}

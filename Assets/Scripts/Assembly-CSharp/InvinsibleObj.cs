using System;
using UnityEngine;

[Serializable]
public class InvinsibleObj : MonoBehaviour
{
	public virtual void Start()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		Component[] array = componentsInChildren;
		for (int i = 0; i < array.Length; i++)
		{
			Renderer renderer = (Renderer)array[i];
			renderer.material.renderQueue = 2002;
		}
	}
}

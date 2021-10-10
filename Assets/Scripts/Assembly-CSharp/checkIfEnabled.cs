using System;
using UnityEngine;

[Serializable]
public class checkIfEnabled : MonoBehaviour
{
	public GameObject Menu;

	public GameObject playButton;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (!Menu.activeSelf)
		{
		}
	}
}

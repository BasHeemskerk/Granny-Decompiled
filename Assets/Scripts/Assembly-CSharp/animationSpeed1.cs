using System;
using UnityEngine;

[Serializable]
public class animationSpeed1 : MonoBehaviour
{
	public GameObject CameraAnim;

	public virtual void Start()
	{
		CameraAnim.GetComponent<Animation>()["EndBookCamera"].speed = 0.5f;
		CameraAnim.GetComponent<Animation>().Play("EndBookCamera");
	}

	public virtual void Update()
	{
	}
}

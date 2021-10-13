using System;
using UnityEngine;

[Serializable]
public class bedEyes2 : MonoBehaviour
{
	public bool lookAtGranny;

	public Transform granny;

	public float speed;

	public GameObject playerStop;

	public virtual void Start()
	{
		base.transform.localEulerAngles = new Vector3(0f, -90f, 0f);
		playerStop = GameObject.Find("BedCam2");
	}

	public virtual void Update()
	{
		if (lookAtGranny)
		{
			faceGrannyBed();
		}
	}

	public virtual void faceGrannyBed()
	{
		Vector3 target = granny.position - base.transform.position;
		float maxRadiansDelta = speed * Time.deltaTime;
		Vector3 vector = Vector3.RotateTowards(base.transform.forward, target, maxRadiansDelta, 0f);
		Debug.DrawRay(base.transform.position, vector, Color.red);
		base.transform.rotation = Quaternion.LookRotation(vector);
	}
}

using System;
using UnityEngine;

[Serializable]
public class ZoomCamera : MonoBehaviour
{
	public Transform origin;

	public float zoom;

	public float zoomMin;

	public float zoomMax;

	public float seekTime;

	public bool smoothZoomIn;

	private Vector3 defaultLocalPosition;

	private Transform thisTransform;

	private float currentZoom;

	private float targetZoom;

	private float zoomVelocity;

	public ZoomCamera()
	{
		zoomMin = -5f;
		zoomMax = 5f;
		seekTime = 1f;
	}

	public virtual void Start()
	{
		thisTransform = base.transform;
		defaultLocalPosition = thisTransform.localPosition;
		currentZoom = zoom;
	}

	public virtual void Update()
	{
		RaycastHit hitInfo = default(RaycastHit);
		zoom = Mathf.Clamp(zoom, zoomMin, zoomMax);
		int layerMask = -261;
		Vector3 position = origin.position;
		Vector3 position2 = defaultLocalPosition + thisTransform.parent.InverseTransformDirection(thisTransform.forward * zoom);
		Vector3 end = thisTransform.parent.TransformPoint(position2);
		if (Physics.Linecast(position, end, out hitInfo, layerMask))
		{
			Vector3 vector = hitInfo.point + thisTransform.TransformDirection(Vector3.forward);
			targetZoom = (vector - thisTransform.parent.TransformPoint(defaultLocalPosition)).magnitude;
		}
		else
		{
			targetZoom = zoom;
		}
		targetZoom = Mathf.Clamp(targetZoom, zoomMin, zoomMax);
		if (!smoothZoomIn && targetZoom - currentZoom > 0f)
		{
			currentZoom = targetZoom;
		}
		else
		{
			currentZoom = Mathf.SmoothDamp(currentZoom, targetZoom, ref zoomVelocity, seekTime);
		}
		position2 = defaultLocalPosition + thisTransform.parent.InverseTransformDirection(thisTransform.forward * currentZoom);
		thisTransform.localPosition = position2;
	}
}

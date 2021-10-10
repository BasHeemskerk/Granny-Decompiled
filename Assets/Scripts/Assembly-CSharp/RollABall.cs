using System;
using UnityEngine;

[Serializable]
[RequireComponent(typeof(Rigidbody))]
public class RollABall : MonoBehaviour
{
	public Vector3 tilt;

	public float speed;

	private float circ;

	private Vector3 previousPosition;

	public RollABall()
	{
		tilt = Vector3.zero;
	}

	public virtual void Start()
	{
		circ = (float)Math.PI * 2f * GetComponent<Collider>().bounds.extents.x;
		previousPosition = base.transform.position;
	}

	public virtual void Update()
	{
		tilt.x = 0f - Input.acceleration.y;
		tilt.z = Input.acceleration.x;
		GetComponent<Rigidbody>().AddForce(tilt * speed * Time.deltaTime);
	}

	public virtual void LateUpdate()
	{
		Vector3 vector = base.transform.position - previousPosition;
		vector = new Vector3(vector.z, 0f, 0f - vector.x);
		base.transform.Rotate(vector / circ * 360f, Space.World);
		previousPosition = base.transform.position;
	}
}

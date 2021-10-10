using System;
using UnityEngine;

[Serializable]
public class seeDoors : MonoBehaviour
{
	public Transform myTransform;

	public float seeRange;

	public virtual void Start()
	{
	}

	public virtual void FixedUpdate()
	{
		RaycastHit raycastHit = default(RaycastHit);
		Vector3 vector = myTransform.TransformDirection(Vector3.forward);
		Debug.DrawLine(base.transform.position, vector, Color.green);
		if (Physics.Raycast(myTransform.position, vector, 3f) && raycastHit.collider.gameObject.tag != "innerdoorclosed")
		{
			MonoBehaviour.print("There is something in front of the object!");
		}
	}
}

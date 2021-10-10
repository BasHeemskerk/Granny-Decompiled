using System;
using UnityEngine;

[Serializable]
public class pushRigidbody : MonoBehaviour
{
	public float pushPower;

	public pushRigidbody()
	{
		pushPower = 2f;
	}

	public virtual void OnControllerColliderHit(ControllerColliderHit hit)
	{
		Rigidbody attachedRigidbody = hit.collider.attachedRigidbody;
		if (!(attachedRigidbody == null) && !attachedRigidbody.isKinematic && !(hit.moveDirection.y < -0.3f))
		{
			Vector3 vector = new Vector3(hit.moveDirection.x, 0f, hit.moveDirection.z);
			attachedRigidbody.velocity = vector * pushPower;
		}
	}
}

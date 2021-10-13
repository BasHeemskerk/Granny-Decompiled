using System;
using UnityEngine;

[Serializable]
public class particleCollider : MonoBehaviour
{
	public virtual void OnParticleCollision(GameObject other)
	{
		if (other.gameObject.tag == "vas")
		{
			MonoBehaviour.print("Hit Granny");
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Effects
{
	public class ExplosionPhysicsForce : MonoBehaviour
	{
		public float explosionForce = 4f;

		private IEnumerator Start()
		{
			yield return null;
			float multiplier = GetComponent<ParticleSystemMultiplier>().multiplier;
			float r = 10f * multiplier;
			Collider[] cols = Physics.OverlapSphere(base.transform.position, r);
			List<Rigidbody> rigidbodies = new List<Rigidbody>();
			Collider[] array = cols;
			foreach (Collider collider in array)
			{
				if (collider.attachedRigidbody != null && !rigidbodies.Contains(collider.attachedRigidbody))
				{
					rigidbodies.Add(collider.attachedRigidbody);
				}
			}
			foreach (Rigidbody item in rigidbodies)
			{
				item.AddExplosionForce(explosionForce * multiplier, base.transform.position, r, 1f * multiplier, ForceMode.Impulse);
			}
		}
	}
}

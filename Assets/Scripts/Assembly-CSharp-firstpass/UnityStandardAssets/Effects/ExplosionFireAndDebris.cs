using System.Collections;
using UnityEngine;

namespace UnityStandardAssets.Effects
{
	public class ExplosionFireAndDebris : MonoBehaviour
	{
		public Transform[] debrisPrefabs;

		public Transform firePrefab;

		public int numDebrisPieces;

		public int numFires;

		private IEnumerator Start()
		{
			float multiplier = GetComponent<ParticleSystemMultiplier>().multiplier;
			for (int i = 0; (float)i < (float)numDebrisPieces * multiplier; i++)
			{
				Transform original = debrisPrefabs[Random.Range(0, debrisPrefabs.Length)];
				Vector3 position = base.transform.position + Random.insideUnitSphere * 3f * multiplier;
				Quaternion rotation = Random.rotation;
				Object.Instantiate(original, position, rotation);
			}
			yield return null;
			float r = 10f * multiplier;
			Collider[] cols = Physics.OverlapSphere(base.transform.position, r);
			Collider[] array = cols;
			foreach (Collider collider in array)
			{
				if (numFires > 0)
				{
					Ray ray = new Ray(base.transform.position, collider.transform.position - base.transform.position);
					RaycastHit hitInfo;
					if (collider.Raycast(ray, out hitInfo, r))
					{
						AddFire(collider.transform, hitInfo.point, hitInfo.normal);
						numFires--;
					}
				}
			}
			float testR = 0f;
			while (numFires > 0 && testR < r)
			{
				Ray ray2 = new Ray(base.transform.position + Vector3.up, Random.onUnitSphere);
				RaycastHit hitInfo2;
				if (Physics.Raycast(ray2, out hitInfo2, testR))
				{
					AddFire(null, hitInfo2.point, hitInfo2.normal);
					numFires--;
				}
				testR += r * 0.1f;
			}
		}

		private void AddFire(Transform t, Vector3 pos, Vector3 normal)
		{
			pos += normal * 0.5f;
			Transform transform = Object.Instantiate(firePrefab, pos, Quaternion.identity);
			transform.parent = t;
		}
	}
}

using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class spawnRagdoll : MonoBehaviour
{
	public Transform grannyRagdoll;

	public virtual IEnumerator Start()
	{
		yield return new WaitForSeconds(5f);
		UnityEngine.Object.Instantiate(grannyRagdoll, base.transform.position, base.transform.rotation);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	public virtual void Update()
	{
	}
}

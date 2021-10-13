using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class destroyInSeconds : MonoBehaviour
{
	public virtual IEnumerator Start()
	{
		yield return new WaitForSeconds(1.3f);
		UnityEngine.Object.Destroy(base.gameObject);
	}
}

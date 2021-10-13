using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class DestroyText : MonoBehaviour
{
	public virtual IEnumerator Start()
	{
		yield return new WaitForSeconds(3f);
		UnityEngine.Object.Destroy(base.gameObject);
	}
}

using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class selfDestructMomFly : MonoBehaviour
{
	public GameObject head;

	public virtual IEnumerator Start()
	{
		yield return new WaitForSeconds(1f);
		UnityEngine.Object.Destroy(head);
	}
}

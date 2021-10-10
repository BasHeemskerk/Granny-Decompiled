using System;
using UnityEngine;

[Serializable]
public class destroyTempNav : MonoBehaviour
{
	public virtual void Start()
	{
		UnityEngine.Object.Destroy(base.gameObject, 5f);
	}
}

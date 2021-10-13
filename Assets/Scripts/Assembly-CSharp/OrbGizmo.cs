using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class OrbGizmo : MonoBehaviour
{
	public virtual void Start()
	{
		MonoBehaviour.print("Orb count: " + base.transform.childCount);
	}

	public virtual void OnDrawGizmos()
	{
		if (!base.enabled)
		{
			return;
		}
		IEnumerator enumerator = base.transform.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Transform transform = (Transform)enumerator.Current;
				Gizmos.DrawIcon(transform.position, "particleGizmo.tif");
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}
}

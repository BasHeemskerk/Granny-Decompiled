using System;
using UnityEngine;

[Serializable]
public class objectIsMoving : MonoBehaviour
{
	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "ByroLoda")
		{
			base.transform.parent = other.transform;
		}
		else if (other.gameObject.name == "Loda")
		{
			base.transform.parent = other.transform;
		}
	}
}

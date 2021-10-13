using System;
using UnityEngine;

[Serializable]
public class explode : MonoBehaviour
{
	public GameObject explosion;

	public GameObject parent;

	public virtual void explodeNow()
	{
		explosion.SetActive(true);
		parent.GetComponent<Renderer>().enabled = false;
	}
}

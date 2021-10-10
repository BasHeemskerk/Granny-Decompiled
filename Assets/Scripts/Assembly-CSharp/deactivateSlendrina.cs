using System;
using UnityEngine;

[Serializable]
public class deactivateSlendrina : MonoBehaviour
{
	public GameObject slendrina;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			slendrina.SetActive(false);
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}

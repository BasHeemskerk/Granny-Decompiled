using System;
using UnityEngine;

[Serializable]
public class adForceToBody : MonoBehaviour
{
	public GameObject player;

	public bool grannyShoot;

	public virtual void Start()
	{
		player = GameObject.Find("Player");
		Vector3 vector = player.transform.position - base.transform.position;
		GetComponent<Rigidbody>().AddForce(-vector * 500f);
	}

	public virtual void Update()
	{
	}
}

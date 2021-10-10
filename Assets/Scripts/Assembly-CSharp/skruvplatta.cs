using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class skruvplatta : MonoBehaviour
{
	public bool skruv1;

	public bool skruv2;

	public GameObject Screw1;

	public GameObject Screw2;

	public bool skruvBorta;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (skruv1 && skruv2 && !skruvBorta)
		{
			skruvBorta = true;
			StartCoroutine(plattaFaller());
		}
	}

	public virtual IEnumerator plattaFaller()
	{
		yield return new WaitForSeconds(1f);
		((Rigidbody)base.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
	}

	public virtual IEnumerator Screw1Bort()
	{
		yield return new WaitForSeconds(0.8f);
		UnityEngine.Object.Destroy(Screw1);
	}

	public virtual IEnumerator Screw2Bort()
	{
		yield return new WaitForSeconds(0.8f);
		UnityEngine.Object.Destroy(Screw2);
	}
}

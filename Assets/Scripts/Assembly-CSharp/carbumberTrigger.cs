using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class carbumberTrigger : MonoBehaviour
{
	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			((Rigidbody)base.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
			base.transform.parent = null;
			StartCoroutine(destroy());
		}
	}

	public virtual IEnumerator destroy()
	{
		yield return new WaitForSeconds(30f);
		UnityEngine.Object.Destroy(base.gameObject);
	}
}

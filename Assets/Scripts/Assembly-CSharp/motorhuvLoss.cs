using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class motorhuvLoss : MonoBehaviour
{
	public bool MotorhuvLoss;

	public GameObject motorhuv;

	public virtual void Start()
	{
	}

	public virtual IEnumerator OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "car" && !MotorhuvLoss)
		{
			MotorhuvLoss = true;
			motorhuv.transform.parent = null;
			((Rigidbody)motorhuv.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
			motorhuv.gameObject.tag = "Untagged";
			yield return new WaitForSeconds(8f);
			UnityEngine.Object.Destroy(motorhuv);
		}
	}
}

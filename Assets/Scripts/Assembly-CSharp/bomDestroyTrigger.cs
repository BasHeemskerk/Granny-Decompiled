using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class bomDestroyTrigger : MonoBehaviour
{
	public AudioClip taBortPlanka;

	public bool soundPlaying;

	public GameObject granny;

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "bomdestroyer")
		{
			base.gameObject.tag = "Untagged";
			((Rigidbody)GetComponent(typeof(Rigidbody))).isKinematic = false;
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).bastuBomNere = false;
			if (!soundPlaying)
			{
				soundPlaying = true;
				GetComponent<AudioSource>().PlayOneShot(taBortPlanka);
			}
			StartCoroutine(destroyPlank());
		}
	}

	public virtual IEnumerator destroyPlank()
	{
		yield return new WaitForSeconds(10f);
		UnityEngine.Object.Destroy(base.gameObject);
	}
}

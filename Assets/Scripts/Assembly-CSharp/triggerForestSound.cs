using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class triggerForestSound : MonoBehaviour
{
	public GameObject soundHolder;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			soundHolder.SetActive(true);
			StartCoroutine(soundTimer());
		}
	}

	public virtual IEnumerator soundTimer()
	{
		yield return new WaitForSeconds(30f);
		soundHolder.SetActive(false);
	}
}

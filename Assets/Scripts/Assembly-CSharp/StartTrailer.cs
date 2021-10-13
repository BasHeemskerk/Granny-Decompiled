using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class StartTrailer : MonoBehaviour
{
	public GameObject Cam1;

	public GameObject Cam2;

	public virtual IEnumerator Start()
	{
		Time.timeScale = 0.13f;
		yield return new WaitForSeconds(5f);
		Time.timeScale = 1f;
		Cam2.SetActive(true);
		Cam1.SetActive(false);
	}

	public virtual void Update()
	{
	}
}

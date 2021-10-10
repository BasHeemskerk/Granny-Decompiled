using System;
using UnityEngine;

[Serializable]
public class destroyBats : MonoBehaviour
{
	public GameObject bats;

	public float timer;

	public virtual void Start()
	{
		timer = 2f;
	}

	public virtual void Update()
	{
		if (bats.activeSelf)
		{
			timer -= Time.deltaTime;
		}
		if (timer < 0f)
		{
			timer = 2f;
			bats.SetActive(false);
		}
	}
}

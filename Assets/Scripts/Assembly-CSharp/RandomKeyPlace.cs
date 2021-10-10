using System;
using UnityEngine;

[Serializable]
public class RandomKeyPlace : MonoBehaviour
{
	public GameObject keyPlace1;

	public GameObject keyPlace2;

	public GameObject keyPlace3;

	public int number;

	public virtual void Start()
	{
		number = UnityEngine.Random.Range(1, 4);
		if (number == 1)
		{
			keyPlace1.SetActive(true);
		}
		else if (number == 2)
		{
			keyPlace2.SetActive(true);
		}
		else if (number == 3)
		{
			keyPlace3.SetActive(true);
		}
	}
}

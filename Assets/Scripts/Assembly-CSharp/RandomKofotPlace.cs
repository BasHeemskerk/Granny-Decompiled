using System;
using UnityEngine;

[Serializable]
public class RandomKofotPlace : MonoBehaviour
{
	public GameObject kofotPlace1;

	public GameObject kofotPlace2;

	public GameObject kofotPlace3;

	public int number;

	public virtual void Start()
	{
		number = UnityEngine.Random.Range(1, 4);
		if (number == 1)
		{
			kofotPlace1.SetActive(true);
		}
		else if (number == 2)
		{
			kofotPlace2.SetActive(true);
		}
		else if (number == 3)
		{
			kofotPlace3.SetActive(true);
		}
	}
}

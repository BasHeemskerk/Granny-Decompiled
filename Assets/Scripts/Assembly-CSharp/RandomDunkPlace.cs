using System;
using UnityEngine;

[Serializable]
public class RandomDunkPlace : MonoBehaviour
{
	public GameObject dunkPlace1;

	public GameObject dunkPlace2;

	public GameObject dunkPlace3;

	public GameObject dunkPlace4;

	public int number;

	public virtual void Start()
	{
		number = UnityEngine.Random.Range(1, 5);
		if (number == 1)
		{
			dunkPlace1.SetActive(true);
		}
		else if (number == 2)
		{
			dunkPlace2.SetActive(true);
		}
		else if (number == 3)
		{
			dunkPlace3.SetActive(true);
		}
		else if (number == 4)
		{
			dunkPlace4.SetActive(true);
		}
	}
}

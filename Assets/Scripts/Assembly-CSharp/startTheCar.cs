using System;
using UnityEngine;

[Serializable]
public class startTheCar : MonoBehaviour
{
	public GameObject gameController;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (Input.GetKeyDown(KeyCode.E))
		{
			((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).startCar();
		}
	}
}

using System;
using UnityEngine;

[Serializable]
public class forwardCar : MonoBehaviour
{
	public GameObject carAnimation;

	public GameObject forwardButton;

	public GameObject outOffCarButton;

	public GameObject carSensorFront;

	public GameObject carForwardSound;

	public GameObject engineOnSound;

	public GameObject backCrashSound;

	public GameObject CarHitTriggers;

	public GameObject optionButton;

	public GameObject escapeMusic;

	public GameObject mainMusic;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (Input.GetKeyDown(KeyCode.W))
		{
			if (((carFrontSensor)carSensorFront.GetComponent(typeof(carFrontSensor))).hitGaragedoorCounter == 2f)
			{
				carAnimation.GetComponent<Animation>().Play("CarEscape");
				forwardButton.SetActive(false);
				outOffCarButton.SetActive(false);
				carForwardSound.SetActive(true);
				optionButton.SetActive(false);
				escapeMusic.SetActive(true);
				mainMusic.SetActive(false);
			}
			else
			{
				carAnimation.GetComponent<Animation>().Play("CarForward");
				forwardButton.SetActive(false);
				outOffCarButton.SetActive(false);
				carForwardSound.SetActive(true);
				engineOnSound.SetActive(false);
				backCrashSound.SetActive(false);
				CarHitTriggers.SetActive(true);
				optionButton.SetActive(false);
			}
		}
	}
}

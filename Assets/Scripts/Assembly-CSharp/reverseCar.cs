using System;
using UnityEngine;

[Serializable]
public class reverseCar : MonoBehaviour
{
	public GameObject carAnimation;

	public GameObject reverseButton;

	public GameObject outOffCarButton;

	public bool reverse1Played;

	public GameObject carReverseSound1;

	public GameObject engineOnSound;

	public GameObject frontCrashSound;

	public GameObject frontCrashSound2;

	public GameObject CarHitTriggers;

	public GameObject optionButton;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (Input.GetKeyDown(KeyCode.S))
		{
			if (!reverse1Played)
			{
				carAnimation.GetComponent<Animation>().Play("CarReverse");
				reverseButton.SetActive(false);
				reverse1Played = true;
				outOffCarButton.SetActive(false);
				carReverseSound1.SetActive(true);
				engineOnSound.SetActive(false);
				frontCrashSound.SetActive(false);
				frontCrashSound2.SetActive(false);
				CarHitTriggers.SetActive(true);
				optionButton.SetActive(false);
			}
			else
			{
				carAnimation.GetComponent<Animation>().Play("CarReverse2");
				reverseButton.SetActive(false);
				outOffCarButton.SetActive(false);
				carReverseSound1.SetActive(true);
				engineOnSound.SetActive(false);
				frontCrashSound.SetActive(false);
				frontCrashSound2.SetActive(false);
				CarHitTriggers.SetActive(true);
				optionButton.SetActive(false);
			}
		}
	}
}

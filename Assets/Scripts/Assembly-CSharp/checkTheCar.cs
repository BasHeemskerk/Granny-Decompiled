using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class checkTheCar : MonoBehaviour
{
	public GameObject granny;

	public bool batteryOK;

	public bool topplockOK;

	public bool sparkplugOK;

	public bool fuelOK;

	public bool playerHaveCarKey;

	public float topplocksskruvar;

	public GameObject startButton;

	public GameObject forwardButton;

	public GameObject reverseButton;

	public bool forwardOK;

	public bool reverseOK;

	public bool engineOn;

	public GameObject engineStartSound;

	public GameObject engineOnSound;

	public GameObject outOffCarButton;

	public GameObject canNotStartCarText;

	public GameObject needCarKeyText;

	public bool textTimerOnOff;

	public float textTimer;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (textTimerOnOff)
		{
			textTimer += Time.deltaTime;
			if (textTimer > 3f)
			{
				textTimerOnOff = false;
				textTimer = 0f;
				canNotStartCarText.SetActive(false);
				needCarKeyText.SetActive(false);
			}
		}
	}

	public virtual void startCar()
	{
		if (batteryOK && topplockOK && sparkplugOK && fuelOK && playerHaveCarKey && topplocksskruvar == 6f)
		{
			startButton.SetActive(false);
			StartCoroutine(startEngine());
			if (reverseOK)
			{
				reverseButton.SetActive(true);
				forwardButton.SetActive(false);
			}
			else if (forwardOK)
			{
				forwardButton.SetActive(true);
				reverseButton.SetActive(false);
			}
			else
			{
				reverseButton.SetActive(true);
				forwardButton.SetActive(false);
			}
		}
		else if (batteryOK && topplockOK && sparkplugOK && fuelOK && !playerHaveCarKey && topplocksskruvar == 6f)
		{
			textTimer = 0f;
			needCarKeyText.SetActive(true);
			textTimerOnOff = true;
		}
		else
		{
			textTimer = 0f;
			canNotStartCarText.SetActive(true);
			textTimerOnOff = true;
		}
	}

	public virtual IEnumerator startEngine()
	{
		engineOn = true;
		engineStartSound.SetActive(true);
		((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerStartCar = true;
		yield return new WaitForSeconds(0.6f);
		engineOnSound.SetActive(true);
	}
}

using System;
using UnityEngine;

[Serializable]
public class grannyRestart : MonoBehaviour
{
	public GameObject Granny;

	public GameObject GrannyBody;

	public Transform GrannyStartPos1;

	public Transform GrannyStartPos2;

	public Transform GrannyStartPos3;

	public Transform GrannyStartPos4;

	public float timerCount;

	public bool startTimer;

	public bool startTimer2;

	public float RandomNR;

	public bool playerFallDead;

	public virtual void setTime()
	{
		if (PlayerPrefs.GetInt("DiffData") == 0)
		{
			timerCount = 30f;
		}
		else if (PlayerPrefs.GetInt("DiffData") == 1)
		{
			timerCount = 90f;
		}
		else if (PlayerPrefs.GetInt("DiffData") == 2)
		{
			timerCount = 0f;
		}
		else if (PlayerPrefs.GetInt("DiffData") == 3)
		{
			timerCount = 0f;
		}
	}

	public virtual void setTime2()
	{
		if (PlayerPrefs.GetInt("DiffData") == 0)
		{
			timerCount = 60f;
		}
		else if (PlayerPrefs.GetInt("DiffData") == 1)
		{
			timerCount = 120f;
		}
		else if (PlayerPrefs.GetInt("DiffData") == 2)
		{
			timerCount = 30f;
		}
		else if (PlayerPrefs.GetInt("DiffData") == 3)
		{
			timerCount = 15f;
		}
	}

	public virtual void Update()
	{
		if (startTimer)
		{
			timerCount -= Time.deltaTime;
			if (timerCount < 0f || playerFallDead)
			{
				startTimer = false;
				Granny.SetActive(false);
				RandomNR = UnityEngine.Random.Range(1, 5);
				if (RandomNR == 1f)
				{
					Granny.transform.position = GrannyStartPos1.position;
				}
				else if (RandomNR == 2f)
				{
					Granny.transform.position = GrannyStartPos2.position;
				}
				else if (RandomNR == 3f)
				{
					Granny.transform.position = GrannyStartPos3.position;
				}
				else if (RandomNR == 4f)
				{
					Granny.transform.position = GrannyStartPos4.position;
				}
				Granny.SetActive(true);
				GrannyBody.SetActive(true);
				playerFallDead = false;
				noArrow();
			}
		}
		if (!startTimer2)
		{
			return;
		}
		timerCount -= Time.deltaTime;
		if (timerCount < 0f || playerFallDead)
		{
			startTimer2 = false;
			Granny.SetActive(false);
			RandomNR = UnityEngine.Random.Range(1, 5);
			if (RandomNR == 1f)
			{
				Granny.transform.position = GrannyStartPos1.position;
			}
			else if (RandomNR == 2f)
			{
				Granny.transform.position = GrannyStartPos2.position;
			}
			else if (RandomNR == 3f)
			{
				Granny.transform.position = GrannyStartPos3.position;
			}
			else if (RandomNR == 4f)
			{
				Granny.transform.position = GrannyStartPos4.position;
			}
			Granny.SetActive(true);
			GrannyBody.SetActive(true);
			playerFallDead = false;
			noArrow();
		}
	}

	public virtual void noArrow()
	{
		((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).hitByArrow = false;
		((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).hitByGun = false;
		((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).hitByCar = false;
		((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).grannyStandBesideCar = false;
		((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).bastuKilled = false;
		((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).ragdollSpawn = false;
		((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).grannyInBastu = false;
		((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).bastuTimer = 15f;
		((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).bastuDoorTimer = 20f;
		((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).bastuTimeOff = false;
		((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).huntPlayer = false;
		((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).grannyIsFollow = false;
		if (((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy)
		{
			if (!((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).spiderIsDead)
			{
				((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).navComponent.speed = ((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).grannysVarSpeed;
				((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).animationHolder.GetComponent<Animation>()["Walk"].speed = ((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).grannysAnimSpeed;
			}
			else
			{
				((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).spiderIsDead = false;
				((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
			}
		}
		else
		{
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).spiderIsDead = false;
		}
	}
}

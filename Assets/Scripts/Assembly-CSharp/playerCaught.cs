using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

[Serializable]
public class playerCaught : MonoBehaviour
{
	public bool grannyTakePlayer;

	public bool spiderBitePlayer;

	public bool explodingPlayer;

	public Transform granny;

	public Transform grannyEye;

	public Transform spiderPos;

	public Transform playerEye;

	public float speed;

	public GameObject playerHukaKnapp;

	public GameObject footstepScriptHolder;

	public GameObject player;

	public GameObject dooropener;

	public GameObject seeHolder;

	public Image removeBar;

	public GameObject trapBar;

	public GameObject playerStop;

	public GameObject MainCam;

	public bool stopFOV;

	public bool startFOV;

	public float timer;

	public GameObject soundHolder;

	public bool soundPlaying;

	public GameObject gameController;

	public GameObject bedButton1;

	public GameObject bedButton2;

	public GameObject bedButton3;

	public GameObject CoffinButton1;

	public GameObject CoffinButton2;

	public GameObject CarButton;

	public virtual void Start()
	{
		playerStop = GameObject.Find("Main Camera");
	}

	public virtual void Update()
	{
		if (player.activeSelf)
		{
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerHidingUnderBed = false;
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerHidingInCoffin = false;
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerHidingInCoffinBackyard = false;
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerHidingInCar = false;
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).hidingUnderBed1 = false;
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).hidingUnderBed2 = false;
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).hidingUnderBed3 = false;
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).hidingInCoffin4 = false;
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).hidingInCoffinBY = false;
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).hidingInCar = false;
		}
		if (grannyTakePlayer && !spiderBitePlayer && !explodingPlayer)
		{
			StartCoroutine(faceGranny());
		}
		if (spiderBitePlayer && !grannyTakePlayer && !explodingPlayer)
		{
			StartCoroutine(faceSpider());
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).dontHitPlayer = true;
		}
		if (explodingPlayer && !grannyTakePlayer && !spiderBitePlayer)
		{
			StartCoroutine(playerExplode());
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).dontHitPlayer = true;
		}
		if (startFOV)
		{
			if (playerStop.GetComponent<Camera>().fieldOfView <= 30f)
			{
				stopFOV = true;
				startFOV = false;
			}
			if (!stopFOV)
			{
				playerStop.GetComponent<Camera>().fieldOfView = playerStop.GetComponent<Camera>().fieldOfView - 100f * Time.deltaTime;
			}
		}
	}

	public virtual IEnumerator faceGranny()
	{
		Vector3 newDir = Vector3.RotateTowards(target: grannyEye.position - playerEye.position, maxRadiansDelta: speed * Time.deltaTime, current: playerEye.forward, maxMagnitudeDelta: 0f);
		Debug.DrawRay(base.transform.position, newDir, Color.red);
		playerEye.rotation = Quaternion.LookRotation(newDir);
		((Footsteps)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
		((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).m_WalkSpeed = 0f;
		((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).playerGetCaught = true;
		((playerInBeartrap)gameController.GetComponent(typeof(playerInBeartrap))).playerHit();
		removeBar.fillAmount = 0f;
		trapBar.SetActive(false);
		bedButton1.SetActive(false);
		bedButton2.SetActive(false);
		bedButton3.SetActive(false);
		CoffinButton1.SetActive(false);
		CoffinButton2.SetActive(false);
		CarButton.SetActive(false);
		((openDoors)dooropener.GetComponent(typeof(openDoors))).playerTaken = true;
		((PickUp)seeHolder.GetComponent(typeof(PickUp))).playerTaken = true;
		((PickUp)seeHolder.GetComponent(typeof(PickUp))).dropObject = true;
		if (!soundPlaying)
		{
			soundPlaying = true;
			((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).playerCaught();
		}
		if (((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerCaughtLastTime)
		{
			yield return new WaitForSeconds(0.8f);
			playerStop.GetComponent<Camera>().fieldOfView = 60f;
			MainCam.GetComponent<Animation>()["PlayerDie"].speed = 1f;
			MainCam.GetComponent<Animation>().CrossFade("PlayerDie");
		}
		yield return new WaitForSeconds(0.2f);
		grannyTakePlayer = false;
		spiderBitePlayer = false;
		explodingPlayer = false;
		StartCoroutine(((endDay)gameController.GetComponent(typeof(endDay))).EndDay());
	}

	public virtual IEnumerator fallingDead()
	{
		((Footsteps)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
		((Footsteps)footstepScriptHolder.GetComponent(typeof(Footsteps))).playerDie = true;
		((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).m_WalkSpeed = 0f;
		((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).playerGetCaught = true;
		((playerInBeartrap)gameController.GetComponent(typeof(playerInBeartrap))).playerStuck();
		((playerCrawl)playerHukaKnapp.GetComponent(typeof(playerCrawl))).standUp();
		removeBar.fillAmount = 0f;
		trapBar.SetActive(false);
		bedButton1.SetActive(false);
		bedButton2.SetActive(false);
		bedButton3.SetActive(false);
		((openDoors)dooropener.GetComponent(typeof(openDoors))).playerTaken = true;
		((PickUp)seeHolder.GetComponent(typeof(PickUp))).playerTaken = true;
		((PickUp)seeHolder.GetComponent(typeof(PickUp))).dropObject = true;
		MainCam.GetComponent<Animation>()["PlayerDie"].speed = 1f;
		MainCam.GetComponent<Animation>().CrossFade("PlayerDie");
		if (((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).ragdollSpawn)
		{
			((grannyRestart)gameController.GetComponent(typeof(grannyRestart))).playerFallDead = true;
		}
		yield return new WaitForSeconds(0.2f);
		grannyTakePlayer = false;
		spiderBitePlayer = false;
		explodingPlayer = false;
		StartCoroutine(((endDay)gameController.GetComponent(typeof(endDay))).EndDay());
	}

	public virtual IEnumerator playerExplode()
	{
		((Footsteps)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
		((Footsteps)footstepScriptHolder.GetComponent(typeof(Footsteps))).playerDie = true;
		((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).m_WalkSpeed = 0f;
		((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).playerGetCaught = true;
		((playerInBeartrap)gameController.GetComponent(typeof(playerInBeartrap))).playerStuck();
		((playerCrawl)playerHukaKnapp.GetComponent(typeof(playerCrawl))).standUp();
		removeBar.fillAmount = 0f;
		trapBar.SetActive(false);
		bedButton1.SetActive(false);
		bedButton2.SetActive(false);
		bedButton3.SetActive(false);
		((openDoors)dooropener.GetComponent(typeof(openDoors))).playerTaken = true;
		((PickUp)seeHolder.GetComponent(typeof(PickUp))).playerTaken = true;
		((PickUp)seeHolder.GetComponent(typeof(PickUp))).dropObject = true;
		MainCam.GetComponent<Animation>()["PlayerDie"].speed = 1f;
		MainCam.GetComponent<Animation>().CrossFade("PlayerDie");
		if (((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).ragdollSpawn)
		{
			((grannyRestart)gameController.GetComponent(typeof(grannyRestart))).playerFallDead = true;
		}
		yield return new WaitForSeconds(0.2f);
		grannyTakePlayer = false;
		spiderBitePlayer = false;
		explodingPlayer = false;
		StartCoroutine(((endDay)gameController.GetComponent(typeof(endDay))).EndDay());
	}

	public virtual IEnumerator faceSpider()
	{
		Vector3 newDir = Vector3.RotateTowards(target: spiderPos.position - playerEye.position, maxRadiansDelta: speed * Time.deltaTime, current: playerEye.forward, maxMagnitudeDelta: 0f);
		Debug.DrawRay(base.transform.position, newDir, Color.red);
		playerEye.rotation = Quaternion.LookRotation(newDir);
		((Footsteps)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
		((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).m_WalkSpeed = 0f;
		((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).playerGetCaught = true;
		((playerInBeartrap)gameController.GetComponent(typeof(playerInBeartrap))).playerBiten();
		removeBar.fillAmount = 0f;
		trapBar.SetActive(false);
		bedButton1.SetActive(false);
		bedButton2.SetActive(false);
		bedButton3.SetActive(false);
		CoffinButton1.SetActive(false);
		CoffinButton2.SetActive(false);
		CarButton.SetActive(false);
		((openDoors)dooropener.GetComponent(typeof(openDoors))).playerTaken = true;
		((PickUp)seeHolder.GetComponent(typeof(PickUp))).playerTaken = true;
		((PickUp)seeHolder.GetComponent(typeof(PickUp))).dropObject = true;
		if (!soundPlaying)
		{
			soundPlaying = true;
		}
		if (((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerCaughtLastTime)
		{
			MainCam.GetComponent<Animation>()["PlayerDie"].speed = 1f;
			MainCam.GetComponent<Animation>().CrossFade("PlayerDie");
		}
		yield return new WaitForSeconds(0.2f);
		grannyTakePlayer = false;
		spiderBitePlayer = false;
		explodingPlayer = false;
		StartCoroutine(((endDay)gameController.GetComponent(typeof(endDay))).EndDay());
	}
}

using System;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

[Serializable]
public class insideCarButton : MonoBehaviour
{
	public GameObject player;

	public GameObject granny;

	public GameObject inCoffin;

	public GameObject underBedCam;

	public GameObject playerPosition;

	public bool PlayerHiding;

	public GameObject playerCam;

	public GameObject crouchButton;

	public GameObject soundHolder;

	public GameObject dropButtonHolder;

	public GameObject hidingSoundHolder;

	public GameObject shootGunButtonHolder;

	public GameObject pickupButton;

	public GameObject openDoorButton;

	public GameObject mittenRing;

	public Sprite hideTexture;

	public Sprite UnhideTexture;

	public Image button;

	public float lockRotXNer;

	public float lockRotXUpp;

	public GameObject startButton;

	public GameObject reverseButton;

	public GameObject forwardButton;

	public GameObject gameController;

	public GameObject engineOffSound;

	public GameObject engineOnSound;

	public GameObject engineStartSound;

	public GameObject objectsHolder;

	public bool drivingCar;

	public virtual void Start()
	{
		PlayerHiding = false;
	}

	public virtual void Update()
	{
		if (Input.GetKeyDown(KeyCode.R) && !((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).menuEnabled)
		{
			if (!PlayerHiding)
			{
				player.SetActive(false);
				PlayerHiding = true;
				inCoffin.SetActive(true);
				underBedCam.transform.localEulerAngles = new Vector3(0f, 0f, 0f);
				((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerHidingInCar = true;
				((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).hidingInCar = true;
				((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerNearGranny = false;
				crouchButton.SetActive(false);
				dropButtonHolder.SetActive(false);
				shootGunButtonHolder.SetActive(false);
				pickupButton.SetActive(false);
				openDoorButton.SetActive(false);
				mittenRing.SetActive(false);
				startButton.SetActive(true);
				((hideSound)hidingSoundHolder.GetComponent(typeof(hideSound))).theSound();
				engineOffSound.SetActive(false);
				objectsHolder.SetActive(false);
			}
			else
			{
				inCoffin.SetActive(false);
				player.transform.position = playerPosition.transform.position;
				player.SetActive(true);
				player.transform.localEulerAngles = new Vector3(0f, 0f, 0f);
				playerCam.transform.localEulerAngles = new Vector3(0f, 0f, 0f);
				((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).resetMouse();
				((playerCrawl)crouchButton.GetComponent(typeof(playerCrawl))).standUp();
				PlayerHiding = false;
				((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerHidingInCar = false;
				((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).hidingInCar = false;
				((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerStartCar = false;
				crouchButton.SetActive(true);
				dropButtonHolder.SetActive(true);
				shootGunButtonHolder.SetActive(true);
				startButton.SetActive(false);
				reverseButton.SetActive(false);
				forwardButton.SetActive(false);
				objectsHolder.SetActive(true);
				((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).CarOut();
				if (((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).engineOn)
				{
					engineOffSound.SetActive(true);
					engineOnSound.SetActive(false);
					engineStartSound.SetActive(false);
					((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).engineOn = false;
				}
			}
		}
		if (PlayerHiding)
		{
			button = GetComponent<Image>();
			button.sprite = UnhideTexture;
		}
		else
		{
			button = GetComponent<Image>();
			button.sprite = hideTexture;
		}
	}
}

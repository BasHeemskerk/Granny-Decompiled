using System;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

[Serializable]
public class bedButton : MonoBehaviour
{
	public GameObject player;

	public GameObject granny;

	public GameObject underBed;

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
				underBed.SetActive(true);
				underBedCam.transform.localEulerAngles = new Vector3(0f, -90f, 0f);
				PlayerHiding = true;
				((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerHidingUnderBed = true;
				((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).hidingUnderBed1 = true;
				((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerNearGranny = false;
				crouchButton.SetActive(false);
				shootGunButtonHolder.SetActive(false);
				dropButtonHolder.SetActive(false);
				pickupButton.SetActive(false);
				openDoorButton.SetActive(false);
				mittenRing.SetActive(false);
				((hideSound)hidingSoundHolder.GetComponent(typeof(hideSound))).theSound();
			}
			else
			{
				underBed.SetActive(false);
				player.transform.position = playerPosition.transform.position;
				player.SetActive(true);
				player.transform.localEulerAngles = new Vector3(0f, 90f, 0f);
				playerCam.transform.localEulerAngles = new Vector3(0f, 0f, 0f);
				((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).resetMouse();
				((playerCrawl)crouchButton.GetComponent(typeof(playerCrawl))).standUp();
				PlayerHiding = false;
				((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerHidingUnderBed = false;
				((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).hidingUnderBed1 = false;
				crouchButton.SetActive(true);
				dropButtonHolder.SetActive(true);
				shootGunButtonHolder.SetActive(true);
				((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).fromBed();
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

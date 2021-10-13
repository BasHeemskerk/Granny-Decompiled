using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

[Serializable]
public class CheckExitDoor : MonoBehaviour
{
	public Image blackScreenTexture;

	public GameObject Granny;

	public GameObject GrannySkin;

	public GameObject GrannyBone;

	public GameObject player;

	public GameObject footstepScriptHolder;

	public GameObject dropObjectText;

	public GameObject crouchButton;

	public Image removeBar;

	public GameObject trapButton;

	public GameObject trapBar;

	public GameObject dooropener;

	public GameObject seeHolder;

	public GameObject soundHolder;

	public float fadeBlackSpeed;

	public bool lampa1ok;

	public bool lampa2ok;

	public bool planka1Bort;

	public bool planka2Bort;

	public bool hangLockBort;

	public bool DpadlockBort;

	public bool batteryLockOk;

	public bool extremeLockOk;

	public GameObject CantopenDoorYetText;

	public GameObject gameController;

	public float counter;

	public float ELtimer;

	public bool startTimer;

	public GameObject extraLock;

	public GameObject extraLockHard;

	public GameObject extraLockExtreme;

	public bool extraLockOK;

	public bool extraLockPlaced;

	public GameObject padlockCodePL1;

	public GameObject padlockCodePL2;

	public GameObject padlockCodePL3;

	public GameObject padlockCodePL4;

	public GameObject padlockCodePL5;

	public GameObject battery1;

	public GameObject battery2;

	public GameObject battery3;

	public GameObject battery4;

	public GameObject battery5;

	public bool easyDiff;

	public bool normalDiff;

	public bool hardDiff;

	public bool extremeDiff;

	public bool practiseDiff;

	public GameObject ExtraLockOnDoorText;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (PlayerPrefs.GetInt("DiffData") == 1)
		{
			if (!easyDiff && PlayerPrefs.GetInt("twoLocksOnOff") == 1)
			{
				ExtralockTimerHard();
				extraLockExtreme.SetActive(true);
				ExtralockTimer();
				easyDiff = true;
			}
		}
		else if (PlayerPrefs.GetInt("DiffData") == 0)
		{
			if (!normalDiff)
			{
				normalDiff = true;
				if (PlayerPrefs.GetInt("twoLocksOnOff") == 1)
				{
					ExtralockTimerHard();
					extraLockExtreme.SetActive(true);
				}
				ExtralockTimer();
			}
		}
		else if (PlayerPrefs.GetInt("DiffData") == 2)
		{
			if (!hardDiff)
			{
				hardDiff = true;
				if (PlayerPrefs.GetInt("twoLocksOnOff") == 1)
				{
					extraLockExtreme.SetActive(true);
				}
				ExtralockTimer();
				ExtralockTimerHard();
			}
		}
		else if (PlayerPrefs.GetInt("DiffData") == 3)
		{
			if (!extremeDiff)
			{
				extremeDiff = true;
				ExtralockTimer();
				ExtralockTimerHard();
				extraLockExtreme.SetActive(true);
			}
		}
		else if (PlayerPrefs.GetInt("DiffData") == 4 && !practiseDiff)
		{
			practiseDiff = true;
			if (PlayerPrefs.GetInt("twoLocksOnOff") == 1)
			{
				ExtralockTimerHard();
				extraLockExtreme.SetActive(true);
			}
			ExtralockTimer();
			((Collider)Granny.gameObject.GetComponent(typeof(Collider))).enabled = false;
			((Renderer)GrannySkin.gameObject.GetComponent(typeof(Renderer))).enabled = false;
			GrannyBone.SetActive(false);
		}
	}

	public virtual IEnumerator openExitdoor()
	{
		if (PlayerPrefs.GetInt("DiffData") == 2)
		{
			if (PlayerPrefs.GetInt("twoLocksOnOff") == 1)
			{
				if (lampa1ok && lampa2ok && planka1Bort && planka2Bort && hangLockBort && extraLockPlaced && DpadlockBort && batteryLockOk && extremeLockOk)
				{
					((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = false;
					((Footsteps)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
					((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).m_WalkSpeed = 0f;
					crouchButton.SetActive(false);
					trapButton.SetActive(false);
					removeBar.fillAmount = 0f;
					trapBar.SetActive(false);
					dropObjectText.SetActive(false);
					((openDoors)dooropener.GetComponent(typeof(openDoors))).playerTaken = true;
					((PickUp)seeHolder.GetComponent(typeof(PickUp))).playerTaken = true;
					((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).openExitDoor();
					blackScreenTexture.CrossFadeAlpha(1f, 0.1f, false);
					yield return new WaitForSeconds(5f);
					SceneManager.LoadScene("EndScene");
				}
				else
				{
					CantopenDoorYetText.SetActive(true);
					((PickUp)seeHolder.GetComponent(typeof(PickUp))).textTimerOnOff = true;
					((PickUp)seeHolder.GetComponent(typeof(PickUp))).textTimer = 0f;
				}
			}
			else if (lampa1ok && lampa2ok && planka1Bort && planka2Bort && hangLockBort && extraLockPlaced && DpadlockBort && batteryLockOk)
			{
				((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = false;
				((Footsteps)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
				((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).m_WalkSpeed = 0f;
				crouchButton.SetActive(false);
				trapButton.SetActive(false);
				removeBar.fillAmount = 0f;
				trapBar.SetActive(false);
				dropObjectText.SetActive(false);
				((openDoors)dooropener.GetComponent(typeof(openDoors))).playerTaken = true;
				((PickUp)seeHolder.GetComponent(typeof(PickUp))).playerTaken = true;
				((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).openExitDoor();
				blackScreenTexture.CrossFadeAlpha(1f, 0.1f, false);
				yield return new WaitForSeconds(5f);
				SceneManager.LoadScene("EndScene");
			}
			else
			{
				CantopenDoorYetText.SetActive(true);
				((PickUp)seeHolder.GetComponent(typeof(PickUp))).textTimerOnOff = true;
				((PickUp)seeHolder.GetComponent(typeof(PickUp))).textTimer = 0f;
			}
		}
		else if (PlayerPrefs.GetInt("DiffData") == 3)
		{
			if (lampa1ok && lampa2ok && planka1Bort && planka2Bort && hangLockBort && extraLockPlaced && DpadlockBort && batteryLockOk && extremeLockOk)
			{
				((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = false;
				((Footsteps)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
				((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).m_WalkSpeed = 0f;
				crouchButton.SetActive(false);
				trapButton.SetActive(false);
				removeBar.fillAmount = 0f;
				trapBar.SetActive(false);
				dropObjectText.SetActive(false);
				((openDoors)dooropener.GetComponent(typeof(openDoors))).playerTaken = true;
				((PickUp)seeHolder.GetComponent(typeof(PickUp))).playerTaken = true;
				((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).openExitDoor();
				blackScreenTexture.CrossFadeAlpha(1f, 0.1f, false);
				yield return new WaitForSeconds(5f);
				SceneManager.LoadScene("EndScene");
			}
			else
			{
				CantopenDoorYetText.SetActive(true);
				((PickUp)seeHolder.GetComponent(typeof(PickUp))).textTimerOnOff = true;
				((PickUp)seeHolder.GetComponent(typeof(PickUp))).textTimer = 0f;
			}
		}
		else if (PlayerPrefs.GetInt("DiffData") == 1)
		{
			if (PlayerPrefs.GetInt("twoLocksOnOff") == 1)
			{
				if (lampa1ok && lampa2ok && planka1Bort && planka2Bort && hangLockBort && extraLockPlaced && DpadlockBort && batteryLockOk && extremeLockOk)
				{
					((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = false;
					((Footsteps)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
					((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).m_WalkSpeed = 0f;
					crouchButton.SetActive(false);
					trapButton.SetActive(false);
					removeBar.fillAmount = 0f;
					trapBar.SetActive(false);
					dropObjectText.SetActive(false);
					((openDoors)dooropener.GetComponent(typeof(openDoors))).playerTaken = true;
					((PickUp)seeHolder.GetComponent(typeof(PickUp))).playerTaken = true;
					((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).openExitDoor();
					blackScreenTexture.CrossFadeAlpha(1f, 0.1f, false);
					yield return new WaitForSeconds(5f);
					SceneManager.LoadScene("EndScene");
				}
				else
				{
					CantopenDoorYetText.SetActive(true);
					((PickUp)seeHolder.GetComponent(typeof(PickUp))).textTimerOnOff = true;
					((PickUp)seeHolder.GetComponent(typeof(PickUp))).textTimer = 0f;
				}
			}
			else if (lampa1ok && lampa2ok && planka1Bort && planka2Bort && hangLockBort && !extraLockPlaced)
			{
				((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = false;
				((Footsteps)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
				((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).m_WalkSpeed = 0f;
				crouchButton.SetActive(false);
				trapButton.SetActive(false);
				removeBar.fillAmount = 0f;
				trapBar.SetActive(false);
				dropObjectText.SetActive(false);
				((openDoors)dooropener.GetComponent(typeof(openDoors))).playerTaken = true;
				((PickUp)seeHolder.GetComponent(typeof(PickUp))).playerTaken = true;
				((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).openExitDoor();
				blackScreenTexture.CrossFadeAlpha(1f, 0.1f, false);
				yield return new WaitForSeconds(5f);
				SceneManager.LoadScene("EndScene");
			}
			else if (lampa1ok && lampa2ok && planka1Bort && planka2Bort && hangLockBort && extraLockPlaced && DpadlockBort)
			{
				((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = false;
				((Footsteps)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
				((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).m_WalkSpeed = 0f;
				crouchButton.SetActive(false);
				trapButton.SetActive(false);
				removeBar.fillAmount = 0f;
				trapBar.SetActive(false);
				dropObjectText.SetActive(false);
				((openDoors)dooropener.GetComponent(typeof(openDoors))).playerTaken = true;
				((PickUp)seeHolder.GetComponent(typeof(PickUp))).playerTaken = true;
				((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).openExitDoor();
				blackScreenTexture.CrossFadeAlpha(1f, 0.1f, false);
				yield return new WaitForSeconds(5f);
				SceneManager.LoadScene("EndScene");
			}
			else
			{
				CantopenDoorYetText.SetActive(true);
				((PickUp)seeHolder.GetComponent(typeof(PickUp))).textTimerOnOff = true;
				((PickUp)seeHolder.GetComponent(typeof(PickUp))).textTimer = 0f;
			}
		}
		else
		{
			if (PlayerPrefs.GetInt("DiffData") != 0 && PlayerPrefs.GetInt("DiffData") != 4)
			{
				yield break;
			}
			if (PlayerPrefs.GetInt("twoLocksOnOff") == 1)
			{
				if (lampa1ok && lampa2ok && planka1Bort && planka2Bort && hangLockBort && extraLockPlaced && DpadlockBort && batteryLockOk && extremeLockOk)
				{
					((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = false;
					((Footsteps)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
					((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).m_WalkSpeed = 0f;
					crouchButton.SetActive(false);
					trapButton.SetActive(false);
					removeBar.fillAmount = 0f;
					trapBar.SetActive(false);
					dropObjectText.SetActive(false);
					((openDoors)dooropener.GetComponent(typeof(openDoors))).playerTaken = true;
					((PickUp)seeHolder.GetComponent(typeof(PickUp))).playerTaken = true;
					((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).openExitDoor();
					blackScreenTexture.CrossFadeAlpha(1f, 0.1f, false);
					yield return new WaitForSeconds(5f);
					SceneManager.LoadScene("EndScene");
				}
				else
				{
					CantopenDoorYetText.SetActive(true);
					((PickUp)seeHolder.GetComponent(typeof(PickUp))).textTimerOnOff = true;
					((PickUp)seeHolder.GetComponent(typeof(PickUp))).textTimer = 0f;
				}
			}
			else if (lampa1ok && lampa2ok && planka1Bort && planka2Bort && hangLockBort && !extraLockPlaced)
			{
				((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = false;
				((Footsteps)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
				((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).m_WalkSpeed = 0f;
				crouchButton.SetActive(false);
				trapButton.SetActive(false);
				removeBar.fillAmount = 0f;
				trapBar.SetActive(false);
				dropObjectText.SetActive(false);
				((openDoors)dooropener.GetComponent(typeof(openDoors))).playerTaken = true;
				((PickUp)seeHolder.GetComponent(typeof(PickUp))).playerTaken = true;
				((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).openExitDoor();
				blackScreenTexture.CrossFadeAlpha(1f, 0.1f, false);
				yield return new WaitForSeconds(5f);
				SceneManager.LoadScene("EndScene");
			}
			else if (lampa1ok && lampa2ok && planka1Bort && planka2Bort && hangLockBort && extraLockPlaced && DpadlockBort)
			{
				((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = false;
				((Footsteps)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
				((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).m_WalkSpeed = 0f;
				crouchButton.SetActive(false);
				trapButton.SetActive(false);
				removeBar.fillAmount = 0f;
				trapBar.SetActive(false);
				dropObjectText.SetActive(false);
				((openDoors)dooropener.GetComponent(typeof(openDoors))).playerTaken = true;
				((PickUp)seeHolder.GetComponent(typeof(PickUp))).playerTaken = true;
				((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).openExitDoor();
				blackScreenTexture.CrossFadeAlpha(1f, 0.1f, false);
				yield return new WaitForSeconds(5f);
				SceneManager.LoadScene("EndScene");
			}
			else
			{
				CantopenDoorYetText.SetActive(true);
				((PickUp)seeHolder.GetComponent(typeof(PickUp))).textTimerOnOff = true;
				((PickUp)seeHolder.GetComponent(typeof(PickUp))).textTimer = 0f;
			}
		}
	}

	public virtual void ExtralockTimer()
	{
		extraLockPlaced = true;
		extraLock.SetActive(true);
		if (PlayerPrefs.GetInt("randomNR") == 1)
		{
			padlockCodePL2.SetActive(true);
		}
		else if (PlayerPrefs.GetInt("randomNR") == 2)
		{
			padlockCodePL3.SetActive(true);
		}
		else if (PlayerPrefs.GetInt("randomNR") == 3)
		{
			padlockCodePL4.SetActive(true);
		}
		else if (PlayerPrefs.GetInt("randomNR") == 4)
		{
			padlockCodePL5.SetActive(true);
		}
		else if (PlayerPrefs.GetInt("randomNR") == 5)
		{
			padlockCodePL1.SetActive(true);
		}
	}

	public virtual void ExtralockTimerHard()
	{
		extraLockHard.SetActive(true);
		if (PlayerPrefs.GetInt("randomNR") == 1)
		{
			battery2.SetActive(true);
		}
		else if (PlayerPrefs.GetInt("randomNR") == 2)
		{
			battery3.SetActive(true);
		}
		else if (PlayerPrefs.GetInt("randomNR") == 3)
		{
			battery4.SetActive(true);
		}
		else if (PlayerPrefs.GetInt("randomNR") == 4)
		{
			battery5.SetActive(true);
		}
		else if (PlayerPrefs.GetInt("randomNR") == 5)
		{
			battery1.SetActive(true);
		}
	}
}

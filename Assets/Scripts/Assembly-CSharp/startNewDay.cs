using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Audio;
//using UnityEngine.PostProcessing;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

[Serializable]
public class startNewDay : MonoBehaviour
{
	public float fadeBlackSpeed;

	public float fadeTextSpeed;

	public Image blackScreenTexture;

	public Image bloodscreenImage;

	public GameObject bloodscreen;

	public GameObject bloodOnBed;

	public Image day1;

	public GameObject day1Text;

	public Image day2;

	public GameObject day2Text;

	public Image day3;

	public GameObject day3Text;

	public Image day4;

	public GameObject day4Text;

	public Image day5;

	public GameObject day5Text;

	public Image day5LastDay;

	public GameObject day5LastDayText;

	public Image day6;

	public GameObject day6Text;

	public GameObject animationHolder;

	public GameObject playerInBed;

	public GameObject Player;

	public Transform playerCam;

	public GameObject playerSkalle;

	public GameObject clipPlaneHolder;

	public Transform playerHead;

	public GameObject crouchButton;

	public GameObject optionButton;

	public GameObject dropObjectText;

	public GameObject allBedButtons;

	public GameObject mittPrick;

	public GameObject Granny;

	public GameObject GrannyEye;

	public GameObject GrannyEyeColor;

	public float daysCounter;

	public GameObject doorRoom1;

	public GameObject doorRoom2;

	public GameObject doorklocka1;

	public GameObject doorklocka2;

	public GameObject gameController;

	public GameObject soundHolder;

	public GameObject soundHolder2;

	public GameObject musicHolder;

	public GameObject kliverUrBedLjud;

	public GameObject haveToLeaveText;

	public GameObject KnarrandeGolv;

	public GameObject KnarrandeGolvExtreme;

	public GameObject adsPauseContinueButton;

	public saveSensitivityData scriptC;

	public GameObject savedValue;

	public float RandomNR;

	public GameObject OP1;

	public GameObject OP1_2;

	public GameObject OP1_3;

	public GameObject OP1_4;

	public GameObject OP1_5;

	public GameObject OP1_6;

	public GameObject OP1_7;

	public GameObject OP2;

	public GameObject OP2_2;

	public GameObject OP2_3;

	public GameObject OP2_4;

	public GameObject OP2_5;

	public GameObject OP3;

	public GameObject OP3_2;

	public GameObject OP3_3;

	public GameObject OP3_4;

	public GameObject OP3_5;

	public GameObject OP3_6;

	public GameObject OP4;

	public GameObject OP4_2;

	public GameObject OP4_3;

	public GameObject OP4_4;

	public GameObject OP4_5;

	public GameObject OP4_6;

	public GameObject OP4_7;

	public GameObject OP5;

	public GameObject OP5_2;

	public GameObject OP5_3;

	public GameObject OP5_4;

	public GameObject OP5_5;

	public GameObject OP5_6;

	public GameObject OP5_7;

	public float RandomNRTavelbitar;

	public GameObject tavla;

	public GameObject tavelbitar;

	public bool tavelbit1;

	public bool tavelbit2;

	public bool tavelbit3;

	public bool tavelbit4;

	public bool allaTavelbitarOnPlace;

	public GameObject playerGetExtraDay;

	public GameObject tavelBitPlace1;

	public GameObject tavelBitPlace2;

	public GameObject tavelBitPlace3;

	public GameObject Teddy;

	public Transform TeddyPos;

	public bool slendrinaAppeard;

	public bool slendrinaMomAppeard;

	public GameObject bokhyllaClose;

	public GameObject GrannyMessage;

	public GameObject allTexts;

	//public PostProcessingProfile CC;

	private bool frameBlendingOn;

	private float FBtimer = 15f;

	public AudioMixer audioMixer;

	public virtual IEnumerator Start()
	{
		Cursor.visible = false;
		if (PlayerPrefs.GetInt("EffectsOnOff") == 1)
		{
			//CC.ambientOcclusion.enabled = true;
			//CC.depthOfField.enabled = true;
			//CC.motionBlur.enabled = true;
			//CC.colorGrading.enabled = true;
			//MotionBlurModel.Settings settings = CC.motionBlur.settings;
			//settings.frameBlending = 0f;
			//CC.motionBlur.settings = settings;
		}
		else if (PlayerPrefs.GetInt("EffectsOnOff") == 0)
		{
			//CC.ambientOcclusion.enabled = false;
			//CC.depthOfField.enabled = false;
			//CC.motionBlur.enabled = false;
			//CC.chromaticAberration.enabled = false;
		}
		if (PlayerPrefs.GetInt("DiffData") == 0)
		{
			KnarrandeGolv.SetActive(true);
			tavla.SetActive(true);
			RandomNRTavelbitar = UnityEngine.Random.Range(1, 4);
			if (RandomNRTavelbitar == 1f)
			{
				tavelBitPlace1.SetActive(true);
			}
			else if (RandomNRTavelbitar == 2f)
			{
				tavelBitPlace2.SetActive(true);
			}
			else if (RandomNRTavelbitar == 3f)
			{
				tavelBitPlace3.SetActive(true);
			}
		}
		else if (PlayerPrefs.GetInt("DiffData") == 1)
		{
			KnarrandeGolv.SetActive(false);
			tavla.SetActive(true);
			RandomNRTavelbitar = UnityEngine.Random.Range(1, 4);
			if (RandomNRTavelbitar == 1f)
			{
				tavelBitPlace1.SetActive(true);
			}
			else if (RandomNRTavelbitar == 2f)
			{
				tavelBitPlace2.SetActive(true);
			}
			else if (RandomNRTavelbitar == 3f)
			{
				tavelBitPlace3.SetActive(true);
			}
		}
		else if (PlayerPrefs.GetInt("DiffData") == 2)
		{
			KnarrandeGolv.SetActive(true);
		}
		else if (PlayerPrefs.GetInt("DiffData") == 3)
		{
			KnarrandeGolvExtreme.SetActive(true);
			KnarrandeGolv.SetActive(false);
		}
		else if (PlayerPrefs.GetInt("DiffData") == 4)
		{
			KnarrandeGolv.SetActive(true);
			tavla.SetActive(true);
			GrannyMessage.SetActive(true);
			RandomNRTavelbitar = UnityEngine.Random.Range(1, 4);
			if (RandomNRTavelbitar == 1f)
			{
				tavelBitPlace1.SetActive(true);
			}
			else if (RandomNRTavelbitar == 2f)
			{
				tavelBitPlace2.SetActive(true);
			}
			else if (RandomNRTavelbitar == 3f)
			{
				tavelBitPlace3.SetActive(true);
			}
		}
		if (PlayerPrefs.GetInt("randomNR") == 0)
		{
			RandomNR = UnityEngine.Random.Range(1, 6);
			if (RandomNR == 1f)
			{
				OP1.SetActive(true);
				OP1_2.SetActive(true);
				OP1_3.SetActive(true);
				OP1_4.SetActive(true);
				OP1_5.SetActive(true);
				OP1_6.SetActive(true);
				OP1_7.SetActive(true);
				PlayerPrefs.SetInt("randomNR", 1);
			}
			else if (RandomNR == 2f)
			{
				OP2.SetActive(true);
				OP2_2.SetActive(true);
				OP2_3.SetActive(true);
				OP2_4.SetActive(true);
				OP2_5.SetActive(true);
				PlayerPrefs.SetInt("randomNR", 2);
			}
			else if (RandomNR == 3f)
			{
				OP3.SetActive(true);
				OP3_2.SetActive(true);
				OP3_3.SetActive(true);
				OP3_4.SetActive(true);
				OP3_5.SetActive(true);
				OP3_6.SetActive(true);
				PlayerPrefs.SetInt("randomNR", 3);
			}
			else if (RandomNR == 4f)
			{
				OP4.SetActive(true);
				OP4_2.SetActive(true);
				OP4_3.SetActive(true);
				OP4_4.SetActive(true);
				OP4_5.SetActive(true);
				OP4_6.SetActive(true);
				OP4_7.SetActive(true);
				PlayerPrefs.SetInt("randomNR", 4);
			}
			else if (RandomNR == 5f)
			{
				OP5.SetActive(true);
				OP5_2.SetActive(true);
				OP5_3.SetActive(true);
				OP5_4.SetActive(true);
				OP5_5.SetActive(true);
				OP5_6.SetActive(true);
				OP5_7.SetActive(true);
				PlayerPrefs.SetInt("randomNR", 5);
			}
		}
		else if (PlayerPrefs.GetInt("randomNR") == 1)
		{
			OP1.SetActive(true);
			OP1_2.SetActive(true);
			OP1_3.SetActive(true);
			OP1_4.SetActive(true);
			OP1_5.SetActive(true);
			OP1_6.SetActive(true);
			OP1_7.SetActive(true);
			PlayerPrefs.SetInt("randomNR", 2);
		}
		else if (PlayerPrefs.GetInt("randomNR") == 2)
		{
			OP2.SetActive(true);
			OP2_2.SetActive(true);
			OP2_3.SetActive(true);
			OP2_4.SetActive(true);
			OP2_5.SetActive(true);
			PlayerPrefs.SetInt("randomNR", 3);
		}
		else if (PlayerPrefs.GetInt("randomNR") == 3)
		{
			OP3.SetActive(true);
			OP3_2.SetActive(true);
			OP3_3.SetActive(true);
			OP3_4.SetActive(true);
			OP3_5.SetActive(true);
			OP3_6.SetActive(true);
			PlayerPrefs.SetInt("randomNR", 4);
		}
		else if (PlayerPrefs.GetInt("randomNR") == 4)
		{
			OP4.SetActive(true);
			OP4_2.SetActive(true);
			OP4_3.SetActive(true);
			OP4_4.SetActive(true);
			OP4_5.SetActive(true);
			OP4_6.SetActive(true);
			OP4_7.SetActive(true);
			PlayerPrefs.SetInt("randomNR", 5);
		}
		else if (PlayerPrefs.GetInt("randomNR") == 5)
		{
			OP5.SetActive(true);
			OP5_2.SetActive(true);
			OP5_3.SetActive(true);
			OP5_4.SetActive(true);
			OP5_5.SetActive(true);
			OP5_6.SetActive(true);
			OP5_7.SetActive(true);
			PlayerPrefs.SetInt("randomNR", 1);
		}
		if (daysCounter == 0f)
		{
			daysCounter = 1f;
		}
		yield return new WaitForSeconds(5f);
		((SoundEffectsPlayerInBed)soundHolder.GetComponent(typeof(SoundEffectsPlayerInBed))).startTextSound();
		yield return StartCoroutine(FadeText1(0f, 1f, 2f));
		yield return new WaitForSeconds(2f);
		fadeTextSpeed = 1f;
		((backgroundSound)soundHolder2.GetComponent(typeof(backgroundSound))).fadeUp = true;
		yield return StartCoroutine(FadeText1(1f, 0f, 2f));
		day1Text.SetActive(false);
		animationHolder.GetComponent<Animation>().CrossFade("PlayerInBed");
		kliverUrBedLjud.SetActive(true);
		if (PlayerPrefs.GetInt("musikOnOff") == 0)
		{
			musicHolder.GetComponent<AudioSource>().Play();
		}
		blackScreenTexture.CrossFadeAlpha(0f, 6f, false);
		yield return new WaitForSeconds(11f);
		playerInBed.SetActive(false);
		Player.SetActive(true);
		crouchButton.SetActive(true);
		optionButton.SetActive(true);
		((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = true;
		mittPrick.SetActive(true);
		kliverUrBedLjud.SetActive(false);
		Cursor.visible = false;
		Screen.lockCursor = true;
	}

	public virtual void Update()
	{
		if (!allaTavelbitarOnPlace && tavelbit1 && tavelbit2 && tavelbit3 && tavelbit4)
		{
			allaTavelbitarOnPlace = true;
			((GrannyGoneText)playerGetExtraDay.GetComponent(typeof(GrannyGoneText))).textOnOff = true;
		}
		if (frameBlendingOn)
		{
			FBtimer -= Time.deltaTime;
			if (FBtimer <= 5f)
			{
				//MotionBlurModel.Settings settings = CC.motionBlur.settings;
				//settings.frameBlending -= Time.deltaTime * 0.1f;
				//CC.motionBlur.settings = settings;
			}
			if (FBtimer <= 0f)
			{
				frameBlendingOn = false;
				//MotionBlurModel.Settings settings2 = CC.motionBlur.settings;
				//settings2.frameBlending = 0f;
				//CC.motionBlur.settings = settings2;
				FBtimer = 15f;
			}
		}
	}

	public virtual IEnumerator FadeText1(float startLevel, float endLevel, float duration)
	{
		for (float t = 0f; t < 1f; t += Time.deltaTime * fadeTextSpeed)
		{
			float a = Mathf.Lerp(startLevel, endLevel, t);
			Color color = day1.color;
			color.a = a;
			day1.color = color;
			yield return null;
		}
	}

	public virtual IEnumerator FadeText2(float startLevel, float endLevel, float duration)
	{
		for (float t = 0f; t < 1f; t += Time.deltaTime * fadeTextSpeed)
		{
			float a = Mathf.Lerp(startLevel, endLevel, t);
			Color color = day2.color;
			color.a = a;
			day2.color = color;
			yield return null;
		}
	}

	public virtual IEnumerator FadeText3(float startLevel, float endLevel, float duration)
	{
		for (float t = 0f; t < 1f; t += Time.deltaTime * fadeTextSpeed)
		{
			float a = Mathf.Lerp(startLevel, endLevel, t);
			Color color = day3.color;
			color.a = a;
			day3.color = color;
			yield return null;
		}
	}

	public virtual IEnumerator FadeText4(float startLevel, float endLevel, float duration)
	{
		for (float t = 0f; t < 1f; t += Time.deltaTime * fadeTextSpeed)
		{
			float a = Mathf.Lerp(startLevel, endLevel, t);
			Color color = day4.color;
			color.a = a;
			day4.color = color;
			yield return null;
		}
	}

	public virtual IEnumerator FadeText5(float startLevel, float endLevel, float duration)
	{
		for (float t = 0f; t < 1f; t += Time.deltaTime * fadeTextSpeed)
		{
			float a = Mathf.Lerp(startLevel, endLevel, t);
			Color color = day5.color;
			color.a = a;
			day5.color = color;
			yield return null;
		}
	}

	public virtual IEnumerator FadeText5LD(float startLevel, float endLevel, float duration)
	{
		for (float t = 0f; t < 1f; t += Time.deltaTime * fadeTextSpeed)
		{
			float a = Mathf.Lerp(startLevel, endLevel, t);
			Color color = day5LastDay.color;
			color.a = a;
			day5LastDay.color = color;
			yield return null;
		}
	}

	public virtual IEnumerator FadeText6(float startLevel, float endLevel, float duration)
	{
		for (float t = 0f; t < 1f; t += Time.deltaTime * fadeTextSpeed)
		{
			float a = Mathf.Lerp(startLevel, endLevel, t);
			Color color = day6.color;
			color.a = a;
			day6.color = color;
			yield return null;
		}
	}

	public virtual IEnumerator newDay()
	{
		daysCounter += 1f;
		if (daysCounter == 2f)
		{
			if (PlayerPrefs.GetInt("EffectsOnOff") == 1)
			{
				//MotionBlurModel.Settings settings = CC.motionBlur.settings;
				//settings.frameBlending = 1f;
				//CC.motionBlur.settings = settings;
				frameBlendingOn = true;
			}
			dropObjectText.SetActive(false);
			fadeTextSpeed = 3f;
			((SoundEffectsPlayerInBed)soundHolder.GetComponent(typeof(SoundEffectsPlayerInBed))).startTextSound();
			yield return StartCoroutine(FadeText2(0f, 1f, 2f));
			yield return new WaitForSeconds(2f);
			if (!slendrinaAppeard && (bool)GameObject.Find("Teddy(Clone)"))
			{
				UnityEngine.Object.Destroy(GameObject.Find("Teddy(Clone)"));
				UnityEngine.Object.Instantiate(Teddy, TeddyPos.position, TeddyPos.rotation);
				yield return new WaitForSeconds(0.5f);
				GameObject.Find("Teddy(Clone)").transform.name = "Teddy";
			}
			fadeTextSpeed = 1f;
			((backgroundSound)soundHolder2.GetComponent(typeof(backgroundSound))).fadeUp = true;
			yield return StartCoroutine(FadeText2(1f, 0f, 2f));
			day2Text.SetActive(false);
			((Footsteps)playerSkalle.GetComponent(typeof(Footsteps))).playerCrouching = false;
			if (PlayerPrefs.GetInt("DiffData") != 4)
			{
				doorRoom1.gameObject.tag = "innerdoorLocked";
			}
			animationHolder.GetComponent<Animation>().CrossFade("PlayerInBed2");
			animationHolder.GetComponent<Animation>()["PlayerInBed"].speed = 1f;
			kliverUrBedLjud.SetActive(true);
			blackScreenTexture.CrossFadeAlpha(0f, 6f, false);
			yield return new WaitForSeconds(11f);
			playerInBed.SetActive(false);
			Player.SetActive(true);
			haveToLeaveText.SetActive(true);
			GameObject.Find("CameraPivot").GetComponent<Footsteps>().day2 = true;
			GameObject.Find("CameraPivot").GetComponent<Footsteps>().playerDie = false;
			crouchButton.SetActive(true);
			optionButton.SetActive(true);
			allBedButtons.SetActive(true);
			((FirstPersonController_Egen)Player.GetComponent(typeof(FirstPersonController_Egen))).playerGetCaught = false;
			((FirstPersonController_Egen)Player.GetComponent(typeof(FirstPersonController_Egen))).playerInhole = false;
			playerCam.transform.localEulerAngles = new Vector3(0f, 0f, 0f);
			Player.transform.localEulerAngles = new Vector3(0f, -90f, 0f);
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = true;
			((EnemyEye)GrannyEye.GetComponent(typeof(EnemyEye))).seeRange = 200f;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).timerBed = 0f;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerNearGranny = false;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
			GrannyEyeColor.gameObject.GetComponent<Renderer>().material.color = new Color(0.1509434f, 0.1509434f, 0.1509434f);
			mittPrick.SetActive(true);
			kliverUrBedLjud.SetActive(false);
			Cursor.visible = false;
			Screen.lockCursor = true;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHiding = false;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).grannyInBastu = false;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).bastuTimer = 15f;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).bastuDoorTimer = 20f;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).bastuTimeOff = false;
			if (slendrinaMomAppeard)
			{
				bokhyllaClose.GetComponent<Animation>().Play("BookShelfClose");
			}
		}
		else if (daysCounter == 3f)
		{
			yield return new WaitForSeconds(1f);
			if (PlayerPrefs.GetInt("EffectsOnOff") == 1)
			{
				//MotionBlurModel.Settings settings2 = CC.motionBlur.settings;
				//settings2.frameBlending = 1f;
				//CC.motionBlur.settings = settings2;
				frameBlendingOn = true;
			}
			dropObjectText.SetActive(false);
			fadeTextSpeed = 3f;
			((SoundEffectsPlayerInBed)soundHolder.GetComponent(typeof(SoundEffectsPlayerInBed))).startTextSound();
			yield return StartCoroutine(FadeText3(0f, 1f, 2f));
			yield return new WaitForSeconds(2f);
			if (!slendrinaAppeard && (bool)GameObject.Find("Teddy(Clone)"))
			{
				UnityEngine.Object.Destroy(GameObject.Find("Teddy(Clone)"));
				UnityEngine.Object.Instantiate(Teddy, TeddyPos.position, TeddyPos.rotation);
				yield return new WaitForSeconds(0.5f);
				GameObject.Find("Teddy(Clone)").transform.name = "Teddy";
			}
			fadeTextSpeed = 1f;
			((backgroundSound)soundHolder2.GetComponent(typeof(backgroundSound))).fadeUp = true;
			yield return StartCoroutine(FadeText3(1f, 0f, 2f));
			day3Text.SetActive(false);
			((Footsteps)playerSkalle.GetComponent(typeof(Footsteps))).playerCrouching = false;
			if (PlayerPrefs.GetInt("DiffData") != 4)
			{
				doorRoom2.gameObject.tag = "innerdoorLocked";
			}
			animationHolder.GetComponent<Animation>().CrossFade("PlayerInBed3");
			animationHolder.GetComponent<Animation>()["PlayerInBed"].speed = 1f;
			kliverUrBedLjud.SetActive(true);
			blackScreenTexture.CrossFadeAlpha(0f, 6f, false);
			yield return new WaitForSeconds(11f);
			playerInBed.SetActive(false);
			Player.SetActive(true);
			GameObject.Find("CameraPivot").GetComponent<Footsteps>().day2 = false;
			GameObject.Find("CameraPivot").GetComponent<Footsteps>().day3 = true;
			GameObject.Find("CameraPivot").GetComponent<Footsteps>().playerDie = false;
			crouchButton.SetActive(true);
			optionButton.SetActive(true);
			allBedButtons.SetActive(true);
			((FirstPersonController_Egen)Player.GetComponent(typeof(FirstPersonController_Egen))).playerGetCaught = false;
			((FirstPersonController_Egen)Player.GetComponent(typeof(FirstPersonController_Egen))).playerInhole = false;
			playerCam.transform.localEulerAngles = new Vector3(0f, 0f, 0f);
			Player.transform.localEulerAngles = new Vector3(0f, -90f, 0f);
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = true;
			((EnemyEye)GrannyEye.GetComponent(typeof(EnemyEye))).seeRange = 200f;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).timerBed = 0f;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerNearGranny = false;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
			GrannyEyeColor.gameObject.GetComponent<Renderer>().material.color = new Color(0.1509434f, 0.1509434f, 0.1509434f);
			mittPrick.SetActive(true);
			kliverUrBedLjud.SetActive(false);
			Cursor.visible = false;
			Screen.lockCursor = true;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHiding = false;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).grannyInBastu = false;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).bastuTimer = 15f;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).bastuDoorTimer = 20f;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).bastuTimeOff = false;
			if (slendrinaMomAppeard)
			{
				bokhyllaClose.GetComponent<Animation>().Play("BookShelfClose");
			}
			AudioListener.pause = false;
			Time.timeScale = 1f;
		}
		else if (daysCounter == 4f)
		{
			if (PlayerPrefs.GetInt("EffectsOnOff") == 1)
			{
				//MotionBlurModel.Settings settings3 = CC.motionBlur.settings;
				//settings3.frameBlending = 1f;
				//CC.motionBlur.settings = settings3;
				frameBlendingOn = true;
			}
			dropObjectText.SetActive(false);
			fadeTextSpeed = 3f;
			((SoundEffectsPlayerInBed)soundHolder.GetComponent(typeof(SoundEffectsPlayerInBed))).startTextSound();
			yield return StartCoroutine(FadeText4(0f, 1f, 2f));
			yield return new WaitForSeconds(2f);
			if (!slendrinaAppeard && (bool)GameObject.Find("Teddy(Clone)"))
			{
				UnityEngine.Object.Destroy(GameObject.Find("Teddy(Clone)"));
				UnityEngine.Object.Instantiate(Teddy, TeddyPos.position, TeddyPos.rotation);
				yield return new WaitForSeconds(0.5f);
				GameObject.Find("Teddy(Clone)").transform.name = "Teddy";
			}
			fadeTextSpeed = 1f;
			((backgroundSound)soundHolder2.GetComponent(typeof(backgroundSound))).fadeUp = true;
			yield return StartCoroutine(FadeText4(1f, 0f, 2f));
			day4Text.SetActive(false);
			((Footsteps)playerSkalle.GetComponent(typeof(Footsteps))).playerCrouching = false;
			animationHolder.GetComponent<Animation>().CrossFade("PlayerInBed2");
			animationHolder.GetComponent<Animation>()["PlayerInBed"].speed = 1f;
			kliverUrBedLjud.SetActive(true);
			bloodscreen.SetActive(true);
			bloodscreenImage.canvasRenderer.SetAlpha(0.5f);
			bloodOnBed.SetActive(true);
			blackScreenTexture.CrossFadeAlpha(0f, 6f, false);
			yield return new WaitForSeconds(11f);
			playerInBed.SetActive(false);
			Player.SetActive(true);
			crouchButton.SetActive(true);
			optionButton.SetActive(true);
			allBedButtons.SetActive(true);
			GameObject.Find("CameraPivot").GetComponent<Footsteps>().playerDie = false;
			((FirstPersonController_Egen)Player.GetComponent(typeof(FirstPersonController_Egen))).playerGetCaught = false;
			((FirstPersonController_Egen)Player.GetComponent(typeof(FirstPersonController_Egen))).playerInhole = false;
			playerCam.transform.localEulerAngles = new Vector3(0f, 0f, 0f);
			Player.transform.localEulerAngles = new Vector3(0f, -90f, 0f);
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = true;
			((EnemyEye)GrannyEye.GetComponent(typeof(EnemyEye))).seeRange = 200f;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).timerBed = 0f;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerNearGranny = false;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
			GrannyEyeColor.gameObject.GetComponent<Renderer>().material.color = new Color(0.1509434f, 0.1509434f, 0.1509434f);
			mittPrick.SetActive(true);
			kliverUrBedLjud.SetActive(false);
			Cursor.visible = false;
			Screen.lockCursor = true;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHiding = false;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).grannyInBastu = false;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).bastuTimer = 15f;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).bastuDoorTimer = 20f;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).bastuTimeOff = false;
			if (slendrinaMomAppeard)
			{
				bokhyllaClose.GetComponent<Animation>().Play("BookShelfClose");
			}
		}
		else if (daysCounter == 5f)
		{
			if (PlayerPrefs.GetInt("EffectsOnOff") == 1)
			{
				//MotionBlurModel.Settings settings4 = CC.motionBlur.settings;
				//settings4.frameBlending = 1f;
				//CC.motionBlur.settings = settings4;
				frameBlendingOn = true;
			}
			dropObjectText.SetActive(false);
			((Footsteps)playerSkalle.GetComponent(typeof(Footsteps))).playerCrouching = false;
			fadeTextSpeed = 3f;
			((SoundEffectsPlayerInBed)soundHolder.GetComponent(typeof(SoundEffectsPlayerInBed))).startTextSound();
			if (PlayerPrefs.GetInt("DiffData") == 2 || PlayerPrefs.GetInt("DiffData") == 3)
			{
				yield return StartCoroutine(FadeText5LD(0f, 1f, 2f));
				yield return new WaitForSeconds(2f);
				fadeTextSpeed = 1f;
				((backgroundSound)soundHolder2.GetComponent(typeof(backgroundSound))).fadeUp = true;
				yield return StartCoroutine(FadeText5LD(1f, 0f, 2f));
				day5LastDayText.SetActive(false);
			}
			else if (tavelbit1 && tavelbit2 && tavelbit3 && tavelbit4)
			{
				yield return StartCoroutine(FadeText5(0f, 1f, 2f));
				yield return new WaitForSeconds(2f);
				fadeTextSpeed = 1f;
				((backgroundSound)soundHolder2.GetComponent(typeof(backgroundSound))).fadeUp = true;
				yield return StartCoroutine(FadeText5(1f, 0f, 2f));
				day5Text.SetActive(false);
			}
			else
			{
				yield return StartCoroutine(FadeText5LD(0f, 1f, 2f));
				yield return new WaitForSeconds(2f);
				fadeTextSpeed = 1f;
				((backgroundSound)soundHolder2.GetComponent(typeof(backgroundSound))).fadeUp = true;
				yield return StartCoroutine(FadeText5LD(1f, 0f, 2f));
				day5LastDayText.SetActive(false);
			}
			if (!slendrinaAppeard && (bool)GameObject.Find("Teddy(Clone)"))
			{
				UnityEngine.Object.Destroy(GameObject.Find("Teddy(Clone)"));
				UnityEngine.Object.Instantiate(Teddy, TeddyPos.position, TeddyPos.rotation);
				yield return new WaitForSeconds(0.5f);
				GameObject.Find("Teddy(Clone)").transform.name = "Teddy";
			}
			animationHolder.GetComponent<Animation>().CrossFade("PlayerInBed");
			animationHolder.GetComponent<Animation>()["PlayerInBed"].speed = 1f;
			kliverUrBedLjud.SetActive(true);
			blackScreenTexture.CrossFadeAlpha(0f, 6f, false);
			yield return new WaitForSeconds(11f);
			playerInBed.SetActive(false);
			Player.SetActive(true);
			crouchButton.SetActive(true);
			optionButton.SetActive(true);
			allBedButtons.SetActive(true);
			GameObject.Find("CameraPivot").GetComponent<Footsteps>().playerDie = false;
			((FirstPersonController_Egen)Player.GetComponent(typeof(FirstPersonController_Egen))).playerGetCaught = false;
			((FirstPersonController_Egen)Player.GetComponent(typeof(FirstPersonController_Egen))).playerInhole = false;
			playerCam.transform.localEulerAngles = new Vector3(0f, 0f, 0f);
			Player.transform.localEulerAngles = new Vector3(0f, -90f, 0f);
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = true;
			((EnemyEye)GrannyEye.GetComponent(typeof(EnemyEye))).seeRange = 200f;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).timerBed = 0f;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerNearGranny = false;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
			GrannyEyeColor.gameObject.GetComponent<Renderer>().material.color = new Color(0.1509434f, 0.1509434f, 0.1509434f);
			mittPrick.SetActive(true);
			kliverUrBedLjud.SetActive(false);
			Cursor.visible = false;
			Screen.lockCursor = true;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHiding = false;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).grannyInBastu = false;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).bastuTimer = 15f;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).bastuDoorTimer = 20f;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).bastuTimeOff = false;
			if (slendrinaMomAppeard)
			{
				bokhyllaClose.GetComponent<Animation>().Play("BookShelfClose");
			}
		}
		else if (daysCounter == 6f)
		{
			if (PlayerPrefs.GetInt("EffectsOnOff") == 1)
			{
				//MotionBlurModel.Settings settings5 = CC.motionBlur.settings;
				//settings5.frameBlending = 1f;
				//CC.motionBlur.settings = settings5;
				frameBlendingOn = true;
			}
			dropObjectText.SetActive(false);
			((Footsteps)playerSkalle.GetComponent(typeof(Footsteps))).playerCrouching = false;
			if (tavelbit1 && tavelbit2 && tavelbit3 && tavelbit4)
			{
				fadeTextSpeed = 3f;
				((SoundEffectsPlayerInBed)soundHolder.GetComponent(typeof(SoundEffectsPlayerInBed))).startTextSound();
				yield return StartCoroutine(FadeText6(0f, 1f, 2f));
				yield return new WaitForSeconds(2f);
				if (!slendrinaAppeard && (bool)GameObject.Find("Teddy(Clone)"))
				{
					UnityEngine.Object.Destroy(GameObject.Find("Teddy(Clone)"));
					UnityEngine.Object.Instantiate(Teddy, TeddyPos.position, TeddyPos.rotation);
					yield return new WaitForSeconds(0.5f);
					GameObject.Find("Teddy(Clone)").transform.name = "Teddy";
				}
				fadeTextSpeed = 1f;
				((backgroundSound)soundHolder2.GetComponent(typeof(backgroundSound))).fadeUp = true;
				yield return StartCoroutine(FadeText6(1f, 0f, 2f));
				day6Text.SetActive(false);
				animationHolder.GetComponent<Animation>().CrossFade("PlayerInBed2");
				animationHolder.GetComponent<Animation>()["PlayerInBed"].speed = 1f;
				kliverUrBedLjud.SetActive(true);
				bloodscreen.SetActive(true);
				bloodOnBed.SetActive(true);
				blackScreenTexture.CrossFadeAlpha(0f, 6f, false);
				yield return new WaitForSeconds(11f);
				playerInBed.SetActive(false);
				Player.SetActive(true);
				crouchButton.SetActive(true);
				optionButton.SetActive(true);
				allBedButtons.SetActive(true);
				GameObject.Find("CameraPivot").GetComponent<Footsteps>().playerDie = false;
				((FirstPersonController_Egen)Player.GetComponent(typeof(FirstPersonController_Egen))).playerGetCaught = false;
				((FirstPersonController_Egen)Player.GetComponent(typeof(FirstPersonController_Egen))).playerInhole = false;
				playerCam.transform.localEulerAngles = new Vector3(0f, 0f, 0f);
				Player.transform.localEulerAngles = new Vector3(0f, -90f, 0f);
				((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = true;
				((EnemyEye)GrannyEye.GetComponent(typeof(EnemyEye))).seeRange = 200f;
				((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).timerBed = 0f;
				((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerNearGranny = false;
				((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
				GrannyEyeColor.gameObject.GetComponent<Renderer>().material.color = new Color(0.1509434f, 0.1509434f, 0.1509434f);
				mittPrick.SetActive(true);
				kliverUrBedLjud.SetActive(false);
				Cursor.visible = false;
				Screen.lockCursor = true;
				((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHiding = false;
				((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).grannyInBastu = false;
				((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).bastuTimer = 15f;
				((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).bastuDoorTimer = 20f;
				((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).bastuTimeOff = false;
				if (slendrinaMomAppeard)
				{
					bokhyllaClose.GetComponent<Animation>().Play("BookShelfClose");
				}
			}
			else if (PlayerPrefs.GetInt("DiffData") == 4)
			{
				StartCoroutine(((playerDead)gameController.GetComponent(typeof(playerDead))).gameOverNoGranny());
			}
			else if (PlayerPrefs.GetInt("DiffGOsceneData") == 0)
			{
				PlayerPrefs.SetInt("DiffGOsceneData", 1);
				StartCoroutine(((playerDead)gameController.GetComponent(typeof(playerDead))).startEndScene());
			}
			else if (PlayerPrefs.GetInt("DiffGOsceneData") == 1)
			{
				PlayerPrefs.SetInt("DiffGOsceneData", 0);
				StartCoroutine(((playerDead)gameController.GetComponent(typeof(playerDead))).startEndScene2());
			}
			else
			{
				PlayerPrefs.SetInt("DiffGOsceneData", 1);
				StartCoroutine(((playerDead)gameController.GetComponent(typeof(playerDead))).startEndScene());
			}
		}
		else if (daysCounter == 7f)
		{
			if (PlayerPrefs.GetInt("DiffData") == 4)
			{
				StartCoroutine(((playerDead)gameController.GetComponent(typeof(playerDead))).gameOverNoGranny());
			}
			else if (PlayerPrefs.GetInt("DiffGOsceneData") == 0)
			{
				PlayerPrefs.SetInt("DiffGOsceneData", 1);
				StartCoroutine(((playerDead)gameController.GetComponent(typeof(playerDead))).startEndScene());
			}
			else if (PlayerPrefs.GetInt("DiffGOsceneData") == 1)
			{
				PlayerPrefs.SetInt("DiffGOsceneData", 0);
				StartCoroutine(((playerDead)gameController.GetComponent(typeof(playerDead))).startEndScene2());
			}
			else
			{
				PlayerPrefs.SetInt("DiffGOsceneData", 1);
				StartCoroutine(((playerDead)gameController.GetComponent(typeof(playerDead))).startEndScene());
			}
		}
	}
}

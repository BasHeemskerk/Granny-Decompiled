using System;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

[Serializable]
public class PickUp : MonoBehaviour
{
	public GameObject Granny;

	public GameObject player;

	public Transform GrannyStartPos;

	public GameObject SeeRay;

	public int layerMask;

	public bool playerTaken;

	public bool pickUp;

	public bool dropObject;

	public bool placeObject;

	public bool readyPickUp;

	public GameObject dropPoint;

	public GameObject dropPointPlanka;

	public GameObject dropObjectButton;

	public GameObject placeObjectButton;

	public GameObject soundHolder;

	public GameObject mittenRing;

	public GameObject avklipptKabelCellar;

	public GameObject avklipptKabelVind;

	public GameObject KabelVind;

	public GameObject avklipptKabel;

	public GameObject fan;

	public GameObject fanCollider;

	public bool playSound;

	public AudioClip klippKabel;

	public AudioClip taBortPlanka;

	public AudioClip doorLocked;

	public AudioClip safeDoordoorLocked;

	public AudioClip safeDoorOpen;

	public AudioClip vapenDoorOpen;

	public AudioClip hitCam;

	public AudioClip plockaUppObject;

	public AudioClip plockaUppNyckel;

	public AudioClip plockaUppCrossbow;

	public AudioClip placeBattery;

	public AudioClip pickUpTeddy;

	public AudioClip placebrunnsvev;

	public AudioClip placeMelon;

	public AudioClip drarIspak;

	public AudioClip meatPlate;

	public AudioClip vind2Dooropen;

	public AudioClip vind2Lockopen;

	public AudioClip pickUpGascan;

	public AudioClip skruva;

	public GameObject LampaDoor1;

	public GameObject LampaDoor2;

	public GameObject gameController;

	public GameObject doorRayHolder;

	public GameObject Bom;

	public GameObject DdoorLock;

	public GameObject arrowButton;

	public GameObject arrowArmborst;

	public GameObject Armborstladdad;

	public GameObject ArmborstOladdad;

	public bool armborstArrowOK;

	public GameObject avbitare;

	public Transform newAvbitare;

	public bool haveAvbitare;

	public GameObject hammare;

	public Transform newHammare;

	public bool haveHammare;

	public GameObject vas;

	public Transform newvas;

	public bool havevas;

	public GameObject vas2;

	public Transform newvas2;

	public bool havevas2;

	public GameObject safeKey;

	public Transform newsafeKey;

	public bool havesafeKey;

	public GameObject exitKey;

	public Transform newexitKey;

	public bool haveexitKey;

	public GameObject hanglockKey;

	public Transform newhanglockKey;

	public bool havehanglockKey;

	public GameObject padlockCode;

	public Transform newpadlockCode;

	public bool havepadlockCode;

	public GameObject armborst;

	public Transform newarmborst;

	public bool havearmborst;

	public Transform newArrow;

	public bool haveArrow;

	public GameObject shootArrowRay;

	public GameObject weaponKey;

	public Transform newweaponKey;

	public bool haveweaponKey;

	public GameObject screwdriver;

	public Transform newscrewdriver;

	public bool havescrewdriver;

	public GameObject planka;

	public Transform newplanka;

	public bool haveplanka;

	public GameObject battery;

	public Transform newbattery;

	public bool havebattery;

	public GameObject playhouseKey;

	public Transform newplayhouseKey;

	public bool haveplayhouseKey;

	public GameObject carKey;

	public Transform newcarKey;

	public bool havecarKey;

	public GameObject melon;

	public Transform newmelon;

	public bool havemelon;

	public GameObject teddy;

	public Transform newteddy;

	public bool haveteddy;

	public GameObject kugg1;

	public Transform newkugg1;

	public bool havekugg1;

	public GameObject kugg2;

	public Transform newkugg2;

	public bool havekugg2;

	public GameObject message;

	public Transform newmessage;

	public bool havemessage;

	public GameObject brunnsvev;

	public Transform newbrunnsvev;

	public bool havebrunnsvev;

	public GameObject oldShotgun;

	public GameObject oldShotgunAnim;

	public Transform newoldShotgun;

	public bool haveoldShotgun;

	public bool oldShotgunLoaded;

	public GameObject shootButton;

	public GameObject shootRay;

	public GameObject ammo;

	public GameObject gunDel1;

	public Transform newgunDel1;

	public bool havegunDel1;

	public GameObject gunDel2;

	public Transform newgunDel2;

	public bool havegunDel2;

	public GameObject gunDel3;

	public Transform newgunDel3;

	public bool havegunDel3;

	public GameObject topplock;

	public Transform newtopplock;

	public bool havetopplock;

	public GameObject topplockInPlace;

	public GameObject carbattery;

	public Transform newcarbattery;

	public bool havecarbattery;

	public GameObject carbatteryInPlace;

	public GameObject gascan;

	public Transform newgascan;

	public bool havegascan;

	public GameObject wrench;

	public Transform newwrench;

	public bool havewrench;

	public GameObject sparkplug;

	public Transform newsparkplug;

	public bool havesparkplug;

	public GameObject sparkPlugInPlace;

	public GameObject sparkPlugCable;

	public GameObject meat;

	public Transform newmeat;

	public bool havemeat;

	public GameObject spider;

	public GameObject meatOnPlate;

	public GameObject spiderTrigger;

	public GameObject specialkey;

	public Transform newspecialkey;

	public bool havespecialkey;

	public GameObject specialkeyLock;

	public GameObject specialkeyDoor;

	public GameObject specialkeyInPlace;

	public GameObject book;

	public Transform newbook;

	public bool havebook;

	public GameObject secretWall;

	public GameObject bookInPlace;

	public bool plankaHighlighted;

	public GameObject highlightedPlanka;

	public GameObject highlightedPlankaTrigger;

	public GameObject plankaHole;

	public GameObject skruvPlatta;

	public GameObject skruvPlattaOutside;

	public GameObject hangLockKeyText;

	public GameObject padlockCodeText;

	public GameObject hammerText;

	public GameObject safeKeyText;

	public GameObject AvbitarTongText;

	public GameObject HusnyckelText;

	public GameObject CrossbowText;

	public GameObject TranquilizerDartText;

	public GameObject weaponKeyText;

	public GameObject screwdriverText;

	public GameObject plankText;

	public GameObject batteryText;

	public GameObject tavelbitText;

	public GameObject playhouseKeyText;

	public GameObject melonText;

	public GameObject teddyText;

	public GameObject cogwheelText;

	public GameObject winchhandleText;

	public GameObject PartOfShotgunText;

	public GameObject ShotgunText;

	public GameObject AmmoText;

	public GameObject carKeyText;

	public GameObject EnginePartText;

	public GameObject SparkPlugText;

	public GameObject GasolineCanText;

	public GameObject CarBatteryText;

	public GameObject WrenchText;

	public GameObject MeatText;

	public GameObject specialKeyText;

	public GameObject bookText;

	public GameObject ShotgunLoadedText;

	public GameObject NeedShotgunText;

	public GameObject NeedhangLockKeyText;

	public GameObject NeedpadlockCodeText;

	public GameObject NeedhammerText;

	public GameObject NeedsafeKeyText;

	public GameObject NeedAvbitarTongText;

	public GameObject NeedHusnyckelText;

	public GameObject NeedCrossbowText;

	public GameObject NeedweaponKeyText;

	public GameObject NeedscrewdriverText;

	public GameObject NeedbatteryText;

	public GameObject NeedplayhouseKeyText;

	public GameObject cutThingsHereText;

	public GameObject NeedWinchhandleText;

	public GameObject NeedFindSwitchText;

	public GameObject missinTavelbitarText;

	public GameObject NeedcarKeyText;

	public GameObject NeedCarBatteryText;

	public GameObject NeedSparkPlugText;

	public GameObject emptyPlateText;

	public GameObject NeedEnginePartText;

	public GameObject NeedWrenchText;

	public GameObject NeedGasolineText;

	public GameObject NeedSpecialKeyText;

	public GameObject MaybePutSomethingHereText;

	public GameObject CantopenDoorYetText;

	public GameObject kamera;

	public GameObject kameraBroken;

	public GameObject kameraSeeTrigger;

	public GameObject galler;

	public GameObject gallerColliders;

	public bool playerInPrison;

	public GameObject prisonDoor;

	public GameObject batteryOnPlace;

	public GameObject batterySpak;

	public GameObject tb1;

	public Transform newtb1;

	public bool havetb1;

	public GameObject tb2;

	public Transform newtb2;

	public bool havetb2;

	public GameObject tb3;

	public Transform newtb3;

	public bool havetb3;

	public GameObject tb4;

	public Transform newtb4;

	public bool havetb4;

	public GameObject playhouseDoor;

	public GameObject giljoCutArea;

	public GameObject melonInPlace;

	public GameObject giljotin;

	public GameObject somethingInsideMelonText;

	public bool haveSeenMelonText;

	public bool kugg1OK;

	public bool kugg2OK;

	public GameObject playHouseLucka;

	public GameObject SomethingMissingHereText;

	public GameObject kugg1inPlace;

	public GameObject kugg2inPlace;

	public GameObject brunnsvevInPlace;

	public GameObject brunnsvevsHolder;

	public GameObject extremeLockOn;

	public GameObject extremeLockOff;

	public GameObject motorCollider;

	public bool textTimerOnOff;

	public float textTimer;

	public PickUp()
	{
		layerMask = 256;
	}

	public virtual void Start()
	{
		layerMask = ~layerMask;
	}

	public virtual void Update()
	{
		if (Input.GetKeyDown(KeyCode.E))
		{
			if (!((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).menuEnabled && readyPickUp)
			{
				pickUp = true;
			}
		}
		else if (Input.GetKeyDown(KeyCode.Space) && !((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).menuEnabled && dropObjectButton.activeSelf)
		{
			dropObject = true;
		}
		RaycastHit hitInfo = default(RaycastHit);
		Vector3 direction = SeeRay.transform.TransformDirection(Vector3.forward);
		if (!playerTaken)
		{
			if (Physics.Raycast(SeeRay.transform.position, direction, out hitInfo, 5f, layerMask))
			{
				if (hitInfo.collider.gameObject.tag == "avbitare")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					AvbitarTongText.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						avbitare.SetActive(true);
						haveAvbitare = true;
						dropObjectButton.SetActive(true);
						mittenRing.SetActive(false);
						readyPickUp = false;
						AvbitarTongText.SetActive(false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
						if (haveHammare)
						{
							hammare.SetActive(false);
							haveHammare = false;
							UnityEngine.Object.Instantiate(newHammare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas)
						{
							vas.SetActive(false);
							havevas = false;
							UnityEngine.Object.Instantiate(newvas, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesafeKey)
						{
							safeKey.SetActive(false);
							havesafeKey = false;
							UnityEngine.Object.Instantiate(newsafeKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveexitKey)
						{
							exitKey.SetActive(false);
							haveexitKey = false;
							UnityEngine.Object.Instantiate(newexitKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havehanglockKey)
						{
							hanglockKey.SetActive(false);
							havehanglockKey = false;
							UnityEngine.Object.Instantiate(newhanglockKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havepadlockCode)
						{
							padlockCode.SetActive(false);
							havepadlockCode = false;
							UnityEngine.Object.Instantiate(newpadlockCode, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havearmborst)
						{
							armborst.SetActive(false);
							havearmborst = false;
							arrowButton.SetActive(false);
							shootArrowRay.SetActive(false);
							UnityEngine.Object.Instantiate(newarmborst, dropPoint.transform.position, dropPoint.transform.rotation);
							if (armborstArrowOK)
							{
								UnityEngine.Object.Instantiate(newArrow, dropPoint.transform.position, dropPoint.transform.rotation);
								haveArrow = false;
								armborstArrowOK = false;
							}
						}
						else if (haveweaponKey)
						{
							weaponKey.SetActive(false);
							haveweaponKey = false;
							UnityEngine.Object.Instantiate(newweaponKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havescrewdriver)
						{
							screwdriver.SetActive(false);
							havescrewdriver = false;
							UnityEngine.Object.Instantiate(newscrewdriver, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplanka)
						{
							planka.SetActive(false);
							haveplanka = false;
							UnityEngine.Object.Instantiate(newplanka, dropPoint.transform.position, dropPoint.transform.rotation);
							placeObject = false;
							placeObjectButton.SetActive(false);
						}
						else if (havebattery)
						{
							battery.SetActive(false);
							havebattery = false;
							UnityEngine.Object.Instantiate(newbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb1)
						{
							tb1.SetActive(false);
							havetb1 = false;
							UnityEngine.Object.Instantiate(newtb1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb2)
						{
							tb2.SetActive(false);
							havetb2 = false;
							UnityEngine.Object.Instantiate(newtb2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb3)
						{
							tb3.SetActive(false);
							havetb3 = false;
							UnityEngine.Object.Instantiate(newtb3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb4)
						{
							tb4.SetActive(false);
							havetb4 = false;
							UnityEngine.Object.Instantiate(newtb4, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas2)
						{
							vas2.SetActive(false);
							havevas2 = false;
							UnityEngine.Object.Instantiate(newvas2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplayhouseKey)
						{
							playhouseKey.SetActive(false);
							haveplayhouseKey = false;
							UnityEngine.Object.Instantiate(newplayhouseKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemelon)
						{
							melon.SetActive(false);
							havemelon = false;
							UnityEngine.Object.Instantiate(newmelon, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveteddy)
						{
							teddy.SetActive(false);
							haveteddy = false;
							((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
							UnityEngine.Object.Instantiate(newteddy, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg1)
						{
							kugg1.SetActive(false);
							havekugg1 = false;
							UnityEngine.Object.Instantiate(newkugg1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg2)
						{
							kugg2.SetActive(false);
							havekugg2 = false;
							UnityEngine.Object.Instantiate(newkugg2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemessage)
						{
							message.SetActive(false);
							havemessage = false;
							UnityEngine.Object.Instantiate(newmessage, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebrunnsvev)
						{
							brunnsvev.SetActive(false);
							havebrunnsvev = false;
							UnityEngine.Object.Instantiate(newbrunnsvev, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveoldShotgun)
						{
							oldShotgun.SetActive(false);
							haveoldShotgun = false;
							shootButton.SetActive(false);
							shootRay.SetActive(false);
							UnityEngine.Object.Instantiate(newoldShotgun, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel1)
						{
							gunDel1.SetActive(false);
							havegunDel1 = false;
							UnityEngine.Object.Instantiate(newgunDel1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel2)
						{
							gunDel2.SetActive(false);
							havegunDel2 = false;
							UnityEngine.Object.Instantiate(newgunDel2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel3)
						{
							gunDel3.SetActive(false);
							havegunDel3 = false;
							UnityEngine.Object.Instantiate(newgunDel3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarKey)
						{
							carKey.SetActive(false);
							havecarKey = false;
							((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).playerHaveCarKey = false;
							UnityEngine.Object.Instantiate(newcarKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetopplock)
						{
							topplock.SetActive(false);
							havetopplock = false;
							UnityEngine.Object.Instantiate(newtopplock, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarbattery)
						{
							carbattery.SetActive(false);
							havecarbattery = false;
							UnityEngine.Object.Instantiate(newcarbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegascan)
						{
							gascan.SetActive(false);
							havegascan = false;
							UnityEngine.Object.Instantiate(newgascan, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havewrench)
						{
							wrench.SetActive(false);
							havewrench = false;
							UnityEngine.Object.Instantiate(newwrench, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesparkplug)
						{
							sparkplug.SetActive(false);
							havesparkplug = false;
							UnityEngine.Object.Instantiate(newsparkplug, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemeat)
						{
							meat.SetActive(false);
							havemeat = false;
							UnityEngine.Object.Instantiate(newmeat, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havespecialkey)
						{
							specialkey.SetActive(false);
							havespecialkey = false;
							UnityEngine.Object.Instantiate(newspecialkey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebook)
						{
							book.SetActive(false);
							havebook = false;
							UnityEngine.Object.Instantiate(newbook, dropPoint.transform.position, dropPoint.transform.rotation);
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "hammer")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					hammerText.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						hammare.SetActive(true);
						haveHammare = true;
						dropObjectButton.SetActive(true);
						mittenRing.SetActive(false);
						readyPickUp = false;
						hammerText.SetActive(false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
						if (haveAvbitare)
						{
							avbitare.SetActive(false);
							haveAvbitare = false;
							UnityEngine.Object.Instantiate(newAvbitare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas)
						{
							vas.SetActive(false);
							havevas = false;
							UnityEngine.Object.Instantiate(newvas, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesafeKey)
						{
							safeKey.SetActive(false);
							havesafeKey = false;
							UnityEngine.Object.Instantiate(newsafeKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveexitKey)
						{
							exitKey.SetActive(false);
							haveexitKey = false;
							UnityEngine.Object.Instantiate(newexitKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havehanglockKey)
						{
							hanglockKey.SetActive(false);
							havehanglockKey = false;
							UnityEngine.Object.Instantiate(newhanglockKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havepadlockCode)
						{
							padlockCode.SetActive(false);
							havepadlockCode = false;
							UnityEngine.Object.Instantiate(newpadlockCode, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havearmborst)
						{
							armborst.SetActive(false);
							havearmborst = false;
							arrowButton.SetActive(false);
							shootArrowRay.SetActive(false);
							UnityEngine.Object.Instantiate(newarmborst, dropPoint.transform.position, dropPoint.transform.rotation);
							if (armborstArrowOK)
							{
								UnityEngine.Object.Instantiate(newArrow, dropPoint.transform.position, dropPoint.transform.rotation);
								haveArrow = false;
								armborstArrowOK = false;
							}
						}
						else if (haveweaponKey)
						{
							weaponKey.SetActive(false);
							haveweaponKey = false;
							UnityEngine.Object.Instantiate(newweaponKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havescrewdriver)
						{
							screwdriver.SetActive(false);
							havescrewdriver = false;
							UnityEngine.Object.Instantiate(newscrewdriver, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplanka)
						{
							planka.SetActive(false);
							haveplanka = false;
							UnityEngine.Object.Instantiate(newplanka, dropPoint.transform.position, dropPoint.transform.rotation);
							placeObject = false;
							placeObjectButton.SetActive(false);
						}
						else if (havebattery)
						{
							battery.SetActive(false);
							havebattery = false;
							UnityEngine.Object.Instantiate(newbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb1)
						{
							tb1.SetActive(false);
							havetb1 = false;
							UnityEngine.Object.Instantiate(newtb1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb2)
						{
							tb2.SetActive(false);
							havetb2 = false;
							UnityEngine.Object.Instantiate(newtb2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb3)
						{
							tb3.SetActive(false);
							havetb3 = false;
							UnityEngine.Object.Instantiate(newtb3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb4)
						{
							tb4.SetActive(false);
							havetb4 = false;
							UnityEngine.Object.Instantiate(newtb4, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas2)
						{
							vas2.SetActive(false);
							havevas2 = false;
							UnityEngine.Object.Instantiate(newvas2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplayhouseKey)
						{
							playhouseKey.SetActive(false);
							haveplayhouseKey = false;
							UnityEngine.Object.Instantiate(newplayhouseKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemelon)
						{
							melon.SetActive(false);
							havemelon = false;
							UnityEngine.Object.Instantiate(newmelon, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveteddy)
						{
							teddy.SetActive(false);
							haveteddy = false;
							((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
							UnityEngine.Object.Instantiate(newteddy, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg1)
						{
							kugg1.SetActive(false);
							havekugg1 = false;
							UnityEngine.Object.Instantiate(newkugg1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg2)
						{
							kugg2.SetActive(false);
							havekugg2 = false;
							UnityEngine.Object.Instantiate(newkugg2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemessage)
						{
							message.SetActive(false);
							havemessage = false;
							UnityEngine.Object.Instantiate(newmessage, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebrunnsvev)
						{
							brunnsvev.SetActive(false);
							havebrunnsvev = false;
							UnityEngine.Object.Instantiate(newbrunnsvev, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveoldShotgun)
						{
							oldShotgun.SetActive(false);
							haveoldShotgun = false;
							shootButton.SetActive(false);
							shootRay.SetActive(false);
							UnityEngine.Object.Instantiate(newoldShotgun, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel1)
						{
							gunDel1.SetActive(false);
							havegunDel1 = false;
							UnityEngine.Object.Instantiate(newgunDel1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel2)
						{
							gunDel2.SetActive(false);
							havegunDel2 = false;
							UnityEngine.Object.Instantiate(newgunDel2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel3)
						{
							gunDel3.SetActive(false);
							havegunDel3 = false;
							UnityEngine.Object.Instantiate(newgunDel3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarKey)
						{
							carKey.SetActive(false);
							havecarKey = false;
							((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).playerHaveCarKey = false;
							UnityEngine.Object.Instantiate(newcarKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetopplock)
						{
							topplock.SetActive(false);
							havetopplock = false;
							UnityEngine.Object.Instantiate(newtopplock, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarbattery)
						{
							carbattery.SetActive(false);
							havecarbattery = false;
							UnityEngine.Object.Instantiate(newcarbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegascan)
						{
							gascan.SetActive(false);
							havegascan = false;
							UnityEngine.Object.Instantiate(newgascan, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havewrench)
						{
							wrench.SetActive(false);
							havewrench = false;
							UnityEngine.Object.Instantiate(newwrench, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesparkplug)
						{
							sparkplug.SetActive(false);
							havesparkplug = false;
							UnityEngine.Object.Instantiate(newsparkplug, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemeat)
						{
							meat.SetActive(false);
							havemeat = false;
							UnityEngine.Object.Instantiate(newmeat, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havespecialkey)
						{
							specialkey.SetActive(false);
							havespecialkey = false;
							UnityEngine.Object.Instantiate(newspecialkey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebook)
						{
							book.SetActive(false);
							havebook = false;
							UnityEngine.Object.Instantiate(newbook, dropPoint.transform.position, dropPoint.transform.rotation);
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "vas")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						vas.SetActive(true);
						havevas = true;
						dropObjectButton.SetActive(true);
						mittenRing.SetActive(false);
						readyPickUp = false;
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
						if (haveAvbitare)
						{
							avbitare.SetActive(false);
							haveAvbitare = false;
							UnityEngine.Object.Instantiate(newAvbitare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveHammare)
						{
							hammare.SetActive(false);
							haveHammare = false;
							UnityEngine.Object.Instantiate(newHammare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesafeKey)
						{
							safeKey.SetActive(false);
							havesafeKey = false;
							UnityEngine.Object.Instantiate(newsafeKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveexitKey)
						{
							exitKey.SetActive(false);
							haveexitKey = false;
							UnityEngine.Object.Instantiate(newexitKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havehanglockKey)
						{
							hanglockKey.SetActive(false);
							havehanglockKey = false;
							UnityEngine.Object.Instantiate(newhanglockKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havepadlockCode)
						{
							padlockCode.SetActive(false);
							havepadlockCode = false;
							UnityEngine.Object.Instantiate(newpadlockCode, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havearmborst)
						{
							armborst.SetActive(false);
							havearmborst = false;
							arrowButton.SetActive(false);
							shootArrowRay.SetActive(false);
							UnityEngine.Object.Instantiate(newarmborst, dropPoint.transform.position, dropPoint.transform.rotation);
							if (armborstArrowOK)
							{
								UnityEngine.Object.Instantiate(newArrow, dropPoint.transform.position, dropPoint.transform.rotation);
								haveArrow = false;
								armborstArrowOK = false;
							}
						}
						else if (haveweaponKey)
						{
							weaponKey.SetActive(false);
							haveweaponKey = false;
							UnityEngine.Object.Instantiate(newweaponKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havescrewdriver)
						{
							screwdriver.SetActive(false);
							havescrewdriver = false;
							UnityEngine.Object.Instantiate(newscrewdriver, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplanka)
						{
							planka.SetActive(false);
							haveplanka = false;
							UnityEngine.Object.Instantiate(newplanka, dropPoint.transform.position, dropPoint.transform.rotation);
							placeObject = false;
							placeObjectButton.SetActive(false);
						}
						else if (havebattery)
						{
							battery.SetActive(false);
							havebattery = false;
							UnityEngine.Object.Instantiate(newbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb1)
						{
							tb1.SetActive(false);
							havetb1 = false;
							UnityEngine.Object.Instantiate(newtb1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb2)
						{
							tb2.SetActive(false);
							havetb2 = false;
							UnityEngine.Object.Instantiate(newtb2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb3)
						{
							tb3.SetActive(false);
							havetb3 = false;
							UnityEngine.Object.Instantiate(newtb3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb4)
						{
							tb4.SetActive(false);
							havetb4 = false;
							UnityEngine.Object.Instantiate(newtb4, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas2)
						{
							vas2.SetActive(false);
							havevas2 = false;
							UnityEngine.Object.Instantiate(newvas2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplayhouseKey)
						{
							playhouseKey.SetActive(false);
							haveplayhouseKey = false;
							UnityEngine.Object.Instantiate(newplayhouseKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemelon)
						{
							melon.SetActive(false);
							havemelon = false;
							UnityEngine.Object.Instantiate(newmelon, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveteddy)
						{
							teddy.SetActive(false);
							haveteddy = false;
							((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
							UnityEngine.Object.Instantiate(newteddy, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg1)
						{
							kugg1.SetActive(false);
							havekugg1 = false;
							UnityEngine.Object.Instantiate(newkugg1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg2)
						{
							kugg2.SetActive(false);
							havekugg2 = false;
							UnityEngine.Object.Instantiate(newkugg2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemessage)
						{
							message.SetActive(false);
							havemessage = false;
							UnityEngine.Object.Instantiate(newmessage, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebrunnsvev)
						{
							brunnsvev.SetActive(false);
							havebrunnsvev = false;
							UnityEngine.Object.Instantiate(newbrunnsvev, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveoldShotgun)
						{
							oldShotgun.SetActive(false);
							haveoldShotgun = false;
							shootButton.SetActive(false);
							shootRay.SetActive(false);
							UnityEngine.Object.Instantiate(newoldShotgun, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel1)
						{
							gunDel1.SetActive(false);
							havegunDel1 = false;
							UnityEngine.Object.Instantiate(newgunDel1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel2)
						{
							gunDel2.SetActive(false);
							havegunDel2 = false;
							UnityEngine.Object.Instantiate(newgunDel2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel3)
						{
							gunDel3.SetActive(false);
							havegunDel3 = false;
							UnityEngine.Object.Instantiate(newgunDel3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarKey)
						{
							carKey.SetActive(false);
							havecarKey = false;
							((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).playerHaveCarKey = false;
							UnityEngine.Object.Instantiate(newcarKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetopplock)
						{
							topplock.SetActive(false);
							havetopplock = false;
							UnityEngine.Object.Instantiate(newtopplock, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarbattery)
						{
							carbattery.SetActive(false);
							havecarbattery = false;
							UnityEngine.Object.Instantiate(newcarbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegascan)
						{
							gascan.SetActive(false);
							havegascan = false;
							UnityEngine.Object.Instantiate(newgascan, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havewrench)
						{
							wrench.SetActive(false);
							havewrench = false;
							UnityEngine.Object.Instantiate(newwrench, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesparkplug)
						{
							sparkplug.SetActive(false);
							havesparkplug = false;
							UnityEngine.Object.Instantiate(newsparkplug, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemeat)
						{
							meat.SetActive(false);
							havemeat = false;
							UnityEngine.Object.Instantiate(newmeat, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havespecialkey)
						{
							specialkey.SetActive(false);
							havespecialkey = false;
							UnityEngine.Object.Instantiate(newspecialkey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebook)
						{
							book.SetActive(false);
							havebook = false;
							UnityEngine.Object.Instantiate(newbook, dropPoint.transform.position, dropPoint.transform.rotation);
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "vas2")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						vas2.SetActive(true);
						havevas2 = true;
						dropObjectButton.SetActive(true);
						mittenRing.SetActive(false);
						readyPickUp = false;
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
						if (haveAvbitare)
						{
							avbitare.SetActive(false);
							haveAvbitare = false;
							UnityEngine.Object.Instantiate(newAvbitare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveHammare)
						{
							hammare.SetActive(false);
							haveHammare = false;
							UnityEngine.Object.Instantiate(newHammare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesafeKey)
						{
							safeKey.SetActive(false);
							havesafeKey = false;
							UnityEngine.Object.Instantiate(newsafeKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveexitKey)
						{
							exitKey.SetActive(false);
							haveexitKey = false;
							UnityEngine.Object.Instantiate(newexitKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havehanglockKey)
						{
							hanglockKey.SetActive(false);
							havehanglockKey = false;
							UnityEngine.Object.Instantiate(newhanglockKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havepadlockCode)
						{
							padlockCode.SetActive(false);
							havepadlockCode = false;
							UnityEngine.Object.Instantiate(newpadlockCode, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havearmborst)
						{
							armborst.SetActive(false);
							havearmborst = false;
							arrowButton.SetActive(false);
							shootArrowRay.SetActive(false);
							UnityEngine.Object.Instantiate(newarmborst, dropPoint.transform.position, dropPoint.transform.rotation);
							if (armborstArrowOK)
							{
								UnityEngine.Object.Instantiate(newArrow, dropPoint.transform.position, dropPoint.transform.rotation);
								haveArrow = false;
								armborstArrowOK = false;
							}
						}
						else if (haveweaponKey)
						{
							weaponKey.SetActive(false);
							haveweaponKey = false;
							UnityEngine.Object.Instantiate(newweaponKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havescrewdriver)
						{
							screwdriver.SetActive(false);
							havescrewdriver = false;
							UnityEngine.Object.Instantiate(newscrewdriver, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplanka)
						{
							planka.SetActive(false);
							haveplanka = false;
							UnityEngine.Object.Instantiate(newplanka, dropPoint.transform.position, dropPoint.transform.rotation);
							placeObject = false;
							placeObjectButton.SetActive(false);
						}
						else if (havebattery)
						{
							battery.SetActive(false);
							havebattery = false;
							UnityEngine.Object.Instantiate(newbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb1)
						{
							tb1.SetActive(false);
							havetb1 = false;
							UnityEngine.Object.Instantiate(newtb1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb2)
						{
							tb2.SetActive(false);
							havetb2 = false;
							UnityEngine.Object.Instantiate(newtb2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb3)
						{
							tb3.SetActive(false);
							havetb3 = false;
							UnityEngine.Object.Instantiate(newtb3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb4)
						{
							tb4.SetActive(false);
							havetb4 = false;
							UnityEngine.Object.Instantiate(newtb4, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas)
						{
							vas.SetActive(false);
							havevas = false;
							UnityEngine.Object.Instantiate(newvas, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplayhouseKey)
						{
							playhouseKey.SetActive(false);
							haveplayhouseKey = false;
							UnityEngine.Object.Instantiate(newplayhouseKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemelon)
						{
							melon.SetActive(false);
							havemelon = false;
							UnityEngine.Object.Instantiate(newmelon, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveteddy)
						{
							teddy.SetActive(false);
							haveteddy = false;
							((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
							UnityEngine.Object.Instantiate(newteddy, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg1)
						{
							kugg1.SetActive(false);
							havekugg1 = false;
							UnityEngine.Object.Instantiate(newkugg1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg2)
						{
							kugg2.SetActive(false);
							havekugg2 = false;
							UnityEngine.Object.Instantiate(newkugg2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemessage)
						{
							message.SetActive(false);
							havemessage = false;
							UnityEngine.Object.Instantiate(newmessage, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebrunnsvev)
						{
							brunnsvev.SetActive(false);
							havebrunnsvev = false;
							UnityEngine.Object.Instantiate(newbrunnsvev, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveoldShotgun)
						{
							oldShotgun.SetActive(false);
							haveoldShotgun = false;
							shootButton.SetActive(false);
							shootRay.SetActive(false);
							UnityEngine.Object.Instantiate(newoldShotgun, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel1)
						{
							gunDel1.SetActive(false);
							havegunDel1 = false;
							UnityEngine.Object.Instantiate(newgunDel1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel2)
						{
							gunDel2.SetActive(false);
							havegunDel2 = false;
							UnityEngine.Object.Instantiate(newgunDel2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel3)
						{
							gunDel3.SetActive(false);
							havegunDel3 = false;
							UnityEngine.Object.Instantiate(newgunDel3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarKey)
						{
							carKey.SetActive(false);
							havecarKey = false;
							((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).playerHaveCarKey = false;
							UnityEngine.Object.Instantiate(newcarKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetopplock)
						{
							topplock.SetActive(false);
							havetopplock = false;
							UnityEngine.Object.Instantiate(newtopplock, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarbattery)
						{
							carbattery.SetActive(false);
							havecarbattery = false;
							UnityEngine.Object.Instantiate(newcarbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegascan)
						{
							gascan.SetActive(false);
							havegascan = false;
							UnityEngine.Object.Instantiate(newgascan, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havewrench)
						{
							wrench.SetActive(false);
							havewrench = false;
							UnityEngine.Object.Instantiate(newwrench, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesparkplug)
						{
							sparkplug.SetActive(false);
							havesparkplug = false;
							UnityEngine.Object.Instantiate(newsparkplug, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemeat)
						{
							meat.SetActive(false);
							havemeat = false;
							UnityEngine.Object.Instantiate(newmeat, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havespecialkey)
						{
							specialkey.SetActive(false);
							havespecialkey = false;
							UnityEngine.Object.Instantiate(newspecialkey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebook)
						{
							book.SetActive(false);
							havebook = false;
							UnityEngine.Object.Instantiate(newbook, dropPoint.transform.position, dropPoint.transform.rotation);
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "safekey")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					safeKeyText.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						safeKey.SetActive(true);
						havesafeKey = true;
						dropObjectButton.SetActive(true);
						mittenRing.SetActive(false);
						readyPickUp = false;
						safeKeyText.SetActive(false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppNyckel);
						if (haveAvbitare)
						{
							avbitare.SetActive(false);
							haveAvbitare = false;
							UnityEngine.Object.Instantiate(newAvbitare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveHammare)
						{
							hammare.SetActive(false);
							haveHammare = false;
							UnityEngine.Object.Instantiate(newHammare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas)
						{
							vas.SetActive(false);
							havevas = false;
							UnityEngine.Object.Instantiate(newvas, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveexitKey)
						{
							exitKey.SetActive(false);
							haveexitKey = false;
							UnityEngine.Object.Instantiate(newexitKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havehanglockKey)
						{
							hanglockKey.SetActive(false);
							havehanglockKey = false;
							UnityEngine.Object.Instantiate(newhanglockKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havepadlockCode)
						{
							padlockCode.SetActive(false);
							havepadlockCode = false;
							UnityEngine.Object.Instantiate(newpadlockCode, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havearmborst)
						{
							armborst.SetActive(false);
							havearmborst = false;
							arrowButton.SetActive(false);
							shootArrowRay.SetActive(false);
							UnityEngine.Object.Instantiate(newarmborst, dropPoint.transform.position, dropPoint.transform.rotation);
							if (armborstArrowOK)
							{
								UnityEngine.Object.Instantiate(newArrow, dropPoint.transform.position, dropPoint.transform.rotation);
								haveArrow = false;
								armborstArrowOK = false;
							}
						}
						else if (haveweaponKey)
						{
							weaponKey.SetActive(false);
							haveweaponKey = false;
							UnityEngine.Object.Instantiate(newweaponKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havescrewdriver)
						{
							screwdriver.SetActive(false);
							havescrewdriver = false;
							UnityEngine.Object.Instantiate(newscrewdriver, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplanka)
						{
							planka.SetActive(false);
							haveplanka = false;
							UnityEngine.Object.Instantiate(newplanka, dropPoint.transform.position, dropPoint.transform.rotation);
							placeObject = false;
							placeObjectButton.SetActive(false);
						}
						else if (havebattery)
						{
							battery.SetActive(false);
							havebattery = false;
							UnityEngine.Object.Instantiate(newbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb1)
						{
							tb1.SetActive(false);
							havetb1 = false;
							UnityEngine.Object.Instantiate(newtb1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb2)
						{
							tb2.SetActive(false);
							havetb2 = false;
							UnityEngine.Object.Instantiate(newtb2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb3)
						{
							tb3.SetActive(false);
							havetb3 = false;
							UnityEngine.Object.Instantiate(newtb3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb4)
						{
							tb4.SetActive(false);
							havetb4 = false;
							UnityEngine.Object.Instantiate(newtb4, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas2)
						{
							vas2.SetActive(false);
							havevas2 = false;
							UnityEngine.Object.Instantiate(newvas2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplayhouseKey)
						{
							playhouseKey.SetActive(false);
							haveplayhouseKey = false;
							UnityEngine.Object.Instantiate(newplayhouseKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemelon)
						{
							melon.SetActive(false);
							havemelon = false;
							UnityEngine.Object.Instantiate(newmelon, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveteddy)
						{
							teddy.SetActive(false);
							haveteddy = false;
							((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
							UnityEngine.Object.Instantiate(newteddy, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg1)
						{
							kugg1.SetActive(false);
							havekugg1 = false;
							UnityEngine.Object.Instantiate(newkugg1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg2)
						{
							kugg2.SetActive(false);
							havekugg2 = false;
							UnityEngine.Object.Instantiate(newkugg2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemessage)
						{
							message.SetActive(false);
							havemessage = false;
							UnityEngine.Object.Instantiate(newmessage, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebrunnsvev)
						{
							brunnsvev.SetActive(false);
							havebrunnsvev = false;
							UnityEngine.Object.Instantiate(newbrunnsvev, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveoldShotgun)
						{
							oldShotgun.SetActive(false);
							haveoldShotgun = false;
							shootButton.SetActive(false);
							shootRay.SetActive(false);
							UnityEngine.Object.Instantiate(newoldShotgun, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel1)
						{
							gunDel1.SetActive(false);
							havegunDel1 = false;
							UnityEngine.Object.Instantiate(newgunDel1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel2)
						{
							gunDel2.SetActive(false);
							havegunDel2 = false;
							UnityEngine.Object.Instantiate(newgunDel2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel3)
						{
							gunDel3.SetActive(false);
							havegunDel3 = false;
							UnityEngine.Object.Instantiate(newgunDel3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarKey)
						{
							carKey.SetActive(false);
							havecarKey = false;
							((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).playerHaveCarKey = false;
							UnityEngine.Object.Instantiate(newcarKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetopplock)
						{
							topplock.SetActive(false);
							havetopplock = false;
							UnityEngine.Object.Instantiate(newtopplock, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarbattery)
						{
							carbattery.SetActive(false);
							havecarbattery = false;
							UnityEngine.Object.Instantiate(newcarbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegascan)
						{
							gascan.SetActive(false);
							havegascan = false;
							UnityEngine.Object.Instantiate(newgascan, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havewrench)
						{
							wrench.SetActive(false);
							havewrench = false;
							UnityEngine.Object.Instantiate(newwrench, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesparkplug)
						{
							sparkplug.SetActive(false);
							havesparkplug = false;
							UnityEngine.Object.Instantiate(newsparkplug, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemeat)
						{
							meat.SetActive(false);
							havemeat = false;
							UnityEngine.Object.Instantiate(newmeat, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havespecialkey)
						{
							specialkey.SetActive(false);
							havespecialkey = false;
							UnityEngine.Object.Instantiate(newspecialkey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebook)
						{
							book.SetActive(false);
							havebook = false;
							UnityEngine.Object.Instantiate(newbook, dropPoint.transform.position, dropPoint.transform.rotation);
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "exitkey")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					HusnyckelText.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						exitKey.SetActive(true);
						haveexitKey = true;
						dropObjectButton.SetActive(true);
						mittenRing.SetActive(false);
						readyPickUp = false;
						HusnyckelText.SetActive(false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppNyckel);
						if (haveAvbitare)
						{
							avbitare.SetActive(false);
							haveAvbitare = false;
							UnityEngine.Object.Instantiate(newAvbitare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveHammare)
						{
							hammare.SetActive(false);
							haveHammare = false;
							UnityEngine.Object.Instantiate(newHammare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas)
						{
							vas.SetActive(false);
							havevas = false;
							UnityEngine.Object.Instantiate(newvas, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesafeKey)
						{
							safeKey.SetActive(false);
							havesafeKey = false;
							UnityEngine.Object.Instantiate(newsafeKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havehanglockKey)
						{
							hanglockKey.SetActive(false);
							havehanglockKey = false;
							UnityEngine.Object.Instantiate(newhanglockKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havepadlockCode)
						{
							padlockCode.SetActive(false);
							havepadlockCode = false;
							UnityEngine.Object.Instantiate(newpadlockCode, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havearmborst)
						{
							armborst.SetActive(false);
							havearmborst = false;
							arrowButton.SetActive(false);
							shootArrowRay.SetActive(false);
							UnityEngine.Object.Instantiate(newarmborst, dropPoint.transform.position, dropPoint.transform.rotation);
							if (armborstArrowOK)
							{
								UnityEngine.Object.Instantiate(newArrow, dropPoint.transform.position, dropPoint.transform.rotation);
								haveArrow = false;
								armborstArrowOK = false;
							}
						}
						else if (haveweaponKey)
						{
							weaponKey.SetActive(false);
							haveweaponKey = false;
							UnityEngine.Object.Instantiate(newweaponKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havescrewdriver)
						{
							screwdriver.SetActive(false);
							havescrewdriver = false;
							UnityEngine.Object.Instantiate(newscrewdriver, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplanka)
						{
							planka.SetActive(false);
							haveplanka = false;
							UnityEngine.Object.Instantiate(newplanka, dropPoint.transform.position, dropPoint.transform.rotation);
							placeObject = false;
							placeObjectButton.SetActive(false);
						}
						else if (havebattery)
						{
							battery.SetActive(false);
							havebattery = false;
							UnityEngine.Object.Instantiate(newbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb1)
						{
							tb1.SetActive(false);
							havetb1 = false;
							UnityEngine.Object.Instantiate(newtb1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb2)
						{
							tb2.SetActive(false);
							havetb2 = false;
							UnityEngine.Object.Instantiate(newtb2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb3)
						{
							tb3.SetActive(false);
							havetb3 = false;
							UnityEngine.Object.Instantiate(newtb3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb4)
						{
							tb4.SetActive(false);
							havetb4 = false;
							UnityEngine.Object.Instantiate(newtb4, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas2)
						{
							vas2.SetActive(false);
							havevas2 = false;
							UnityEngine.Object.Instantiate(newvas2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplayhouseKey)
						{
							playhouseKey.SetActive(false);
							haveplayhouseKey = false;
							UnityEngine.Object.Instantiate(newplayhouseKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemelon)
						{
							melon.SetActive(false);
							havemelon = false;
							UnityEngine.Object.Instantiate(newmelon, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveteddy)
						{
							teddy.SetActive(false);
							haveteddy = false;
							((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
							UnityEngine.Object.Instantiate(newteddy, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg1)
						{
							kugg1.SetActive(false);
							havekugg1 = false;
							UnityEngine.Object.Instantiate(newkugg1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg2)
						{
							kugg2.SetActive(false);
							havekugg2 = false;
							UnityEngine.Object.Instantiate(newkugg2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemessage)
						{
							message.SetActive(false);
							havemessage = false;
							UnityEngine.Object.Instantiate(newmessage, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebrunnsvev)
						{
							brunnsvev.SetActive(false);
							havebrunnsvev = false;
							UnityEngine.Object.Instantiate(newbrunnsvev, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveoldShotgun)
						{
							oldShotgun.SetActive(false);
							haveoldShotgun = false;
							shootButton.SetActive(false);
							shootRay.SetActive(false);
							UnityEngine.Object.Instantiate(newoldShotgun, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel1)
						{
							gunDel1.SetActive(false);
							havegunDel1 = false;
							UnityEngine.Object.Instantiate(newgunDel1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel2)
						{
							gunDel2.SetActive(false);
							havegunDel2 = false;
							UnityEngine.Object.Instantiate(newgunDel2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel3)
						{
							gunDel3.SetActive(false);
							havegunDel3 = false;
							UnityEngine.Object.Instantiate(newgunDel3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarKey)
						{
							carKey.SetActive(false);
							havecarKey = false;
							((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).playerHaveCarKey = false;
							UnityEngine.Object.Instantiate(newcarKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetopplock)
						{
							topplock.SetActive(false);
							havetopplock = false;
							UnityEngine.Object.Instantiate(newtopplock, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarbattery)
						{
							carbattery.SetActive(false);
							havecarbattery = false;
							UnityEngine.Object.Instantiate(newcarbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegascan)
						{
							gascan.SetActive(false);
							havegascan = false;
							UnityEngine.Object.Instantiate(newgascan, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havewrench)
						{
							wrench.SetActive(false);
							havewrench = false;
							UnityEngine.Object.Instantiate(newwrench, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesparkplug)
						{
							sparkplug.SetActive(false);
							havesparkplug = false;
							UnityEngine.Object.Instantiate(newsparkplug, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemeat)
						{
							meat.SetActive(false);
							havemeat = false;
							UnityEngine.Object.Instantiate(newmeat, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havespecialkey)
						{
							specialkey.SetActive(false);
							havespecialkey = false;
							UnityEngine.Object.Instantiate(newspecialkey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebook)
						{
							book.SetActive(false);
							havebook = false;
							UnityEngine.Object.Instantiate(newbook, dropPoint.transform.position, dropPoint.transform.rotation);
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "hanglockkey")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					hangLockKeyText.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						hanglockKey.SetActive(true);
						havehanglockKey = true;
						dropObjectButton.SetActive(true);
						mittenRing.SetActive(false);
						readyPickUp = false;
						hangLockKeyText.SetActive(false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppNyckel);
						if (haveAvbitare)
						{
							avbitare.SetActive(false);
							haveAvbitare = false;
							UnityEngine.Object.Instantiate(newAvbitare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveHammare)
						{
							hammare.SetActive(false);
							haveHammare = false;
							UnityEngine.Object.Instantiate(newHammare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas)
						{
							vas.SetActive(false);
							havevas = false;
							UnityEngine.Object.Instantiate(newvas, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesafeKey)
						{
							safeKey.SetActive(false);
							havesafeKey = false;
							UnityEngine.Object.Instantiate(newsafeKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveexitKey)
						{
							exitKey.SetActive(false);
							haveexitKey = false;
							UnityEngine.Object.Instantiate(newexitKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havepadlockCode)
						{
							padlockCode.SetActive(false);
							havepadlockCode = false;
							UnityEngine.Object.Instantiate(newpadlockCode, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havearmborst)
						{
							armborst.SetActive(false);
							havearmborst = false;
							arrowButton.SetActive(false);
							shootArrowRay.SetActive(false);
							UnityEngine.Object.Instantiate(newarmborst, dropPoint.transform.position, dropPoint.transform.rotation);
							if (armborstArrowOK)
							{
								UnityEngine.Object.Instantiate(newArrow, dropPoint.transform.position, dropPoint.transform.rotation);
								haveArrow = false;
								armborstArrowOK = false;
							}
						}
						else if (haveweaponKey)
						{
							weaponKey.SetActive(false);
							haveweaponKey = false;
							UnityEngine.Object.Instantiate(newweaponKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havescrewdriver)
						{
							screwdriver.SetActive(false);
							havescrewdriver = false;
							UnityEngine.Object.Instantiate(newscrewdriver, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplanka)
						{
							planka.SetActive(false);
							haveplanka = false;
							UnityEngine.Object.Instantiate(newplanka, dropPoint.transform.position, dropPoint.transform.rotation);
							placeObject = false;
							placeObjectButton.SetActive(false);
						}
						else if (havebattery)
						{
							battery.SetActive(false);
							havebattery = false;
							UnityEngine.Object.Instantiate(newbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb1)
						{
							tb1.SetActive(false);
							havetb1 = false;
							UnityEngine.Object.Instantiate(newtb1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb2)
						{
							tb2.SetActive(false);
							havetb2 = false;
							UnityEngine.Object.Instantiate(newtb2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb3)
						{
							tb3.SetActive(false);
							havetb3 = false;
							UnityEngine.Object.Instantiate(newtb3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb4)
						{
							tb4.SetActive(false);
							havetb4 = false;
							UnityEngine.Object.Instantiate(newtb4, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas2)
						{
							vas2.SetActive(false);
							havevas2 = false;
							UnityEngine.Object.Instantiate(newvas2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplayhouseKey)
						{
							playhouseKey.SetActive(false);
							haveplayhouseKey = false;
							UnityEngine.Object.Instantiate(newplayhouseKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemelon)
						{
							melon.SetActive(false);
							havemelon = false;
							UnityEngine.Object.Instantiate(newmelon, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveteddy)
						{
							teddy.SetActive(false);
							haveteddy = false;
							((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
							UnityEngine.Object.Instantiate(newteddy, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg1)
						{
							kugg1.SetActive(false);
							havekugg1 = false;
							UnityEngine.Object.Instantiate(newkugg1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg2)
						{
							kugg2.SetActive(false);
							havekugg2 = false;
							UnityEngine.Object.Instantiate(newkugg2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemessage)
						{
							message.SetActive(false);
							havemessage = false;
							UnityEngine.Object.Instantiate(newmessage, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebrunnsvev)
						{
							brunnsvev.SetActive(false);
							havebrunnsvev = false;
							UnityEngine.Object.Instantiate(newbrunnsvev, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveoldShotgun)
						{
							oldShotgun.SetActive(false);
							haveoldShotgun = false;
							shootButton.SetActive(false);
							shootRay.SetActive(false);
							UnityEngine.Object.Instantiate(newoldShotgun, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel1)
						{
							gunDel1.SetActive(false);
							havegunDel1 = false;
							UnityEngine.Object.Instantiate(newgunDel1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel2)
						{
							gunDel2.SetActive(false);
							havegunDel2 = false;
							UnityEngine.Object.Instantiate(newgunDel2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel3)
						{
							gunDel3.SetActive(false);
							havegunDel3 = false;
							UnityEngine.Object.Instantiate(newgunDel3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarKey)
						{
							carKey.SetActive(false);
							havecarKey = false;
							((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).playerHaveCarKey = false;
							UnityEngine.Object.Instantiate(newcarKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetopplock)
						{
							topplock.SetActive(false);
							havetopplock = false;
							UnityEngine.Object.Instantiate(newtopplock, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarbattery)
						{
							carbattery.SetActive(false);
							havecarbattery = false;
							UnityEngine.Object.Instantiate(newcarbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegascan)
						{
							gascan.SetActive(false);
							havegascan = false;
							UnityEngine.Object.Instantiate(newgascan, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havewrench)
						{
							wrench.SetActive(false);
							havewrench = false;
							UnityEngine.Object.Instantiate(newwrench, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesparkplug)
						{
							sparkplug.SetActive(false);
							havesparkplug = false;
							UnityEngine.Object.Instantiate(newsparkplug, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemeat)
						{
							meat.SetActive(false);
							havemeat = false;
							UnityEngine.Object.Instantiate(newmeat, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havespecialkey)
						{
							specialkey.SetActive(false);
							havespecialkey = false;
							UnityEngine.Object.Instantiate(newspecialkey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebook)
						{
							book.SetActive(false);
							havebook = false;
							UnityEngine.Object.Instantiate(newbook, dropPoint.transform.position, dropPoint.transform.rotation);
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "dpadlockCode")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					padlockCodeText.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						padlockCode.SetActive(true);
						havepadlockCode = true;
						dropObjectButton.SetActive(true);
						mittenRing.SetActive(false);
						readyPickUp = false;
						padlockCodeText.SetActive(false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
						if (haveAvbitare)
						{
							avbitare.SetActive(false);
							haveAvbitare = false;
							UnityEngine.Object.Instantiate(newAvbitare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveHammare)
						{
							hammare.SetActive(false);
							haveHammare = false;
							UnityEngine.Object.Instantiate(newHammare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas)
						{
							vas.SetActive(false);
							havevas = false;
							UnityEngine.Object.Instantiate(newvas, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesafeKey)
						{
							safeKey.SetActive(false);
							havesafeKey = false;
							UnityEngine.Object.Instantiate(newsafeKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveexitKey)
						{
							exitKey.SetActive(false);
							haveexitKey = false;
							UnityEngine.Object.Instantiate(newexitKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havehanglockKey)
						{
							hanglockKey.SetActive(false);
							havehanglockKey = false;
							UnityEngine.Object.Instantiate(newhanglockKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havearmborst)
						{
							armborst.SetActive(false);
							havearmborst = false;
							arrowButton.SetActive(false);
							shootArrowRay.SetActive(false);
							UnityEngine.Object.Instantiate(newarmborst, dropPoint.transform.position, dropPoint.transform.rotation);
							if (armborstArrowOK)
							{
								UnityEngine.Object.Instantiate(newArrow, dropPoint.transform.position, dropPoint.transform.rotation);
								haveArrow = false;
								armborstArrowOK = false;
							}
						}
						else if (haveweaponKey)
						{
							weaponKey.SetActive(false);
							haveweaponKey = false;
							UnityEngine.Object.Instantiate(newweaponKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havescrewdriver)
						{
							screwdriver.SetActive(false);
							havescrewdriver = false;
							UnityEngine.Object.Instantiate(newscrewdriver, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplanka)
						{
							planka.SetActive(false);
							haveplanka = false;
							UnityEngine.Object.Instantiate(newplanka, dropPoint.transform.position, dropPoint.transform.rotation);
							placeObject = false;
							placeObjectButton.SetActive(false);
						}
						else if (havebattery)
						{
							battery.SetActive(false);
							havebattery = false;
							UnityEngine.Object.Instantiate(newbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb1)
						{
							tb1.SetActive(false);
							havetb1 = false;
							UnityEngine.Object.Instantiate(newtb1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb2)
						{
							tb2.SetActive(false);
							havetb2 = false;
							UnityEngine.Object.Instantiate(newtb2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb3)
						{
							tb3.SetActive(false);
							havetb3 = false;
							UnityEngine.Object.Instantiate(newtb3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb4)
						{
							tb4.SetActive(false);
							havetb4 = false;
							UnityEngine.Object.Instantiate(newtb4, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas2)
						{
							vas2.SetActive(false);
							havevas2 = false;
							UnityEngine.Object.Instantiate(newvas2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplayhouseKey)
						{
							playhouseKey.SetActive(false);
							haveplayhouseKey = false;
							UnityEngine.Object.Instantiate(newplayhouseKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemelon)
						{
							melon.SetActive(false);
							havemelon = false;
							UnityEngine.Object.Instantiate(newmelon, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveteddy)
						{
							teddy.SetActive(false);
							haveteddy = false;
							((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
							UnityEngine.Object.Instantiate(newteddy, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg1)
						{
							kugg1.SetActive(false);
							havekugg1 = false;
							UnityEngine.Object.Instantiate(newkugg1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg2)
						{
							kugg2.SetActive(false);
							havekugg2 = false;
							UnityEngine.Object.Instantiate(newkugg2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemessage)
						{
							message.SetActive(false);
							havemessage = false;
							UnityEngine.Object.Instantiate(newmessage, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebrunnsvev)
						{
							brunnsvev.SetActive(false);
							havebrunnsvev = false;
							UnityEngine.Object.Instantiate(newbrunnsvev, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveoldShotgun)
						{
							oldShotgun.SetActive(false);
							haveoldShotgun = false;
							shootButton.SetActive(false);
							shootRay.SetActive(false);
							UnityEngine.Object.Instantiate(newoldShotgun, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel1)
						{
							gunDel1.SetActive(false);
							havegunDel1 = false;
							UnityEngine.Object.Instantiate(newgunDel1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel2)
						{
							gunDel2.SetActive(false);
							havegunDel2 = false;
							UnityEngine.Object.Instantiate(newgunDel2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel3)
						{
							gunDel3.SetActive(false);
							havegunDel3 = false;
							UnityEngine.Object.Instantiate(newgunDel3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarKey)
						{
							carKey.SetActive(false);
							havecarKey = false;
							((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).playerHaveCarKey = false;
							UnityEngine.Object.Instantiate(newcarKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetopplock)
						{
							topplock.SetActive(false);
							havetopplock = false;
							UnityEngine.Object.Instantiate(newtopplock, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarbattery)
						{
							carbattery.SetActive(false);
							havecarbattery = false;
							UnityEngine.Object.Instantiate(newcarbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegascan)
						{
							gascan.SetActive(false);
							havegascan = false;
							UnityEngine.Object.Instantiate(newgascan, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havewrench)
						{
							wrench.SetActive(false);
							havewrench = false;
							UnityEngine.Object.Instantiate(newwrench, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesparkplug)
						{
							sparkplug.SetActive(false);
							havesparkplug = false;
							UnityEngine.Object.Instantiate(newsparkplug, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemeat)
						{
							meat.SetActive(false);
							havemeat = false;
							UnityEngine.Object.Instantiate(newmeat, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havespecialkey)
						{
							specialkey.SetActive(false);
							havespecialkey = false;
							UnityEngine.Object.Instantiate(newspecialkey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebook)
						{
							book.SetActive(false);
							havebook = false;
							UnityEngine.Object.Instantiate(newbook, dropPoint.transform.position, dropPoint.transform.rotation);
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "armborst")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					CrossbowText.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						armborst.SetActive(true);
						arrowButton.SetActive(false);
						arrowArmborst.SetActive(false);
						Armborstladdad.SetActive(false);
						ArmborstOladdad.SetActive(true);
						havearmborst = true;
						dropObjectButton.SetActive(true);
						mittenRing.SetActive(false);
						readyPickUp = false;
						CrossbowText.SetActive(false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppCrossbow);
						if (haveAvbitare)
						{
							avbitare.SetActive(false);
							haveAvbitare = false;
							UnityEngine.Object.Instantiate(newAvbitare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveHammare)
						{
							hammare.SetActive(false);
							haveHammare = false;
							UnityEngine.Object.Instantiate(newHammare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas)
						{
							vas.SetActive(false);
							havevas = false;
							UnityEngine.Object.Instantiate(newvas, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesafeKey)
						{
							safeKey.SetActive(false);
							havesafeKey = false;
							UnityEngine.Object.Instantiate(newsafeKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveexitKey)
						{
							exitKey.SetActive(false);
							haveexitKey = false;
							UnityEngine.Object.Instantiate(newexitKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havehanglockKey)
						{
							hanglockKey.SetActive(false);
							havehanglockKey = false;
							UnityEngine.Object.Instantiate(newhanglockKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havepadlockCode)
						{
							padlockCode.SetActive(false);
							havepadlockCode = false;
							UnityEngine.Object.Instantiate(newpadlockCode, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveweaponKey)
						{
							weaponKey.SetActive(false);
							haveweaponKey = false;
							UnityEngine.Object.Instantiate(newweaponKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havescrewdriver)
						{
							screwdriver.SetActive(false);
							havescrewdriver = false;
							UnityEngine.Object.Instantiate(newscrewdriver, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplanka)
						{
							planka.SetActive(false);
							haveplanka = false;
							UnityEngine.Object.Instantiate(newplanka, dropPoint.transform.position, dropPoint.transform.rotation);
							placeObject = false;
							placeObjectButton.SetActive(false);
						}
						else if (havebattery)
						{
							battery.SetActive(false);
							havebattery = false;
							UnityEngine.Object.Instantiate(newbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb1)
						{
							tb1.SetActive(false);
							havetb1 = false;
							UnityEngine.Object.Instantiate(newtb1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb2)
						{
							tb2.SetActive(false);
							havetb2 = false;
							UnityEngine.Object.Instantiate(newtb2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb3)
						{
							tb3.SetActive(false);
							havetb3 = false;
							UnityEngine.Object.Instantiate(newtb3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb4)
						{
							tb4.SetActive(false);
							havetb4 = false;
							UnityEngine.Object.Instantiate(newtb4, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas2)
						{
							vas2.SetActive(false);
							havevas2 = false;
							UnityEngine.Object.Instantiate(newvas2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplayhouseKey)
						{
							playhouseKey.SetActive(false);
							haveplayhouseKey = false;
							UnityEngine.Object.Instantiate(newplayhouseKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemelon)
						{
							melon.SetActive(false);
							havemelon = false;
							UnityEngine.Object.Instantiate(newmelon, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveteddy)
						{
							teddy.SetActive(false);
							haveteddy = false;
							((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
							UnityEngine.Object.Instantiate(newteddy, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg1)
						{
							kugg1.SetActive(false);
							havekugg1 = false;
							UnityEngine.Object.Instantiate(newkugg1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg2)
						{
							kugg2.SetActive(false);
							havekugg2 = false;
							UnityEngine.Object.Instantiate(newkugg2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemessage)
						{
							message.SetActive(false);
							havemessage = false;
							UnityEngine.Object.Instantiate(newmessage, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebrunnsvev)
						{
							brunnsvev.SetActive(false);
							havebrunnsvev = false;
							UnityEngine.Object.Instantiate(newbrunnsvev, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveoldShotgun)
						{
							oldShotgun.SetActive(false);
							haveoldShotgun = false;
							shootButton.SetActive(false);
							shootRay.SetActive(false);
							UnityEngine.Object.Instantiate(newoldShotgun, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel1)
						{
							gunDel1.SetActive(false);
							havegunDel1 = false;
							UnityEngine.Object.Instantiate(newgunDel1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel2)
						{
							gunDel2.SetActive(false);
							havegunDel2 = false;
							UnityEngine.Object.Instantiate(newgunDel2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel3)
						{
							gunDel3.SetActive(false);
							havegunDel3 = false;
							UnityEngine.Object.Instantiate(newgunDel3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarKey)
						{
							carKey.SetActive(false);
							havecarKey = false;
							((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).playerHaveCarKey = false;
							UnityEngine.Object.Instantiate(newcarKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetopplock)
						{
							topplock.SetActive(false);
							havetopplock = false;
							UnityEngine.Object.Instantiate(newtopplock, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarbattery)
						{
							carbattery.SetActive(false);
							havecarbattery = false;
							UnityEngine.Object.Instantiate(newcarbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegascan)
						{
							gascan.SetActive(false);
							havegascan = false;
							UnityEngine.Object.Instantiate(newgascan, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havewrench)
						{
							wrench.SetActive(false);
							havewrench = false;
							UnityEngine.Object.Instantiate(newwrench, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesparkplug)
						{
							sparkplug.SetActive(false);
							havesparkplug = false;
							UnityEngine.Object.Instantiate(newsparkplug, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemeat)
						{
							meat.SetActive(false);
							havemeat = false;
							UnityEngine.Object.Instantiate(newmeat, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havespecialkey)
						{
							specialkey.SetActive(false);
							havespecialkey = false;
							UnityEngine.Object.Instantiate(newspecialkey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebook)
						{
							book.SetActive(false);
							havebook = false;
							UnityEngine.Object.Instantiate(newbook, dropPoint.transform.position, dropPoint.transform.rotation);
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "arrow")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					TranquilizerDartText.SetActive(true);
					if (havearmborst)
					{
						if (pickUp)
						{
							if (!haveArrow)
							{
								haveArrow = true;
								pickUp = false;
								UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
								arrowButton.SetActive(true);
								shootArrowRay.SetActive(true);
								arrowArmborst.SetActive(true);
								Armborstladdad.SetActive(true);
								ArmborstOladdad.SetActive(false);
								mittenRing.SetActive(false);
								readyPickUp = false;
								armborstArrowOK = true;
								TranquilizerDartText.SetActive(false);
								GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
								((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).CrossbowLoad();
							}
							else if (haveArrow)
							{
								haveArrow = true;
								pickUp = false;
								UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
								arrowButton.SetActive(true);
								shootArrowRay.SetActive(true);
								arrowArmborst.SetActive(true);
								Armborstladdad.SetActive(true);
								ArmborstOladdad.SetActive(false);
								mittenRing.SetActive(false);
								armborstArrowOK = true;
								TranquilizerDartText.SetActive(false);
								GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
								UnityEngine.Object.Instantiate(newArrow, dropPoint.transform.position, dropPoint.transform.rotation);
							}
						}
					}
					else if (pickUp)
					{
						pickUp = false;
						NeedCrossbowText.SetActive(true);
						textTimerOnOff = true;
					}
				}
				else if (hitInfo.collider.gameObject.tag == "weaponkey")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					weaponKeyText.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						weaponKey.SetActive(true);
						haveweaponKey = true;
						dropObjectButton.SetActive(true);
						mittenRing.SetActive(false);
						readyPickUp = false;
						weaponKeyText.SetActive(false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
						if (haveAvbitare)
						{
							avbitare.SetActive(false);
							haveAvbitare = false;
							UnityEngine.Object.Instantiate(newAvbitare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveHammare)
						{
							hammare.SetActive(false);
							haveHammare = false;
							UnityEngine.Object.Instantiate(newHammare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas)
						{
							vas.SetActive(false);
							havevas = false;
							UnityEngine.Object.Instantiate(newvas, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesafeKey)
						{
							safeKey.SetActive(false);
							havesafeKey = false;
							UnityEngine.Object.Instantiate(newsafeKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveexitKey)
						{
							exitKey.SetActive(false);
							haveexitKey = false;
							UnityEngine.Object.Instantiate(newexitKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havehanglockKey)
						{
							hanglockKey.SetActive(false);
							havehanglockKey = false;
							UnityEngine.Object.Instantiate(newhanglockKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havepadlockCode)
						{
							padlockCode.SetActive(false);
							havepadlockCode = false;
							UnityEngine.Object.Instantiate(newpadlockCode, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havearmborst)
						{
							armborst.SetActive(false);
							havearmborst = false;
							arrowButton.SetActive(false);
							shootArrowRay.SetActive(false);
							UnityEngine.Object.Instantiate(newarmborst, dropPoint.transform.position, dropPoint.transform.rotation);
							if (armborstArrowOK)
							{
								UnityEngine.Object.Instantiate(newArrow, dropPoint.transform.position, dropPoint.transform.rotation);
								haveArrow = false;
								armborstArrowOK = false;
							}
						}
						else if (havescrewdriver)
						{
							screwdriver.SetActive(false);
							havescrewdriver = false;
							UnityEngine.Object.Instantiate(newscrewdriver, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplanka)
						{
							planka.SetActive(false);
							haveplanka = false;
							UnityEngine.Object.Instantiate(newplanka, dropPoint.transform.position, dropPoint.transform.rotation);
							placeObject = false;
							placeObjectButton.SetActive(false);
						}
						else if (havebattery)
						{
							battery.SetActive(false);
							havebattery = false;
							UnityEngine.Object.Instantiate(newbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb1)
						{
							tb1.SetActive(false);
							havetb1 = false;
							UnityEngine.Object.Instantiate(newtb1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb2)
						{
							tb2.SetActive(false);
							havetb2 = false;
							UnityEngine.Object.Instantiate(newtb2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb3)
						{
							tb3.SetActive(false);
							havetb3 = false;
							UnityEngine.Object.Instantiate(newtb3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb4)
						{
							tb4.SetActive(false);
							havetb4 = false;
							UnityEngine.Object.Instantiate(newtb4, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas2)
						{
							vas2.SetActive(false);
							havevas2 = false;
							UnityEngine.Object.Instantiate(newvas2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplayhouseKey)
						{
							playhouseKey.SetActive(false);
							haveplayhouseKey = false;
							UnityEngine.Object.Instantiate(newplayhouseKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemelon)
						{
							melon.SetActive(false);
							havemelon = false;
							UnityEngine.Object.Instantiate(newmelon, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveteddy)
						{
							teddy.SetActive(false);
							haveteddy = false;
							((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
							UnityEngine.Object.Instantiate(newteddy, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg1)
						{
							kugg1.SetActive(false);
							havekugg1 = false;
							UnityEngine.Object.Instantiate(newkugg1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg2)
						{
							kugg2.SetActive(false);
							havekugg2 = false;
							UnityEngine.Object.Instantiate(newkugg2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemessage)
						{
							message.SetActive(false);
							havemessage = false;
							UnityEngine.Object.Instantiate(newmessage, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebrunnsvev)
						{
							brunnsvev.SetActive(false);
							havebrunnsvev = false;
							UnityEngine.Object.Instantiate(newbrunnsvev, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveoldShotgun)
						{
							oldShotgun.SetActive(false);
							haveoldShotgun = false;
							shootButton.SetActive(false);
							shootRay.SetActive(false);
							UnityEngine.Object.Instantiate(newoldShotgun, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel1)
						{
							gunDel1.SetActive(false);
							havegunDel1 = false;
							UnityEngine.Object.Instantiate(newgunDel1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel2)
						{
							gunDel2.SetActive(false);
							havegunDel2 = false;
							UnityEngine.Object.Instantiate(newgunDel2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel3)
						{
							gunDel3.SetActive(false);
							havegunDel3 = false;
							UnityEngine.Object.Instantiate(newgunDel3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarKey)
						{
							carKey.SetActive(false);
							havecarKey = false;
							((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).playerHaveCarKey = false;
							UnityEngine.Object.Instantiate(newcarKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetopplock)
						{
							topplock.SetActive(false);
							havetopplock = false;
							UnityEngine.Object.Instantiate(newtopplock, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarbattery)
						{
							carbattery.SetActive(false);
							havecarbattery = false;
							UnityEngine.Object.Instantiate(newcarbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegascan)
						{
							gascan.SetActive(false);
							havegascan = false;
							UnityEngine.Object.Instantiate(newgascan, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havewrench)
						{
							wrench.SetActive(false);
							havewrench = false;
							UnityEngine.Object.Instantiate(newwrench, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesparkplug)
						{
							sparkplug.SetActive(false);
							havesparkplug = false;
							UnityEngine.Object.Instantiate(newsparkplug, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemeat)
						{
							meat.SetActive(false);
							havemeat = false;
							UnityEngine.Object.Instantiate(newmeat, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havespecialkey)
						{
							specialkey.SetActive(false);
							havespecialkey = false;
							UnityEngine.Object.Instantiate(newspecialkey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebook)
						{
							book.SetActive(false);
							havebook = false;
							UnityEngine.Object.Instantiate(newbook, dropPoint.transform.position, dropPoint.transform.rotation);
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "screwdriver")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					screwdriverText.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						screwdriver.SetActive(true);
						havescrewdriver = true;
						dropObjectButton.SetActive(true);
						mittenRing.SetActive(false);
						readyPickUp = false;
						screwdriverText.SetActive(false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
						if (haveAvbitare)
						{
							avbitare.SetActive(false);
							haveAvbitare = false;
							UnityEngine.Object.Instantiate(newAvbitare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveHammare)
						{
							hammare.SetActive(false);
							haveHammare = false;
							UnityEngine.Object.Instantiate(newHammare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas)
						{
							vas.SetActive(false);
							havevas = false;
							UnityEngine.Object.Instantiate(newvas, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesafeKey)
						{
							safeKey.SetActive(false);
							havesafeKey = false;
							UnityEngine.Object.Instantiate(newsafeKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveexitKey)
						{
							exitKey.SetActive(false);
							haveexitKey = false;
							UnityEngine.Object.Instantiate(newexitKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havehanglockKey)
						{
							hanglockKey.SetActive(false);
							havehanglockKey = false;
							UnityEngine.Object.Instantiate(newhanglockKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havepadlockCode)
						{
							padlockCode.SetActive(false);
							havepadlockCode = false;
							UnityEngine.Object.Instantiate(newpadlockCode, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havearmborst)
						{
							armborst.SetActive(false);
							havearmborst = false;
							arrowButton.SetActive(false);
							shootArrowRay.SetActive(false);
							UnityEngine.Object.Instantiate(newarmborst, dropPoint.transform.position, dropPoint.transform.rotation);
							if (armborstArrowOK)
							{
								UnityEngine.Object.Instantiate(newArrow, dropPoint.transform.position, dropPoint.transform.rotation);
								haveArrow = false;
								armborstArrowOK = false;
							}
						}
						else if (haveplanka)
						{
							planka.SetActive(false);
							haveplanka = false;
							UnityEngine.Object.Instantiate(newplanka, dropPoint.transform.position, dropPoint.transform.rotation);
							placeObject = false;
							placeObjectButton.SetActive(false);
						}
						else if (havebattery)
						{
							battery.SetActive(false);
							havebattery = false;
							UnityEngine.Object.Instantiate(newbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb1)
						{
							tb1.SetActive(false);
							havetb1 = false;
							UnityEngine.Object.Instantiate(newtb1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb2)
						{
							tb2.SetActive(false);
							havetb2 = false;
							UnityEngine.Object.Instantiate(newtb2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb3)
						{
							tb3.SetActive(false);
							havetb3 = false;
							UnityEngine.Object.Instantiate(newtb3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb4)
						{
							tb4.SetActive(false);
							havetb4 = false;
							UnityEngine.Object.Instantiate(newtb4, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas2)
						{
							vas2.SetActive(false);
							havevas2 = false;
							UnityEngine.Object.Instantiate(newvas2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplayhouseKey)
						{
							playhouseKey.SetActive(false);
							haveplayhouseKey = false;
							UnityEngine.Object.Instantiate(newplayhouseKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemelon)
						{
							melon.SetActive(false);
							havemelon = false;
							UnityEngine.Object.Instantiate(newmelon, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveteddy)
						{
							teddy.SetActive(false);
							haveteddy = false;
							((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
							UnityEngine.Object.Instantiate(newteddy, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg1)
						{
							kugg1.SetActive(false);
							havekugg1 = false;
							UnityEngine.Object.Instantiate(newkugg1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg2)
						{
							kugg2.SetActive(false);
							havekugg2 = false;
							UnityEngine.Object.Instantiate(newkugg2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemessage)
						{
							message.SetActive(false);
							havemessage = false;
							UnityEngine.Object.Instantiate(newmessage, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebrunnsvev)
						{
							brunnsvev.SetActive(false);
							havebrunnsvev = false;
							UnityEngine.Object.Instantiate(newbrunnsvev, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveweaponKey)
						{
							weaponKey.SetActive(false);
							haveweaponKey = false;
							UnityEngine.Object.Instantiate(newweaponKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveoldShotgun)
						{
							oldShotgun.SetActive(false);
							haveoldShotgun = false;
							shootButton.SetActive(false);
							shootRay.SetActive(false);
							UnityEngine.Object.Instantiate(newoldShotgun, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel1)
						{
							gunDel1.SetActive(false);
							havegunDel1 = false;
							UnityEngine.Object.Instantiate(newgunDel1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel2)
						{
							gunDel2.SetActive(false);
							havegunDel2 = false;
							UnityEngine.Object.Instantiate(newgunDel2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel3)
						{
							gunDel3.SetActive(false);
							havegunDel3 = false;
							UnityEngine.Object.Instantiate(newgunDel3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarKey)
						{
							carKey.SetActive(false);
							havecarKey = false;
							((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).playerHaveCarKey = false;
							UnityEngine.Object.Instantiate(newcarKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetopplock)
						{
							topplock.SetActive(false);
							havetopplock = false;
							UnityEngine.Object.Instantiate(newtopplock, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarbattery)
						{
							carbattery.SetActive(false);
							havecarbattery = false;
							UnityEngine.Object.Instantiate(newcarbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegascan)
						{
							gascan.SetActive(false);
							havegascan = false;
							UnityEngine.Object.Instantiate(newgascan, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havewrench)
						{
							wrench.SetActive(false);
							havewrench = false;
							UnityEngine.Object.Instantiate(newwrench, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesparkplug)
						{
							sparkplug.SetActive(false);
							havesparkplug = false;
							UnityEngine.Object.Instantiate(newsparkplug, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemeat)
						{
							meat.SetActive(false);
							havemeat = false;
							UnityEngine.Object.Instantiate(newmeat, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havespecialkey)
						{
							specialkey.SetActive(false);
							havespecialkey = false;
							UnityEngine.Object.Instantiate(newspecialkey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebook)
						{
							book.SetActive(false);
							havebook = false;
							UnityEngine.Object.Instantiate(newbook, dropPoint.transform.position, dropPoint.transform.rotation);
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "plankawalk")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					plankText.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						planka.SetActive(true);
						if (haveplanka)
						{
							UnityEngine.Object.Instantiate(newplanka, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						haveplanka = true;
						dropObjectButton.SetActive(true);
						mittenRing.SetActive(false);
						readyPickUp = false;
						plankText.SetActive(false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
						if (haveAvbitare)
						{
							avbitare.SetActive(false);
							haveAvbitare = false;
							UnityEngine.Object.Instantiate(newAvbitare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveHammare)
						{
							hammare.SetActive(false);
							haveHammare = false;
							UnityEngine.Object.Instantiate(newHammare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas)
						{
							vas.SetActive(false);
							havevas = false;
							UnityEngine.Object.Instantiate(newvas, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesafeKey)
						{
							safeKey.SetActive(false);
							havesafeKey = false;
							UnityEngine.Object.Instantiate(newsafeKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveexitKey)
						{
							exitKey.SetActive(false);
							haveexitKey = false;
							UnityEngine.Object.Instantiate(newexitKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havehanglockKey)
						{
							hanglockKey.SetActive(false);
							havehanglockKey = false;
							UnityEngine.Object.Instantiate(newhanglockKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havepadlockCode)
						{
							padlockCode.SetActive(false);
							havepadlockCode = false;
							UnityEngine.Object.Instantiate(newpadlockCode, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havearmborst)
						{
							armborst.SetActive(false);
							havearmborst = false;
							arrowButton.SetActive(false);
							shootArrowRay.SetActive(false);
							UnityEngine.Object.Instantiate(newarmborst, dropPoint.transform.position, dropPoint.transform.rotation);
							if (armborstArrowOK)
							{
								UnityEngine.Object.Instantiate(newArrow, dropPoint.transform.position, dropPoint.transform.rotation);
								haveArrow = false;
								armborstArrowOK = false;
							}
						}
						else if (havescrewdriver)
						{
							screwdriver.SetActive(false);
							havescrewdriver = false;
							UnityEngine.Object.Instantiate(newscrewdriver, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebattery)
						{
							battery.SetActive(false);
							havebattery = false;
							UnityEngine.Object.Instantiate(newbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb1)
						{
							tb1.SetActive(false);
							havetb1 = false;
							UnityEngine.Object.Instantiate(newtb1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb2)
						{
							tb2.SetActive(false);
							havetb2 = false;
							UnityEngine.Object.Instantiate(newtb2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb3)
						{
							tb3.SetActive(false);
							havetb3 = false;
							UnityEngine.Object.Instantiate(newtb3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb4)
						{
							tb4.SetActive(false);
							havetb4 = false;
							UnityEngine.Object.Instantiate(newtb4, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas2)
						{
							vas2.SetActive(false);
							havevas2 = false;
							UnityEngine.Object.Instantiate(newvas2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplayhouseKey)
						{
							playhouseKey.SetActive(false);
							haveplayhouseKey = false;
							UnityEngine.Object.Instantiate(newplayhouseKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemelon)
						{
							melon.SetActive(false);
							havemelon = false;
							UnityEngine.Object.Instantiate(newmelon, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveteddy)
						{
							teddy.SetActive(false);
							haveteddy = false;
							((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
							UnityEngine.Object.Instantiate(newteddy, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg1)
						{
							kugg1.SetActive(false);
							havekugg1 = false;
							UnityEngine.Object.Instantiate(newkugg1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg2)
						{
							kugg2.SetActive(false);
							havekugg2 = false;
							UnityEngine.Object.Instantiate(newkugg2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemessage)
						{
							message.SetActive(false);
							havemessage = false;
							UnityEngine.Object.Instantiate(newmessage, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebrunnsvev)
						{
							brunnsvev.SetActive(false);
							havebrunnsvev = false;
							UnityEngine.Object.Instantiate(newbrunnsvev, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveweaponKey)
						{
							weaponKey.SetActive(false);
							haveweaponKey = false;
							UnityEngine.Object.Instantiate(newweaponKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveoldShotgun)
						{
							oldShotgun.SetActive(false);
							haveoldShotgun = false;
							shootButton.SetActive(false);
							shootRay.SetActive(false);
							UnityEngine.Object.Instantiate(newoldShotgun, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel1)
						{
							gunDel1.SetActive(false);
							havegunDel1 = false;
							UnityEngine.Object.Instantiate(newgunDel1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel2)
						{
							gunDel2.SetActive(false);
							havegunDel2 = false;
							UnityEngine.Object.Instantiate(newgunDel2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel3)
						{
							gunDel3.SetActive(false);
							havegunDel3 = false;
							UnityEngine.Object.Instantiate(newgunDel3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarKey)
						{
							carKey.SetActive(false);
							havecarKey = false;
							((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).playerHaveCarKey = false;
							UnityEngine.Object.Instantiate(newcarKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetopplock)
						{
							topplock.SetActive(false);
							havetopplock = false;
							UnityEngine.Object.Instantiate(newtopplock, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarbattery)
						{
							carbattery.SetActive(false);
							havecarbattery = false;
							UnityEngine.Object.Instantiate(newcarbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegascan)
						{
							gascan.SetActive(false);
							havegascan = false;
							UnityEngine.Object.Instantiate(newgascan, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havewrench)
						{
							wrench.SetActive(false);
							havewrench = false;
							UnityEngine.Object.Instantiate(newwrench, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesparkplug)
						{
							sparkplug.SetActive(false);
							havesparkplug = false;
							UnityEngine.Object.Instantiate(newsparkplug, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemeat)
						{
							meat.SetActive(false);
							havemeat = false;
							UnityEngine.Object.Instantiate(newmeat, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havespecialkey)
						{
							specialkey.SetActive(false);
							havespecialkey = false;
							UnityEngine.Object.Instantiate(newspecialkey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebook)
						{
							book.SetActive(false);
							havebook = false;
							UnityEngine.Object.Instantiate(newbook, dropPoint.transform.position, dropPoint.transform.rotation);
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "battery")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					batteryText.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						battery.SetActive(true);
						havebattery = true;
						dropObjectButton.SetActive(true);
						mittenRing.SetActive(false);
						readyPickUp = false;
						batteryText.SetActive(false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
						if (haveAvbitare)
						{
							avbitare.SetActive(false);
							haveAvbitare = false;
							UnityEngine.Object.Instantiate(newAvbitare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveHammare)
						{
							hammare.SetActive(false);
							haveHammare = false;
							UnityEngine.Object.Instantiate(newHammare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas)
						{
							vas.SetActive(false);
							havevas = false;
							UnityEngine.Object.Instantiate(newvas, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesafeKey)
						{
							safeKey.SetActive(false);
							havesafeKey = false;
							UnityEngine.Object.Instantiate(newsafeKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveexitKey)
						{
							exitKey.SetActive(false);
							haveexitKey = false;
							UnityEngine.Object.Instantiate(newexitKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havehanglockKey)
						{
							hanglockKey.SetActive(false);
							havehanglockKey = false;
							UnityEngine.Object.Instantiate(newhanglockKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havepadlockCode)
						{
							padlockCode.SetActive(false);
							havepadlockCode = false;
							UnityEngine.Object.Instantiate(newpadlockCode, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havearmborst)
						{
							armborst.SetActive(false);
							havearmborst = false;
							arrowButton.SetActive(false);
							shootArrowRay.SetActive(false);
							UnityEngine.Object.Instantiate(newarmborst, dropPoint.transform.position, dropPoint.transform.rotation);
							if (armborstArrowOK)
							{
								UnityEngine.Object.Instantiate(newArrow, dropPoint.transform.position, dropPoint.transform.rotation);
								haveArrow = false;
								armborstArrowOK = false;
							}
						}
						else if (haveplanka)
						{
							planka.SetActive(false);
							haveplanka = false;
							UnityEngine.Object.Instantiate(newplanka, dropPoint.transform.position, dropPoint.transform.rotation);
							placeObject = false;
							placeObjectButton.SetActive(false);
						}
						else if (havescrewdriver)
						{
							screwdriver.SetActive(false);
							havescrewdriver = false;
							UnityEngine.Object.Instantiate(newscrewdriver, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb1)
						{
							tb1.SetActive(false);
							havetb1 = false;
							UnityEngine.Object.Instantiate(newtb1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb2)
						{
							tb2.SetActive(false);
							havetb2 = false;
							UnityEngine.Object.Instantiate(newtb2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb3)
						{
							tb3.SetActive(false);
							havetb3 = false;
							UnityEngine.Object.Instantiate(newtb3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb4)
						{
							tb4.SetActive(false);
							havetb4 = false;
							UnityEngine.Object.Instantiate(newtb4, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas2)
						{
							vas2.SetActive(false);
							havevas2 = false;
							UnityEngine.Object.Instantiate(newvas2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplayhouseKey)
						{
							playhouseKey.SetActive(false);
							haveplayhouseKey = false;
							UnityEngine.Object.Instantiate(newplayhouseKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemelon)
						{
							melon.SetActive(false);
							havemelon = false;
							UnityEngine.Object.Instantiate(newmelon, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveteddy)
						{
							teddy.SetActive(false);
							haveteddy = false;
							((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
							UnityEngine.Object.Instantiate(newteddy, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg1)
						{
							kugg1.SetActive(false);
							havekugg1 = false;
							UnityEngine.Object.Instantiate(newkugg1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg2)
						{
							kugg2.SetActive(false);
							havekugg2 = false;
							UnityEngine.Object.Instantiate(newkugg2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemessage)
						{
							message.SetActive(false);
							havemessage = false;
							UnityEngine.Object.Instantiate(newmessage, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebrunnsvev)
						{
							brunnsvev.SetActive(false);
							havebrunnsvev = false;
							UnityEngine.Object.Instantiate(newbrunnsvev, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveweaponKey)
						{
							weaponKey.SetActive(false);
							haveweaponKey = false;
							UnityEngine.Object.Instantiate(newweaponKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveoldShotgun)
						{
							oldShotgun.SetActive(false);
							haveoldShotgun = false;
							shootButton.SetActive(false);
							shootRay.SetActive(false);
							UnityEngine.Object.Instantiate(newoldShotgun, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel1)
						{
							gunDel1.SetActive(false);
							havegunDel1 = false;
							UnityEngine.Object.Instantiate(newgunDel1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel2)
						{
							gunDel2.SetActive(false);
							havegunDel2 = false;
							UnityEngine.Object.Instantiate(newgunDel2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel3)
						{
							gunDel3.SetActive(false);
							havegunDel3 = false;
							UnityEngine.Object.Instantiate(newgunDel3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarKey)
						{
							carKey.SetActive(false);
							havecarKey = false;
							((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).playerHaveCarKey = false;
							UnityEngine.Object.Instantiate(newcarKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetopplock)
						{
							topplock.SetActive(false);
							havetopplock = false;
							UnityEngine.Object.Instantiate(newtopplock, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarbattery)
						{
							carbattery.SetActive(false);
							havecarbattery = false;
							UnityEngine.Object.Instantiate(newcarbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegascan)
						{
							gascan.SetActive(false);
							havegascan = false;
							UnityEngine.Object.Instantiate(newgascan, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havewrench)
						{
							wrench.SetActive(false);
							havewrench = false;
							UnityEngine.Object.Instantiate(newwrench, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesparkplug)
						{
							sparkplug.SetActive(false);
							havesparkplug = false;
							UnityEngine.Object.Instantiate(newsparkplug, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemeat)
						{
							meat.SetActive(false);
							havemeat = false;
							UnityEngine.Object.Instantiate(newmeat, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havespecialkey)
						{
							specialkey.SetActive(false);
							havespecialkey = false;
							UnityEngine.Object.Instantiate(newspecialkey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebook)
						{
							book.SetActive(false);
							havebook = false;
							UnityEngine.Object.Instantiate(newbook, dropPoint.transform.position, dropPoint.transform.rotation);
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "tb1")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					tavelbitText.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						tb1.SetActive(true);
						havetb1 = true;
						dropObjectButton.SetActive(true);
						mittenRing.SetActive(false);
						readyPickUp = false;
						tavelbitText.SetActive(false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
						if (haveAvbitare)
						{
							avbitare.SetActive(false);
							haveAvbitare = false;
							UnityEngine.Object.Instantiate(newAvbitare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveHammare)
						{
							hammare.SetActive(false);
							haveHammare = false;
							UnityEngine.Object.Instantiate(newHammare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas)
						{
							vas.SetActive(false);
							havevas = false;
							UnityEngine.Object.Instantiate(newvas, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesafeKey)
						{
							safeKey.SetActive(false);
							havesafeKey = false;
							UnityEngine.Object.Instantiate(newsafeKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveexitKey)
						{
							exitKey.SetActive(false);
							haveexitKey = false;
							UnityEngine.Object.Instantiate(newexitKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havehanglockKey)
						{
							hanglockKey.SetActive(false);
							havehanglockKey = false;
							UnityEngine.Object.Instantiate(newhanglockKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havepadlockCode)
						{
							padlockCode.SetActive(false);
							havepadlockCode = false;
							UnityEngine.Object.Instantiate(newpadlockCode, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havearmborst)
						{
							armborst.SetActive(false);
							havearmborst = false;
							arrowButton.SetActive(false);
							shootArrowRay.SetActive(false);
							UnityEngine.Object.Instantiate(newarmborst, dropPoint.transform.position, dropPoint.transform.rotation);
							if (armborstArrowOK)
							{
								UnityEngine.Object.Instantiate(newArrow, dropPoint.transform.position, dropPoint.transform.rotation);
								haveArrow = false;
								armborstArrowOK = false;
							}
						}
						else if (haveplanka)
						{
							planka.SetActive(false);
							haveplanka = false;
							UnityEngine.Object.Instantiate(newplanka, dropPoint.transform.position, dropPoint.transform.rotation);
							placeObject = false;
							placeObjectButton.SetActive(false);
						}
						else if (havescrewdriver)
						{
							screwdriver.SetActive(false);
							havescrewdriver = false;
							UnityEngine.Object.Instantiate(newscrewdriver, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebattery)
						{
							battery.SetActive(false);
							havebattery = false;
							UnityEngine.Object.Instantiate(newbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb2)
						{
							tb2.SetActive(false);
							havetb2 = false;
							UnityEngine.Object.Instantiate(newtb2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb3)
						{
							tb3.SetActive(false);
							havetb3 = false;
							UnityEngine.Object.Instantiate(newtb3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb4)
						{
							tb4.SetActive(false);
							havetb4 = false;
							UnityEngine.Object.Instantiate(newtb4, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas2)
						{
							vas2.SetActive(false);
							havevas2 = false;
							UnityEngine.Object.Instantiate(newvas2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplayhouseKey)
						{
							playhouseKey.SetActive(false);
							haveplayhouseKey = false;
							UnityEngine.Object.Instantiate(newplayhouseKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemelon)
						{
							melon.SetActive(false);
							havemelon = false;
							UnityEngine.Object.Instantiate(newmelon, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveteddy)
						{
							teddy.SetActive(false);
							haveteddy = false;
							((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
							UnityEngine.Object.Instantiate(newteddy, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg1)
						{
							kugg1.SetActive(false);
							havekugg1 = false;
							UnityEngine.Object.Instantiate(newkugg1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg2)
						{
							kugg2.SetActive(false);
							havekugg2 = false;
							UnityEngine.Object.Instantiate(newkugg2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemessage)
						{
							message.SetActive(false);
							havemessage = false;
							UnityEngine.Object.Instantiate(newmessage, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebrunnsvev)
						{
							brunnsvev.SetActive(false);
							havebrunnsvev = false;
							UnityEngine.Object.Instantiate(newbrunnsvev, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveweaponKey)
						{
							weaponKey.SetActive(false);
							haveweaponKey = false;
							UnityEngine.Object.Instantiate(newweaponKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveoldShotgun)
						{
							oldShotgun.SetActive(false);
							haveoldShotgun = false;
							shootButton.SetActive(false);
							shootRay.SetActive(false);
							UnityEngine.Object.Instantiate(newoldShotgun, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel1)
						{
							gunDel1.SetActive(false);
							havegunDel1 = false;
							UnityEngine.Object.Instantiate(newgunDel1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel2)
						{
							gunDel2.SetActive(false);
							havegunDel2 = false;
							UnityEngine.Object.Instantiate(newgunDel2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel3)
						{
							gunDel3.SetActive(false);
							havegunDel3 = false;
							UnityEngine.Object.Instantiate(newgunDel3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarKey)
						{
							carKey.SetActive(false);
							havecarKey = false;
							((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).playerHaveCarKey = false;
							UnityEngine.Object.Instantiate(newcarKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetopplock)
						{
							topplock.SetActive(false);
							havetopplock = false;
							UnityEngine.Object.Instantiate(newtopplock, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarbattery)
						{
							carbattery.SetActive(false);
							havecarbattery = false;
							UnityEngine.Object.Instantiate(newcarbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegascan)
						{
							gascan.SetActive(false);
							havegascan = false;
							UnityEngine.Object.Instantiate(newgascan, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havewrench)
						{
							wrench.SetActive(false);
							havewrench = false;
							UnityEngine.Object.Instantiate(newwrench, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesparkplug)
						{
							sparkplug.SetActive(false);
							havesparkplug = false;
							UnityEngine.Object.Instantiate(newsparkplug, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemeat)
						{
							meat.SetActive(false);
							havemeat = false;
							UnityEngine.Object.Instantiate(newmeat, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havespecialkey)
						{
							specialkey.SetActive(false);
							havespecialkey = false;
							UnityEngine.Object.Instantiate(newspecialkey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebook)
						{
							book.SetActive(false);
							havebook = false;
							UnityEngine.Object.Instantiate(newbook, dropPoint.transform.position, dropPoint.transform.rotation);
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "tb2")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					tavelbitText.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						tb2.SetActive(true);
						havetb2 = true;
						dropObjectButton.SetActive(true);
						mittenRing.SetActive(false);
						readyPickUp = false;
						tavelbitText.SetActive(false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
						if (haveAvbitare)
						{
							avbitare.SetActive(false);
							haveAvbitare = false;
							UnityEngine.Object.Instantiate(newAvbitare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveHammare)
						{
							hammare.SetActive(false);
							haveHammare = false;
							UnityEngine.Object.Instantiate(newHammare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas)
						{
							vas.SetActive(false);
							havevas = false;
							UnityEngine.Object.Instantiate(newvas, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesafeKey)
						{
							safeKey.SetActive(false);
							havesafeKey = false;
							UnityEngine.Object.Instantiate(newsafeKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveexitKey)
						{
							exitKey.SetActive(false);
							haveexitKey = false;
							UnityEngine.Object.Instantiate(newexitKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havehanglockKey)
						{
							hanglockKey.SetActive(false);
							havehanglockKey = false;
							UnityEngine.Object.Instantiate(newhanglockKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havepadlockCode)
						{
							padlockCode.SetActive(false);
							havepadlockCode = false;
							UnityEngine.Object.Instantiate(newpadlockCode, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havearmborst)
						{
							armborst.SetActive(false);
							havearmborst = false;
							arrowButton.SetActive(false);
							shootArrowRay.SetActive(false);
							UnityEngine.Object.Instantiate(newarmborst, dropPoint.transform.position, dropPoint.transform.rotation);
							if (armborstArrowOK)
							{
								UnityEngine.Object.Instantiate(newArrow, dropPoint.transform.position, dropPoint.transform.rotation);
								haveArrow = false;
								armborstArrowOK = false;
							}
						}
						else if (haveplanka)
						{
							planka.SetActive(false);
							haveplanka = false;
							UnityEngine.Object.Instantiate(newplanka, dropPoint.transform.position, dropPoint.transform.rotation);
							placeObject = false;
							placeObjectButton.SetActive(false);
						}
						else if (havescrewdriver)
						{
							screwdriver.SetActive(false);
							havescrewdriver = false;
							UnityEngine.Object.Instantiate(newscrewdriver, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebattery)
						{
							battery.SetActive(false);
							havebattery = false;
							UnityEngine.Object.Instantiate(newbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb1)
						{
							tb1.SetActive(false);
							havetb1 = false;
							UnityEngine.Object.Instantiate(newtb1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb3)
						{
							tb3.SetActive(false);
							havetb3 = false;
							UnityEngine.Object.Instantiate(newtb3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb4)
						{
							tb4.SetActive(false);
							havetb4 = false;
							UnityEngine.Object.Instantiate(newtb4, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas2)
						{
							vas2.SetActive(false);
							havevas2 = false;
							UnityEngine.Object.Instantiate(newvas2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplayhouseKey)
						{
							playhouseKey.SetActive(false);
							haveplayhouseKey = false;
							UnityEngine.Object.Instantiate(newplayhouseKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemelon)
						{
							melon.SetActive(false);
							havemelon = false;
							UnityEngine.Object.Instantiate(newmelon, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveteddy)
						{
							teddy.SetActive(false);
							haveteddy = false;
							((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
							UnityEngine.Object.Instantiate(newteddy, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg1)
						{
							kugg1.SetActive(false);
							havekugg1 = false;
							UnityEngine.Object.Instantiate(newkugg1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg2)
						{
							kugg2.SetActive(false);
							havekugg2 = false;
							UnityEngine.Object.Instantiate(newkugg2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemessage)
						{
							message.SetActive(false);
							havemessage = false;
							UnityEngine.Object.Instantiate(newmessage, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebrunnsvev)
						{
							brunnsvev.SetActive(false);
							havebrunnsvev = false;
							UnityEngine.Object.Instantiate(newbrunnsvev, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveweaponKey)
						{
							weaponKey.SetActive(false);
							haveweaponKey = false;
							UnityEngine.Object.Instantiate(newweaponKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveoldShotgun)
						{
							oldShotgun.SetActive(false);
							haveoldShotgun = false;
							shootButton.SetActive(false);
							shootRay.SetActive(false);
							UnityEngine.Object.Instantiate(newoldShotgun, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel1)
						{
							gunDel1.SetActive(false);
							havegunDel1 = false;
							UnityEngine.Object.Instantiate(newgunDel1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel2)
						{
							gunDel2.SetActive(false);
							havegunDel2 = false;
							UnityEngine.Object.Instantiate(newgunDel2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel3)
						{
							gunDel3.SetActive(false);
							havegunDel3 = false;
							UnityEngine.Object.Instantiate(newgunDel3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarKey)
						{
							carKey.SetActive(false);
							havecarKey = false;
							((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).playerHaveCarKey = false;
							UnityEngine.Object.Instantiate(newcarKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetopplock)
						{
							topplock.SetActive(false);
							havetopplock = false;
							UnityEngine.Object.Instantiate(newtopplock, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarbattery)
						{
							carbattery.SetActive(false);
							havecarbattery = false;
							UnityEngine.Object.Instantiate(newcarbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegascan)
						{
							gascan.SetActive(false);
							havegascan = false;
							UnityEngine.Object.Instantiate(newgascan, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havewrench)
						{
							wrench.SetActive(false);
							havewrench = false;
							UnityEngine.Object.Instantiate(newwrench, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesparkplug)
						{
							sparkplug.SetActive(false);
							havesparkplug = false;
							UnityEngine.Object.Instantiate(newsparkplug, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemeat)
						{
							meat.SetActive(false);
							havemeat = false;
							UnityEngine.Object.Instantiate(newmeat, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havespecialkey)
						{
							specialkey.SetActive(false);
							havespecialkey = false;
							UnityEngine.Object.Instantiate(newspecialkey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebook)
						{
							book.SetActive(false);
							havebook = false;
							UnityEngine.Object.Instantiate(newbook, dropPoint.transform.position, dropPoint.transform.rotation);
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "tb3")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					tavelbitText.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						tb3.SetActive(true);
						havetb3 = true;
						dropObjectButton.SetActive(true);
						mittenRing.SetActive(false);
						readyPickUp = false;
						tavelbitText.SetActive(false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
						if (haveAvbitare)
						{
							avbitare.SetActive(false);
							haveAvbitare = false;
							UnityEngine.Object.Instantiate(newAvbitare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveHammare)
						{
							hammare.SetActive(false);
							haveHammare = false;
							UnityEngine.Object.Instantiate(newHammare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas)
						{
							vas.SetActive(false);
							havevas = false;
							UnityEngine.Object.Instantiate(newvas, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesafeKey)
						{
							safeKey.SetActive(false);
							havesafeKey = false;
							UnityEngine.Object.Instantiate(newsafeKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveexitKey)
						{
							exitKey.SetActive(false);
							haveexitKey = false;
							UnityEngine.Object.Instantiate(newexitKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havehanglockKey)
						{
							hanglockKey.SetActive(false);
							havehanglockKey = false;
							UnityEngine.Object.Instantiate(newhanglockKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havepadlockCode)
						{
							padlockCode.SetActive(false);
							havepadlockCode = false;
							UnityEngine.Object.Instantiate(newpadlockCode, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havearmborst)
						{
							armborst.SetActive(false);
							havearmborst = false;
							arrowButton.SetActive(false);
							shootArrowRay.SetActive(false);
							UnityEngine.Object.Instantiate(newarmborst, dropPoint.transform.position, dropPoint.transform.rotation);
							if (armborstArrowOK)
							{
								UnityEngine.Object.Instantiate(newArrow, dropPoint.transform.position, dropPoint.transform.rotation);
								haveArrow = false;
								armborstArrowOK = false;
							}
						}
						else if (haveplanka)
						{
							planka.SetActive(false);
							haveplanka = false;
							UnityEngine.Object.Instantiate(newplanka, dropPoint.transform.position, dropPoint.transform.rotation);
							placeObject = false;
							placeObjectButton.SetActive(false);
						}
						else if (havescrewdriver)
						{
							screwdriver.SetActive(false);
							havescrewdriver = false;
							UnityEngine.Object.Instantiate(newscrewdriver, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebattery)
						{
							battery.SetActive(false);
							havebattery = false;
							UnityEngine.Object.Instantiate(newbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb2)
						{
							tb2.SetActive(false);
							havetb2 = false;
							UnityEngine.Object.Instantiate(newtb2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb1)
						{
							tb1.SetActive(false);
							havetb1 = false;
							UnityEngine.Object.Instantiate(newtb1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb4)
						{
							tb4.SetActive(false);
							havetb4 = false;
							UnityEngine.Object.Instantiate(newtb4, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas2)
						{
							vas2.SetActive(false);
							havevas2 = false;
							UnityEngine.Object.Instantiate(newvas2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplayhouseKey)
						{
							playhouseKey.SetActive(false);
							haveplayhouseKey = false;
							UnityEngine.Object.Instantiate(newplayhouseKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemelon)
						{
							melon.SetActive(false);
							havemelon = false;
							UnityEngine.Object.Instantiate(newmelon, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveteddy)
						{
							teddy.SetActive(false);
							haveteddy = false;
							((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
							UnityEngine.Object.Instantiate(newteddy, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg1)
						{
							kugg1.SetActive(false);
							havekugg1 = false;
							UnityEngine.Object.Instantiate(newkugg1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg2)
						{
							kugg2.SetActive(false);
							havekugg2 = false;
							UnityEngine.Object.Instantiate(newkugg2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemessage)
						{
							message.SetActive(false);
							havemessage = false;
							UnityEngine.Object.Instantiate(newmessage, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebrunnsvev)
						{
							brunnsvev.SetActive(false);
							havebrunnsvev = false;
							UnityEngine.Object.Instantiate(newbrunnsvev, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveweaponKey)
						{
							weaponKey.SetActive(false);
							haveweaponKey = false;
							UnityEngine.Object.Instantiate(newweaponKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveoldShotgun)
						{
							oldShotgun.SetActive(false);
							haveoldShotgun = false;
							shootButton.SetActive(false);
							shootRay.SetActive(false);
							UnityEngine.Object.Instantiate(newoldShotgun, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel1)
						{
							gunDel1.SetActive(false);
							havegunDel1 = false;
							UnityEngine.Object.Instantiate(newgunDel1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel2)
						{
							gunDel2.SetActive(false);
							havegunDel2 = false;
							UnityEngine.Object.Instantiate(newgunDel2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel3)
						{
							gunDel3.SetActive(false);
							havegunDel3 = false;
							UnityEngine.Object.Instantiate(newgunDel3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarKey)
						{
							carKey.SetActive(false);
							havecarKey = false;
							((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).playerHaveCarKey = false;
							UnityEngine.Object.Instantiate(newcarKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetopplock)
						{
							topplock.SetActive(false);
							havetopplock = false;
							UnityEngine.Object.Instantiate(newtopplock, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarbattery)
						{
							carbattery.SetActive(false);
							havecarbattery = false;
							UnityEngine.Object.Instantiate(newcarbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegascan)
						{
							gascan.SetActive(false);
							havegascan = false;
							UnityEngine.Object.Instantiate(newgascan, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havewrench)
						{
							wrench.SetActive(false);
							havewrench = false;
							UnityEngine.Object.Instantiate(newwrench, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesparkplug)
						{
							sparkplug.SetActive(false);
							havesparkplug = false;
							UnityEngine.Object.Instantiate(newsparkplug, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemeat)
						{
							meat.SetActive(false);
							havemeat = false;
							UnityEngine.Object.Instantiate(newmeat, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havespecialkey)
						{
							specialkey.SetActive(false);
							havespecialkey = false;
							UnityEngine.Object.Instantiate(newspecialkey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebook)
						{
							book.SetActive(false);
							havebook = false;
							UnityEngine.Object.Instantiate(newbook, dropPoint.transform.position, dropPoint.transform.rotation);
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "tb4")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					tavelbitText.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						tb4.SetActive(true);
						havetb4 = true;
						dropObjectButton.SetActive(true);
						mittenRing.SetActive(false);
						readyPickUp = false;
						tavelbitText.SetActive(false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
						if (haveAvbitare)
						{
							avbitare.SetActive(false);
							haveAvbitare = false;
							UnityEngine.Object.Instantiate(newAvbitare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveHammare)
						{
							hammare.SetActive(false);
							haveHammare = false;
							UnityEngine.Object.Instantiate(newHammare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas)
						{
							vas.SetActive(false);
							havevas = false;
							UnityEngine.Object.Instantiate(newvas, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesafeKey)
						{
							safeKey.SetActive(false);
							havesafeKey = false;
							UnityEngine.Object.Instantiate(newsafeKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveexitKey)
						{
							exitKey.SetActive(false);
							haveexitKey = false;
							UnityEngine.Object.Instantiate(newexitKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havehanglockKey)
						{
							hanglockKey.SetActive(false);
							havehanglockKey = false;
							UnityEngine.Object.Instantiate(newhanglockKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havepadlockCode)
						{
							padlockCode.SetActive(false);
							havepadlockCode = false;
							UnityEngine.Object.Instantiate(newpadlockCode, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havearmborst)
						{
							armborst.SetActive(false);
							havearmborst = false;
							arrowButton.SetActive(false);
							shootArrowRay.SetActive(false);
							UnityEngine.Object.Instantiate(newarmborst, dropPoint.transform.position, dropPoint.transform.rotation);
							if (armborstArrowOK)
							{
								UnityEngine.Object.Instantiate(newArrow, dropPoint.transform.position, dropPoint.transform.rotation);
								haveArrow = false;
								armborstArrowOK = false;
							}
						}
						else if (haveplanka)
						{
							planka.SetActive(false);
							haveplanka = false;
							UnityEngine.Object.Instantiate(newplanka, dropPoint.transform.position, dropPoint.transform.rotation);
							placeObject = false;
							placeObjectButton.SetActive(false);
						}
						else if (havescrewdriver)
						{
							screwdriver.SetActive(false);
							havescrewdriver = false;
							UnityEngine.Object.Instantiate(newscrewdriver, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebattery)
						{
							battery.SetActive(false);
							havebattery = false;
							UnityEngine.Object.Instantiate(newbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb2)
						{
							tb2.SetActive(false);
							havetb2 = false;
							UnityEngine.Object.Instantiate(newtb2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb3)
						{
							tb3.SetActive(false);
							havetb3 = false;
							UnityEngine.Object.Instantiate(newtb3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb1)
						{
							tb1.SetActive(false);
							havetb1 = false;
							UnityEngine.Object.Instantiate(newtb1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas2)
						{
							vas2.SetActive(false);
							havevas2 = false;
							UnityEngine.Object.Instantiate(newvas2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplayhouseKey)
						{
							playhouseKey.SetActive(false);
							haveplayhouseKey = false;
							UnityEngine.Object.Instantiate(newplayhouseKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemelon)
						{
							melon.SetActive(false);
							havemelon = false;
							UnityEngine.Object.Instantiate(newmelon, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveteddy)
						{
							teddy.SetActive(false);
							haveteddy = false;
							((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
							UnityEngine.Object.Instantiate(newteddy, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg1)
						{
							kugg1.SetActive(false);
							havekugg1 = false;
							UnityEngine.Object.Instantiate(newkugg1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg2)
						{
							kugg2.SetActive(false);
							havekugg2 = false;
							UnityEngine.Object.Instantiate(newkugg2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemessage)
						{
							message.SetActive(false);
							havemessage = false;
							UnityEngine.Object.Instantiate(newmessage, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebrunnsvev)
						{
							brunnsvev.SetActive(false);
							havebrunnsvev = false;
							UnityEngine.Object.Instantiate(newbrunnsvev, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveweaponKey)
						{
							weaponKey.SetActive(false);
							haveweaponKey = false;
							UnityEngine.Object.Instantiate(newweaponKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveoldShotgun)
						{
							oldShotgun.SetActive(false);
							haveoldShotgun = false;
							shootButton.SetActive(false);
							shootRay.SetActive(false);
							UnityEngine.Object.Instantiate(newoldShotgun, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel1)
						{
							gunDel1.SetActive(false);
							havegunDel1 = false;
							UnityEngine.Object.Instantiate(newgunDel1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel2)
						{
							gunDel2.SetActive(false);
							havegunDel2 = false;
							UnityEngine.Object.Instantiate(newgunDel2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel3)
						{
							gunDel3.SetActive(false);
							havegunDel3 = false;
							UnityEngine.Object.Instantiate(newgunDel3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarKey)
						{
							carKey.SetActive(false);
							havecarKey = false;
							((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).playerHaveCarKey = false;
							UnityEngine.Object.Instantiate(newcarKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetopplock)
						{
							topplock.SetActive(false);
							havetopplock = false;
							UnityEngine.Object.Instantiate(newtopplock, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarbattery)
						{
							carbattery.SetActive(false);
							havecarbattery = false;
							UnityEngine.Object.Instantiate(newcarbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegascan)
						{
							gascan.SetActive(false);
							havegascan = false;
							UnityEngine.Object.Instantiate(newgascan, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havewrench)
						{
							wrench.SetActive(false);
							havewrench = false;
							UnityEngine.Object.Instantiate(newwrench, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesparkplug)
						{
							sparkplug.SetActive(false);
							havesparkplug = false;
							UnityEngine.Object.Instantiate(newsparkplug, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemeat)
						{
							meat.SetActive(false);
							havemeat = false;
							UnityEngine.Object.Instantiate(newmeat, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havespecialkey)
						{
							specialkey.SetActive(false);
							havespecialkey = false;
							UnityEngine.Object.Instantiate(newspecialkey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebook)
						{
							book.SetActive(false);
							havebook = false;
							UnityEngine.Object.Instantiate(newbook, dropPoint.transform.position, dropPoint.transform.rotation);
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "playhousekey")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					playhouseKeyText.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						playhouseKey.SetActive(true);
						haveplayhouseKey = true;
						dropObjectButton.SetActive(true);
						mittenRing.SetActive(false);
						readyPickUp = false;
						playhouseKeyText.SetActive(false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppNyckel);
						if (haveAvbitare)
						{
							avbitare.SetActive(false);
							haveAvbitare = false;
							UnityEngine.Object.Instantiate(newAvbitare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveHammare)
						{
							hammare.SetActive(false);
							haveHammare = false;
							UnityEngine.Object.Instantiate(newHammare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas)
						{
							vas.SetActive(false);
							havevas = false;
							UnityEngine.Object.Instantiate(newvas, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesafeKey)
						{
							safeKey.SetActive(false);
							havesafeKey = false;
							UnityEngine.Object.Instantiate(newsafeKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveexitKey)
						{
							exitKey.SetActive(false);
							haveexitKey = false;
							UnityEngine.Object.Instantiate(newexitKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havepadlockCode)
						{
							padlockCode.SetActive(false);
							havepadlockCode = false;
							UnityEngine.Object.Instantiate(newpadlockCode, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havearmborst)
						{
							armborst.SetActive(false);
							havearmborst = false;
							arrowButton.SetActive(false);
							shootArrowRay.SetActive(false);
							UnityEngine.Object.Instantiate(newarmborst, dropPoint.transform.position, dropPoint.transform.rotation);
							if (armborstArrowOK)
							{
								UnityEngine.Object.Instantiate(newArrow, dropPoint.transform.position, dropPoint.transform.rotation);
								haveArrow = false;
								armborstArrowOK = false;
							}
						}
						else if (haveweaponKey)
						{
							weaponKey.SetActive(false);
							haveweaponKey = false;
							UnityEngine.Object.Instantiate(newweaponKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havescrewdriver)
						{
							screwdriver.SetActive(false);
							havescrewdriver = false;
							UnityEngine.Object.Instantiate(newscrewdriver, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplanka)
						{
							planka.SetActive(false);
							haveplanka = false;
							UnityEngine.Object.Instantiate(newplanka, dropPoint.transform.position, dropPoint.transform.rotation);
							placeObject = false;
							placeObjectButton.SetActive(false);
						}
						else if (havebattery)
						{
							battery.SetActive(false);
							havebattery = false;
							UnityEngine.Object.Instantiate(newbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb1)
						{
							tb1.SetActive(false);
							havetb1 = false;
							UnityEngine.Object.Instantiate(newtb1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb2)
						{
							tb2.SetActive(false);
							havetb2 = false;
							UnityEngine.Object.Instantiate(newtb2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb3)
						{
							tb3.SetActive(false);
							havetb3 = false;
							UnityEngine.Object.Instantiate(newtb3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb4)
						{
							tb4.SetActive(false);
							havetb4 = false;
							UnityEngine.Object.Instantiate(newtb4, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas2)
						{
							vas2.SetActive(false);
							havevas2 = false;
							UnityEngine.Object.Instantiate(newvas2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havehanglockKey)
						{
							hanglockKey.SetActive(false);
							havehanglockKey = false;
							UnityEngine.Object.Instantiate(newhanglockKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemelon)
						{
							melon.SetActive(false);
							havemelon = false;
							UnityEngine.Object.Instantiate(newmelon, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveteddy)
						{
							teddy.SetActive(false);
							haveteddy = false;
							((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
							UnityEngine.Object.Instantiate(newteddy, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg1)
						{
							kugg1.SetActive(false);
							havekugg1 = false;
							UnityEngine.Object.Instantiate(newkugg1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg2)
						{
							kugg2.SetActive(false);
							havekugg2 = false;
							UnityEngine.Object.Instantiate(newkugg2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemessage)
						{
							message.SetActive(false);
							havemessage = false;
							UnityEngine.Object.Instantiate(newmessage, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebrunnsvev)
						{
							brunnsvev.SetActive(false);
							havebrunnsvev = false;
							UnityEngine.Object.Instantiate(newbrunnsvev, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveoldShotgun)
						{
							oldShotgun.SetActive(false);
							haveoldShotgun = false;
							shootButton.SetActive(false);
							shootRay.SetActive(false);
							UnityEngine.Object.Instantiate(newoldShotgun, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel1)
						{
							gunDel1.SetActive(false);
							havegunDel1 = false;
							UnityEngine.Object.Instantiate(newgunDel1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel2)
						{
							gunDel2.SetActive(false);
							havegunDel2 = false;
							UnityEngine.Object.Instantiate(newgunDel2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel3)
						{
							gunDel3.SetActive(false);
							havegunDel3 = false;
							UnityEngine.Object.Instantiate(newgunDel3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarKey)
						{
							carKey.SetActive(false);
							havecarKey = false;
							((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).playerHaveCarKey = false;
							UnityEngine.Object.Instantiate(newcarKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetopplock)
						{
							topplock.SetActive(false);
							havetopplock = false;
							UnityEngine.Object.Instantiate(newtopplock, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarbattery)
						{
							carbattery.SetActive(false);
							havecarbattery = false;
							UnityEngine.Object.Instantiate(newcarbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegascan)
						{
							gascan.SetActive(false);
							havegascan = false;
							UnityEngine.Object.Instantiate(newgascan, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havewrench)
						{
							wrench.SetActive(false);
							havewrench = false;
							UnityEngine.Object.Instantiate(newwrench, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesparkplug)
						{
							sparkplug.SetActive(false);
							havesparkplug = false;
							UnityEngine.Object.Instantiate(newsparkplug, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemeat)
						{
							meat.SetActive(false);
							havemeat = false;
							UnityEngine.Object.Instantiate(newmeat, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havespecialkey)
						{
							specialkey.SetActive(false);
							havespecialkey = false;
							UnityEngine.Object.Instantiate(newspecialkey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebook)
						{
							book.SetActive(false);
							havebook = false;
							UnityEngine.Object.Instantiate(newbook, dropPoint.transform.position, dropPoint.transform.rotation);
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "melon")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					melonText.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						melon.SetActive(true);
						havemelon = true;
						textTimer = 0f;
						if (!haveSeenMelonText)
						{
							haveSeenMelonText = true;
							somethingInsideMelonText.SetActive(true);
							textTimerOnOff = true;
						}
						dropObjectButton.SetActive(true);
						mittenRing.SetActive(false);
						readyPickUp = false;
						melonText.SetActive(false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
						if (haveAvbitare)
						{
							avbitare.SetActive(false);
							haveAvbitare = false;
							UnityEngine.Object.Instantiate(newAvbitare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveHammare)
						{
							hammare.SetActive(false);
							haveHammare = false;
							UnityEngine.Object.Instantiate(newHammare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas)
						{
							vas.SetActive(false);
							havevas = false;
							UnityEngine.Object.Instantiate(newvas, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesafeKey)
						{
							safeKey.SetActive(false);
							havesafeKey = false;
							UnityEngine.Object.Instantiate(newsafeKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveexitKey)
						{
							exitKey.SetActive(false);
							haveexitKey = false;
							UnityEngine.Object.Instantiate(newexitKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havepadlockCode)
						{
							padlockCode.SetActive(false);
							havepadlockCode = false;
							UnityEngine.Object.Instantiate(newpadlockCode, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havearmborst)
						{
							armborst.SetActive(false);
							havearmborst = false;
							arrowButton.SetActive(false);
							shootArrowRay.SetActive(false);
							UnityEngine.Object.Instantiate(newarmborst, dropPoint.transform.position, dropPoint.transform.rotation);
							if (armborstArrowOK)
							{
								UnityEngine.Object.Instantiate(newArrow, dropPoint.transform.position, dropPoint.transform.rotation);
								haveArrow = false;
								armborstArrowOK = false;
							}
						}
						else if (haveweaponKey)
						{
							weaponKey.SetActive(false);
							haveweaponKey = false;
							UnityEngine.Object.Instantiate(newweaponKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havescrewdriver)
						{
							screwdriver.SetActive(false);
							havescrewdriver = false;
							UnityEngine.Object.Instantiate(newscrewdriver, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplanka)
						{
							planka.SetActive(false);
							haveplanka = false;
							UnityEngine.Object.Instantiate(newplanka, dropPoint.transform.position, dropPoint.transform.rotation);
							placeObject = false;
							placeObjectButton.SetActive(false);
						}
						else if (havebattery)
						{
							battery.SetActive(false);
							havebattery = false;
							UnityEngine.Object.Instantiate(newbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb1)
						{
							tb1.SetActive(false);
							havetb1 = false;
							UnityEngine.Object.Instantiate(newtb1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb2)
						{
							tb2.SetActive(false);
							havetb2 = false;
							UnityEngine.Object.Instantiate(newtb2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb3)
						{
							tb3.SetActive(false);
							havetb3 = false;
							UnityEngine.Object.Instantiate(newtb3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb4)
						{
							tb4.SetActive(false);
							havetb4 = false;
							UnityEngine.Object.Instantiate(newtb4, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas2)
						{
							vas2.SetActive(false);
							havevas2 = false;
							UnityEngine.Object.Instantiate(newvas2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplayhouseKey)
						{
							playhouseKey.SetActive(false);
							haveplayhouseKey = false;
							UnityEngine.Object.Instantiate(newplayhouseKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveteddy)
						{
							teddy.SetActive(false);
							haveteddy = false;
							((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
							UnityEngine.Object.Instantiate(newteddy, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg1)
						{
							kugg1.SetActive(false);
							havekugg1 = false;
							UnityEngine.Object.Instantiate(newkugg1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg2)
						{
							kugg2.SetActive(false);
							havekugg2 = false;
							UnityEngine.Object.Instantiate(newkugg2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemessage)
						{
							message.SetActive(false);
							havemessage = false;
							UnityEngine.Object.Instantiate(newmessage, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebrunnsvev)
						{
							brunnsvev.SetActive(false);
							havebrunnsvev = false;
							UnityEngine.Object.Instantiate(newbrunnsvev, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havehanglockKey)
						{
							hanglockKey.SetActive(false);
							havehanglockKey = false;
							UnityEngine.Object.Instantiate(newhanglockKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveoldShotgun)
						{
							oldShotgun.SetActive(false);
							haveoldShotgun = false;
							shootButton.SetActive(false);
							shootRay.SetActive(false);
							UnityEngine.Object.Instantiate(newoldShotgun, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel1)
						{
							gunDel1.SetActive(false);
							havegunDel1 = false;
							UnityEngine.Object.Instantiate(newgunDel1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel2)
						{
							gunDel2.SetActive(false);
							havegunDel2 = false;
							UnityEngine.Object.Instantiate(newgunDel2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel3)
						{
							gunDel3.SetActive(false);
							havegunDel3 = false;
							UnityEngine.Object.Instantiate(newgunDel3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarKey)
						{
							carKey.SetActive(false);
							havecarKey = false;
							((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).playerHaveCarKey = false;
							UnityEngine.Object.Instantiate(newcarKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetopplock)
						{
							topplock.SetActive(false);
							havetopplock = false;
							UnityEngine.Object.Instantiate(newtopplock, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarbattery)
						{
							carbattery.SetActive(false);
							havecarbattery = false;
							UnityEngine.Object.Instantiate(newcarbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegascan)
						{
							gascan.SetActive(false);
							havegascan = false;
							UnityEngine.Object.Instantiate(newgascan, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havewrench)
						{
							wrench.SetActive(false);
							havewrench = false;
							UnityEngine.Object.Instantiate(newwrench, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesparkplug)
						{
							sparkplug.SetActive(false);
							havesparkplug = false;
							UnityEngine.Object.Instantiate(newsparkplug, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemeat)
						{
							meat.SetActive(false);
							havemeat = false;
							UnityEngine.Object.Instantiate(newmeat, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havespecialkey)
						{
							specialkey.SetActive(false);
							havespecialkey = false;
							UnityEngine.Object.Instantiate(newspecialkey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebook)
						{
							book.SetActive(false);
							havebook = false;
							UnityEngine.Object.Instantiate(newbook, dropPoint.transform.position, dropPoint.transform.rotation);
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "teddy")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					teddyText.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						teddy.SetActive(true);
						haveteddy = true;
						((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = true;
						dropObjectButton.SetActive(true);
						mittenRing.SetActive(false);
						readyPickUp = false;
						teddyText.SetActive(false);
						GetComponent<AudioSource>().PlayOneShot(pickUpTeddy);
						if (haveAvbitare)
						{
							avbitare.SetActive(false);
							haveAvbitare = false;
							UnityEngine.Object.Instantiate(newAvbitare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveHammare)
						{
							hammare.SetActive(false);
							haveHammare = false;
							UnityEngine.Object.Instantiate(newHammare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas)
						{
							vas.SetActive(false);
							havevas = false;
							UnityEngine.Object.Instantiate(newvas, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesafeKey)
						{
							safeKey.SetActive(false);
							havesafeKey = false;
							UnityEngine.Object.Instantiate(newsafeKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveexitKey)
						{
							exitKey.SetActive(false);
							haveexitKey = false;
							UnityEngine.Object.Instantiate(newexitKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havepadlockCode)
						{
							padlockCode.SetActive(false);
							havepadlockCode = false;
							UnityEngine.Object.Instantiate(newpadlockCode, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havearmborst)
						{
							armborst.SetActive(false);
							havearmborst = false;
							arrowButton.SetActive(false);
							shootArrowRay.SetActive(false);
							UnityEngine.Object.Instantiate(newarmborst, dropPoint.transform.position, dropPoint.transform.rotation);
							if (armborstArrowOK)
							{
								UnityEngine.Object.Instantiate(newArrow, dropPoint.transform.position, dropPoint.transform.rotation);
								haveArrow = false;
								armborstArrowOK = false;
							}
						}
						else if (haveweaponKey)
						{
							weaponKey.SetActive(false);
							haveweaponKey = false;
							UnityEngine.Object.Instantiate(newweaponKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havescrewdriver)
						{
							screwdriver.SetActive(false);
							havescrewdriver = false;
							UnityEngine.Object.Instantiate(newscrewdriver, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplanka)
						{
							planka.SetActive(false);
							haveplanka = false;
							UnityEngine.Object.Instantiate(newplanka, dropPoint.transform.position, dropPoint.transform.rotation);
							placeObject = false;
							placeObjectButton.SetActive(false);
						}
						else if (havebattery)
						{
							battery.SetActive(false);
							havebattery = false;
							UnityEngine.Object.Instantiate(newbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb1)
						{
							tb1.SetActive(false);
							havetb1 = false;
							UnityEngine.Object.Instantiate(newtb1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb2)
						{
							tb2.SetActive(false);
							havetb2 = false;
							UnityEngine.Object.Instantiate(newtb2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb3)
						{
							tb3.SetActive(false);
							havetb3 = false;
							UnityEngine.Object.Instantiate(newtb3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb4)
						{
							tb4.SetActive(false);
							havetb4 = false;
							UnityEngine.Object.Instantiate(newtb4, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas2)
						{
							vas2.SetActive(false);
							havevas2 = false;
							UnityEngine.Object.Instantiate(newvas2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplayhouseKey)
						{
							playhouseKey.SetActive(false);
							haveplayhouseKey = false;
							UnityEngine.Object.Instantiate(newplayhouseKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemelon)
						{
							melon.SetActive(false);
							havemelon = false;
							UnityEngine.Object.Instantiate(newmelon, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg1)
						{
							kugg1.SetActive(false);
							havekugg1 = false;
							UnityEngine.Object.Instantiate(newkugg1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg2)
						{
							kugg2.SetActive(false);
							havekugg2 = false;
							UnityEngine.Object.Instantiate(newkugg2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemessage)
						{
							message.SetActive(false);
							havemessage = false;
							UnityEngine.Object.Instantiate(newmessage, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebrunnsvev)
						{
							brunnsvev.SetActive(false);
							havebrunnsvev = false;
							UnityEngine.Object.Instantiate(newbrunnsvev, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havehanglockKey)
						{
							hanglockKey.SetActive(false);
							havehanglockKey = false;
							UnityEngine.Object.Instantiate(newhanglockKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveoldShotgun)
						{
							oldShotgun.SetActive(false);
							haveoldShotgun = false;
							shootButton.SetActive(false);
							shootRay.SetActive(false);
							UnityEngine.Object.Instantiate(newoldShotgun, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel1)
						{
							gunDel1.SetActive(false);
							havegunDel1 = false;
							UnityEngine.Object.Instantiate(newgunDel1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel2)
						{
							gunDel2.SetActive(false);
							havegunDel2 = false;
							UnityEngine.Object.Instantiate(newgunDel2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel3)
						{
							gunDel3.SetActive(false);
							havegunDel3 = false;
							UnityEngine.Object.Instantiate(newgunDel3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarKey)
						{
							carKey.SetActive(false);
							havecarKey = false;
							((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).playerHaveCarKey = false;
							UnityEngine.Object.Instantiate(newcarKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetopplock)
						{
							topplock.SetActive(false);
							havetopplock = false;
							UnityEngine.Object.Instantiate(newtopplock, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarbattery)
						{
							carbattery.SetActive(false);
							havecarbattery = false;
							UnityEngine.Object.Instantiate(newcarbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegascan)
						{
							gascan.SetActive(false);
							havegascan = false;
							UnityEngine.Object.Instantiate(newgascan, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havewrench)
						{
							wrench.SetActive(false);
							havewrench = false;
							UnityEngine.Object.Instantiate(newwrench, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesparkplug)
						{
							sparkplug.SetActive(false);
							havesparkplug = false;
							UnityEngine.Object.Instantiate(newsparkplug, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemeat)
						{
							meat.SetActive(false);
							havemeat = false;
							UnityEngine.Object.Instantiate(newmeat, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havespecialkey)
						{
							specialkey.SetActive(false);
							havespecialkey = false;
							UnityEngine.Object.Instantiate(newspecialkey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebook)
						{
							book.SetActive(false);
							havebook = false;
							UnityEngine.Object.Instantiate(newbook, dropPoint.transform.position, dropPoint.transform.rotation);
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "kugg1")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					cogwheelText.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						kugg1.SetActive(true);
						havekugg1 = true;
						dropObjectButton.SetActive(true);
						mittenRing.SetActive(false);
						readyPickUp = false;
						cogwheelText.SetActive(false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
						if (haveAvbitare)
						{
							avbitare.SetActive(false);
							haveAvbitare = false;
							UnityEngine.Object.Instantiate(newAvbitare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveHammare)
						{
							hammare.SetActive(false);
							haveHammare = false;
							UnityEngine.Object.Instantiate(newHammare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas)
						{
							vas.SetActive(false);
							havevas = false;
							UnityEngine.Object.Instantiate(newvas, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesafeKey)
						{
							safeKey.SetActive(false);
							havesafeKey = false;
							UnityEngine.Object.Instantiate(newsafeKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveexitKey)
						{
							exitKey.SetActive(false);
							haveexitKey = false;
							UnityEngine.Object.Instantiate(newexitKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havepadlockCode)
						{
							padlockCode.SetActive(false);
							havepadlockCode = false;
							UnityEngine.Object.Instantiate(newpadlockCode, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havearmborst)
						{
							armborst.SetActive(false);
							havearmborst = false;
							arrowButton.SetActive(false);
							shootArrowRay.SetActive(false);
							UnityEngine.Object.Instantiate(newarmborst, dropPoint.transform.position, dropPoint.transform.rotation);
							if (armborstArrowOK)
							{
								UnityEngine.Object.Instantiate(newArrow, dropPoint.transform.position, dropPoint.transform.rotation);
								haveArrow = false;
								armborstArrowOK = false;
							}
						}
						else if (haveweaponKey)
						{
							weaponKey.SetActive(false);
							haveweaponKey = false;
							UnityEngine.Object.Instantiate(newweaponKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havescrewdriver)
						{
							screwdriver.SetActive(false);
							havescrewdriver = false;
							UnityEngine.Object.Instantiate(newscrewdriver, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplanka)
						{
							planka.SetActive(false);
							haveplanka = false;
							UnityEngine.Object.Instantiate(newplanka, dropPoint.transform.position, dropPoint.transform.rotation);
							placeObject = false;
							placeObjectButton.SetActive(false);
						}
						else if (havebattery)
						{
							battery.SetActive(false);
							havebattery = false;
							UnityEngine.Object.Instantiate(newbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb1)
						{
							tb1.SetActive(false);
							havetb1 = false;
							UnityEngine.Object.Instantiate(newtb1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb2)
						{
							tb2.SetActive(false);
							havetb2 = false;
							UnityEngine.Object.Instantiate(newtb2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb3)
						{
							tb3.SetActive(false);
							havetb3 = false;
							UnityEngine.Object.Instantiate(newtb3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb4)
						{
							tb4.SetActive(false);
							havetb4 = false;
							UnityEngine.Object.Instantiate(newtb4, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas2)
						{
							vas2.SetActive(false);
							havevas2 = false;
							UnityEngine.Object.Instantiate(newvas2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplayhouseKey)
						{
							playhouseKey.SetActive(false);
							haveplayhouseKey = false;
							UnityEngine.Object.Instantiate(newplayhouseKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemelon)
						{
							melon.SetActive(false);
							havemelon = false;
							UnityEngine.Object.Instantiate(newmelon, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveteddy)
						{
							teddy.SetActive(false);
							haveteddy = false;
							((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
							UnityEngine.Object.Instantiate(newteddy, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg2)
						{
							kugg2.SetActive(false);
							havekugg2 = false;
							UnityEngine.Object.Instantiate(newkugg2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemessage)
						{
							message.SetActive(false);
							havemessage = false;
							UnityEngine.Object.Instantiate(newmessage, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebrunnsvev)
						{
							brunnsvev.SetActive(false);
							havebrunnsvev = false;
							UnityEngine.Object.Instantiate(newbrunnsvev, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havehanglockKey)
						{
							hanglockKey.SetActive(false);
							havehanglockKey = false;
							UnityEngine.Object.Instantiate(newhanglockKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveoldShotgun)
						{
							oldShotgun.SetActive(false);
							haveoldShotgun = false;
							shootButton.SetActive(false);
							shootRay.SetActive(false);
							UnityEngine.Object.Instantiate(newoldShotgun, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel1)
						{
							gunDel1.SetActive(false);
							havegunDel1 = false;
							UnityEngine.Object.Instantiate(newgunDel1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel2)
						{
							gunDel2.SetActive(false);
							havegunDel2 = false;
							UnityEngine.Object.Instantiate(newgunDel2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel3)
						{
							gunDel3.SetActive(false);
							havegunDel3 = false;
							UnityEngine.Object.Instantiate(newgunDel3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarKey)
						{
							carKey.SetActive(false);
							havecarKey = false;
							((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).playerHaveCarKey = false;
							UnityEngine.Object.Instantiate(newcarKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetopplock)
						{
							topplock.SetActive(false);
							havetopplock = false;
							UnityEngine.Object.Instantiate(newtopplock, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarbattery)
						{
							carbattery.SetActive(false);
							havecarbattery = false;
							UnityEngine.Object.Instantiate(newcarbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegascan)
						{
							gascan.SetActive(false);
							havegascan = false;
							UnityEngine.Object.Instantiate(newgascan, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havewrench)
						{
							wrench.SetActive(false);
							havewrench = false;
							UnityEngine.Object.Instantiate(newwrench, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesparkplug)
						{
							sparkplug.SetActive(false);
							havesparkplug = false;
							UnityEngine.Object.Instantiate(newsparkplug, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemeat)
						{
							meat.SetActive(false);
							havemeat = false;
							UnityEngine.Object.Instantiate(newmeat, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havespecialkey)
						{
							specialkey.SetActive(false);
							havespecialkey = false;
							UnityEngine.Object.Instantiate(newspecialkey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebook)
						{
							book.SetActive(false);
							havebook = false;
							UnityEngine.Object.Instantiate(newbook, dropPoint.transform.position, dropPoint.transform.rotation);
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "kugg2")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					cogwheelText.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						kugg2.SetActive(true);
						havekugg2 = true;
						dropObjectButton.SetActive(true);
						mittenRing.SetActive(false);
						readyPickUp = false;
						cogwheelText.SetActive(false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
						if (haveAvbitare)
						{
							avbitare.SetActive(false);
							haveAvbitare = false;
							UnityEngine.Object.Instantiate(newAvbitare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveHammare)
						{
							hammare.SetActive(false);
							haveHammare = false;
							UnityEngine.Object.Instantiate(newHammare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas)
						{
							vas.SetActive(false);
							havevas = false;
							UnityEngine.Object.Instantiate(newvas, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesafeKey)
						{
							safeKey.SetActive(false);
							havesafeKey = false;
							UnityEngine.Object.Instantiate(newsafeKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveexitKey)
						{
							exitKey.SetActive(false);
							haveexitKey = false;
							UnityEngine.Object.Instantiate(newexitKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havepadlockCode)
						{
							padlockCode.SetActive(false);
							havepadlockCode = false;
							UnityEngine.Object.Instantiate(newpadlockCode, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havearmborst)
						{
							armborst.SetActive(false);
							havearmborst = false;
							arrowButton.SetActive(false);
							shootArrowRay.SetActive(false);
							UnityEngine.Object.Instantiate(newarmborst, dropPoint.transform.position, dropPoint.transform.rotation);
							if (armborstArrowOK)
							{
								UnityEngine.Object.Instantiate(newArrow, dropPoint.transform.position, dropPoint.transform.rotation);
								haveArrow = false;
								armborstArrowOK = false;
							}
						}
						else if (haveweaponKey)
						{
							weaponKey.SetActive(false);
							haveweaponKey = false;
							UnityEngine.Object.Instantiate(newweaponKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havescrewdriver)
						{
							screwdriver.SetActive(false);
							havescrewdriver = false;
							UnityEngine.Object.Instantiate(newscrewdriver, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplanka)
						{
							planka.SetActive(false);
							haveplanka = false;
							UnityEngine.Object.Instantiate(newplanka, dropPoint.transform.position, dropPoint.transform.rotation);
							placeObject = false;
							placeObjectButton.SetActive(false);
						}
						else if (havebattery)
						{
							battery.SetActive(false);
							havebattery = false;
							UnityEngine.Object.Instantiate(newbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb1)
						{
							tb1.SetActive(false);
							havetb1 = false;
							UnityEngine.Object.Instantiate(newtb1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb2)
						{
							tb2.SetActive(false);
							havetb2 = false;
							UnityEngine.Object.Instantiate(newtb2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb3)
						{
							tb3.SetActive(false);
							havetb3 = false;
							UnityEngine.Object.Instantiate(newtb3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb4)
						{
							tb4.SetActive(false);
							havetb4 = false;
							UnityEngine.Object.Instantiate(newtb4, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas2)
						{
							vas2.SetActive(false);
							havevas2 = false;
							UnityEngine.Object.Instantiate(newvas2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplayhouseKey)
						{
							playhouseKey.SetActive(false);
							haveplayhouseKey = false;
							UnityEngine.Object.Instantiate(newplayhouseKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemelon)
						{
							melon.SetActive(false);
							havemelon = false;
							UnityEngine.Object.Instantiate(newmelon, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveteddy)
						{
							teddy.SetActive(false);
							haveteddy = false;
							((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
							UnityEngine.Object.Instantiate(newteddy, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg1)
						{
							kugg1.SetActive(false);
							havekugg1 = false;
							UnityEngine.Object.Instantiate(newkugg1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemessage)
						{
							message.SetActive(false);
							havemessage = false;
							UnityEngine.Object.Instantiate(newmessage, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebrunnsvev)
						{
							brunnsvev.SetActive(false);
							havebrunnsvev = false;
							UnityEngine.Object.Instantiate(newbrunnsvev, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havehanglockKey)
						{
							hanglockKey.SetActive(false);
							havehanglockKey = false;
							UnityEngine.Object.Instantiate(newhanglockKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveoldShotgun)
						{
							oldShotgun.SetActive(false);
							haveoldShotgun = false;
							shootButton.SetActive(false);
							shootRay.SetActive(false);
							UnityEngine.Object.Instantiate(newoldShotgun, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel1)
						{
							gunDel1.SetActive(false);
							havegunDel1 = false;
							UnityEngine.Object.Instantiate(newgunDel1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel2)
						{
							gunDel2.SetActive(false);
							havegunDel2 = false;
							UnityEngine.Object.Instantiate(newgunDel2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel3)
						{
							gunDel3.SetActive(false);
							havegunDel3 = false;
							UnityEngine.Object.Instantiate(newgunDel3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarKey)
						{
							carKey.SetActive(false);
							havecarKey = false;
							((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).playerHaveCarKey = false;
							UnityEngine.Object.Instantiate(newcarKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetopplock)
						{
							topplock.SetActive(false);
							havetopplock = false;
							UnityEngine.Object.Instantiate(newtopplock, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarbattery)
						{
							carbattery.SetActive(false);
							havecarbattery = false;
							UnityEngine.Object.Instantiate(newcarbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegascan)
						{
							gascan.SetActive(false);
							havegascan = false;
							UnityEngine.Object.Instantiate(newgascan, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havewrench)
						{
							wrench.SetActive(false);
							havewrench = false;
							UnityEngine.Object.Instantiate(newwrench, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesparkplug)
						{
							sparkplug.SetActive(false);
							havesparkplug = false;
							UnityEngine.Object.Instantiate(newsparkplug, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemeat)
						{
							meat.SetActive(false);
							havemeat = false;
							UnityEngine.Object.Instantiate(newmeat, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havespecialkey)
						{
							specialkey.SetActive(false);
							havespecialkey = false;
							UnityEngine.Object.Instantiate(newspecialkey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebook)
						{
							book.SetActive(false);
							havebook = false;
							UnityEngine.Object.Instantiate(newbook, dropPoint.transform.position, dropPoint.transform.rotation);
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "message")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						message.SetActive(true);
						havemessage = true;
						dropObjectButton.SetActive(true);
						mittenRing.SetActive(false);
						readyPickUp = false;
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
						if (haveAvbitare)
						{
							avbitare.SetActive(false);
							haveAvbitare = false;
							UnityEngine.Object.Instantiate(newAvbitare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveHammare)
						{
							hammare.SetActive(false);
							haveHammare = false;
							UnityEngine.Object.Instantiate(newHammare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas)
						{
							vas.SetActive(false);
							havevas = false;
							UnityEngine.Object.Instantiate(newvas, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesafeKey)
						{
							safeKey.SetActive(false);
							havesafeKey = false;
							UnityEngine.Object.Instantiate(newsafeKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveexitKey)
						{
							exitKey.SetActive(false);
							haveexitKey = false;
							UnityEngine.Object.Instantiate(newexitKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havepadlockCode)
						{
							padlockCode.SetActive(false);
							havepadlockCode = false;
							UnityEngine.Object.Instantiate(newpadlockCode, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havearmborst)
						{
							armborst.SetActive(false);
							havearmborst = false;
							arrowButton.SetActive(false);
							shootArrowRay.SetActive(false);
							UnityEngine.Object.Instantiate(newarmborst, dropPoint.transform.position, dropPoint.transform.rotation);
							if (armborstArrowOK)
							{
								UnityEngine.Object.Instantiate(newArrow, dropPoint.transform.position, dropPoint.transform.rotation);
								haveArrow = false;
								armborstArrowOK = false;
							}
						}
						else if (haveweaponKey)
						{
							weaponKey.SetActive(false);
							haveweaponKey = false;
							UnityEngine.Object.Instantiate(newweaponKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havescrewdriver)
						{
							screwdriver.SetActive(false);
							havescrewdriver = false;
							UnityEngine.Object.Instantiate(newscrewdriver, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplanka)
						{
							planka.SetActive(false);
							haveplanka = false;
							UnityEngine.Object.Instantiate(newplanka, dropPoint.transform.position, dropPoint.transform.rotation);
							placeObject = false;
							placeObjectButton.SetActive(false);
						}
						else if (havebattery)
						{
							battery.SetActive(false);
							havebattery = false;
							UnityEngine.Object.Instantiate(newbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb1)
						{
							tb1.SetActive(false);
							havetb1 = false;
							UnityEngine.Object.Instantiate(newtb1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb2)
						{
							tb2.SetActive(false);
							havetb2 = false;
							UnityEngine.Object.Instantiate(newtb2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb3)
						{
							tb3.SetActive(false);
							havetb3 = false;
							UnityEngine.Object.Instantiate(newtb3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb4)
						{
							tb4.SetActive(false);
							havetb4 = false;
							UnityEngine.Object.Instantiate(newtb4, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas2)
						{
							vas2.SetActive(false);
							havevas2 = false;
							UnityEngine.Object.Instantiate(newvas2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplayhouseKey)
						{
							playhouseKey.SetActive(false);
							haveplayhouseKey = false;
							UnityEngine.Object.Instantiate(newplayhouseKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemelon)
						{
							melon.SetActive(false);
							havemelon = false;
							UnityEngine.Object.Instantiate(newmelon, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveteddy)
						{
							teddy.SetActive(false);
							haveteddy = false;
							((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
							UnityEngine.Object.Instantiate(newteddy, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg1)
						{
							kugg1.SetActive(false);
							havekugg1 = false;
							UnityEngine.Object.Instantiate(newkugg1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg2)
						{
							kugg2.SetActive(false);
							havekugg2 = false;
							UnityEngine.Object.Instantiate(newkugg2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebrunnsvev)
						{
							brunnsvev.SetActive(false);
							havebrunnsvev = false;
							UnityEngine.Object.Instantiate(newbrunnsvev, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havehanglockKey)
						{
							hanglockKey.SetActive(false);
							havehanglockKey = false;
							UnityEngine.Object.Instantiate(newhanglockKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveoldShotgun)
						{
							oldShotgun.SetActive(false);
							haveoldShotgun = false;
							shootButton.SetActive(false);
							shootRay.SetActive(false);
							UnityEngine.Object.Instantiate(newoldShotgun, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel1)
						{
							gunDel1.SetActive(false);
							havegunDel1 = false;
							UnityEngine.Object.Instantiate(newgunDel1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel2)
						{
							gunDel2.SetActive(false);
							havegunDel2 = false;
							UnityEngine.Object.Instantiate(newgunDel2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel3)
						{
							gunDel3.SetActive(false);
							havegunDel3 = false;
							UnityEngine.Object.Instantiate(newgunDel3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarKey)
						{
							carKey.SetActive(false);
							havecarKey = false;
							((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).playerHaveCarKey = false;
							UnityEngine.Object.Instantiate(newcarKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetopplock)
						{
							topplock.SetActive(false);
							havetopplock = false;
							UnityEngine.Object.Instantiate(newtopplock, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarbattery)
						{
							carbattery.SetActive(false);
							havecarbattery = false;
							UnityEngine.Object.Instantiate(newcarbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegascan)
						{
							gascan.SetActive(false);
							havegascan = false;
							UnityEngine.Object.Instantiate(newgascan, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havewrench)
						{
							wrench.SetActive(false);
							havewrench = false;
							UnityEngine.Object.Instantiate(newwrench, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesparkplug)
						{
							sparkplug.SetActive(false);
							havesparkplug = false;
							UnityEngine.Object.Instantiate(newsparkplug, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemeat)
						{
							meat.SetActive(false);
							havemeat = false;
							UnityEngine.Object.Instantiate(newmeat, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havespecialkey)
						{
							specialkey.SetActive(false);
							havespecialkey = false;
							UnityEngine.Object.Instantiate(newspecialkey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebook)
						{
							book.SetActive(false);
							havebook = false;
							UnityEngine.Object.Instantiate(newbook, dropPoint.transform.position, dropPoint.transform.rotation);
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "brunnsvevpickup")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					winchhandleText.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						brunnsvev.SetActive(true);
						havebrunnsvev = true;
						dropObjectButton.SetActive(true);
						mittenRing.SetActive(false);
						readyPickUp = false;
						winchhandleText.SetActive(false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
						if (haveAvbitare)
						{
							avbitare.SetActive(false);
							haveAvbitare = false;
							UnityEngine.Object.Instantiate(newAvbitare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveHammare)
						{
							hammare.SetActive(false);
							haveHammare = false;
							UnityEngine.Object.Instantiate(newHammare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas)
						{
							vas.SetActive(false);
							havevas = false;
							UnityEngine.Object.Instantiate(newvas, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesafeKey)
						{
							safeKey.SetActive(false);
							havesafeKey = false;
							UnityEngine.Object.Instantiate(newsafeKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveexitKey)
						{
							exitKey.SetActive(false);
							haveexitKey = false;
							UnityEngine.Object.Instantiate(newexitKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havepadlockCode)
						{
							padlockCode.SetActive(false);
							havepadlockCode = false;
							UnityEngine.Object.Instantiate(newpadlockCode, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havearmborst)
						{
							armborst.SetActive(false);
							havearmborst = false;
							arrowButton.SetActive(false);
							shootArrowRay.SetActive(false);
							UnityEngine.Object.Instantiate(newarmborst, dropPoint.transform.position, dropPoint.transform.rotation);
							if (armborstArrowOK)
							{
								UnityEngine.Object.Instantiate(newArrow, dropPoint.transform.position, dropPoint.transform.rotation);
								haveArrow = false;
								armborstArrowOK = false;
							}
						}
						else if (haveweaponKey)
						{
							weaponKey.SetActive(false);
							haveweaponKey = false;
							UnityEngine.Object.Instantiate(newweaponKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havescrewdriver)
						{
							screwdriver.SetActive(false);
							havescrewdriver = false;
							UnityEngine.Object.Instantiate(newscrewdriver, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplanka)
						{
							planka.SetActive(false);
							haveplanka = false;
							UnityEngine.Object.Instantiate(newplanka, dropPoint.transform.position, dropPoint.transform.rotation);
							placeObject = false;
							placeObjectButton.SetActive(false);
						}
						else if (havebattery)
						{
							battery.SetActive(false);
							havebattery = false;
							UnityEngine.Object.Instantiate(newbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb1)
						{
							tb1.SetActive(false);
							havetb1 = false;
							UnityEngine.Object.Instantiate(newtb1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb2)
						{
							tb2.SetActive(false);
							havetb2 = false;
							UnityEngine.Object.Instantiate(newtb2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb3)
						{
							tb3.SetActive(false);
							havetb3 = false;
							UnityEngine.Object.Instantiate(newtb3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb4)
						{
							tb4.SetActive(false);
							havetb4 = false;
							UnityEngine.Object.Instantiate(newtb4, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas2)
						{
							vas2.SetActive(false);
							havevas2 = false;
							UnityEngine.Object.Instantiate(newvas2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplayhouseKey)
						{
							playhouseKey.SetActive(false);
							haveplayhouseKey = false;
							UnityEngine.Object.Instantiate(newplayhouseKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemelon)
						{
							melon.SetActive(false);
							havemelon = false;
							UnityEngine.Object.Instantiate(newmelon, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveteddy)
						{
							teddy.SetActive(false);
							haveteddy = false;
							((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
							UnityEngine.Object.Instantiate(newteddy, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg1)
						{
							kugg1.SetActive(false);
							havekugg1 = false;
							UnityEngine.Object.Instantiate(newkugg1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg2)
						{
							kugg2.SetActive(false);
							havekugg2 = false;
							UnityEngine.Object.Instantiate(newkugg2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemessage)
						{
							message.SetActive(false);
							havemessage = false;
							UnityEngine.Object.Instantiate(newmessage, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havehanglockKey)
						{
							hanglockKey.SetActive(false);
							havehanglockKey = false;
							UnityEngine.Object.Instantiate(newhanglockKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveoldShotgun)
						{
							oldShotgun.SetActive(false);
							haveoldShotgun = false;
							shootButton.SetActive(false);
							shootRay.SetActive(false);
							UnityEngine.Object.Instantiate(newoldShotgun, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel1)
						{
							gunDel1.SetActive(false);
							havegunDel1 = false;
							UnityEngine.Object.Instantiate(newgunDel1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel2)
						{
							gunDel2.SetActive(false);
							havegunDel2 = false;
							UnityEngine.Object.Instantiate(newgunDel2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel3)
						{
							gunDel3.SetActive(false);
							havegunDel3 = false;
							UnityEngine.Object.Instantiate(newgunDel3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarKey)
						{
							carKey.SetActive(false);
							havecarKey = false;
							((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).playerHaveCarKey = false;
							UnityEngine.Object.Instantiate(newcarKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetopplock)
						{
							topplock.SetActive(false);
							havetopplock = false;
							UnityEngine.Object.Instantiate(newtopplock, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarbattery)
						{
							carbattery.SetActive(false);
							havecarbattery = false;
							UnityEngine.Object.Instantiate(newcarbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegascan)
						{
							gascan.SetActive(false);
							havegascan = false;
							UnityEngine.Object.Instantiate(newgascan, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havewrench)
						{
							wrench.SetActive(false);
							havewrench = false;
							UnityEngine.Object.Instantiate(newwrench, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesparkplug)
						{
							sparkplug.SetActive(false);
							havesparkplug = false;
							UnityEngine.Object.Instantiate(newsparkplug, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemeat)
						{
							meat.SetActive(false);
							havemeat = false;
							UnityEngine.Object.Instantiate(newmeat, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havespecialkey)
						{
							specialkey.SetActive(false);
							havespecialkey = false;
							UnityEngine.Object.Instantiate(newspecialkey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebook)
						{
							book.SetActive(false);
							havebook = false;
							UnityEngine.Object.Instantiate(newbook, dropPoint.transform.position, dropPoint.transform.rotation);
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "shotgun")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					ShotgunText.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						oldShotgun.SetActive(true);
						if (oldShotgunLoaded)
						{
							ammo.SetActive(true);
							oldShotgunAnim.GetComponent<Animation>().Play("Load");
							shootButton.SetActive(true);
							shootRay.SetActive(true);
							((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).loadedPickup();
						}
						else
						{
							oldShotgunAnim.GetComponent<Animation>().Play("OpenEmpty");
							shootButton.SetActive(false);
							shootRay.SetActive(false);
							ammo.SetActive(false);
							((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).emptyShotgun();
						}
						haveoldShotgun = true;
						dropObjectButton.SetActive(true);
						mittenRing.SetActive(false);
						readyPickUp = false;
						ShotgunText.SetActive(false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
						if (haveAvbitare)
						{
							avbitare.SetActive(false);
							haveAvbitare = false;
							UnityEngine.Object.Instantiate(newAvbitare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveHammare)
						{
							hammare.SetActive(false);
							haveHammare = false;
							UnityEngine.Object.Instantiate(newHammare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas)
						{
							vas.SetActive(false);
							havevas = false;
							UnityEngine.Object.Instantiate(newvas, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesafeKey)
						{
							safeKey.SetActive(false);
							havesafeKey = false;
							UnityEngine.Object.Instantiate(newsafeKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveexitKey)
						{
							exitKey.SetActive(false);
							haveexitKey = false;
							UnityEngine.Object.Instantiate(newexitKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havepadlockCode)
						{
							padlockCode.SetActive(false);
							havepadlockCode = false;
							UnityEngine.Object.Instantiate(newpadlockCode, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havearmborst)
						{
							armborst.SetActive(false);
							havearmborst = false;
							arrowButton.SetActive(false);
							shootArrowRay.SetActive(false);
							UnityEngine.Object.Instantiate(newarmborst, dropPoint.transform.position, dropPoint.transform.rotation);
							if (armborstArrowOK)
							{
								UnityEngine.Object.Instantiate(newArrow, dropPoint.transform.position, dropPoint.transform.rotation);
								haveArrow = false;
								armborstArrowOK = false;
							}
						}
						else if (haveweaponKey)
						{
							weaponKey.SetActive(false);
							haveweaponKey = false;
							UnityEngine.Object.Instantiate(newweaponKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havescrewdriver)
						{
							screwdriver.SetActive(false);
							havescrewdriver = false;
							UnityEngine.Object.Instantiate(newscrewdriver, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplanka)
						{
							planka.SetActive(false);
							haveplanka = false;
							UnityEngine.Object.Instantiate(newplanka, dropPoint.transform.position, dropPoint.transform.rotation);
							placeObject = false;
							placeObjectButton.SetActive(false);
						}
						else if (havebattery)
						{
							battery.SetActive(false);
							havebattery = false;
							UnityEngine.Object.Instantiate(newbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb1)
						{
							tb1.SetActive(false);
							havetb1 = false;
							UnityEngine.Object.Instantiate(newtb1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb2)
						{
							tb2.SetActive(false);
							havetb2 = false;
							UnityEngine.Object.Instantiate(newtb2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb3)
						{
							tb3.SetActive(false);
							havetb3 = false;
							UnityEngine.Object.Instantiate(newtb3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb4)
						{
							tb4.SetActive(false);
							havetb4 = false;
							UnityEngine.Object.Instantiate(newtb4, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas2)
						{
							vas2.SetActive(false);
							havevas2 = false;
							UnityEngine.Object.Instantiate(newvas2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplayhouseKey)
						{
							playhouseKey.SetActive(false);
							haveplayhouseKey = false;
							UnityEngine.Object.Instantiate(newplayhouseKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemelon)
						{
							melon.SetActive(false);
							havemelon = false;
							UnityEngine.Object.Instantiate(newmelon, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveteddy)
						{
							teddy.SetActive(false);
							haveteddy = false;
							((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
							UnityEngine.Object.Instantiate(newteddy, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg1)
						{
							kugg1.SetActive(false);
							havekugg1 = false;
							UnityEngine.Object.Instantiate(newkugg1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg2)
						{
							kugg2.SetActive(false);
							havekugg2 = false;
							UnityEngine.Object.Instantiate(newkugg2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemessage)
						{
							message.SetActive(false);
							havemessage = false;
							UnityEngine.Object.Instantiate(newmessage, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havehanglockKey)
						{
							hanglockKey.SetActive(false);
							havehanglockKey = false;
							UnityEngine.Object.Instantiate(newhanglockKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebrunnsvev)
						{
							brunnsvev.SetActive(false);
							havebrunnsvev = false;
							UnityEngine.Object.Instantiate(newbrunnsvev, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarKey)
						{
							carKey.SetActive(false);
							havecarKey = false;
							((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).playerHaveCarKey = false;
							UnityEngine.Object.Instantiate(newcarKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetopplock)
						{
							topplock.SetActive(false);
							havetopplock = false;
							UnityEngine.Object.Instantiate(newtopplock, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarbattery)
						{
							carbattery.SetActive(false);
							havecarbattery = false;
							UnityEngine.Object.Instantiate(newcarbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegascan)
						{
							gascan.SetActive(false);
							havegascan = false;
							UnityEngine.Object.Instantiate(newgascan, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havewrench)
						{
							wrench.SetActive(false);
							havewrench = false;
							UnityEngine.Object.Instantiate(newwrench, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesparkplug)
						{
							sparkplug.SetActive(false);
							havesparkplug = false;
							UnityEngine.Object.Instantiate(newsparkplug, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemeat)
						{
							meat.SetActive(false);
							havemeat = false;
							UnityEngine.Object.Instantiate(newmeat, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havespecialkey)
						{
							specialkey.SetActive(false);
							havespecialkey = false;
							UnityEngine.Object.Instantiate(newspecialkey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebook)
						{
							book.SetActive(false);
							havebook = false;
							UnityEngine.Object.Instantiate(newbook, dropPoint.transform.position, dropPoint.transform.rotation);
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "ammo")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					AmmoText.SetActive(true);
					if (haveoldShotgun)
					{
						if (pickUp)
						{
							if (!oldShotgunLoaded)
							{
								oldShotgunLoaded = true;
								pickUp = false;
								UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
								shootButton.SetActive(true);
								shootRay.SetActive(true);
								ammo.SetActive(true);
								oldShotgunAnim.GetComponent<Animation>().Play("Load");
								mittenRing.SetActive(false);
								readyPickUp = false;
								AmmoText.SetActive(false);
								GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
								((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).loadShotgun();
							}
							else if (oldShotgunLoaded)
							{
								oldShotgunLoaded = true;
								pickUp = false;
								ShotgunLoadedText.SetActive(true);
								textTimerOnOff = true;
							}
						}
					}
					else if (pickUp)
					{
						pickUp = false;
						NeedShotgunText.SetActive(true);
						textTimerOnOff = true;
					}
				}
				else if (hitInfo.collider.gameObject.tag == "shotgunp1")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					PartOfShotgunText.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						gunDel1.SetActive(true);
						havegunDel1 = true;
						dropObjectButton.SetActive(true);
						mittenRing.SetActive(false);
						readyPickUp = false;
						PartOfShotgunText.SetActive(false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
						if (haveAvbitare)
						{
							avbitare.SetActive(false);
							haveAvbitare = false;
							UnityEngine.Object.Instantiate(newAvbitare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveHammare)
						{
							hammare.SetActive(false);
							haveHammare = false;
							UnityEngine.Object.Instantiate(newHammare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas)
						{
							vas.SetActive(false);
							havevas = false;
							UnityEngine.Object.Instantiate(newvas, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesafeKey)
						{
							safeKey.SetActive(false);
							havesafeKey = false;
							UnityEngine.Object.Instantiate(newsafeKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveexitKey)
						{
							exitKey.SetActive(false);
							haveexitKey = false;
							UnityEngine.Object.Instantiate(newexitKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havepadlockCode)
						{
							padlockCode.SetActive(false);
							havepadlockCode = false;
							UnityEngine.Object.Instantiate(newpadlockCode, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havearmborst)
						{
							armborst.SetActive(false);
							havearmborst = false;
							arrowButton.SetActive(false);
							shootArrowRay.SetActive(false);
							UnityEngine.Object.Instantiate(newarmborst, dropPoint.transform.position, dropPoint.transform.rotation);
							if (armborstArrowOK)
							{
								UnityEngine.Object.Instantiate(newArrow, dropPoint.transform.position, dropPoint.transform.rotation);
								haveArrow = false;
								armborstArrowOK = false;
							}
						}
						else if (haveweaponKey)
						{
							weaponKey.SetActive(false);
							haveweaponKey = false;
							UnityEngine.Object.Instantiate(newweaponKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havescrewdriver)
						{
							screwdriver.SetActive(false);
							havescrewdriver = false;
							UnityEngine.Object.Instantiate(newscrewdriver, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplanka)
						{
							planka.SetActive(false);
							haveplanka = false;
							UnityEngine.Object.Instantiate(newplanka, dropPoint.transform.position, dropPoint.transform.rotation);
							placeObject = false;
							placeObjectButton.SetActive(false);
						}
						else if (havebattery)
						{
							battery.SetActive(false);
							havebattery = false;
							UnityEngine.Object.Instantiate(newbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb1)
						{
							tb1.SetActive(false);
							havetb1 = false;
							UnityEngine.Object.Instantiate(newtb1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb2)
						{
							tb2.SetActive(false);
							havetb2 = false;
							UnityEngine.Object.Instantiate(newtb2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb3)
						{
							tb3.SetActive(false);
							havetb3 = false;
							UnityEngine.Object.Instantiate(newtb3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb4)
						{
							tb4.SetActive(false);
							havetb4 = false;
							UnityEngine.Object.Instantiate(newtb4, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas2)
						{
							vas2.SetActive(false);
							havevas2 = false;
							UnityEngine.Object.Instantiate(newvas2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplayhouseKey)
						{
							playhouseKey.SetActive(false);
							haveplayhouseKey = false;
							UnityEngine.Object.Instantiate(newplayhouseKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemelon)
						{
							melon.SetActive(false);
							havemelon = false;
							UnityEngine.Object.Instantiate(newmelon, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveteddy)
						{
							teddy.SetActive(false);
							haveteddy = false;
							((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
							UnityEngine.Object.Instantiate(newteddy, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg1)
						{
							kugg1.SetActive(false);
							havekugg1 = false;
							UnityEngine.Object.Instantiate(newkugg1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg2)
						{
							kugg2.SetActive(false);
							havekugg2 = false;
							UnityEngine.Object.Instantiate(newkugg2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemessage)
						{
							message.SetActive(false);
							havemessage = false;
							UnityEngine.Object.Instantiate(newmessage, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havehanglockKey)
						{
							hanglockKey.SetActive(false);
							havehanglockKey = false;
							UnityEngine.Object.Instantiate(newhanglockKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveoldShotgun)
						{
							oldShotgun.SetActive(false);
							haveoldShotgun = false;
							shootButton.SetActive(false);
							shootRay.SetActive(false);
							UnityEngine.Object.Instantiate(newoldShotgun, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebrunnsvev)
						{
							brunnsvev.SetActive(false);
							havebrunnsvev = false;
							UnityEngine.Object.Instantiate(newbrunnsvev, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel2)
						{
							gunDel2.SetActive(false);
							havegunDel2 = false;
							UnityEngine.Object.Instantiate(newgunDel2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel3)
						{
							gunDel3.SetActive(false);
							havegunDel3 = false;
							UnityEngine.Object.Instantiate(newgunDel3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarKey)
						{
							carKey.SetActive(false);
							havecarKey = false;
							((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).playerHaveCarKey = false;
							UnityEngine.Object.Instantiate(newcarKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetopplock)
						{
							topplock.SetActive(false);
							havetopplock = false;
							UnityEngine.Object.Instantiate(newtopplock, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarbattery)
						{
							carbattery.SetActive(false);
							havecarbattery = false;
							UnityEngine.Object.Instantiate(newcarbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegascan)
						{
							gascan.SetActive(false);
							havegascan = false;
							UnityEngine.Object.Instantiate(newgascan, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havewrench)
						{
							wrench.SetActive(false);
							havewrench = false;
							UnityEngine.Object.Instantiate(newwrench, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesparkplug)
						{
							sparkplug.SetActive(false);
							havesparkplug = false;
							UnityEngine.Object.Instantiate(newsparkplug, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemeat)
						{
							meat.SetActive(false);
							havemeat = false;
							UnityEngine.Object.Instantiate(newmeat, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havespecialkey)
						{
							specialkey.SetActive(false);
							havespecialkey = false;
							UnityEngine.Object.Instantiate(newspecialkey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebook)
						{
							book.SetActive(false);
							havebook = false;
							UnityEngine.Object.Instantiate(newbook, dropPoint.transform.position, dropPoint.transform.rotation);
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "shotgunp2")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					PartOfShotgunText.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						gunDel2.SetActive(true);
						havegunDel2 = true;
						dropObjectButton.SetActive(true);
						mittenRing.SetActive(false);
						readyPickUp = false;
						PartOfShotgunText.SetActive(false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
						if (haveAvbitare)
						{
							avbitare.SetActive(false);
							haveAvbitare = false;
							UnityEngine.Object.Instantiate(newAvbitare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveHammare)
						{
							hammare.SetActive(false);
							haveHammare = false;
							UnityEngine.Object.Instantiate(newHammare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas)
						{
							vas.SetActive(false);
							havevas = false;
							UnityEngine.Object.Instantiate(newvas, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesafeKey)
						{
							safeKey.SetActive(false);
							havesafeKey = false;
							UnityEngine.Object.Instantiate(newsafeKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveexitKey)
						{
							exitKey.SetActive(false);
							haveexitKey = false;
							UnityEngine.Object.Instantiate(newexitKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havepadlockCode)
						{
							padlockCode.SetActive(false);
							havepadlockCode = false;
							UnityEngine.Object.Instantiate(newpadlockCode, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havearmborst)
						{
							armborst.SetActive(false);
							havearmborst = false;
							arrowButton.SetActive(false);
							shootArrowRay.SetActive(false);
							UnityEngine.Object.Instantiate(newarmborst, dropPoint.transform.position, dropPoint.transform.rotation);
							if (armborstArrowOK)
							{
								UnityEngine.Object.Instantiate(newArrow, dropPoint.transform.position, dropPoint.transform.rotation);
								haveArrow = false;
								armborstArrowOK = false;
							}
						}
						else if (haveweaponKey)
						{
							weaponKey.SetActive(false);
							haveweaponKey = false;
							UnityEngine.Object.Instantiate(newweaponKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havescrewdriver)
						{
							screwdriver.SetActive(false);
							havescrewdriver = false;
							UnityEngine.Object.Instantiate(newscrewdriver, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplanka)
						{
							planka.SetActive(false);
							haveplanka = false;
							UnityEngine.Object.Instantiate(newplanka, dropPoint.transform.position, dropPoint.transform.rotation);
							placeObject = false;
							placeObjectButton.SetActive(false);
						}
						else if (havebattery)
						{
							battery.SetActive(false);
							havebattery = false;
							UnityEngine.Object.Instantiate(newbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb1)
						{
							tb1.SetActive(false);
							havetb1 = false;
							UnityEngine.Object.Instantiate(newtb1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb2)
						{
							tb2.SetActive(false);
							havetb2 = false;
							UnityEngine.Object.Instantiate(newtb2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb3)
						{
							tb3.SetActive(false);
							havetb3 = false;
							UnityEngine.Object.Instantiate(newtb3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb4)
						{
							tb4.SetActive(false);
							havetb4 = false;
							UnityEngine.Object.Instantiate(newtb4, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas2)
						{
							vas2.SetActive(false);
							havevas2 = false;
							UnityEngine.Object.Instantiate(newvas2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplayhouseKey)
						{
							playhouseKey.SetActive(false);
							haveplayhouseKey = false;
							UnityEngine.Object.Instantiate(newplayhouseKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemelon)
						{
							melon.SetActive(false);
							havemelon = false;
							UnityEngine.Object.Instantiate(newmelon, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveteddy)
						{
							teddy.SetActive(false);
							haveteddy = false;
							((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
							UnityEngine.Object.Instantiate(newteddy, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg1)
						{
							kugg1.SetActive(false);
							havekugg1 = false;
							UnityEngine.Object.Instantiate(newkugg1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg2)
						{
							kugg2.SetActive(false);
							havekugg2 = false;
							UnityEngine.Object.Instantiate(newkugg2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemessage)
						{
							message.SetActive(false);
							havemessage = false;
							UnityEngine.Object.Instantiate(newmessage, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havehanglockKey)
						{
							hanglockKey.SetActive(false);
							havehanglockKey = false;
							UnityEngine.Object.Instantiate(newhanglockKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveoldShotgun)
						{
							oldShotgun.SetActive(false);
							haveoldShotgun = false;
							shootButton.SetActive(false);
							shootRay.SetActive(false);
							UnityEngine.Object.Instantiate(newoldShotgun, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebrunnsvev)
						{
							brunnsvev.SetActive(false);
							havebrunnsvev = false;
							UnityEngine.Object.Instantiate(newbrunnsvev, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel1)
						{
							gunDel1.SetActive(false);
							havegunDel1 = false;
							UnityEngine.Object.Instantiate(newgunDel1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel3)
						{
							gunDel3.SetActive(false);
							havegunDel3 = false;
							UnityEngine.Object.Instantiate(newgunDel3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarKey)
						{
							carKey.SetActive(false);
							havecarKey = false;
							((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).playerHaveCarKey = false;
							UnityEngine.Object.Instantiate(newcarKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetopplock)
						{
							topplock.SetActive(false);
							havetopplock = false;
							UnityEngine.Object.Instantiate(newtopplock, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarbattery)
						{
							carbattery.SetActive(false);
							havecarbattery = false;
							UnityEngine.Object.Instantiate(newcarbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegascan)
						{
							gascan.SetActive(false);
							havegascan = false;
							UnityEngine.Object.Instantiate(newgascan, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havewrench)
						{
							wrench.SetActive(false);
							havewrench = false;
							UnityEngine.Object.Instantiate(newwrench, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesparkplug)
						{
							sparkplug.SetActive(false);
							havesparkplug = false;
							UnityEngine.Object.Instantiate(newsparkplug, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemeat)
						{
							meat.SetActive(false);
							havemeat = false;
							UnityEngine.Object.Instantiate(newmeat, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havespecialkey)
						{
							specialkey.SetActive(false);
							havespecialkey = false;
							UnityEngine.Object.Instantiate(newspecialkey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebook)
						{
							book.SetActive(false);
							havebook = false;
							UnityEngine.Object.Instantiate(newbook, dropPoint.transform.position, dropPoint.transform.rotation);
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "shotgunp3")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					PartOfShotgunText.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						gunDel3.SetActive(true);
						havegunDel3 = true;
						dropObjectButton.SetActive(true);
						mittenRing.SetActive(false);
						readyPickUp = false;
						PartOfShotgunText.SetActive(false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
						if (haveAvbitare)
						{
							avbitare.SetActive(false);
							haveAvbitare = false;
							UnityEngine.Object.Instantiate(newAvbitare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveHammare)
						{
							hammare.SetActive(false);
							haveHammare = false;
							UnityEngine.Object.Instantiate(newHammare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas)
						{
							vas.SetActive(false);
							havevas = false;
							UnityEngine.Object.Instantiate(newvas, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesafeKey)
						{
							safeKey.SetActive(false);
							havesafeKey = false;
							UnityEngine.Object.Instantiate(newsafeKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveexitKey)
						{
							exitKey.SetActive(false);
							haveexitKey = false;
							UnityEngine.Object.Instantiate(newexitKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havepadlockCode)
						{
							padlockCode.SetActive(false);
							havepadlockCode = false;
							UnityEngine.Object.Instantiate(newpadlockCode, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havearmborst)
						{
							armborst.SetActive(false);
							havearmborst = false;
							arrowButton.SetActive(false);
							shootArrowRay.SetActive(false);
							UnityEngine.Object.Instantiate(newarmborst, dropPoint.transform.position, dropPoint.transform.rotation);
							if (armborstArrowOK)
							{
								UnityEngine.Object.Instantiate(newArrow, dropPoint.transform.position, dropPoint.transform.rotation);
								haveArrow = false;
								armborstArrowOK = false;
							}
						}
						else if (haveweaponKey)
						{
							weaponKey.SetActive(false);
							haveweaponKey = false;
							UnityEngine.Object.Instantiate(newweaponKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havescrewdriver)
						{
							screwdriver.SetActive(false);
							havescrewdriver = false;
							UnityEngine.Object.Instantiate(newscrewdriver, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplanka)
						{
							planka.SetActive(false);
							haveplanka = false;
							UnityEngine.Object.Instantiate(newplanka, dropPoint.transform.position, dropPoint.transform.rotation);
							placeObject = false;
							placeObjectButton.SetActive(false);
						}
						else if (havebattery)
						{
							battery.SetActive(false);
							havebattery = false;
							UnityEngine.Object.Instantiate(newbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb1)
						{
							tb1.SetActive(false);
							havetb1 = false;
							UnityEngine.Object.Instantiate(newtb1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb2)
						{
							tb2.SetActive(false);
							havetb2 = false;
							UnityEngine.Object.Instantiate(newtb2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb3)
						{
							tb3.SetActive(false);
							havetb3 = false;
							UnityEngine.Object.Instantiate(newtb3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb4)
						{
							tb4.SetActive(false);
							havetb4 = false;
							UnityEngine.Object.Instantiate(newtb4, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas2)
						{
							vas2.SetActive(false);
							havevas2 = false;
							UnityEngine.Object.Instantiate(newvas2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplayhouseKey)
						{
							playhouseKey.SetActive(false);
							haveplayhouseKey = false;
							UnityEngine.Object.Instantiate(newplayhouseKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemelon)
						{
							melon.SetActive(false);
							havemelon = false;
							UnityEngine.Object.Instantiate(newmelon, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveteddy)
						{
							teddy.SetActive(false);
							haveteddy = false;
							((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
							UnityEngine.Object.Instantiate(newteddy, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg1)
						{
							kugg1.SetActive(false);
							havekugg1 = false;
							UnityEngine.Object.Instantiate(newkugg1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg2)
						{
							kugg2.SetActive(false);
							havekugg2 = false;
							UnityEngine.Object.Instantiate(newkugg2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemessage)
						{
							message.SetActive(false);
							havemessage = false;
							UnityEngine.Object.Instantiate(newmessage, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havehanglockKey)
						{
							hanglockKey.SetActive(false);
							havehanglockKey = false;
							UnityEngine.Object.Instantiate(newhanglockKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveoldShotgun)
						{
							oldShotgun.SetActive(false);
							haveoldShotgun = false;
							shootButton.SetActive(false);
							shootRay.SetActive(false);
							UnityEngine.Object.Instantiate(newoldShotgun, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebrunnsvev)
						{
							brunnsvev.SetActive(false);
							havebrunnsvev = false;
							UnityEngine.Object.Instantiate(newbrunnsvev, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel1)
						{
							gunDel1.SetActive(false);
							havegunDel1 = false;
							UnityEngine.Object.Instantiate(newgunDel1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel2)
						{
							gunDel2.SetActive(false);
							havegunDel2 = false;
							UnityEngine.Object.Instantiate(newgunDel2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarKey)
						{
							carKey.SetActive(false);
							havecarKey = false;
							((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).playerHaveCarKey = false;
							UnityEngine.Object.Instantiate(newcarKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetopplock)
						{
							topplock.SetActive(false);
							havetopplock = false;
							UnityEngine.Object.Instantiate(newtopplock, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarbattery)
						{
							carbattery.SetActive(false);
							havecarbattery = false;
							UnityEngine.Object.Instantiate(newcarbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegascan)
						{
							gascan.SetActive(false);
							havegascan = false;
							UnityEngine.Object.Instantiate(newgascan, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havewrench)
						{
							wrench.SetActive(false);
							havewrench = false;
							UnityEngine.Object.Instantiate(newwrench, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesparkplug)
						{
							sparkplug.SetActive(false);
							havesparkplug = false;
							UnityEngine.Object.Instantiate(newsparkplug, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemeat)
						{
							meat.SetActive(false);
							havemeat = false;
							UnityEngine.Object.Instantiate(newmeat, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havespecialkey)
						{
							specialkey.SetActive(false);
							havespecialkey = false;
							UnityEngine.Object.Instantiate(newspecialkey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebook)
						{
							book.SetActive(false);
							havebook = false;
							UnityEngine.Object.Instantiate(newbook, dropPoint.transform.position, dropPoint.transform.rotation);
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "carkey")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					carKeyText.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						carKey.SetActive(true);
						havecarKey = true;
						((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).playerHaveCarKey = true;
						dropObjectButton.SetActive(true);
						mittenRing.SetActive(false);
						readyPickUp = false;
						carKeyText.SetActive(false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
						if (haveAvbitare)
						{
							avbitare.SetActive(false);
							haveAvbitare = false;
							UnityEngine.Object.Instantiate(newAvbitare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveHammare)
						{
							hammare.SetActive(false);
							haveHammare = false;
							UnityEngine.Object.Instantiate(newHammare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas)
						{
							vas.SetActive(false);
							havevas = false;
							UnityEngine.Object.Instantiate(newvas, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesafeKey)
						{
							safeKey.SetActive(false);
							havesafeKey = false;
							UnityEngine.Object.Instantiate(newsafeKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveexitKey)
						{
							exitKey.SetActive(false);
							haveexitKey = false;
							UnityEngine.Object.Instantiate(newexitKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havepadlockCode)
						{
							padlockCode.SetActive(false);
							havepadlockCode = false;
							UnityEngine.Object.Instantiate(newpadlockCode, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havearmborst)
						{
							armborst.SetActive(false);
							havearmborst = false;
							arrowButton.SetActive(false);
							shootArrowRay.SetActive(false);
							UnityEngine.Object.Instantiate(newarmborst, dropPoint.transform.position, dropPoint.transform.rotation);
							if (armborstArrowOK)
							{
								UnityEngine.Object.Instantiate(newArrow, dropPoint.transform.position, dropPoint.transform.rotation);
								haveArrow = false;
								armborstArrowOK = false;
							}
						}
						else if (haveweaponKey)
						{
							weaponKey.SetActive(false);
							haveweaponKey = false;
							UnityEngine.Object.Instantiate(newweaponKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havescrewdriver)
						{
							screwdriver.SetActive(false);
							havescrewdriver = false;
							UnityEngine.Object.Instantiate(newscrewdriver, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplanka)
						{
							planka.SetActive(false);
							haveplanka = false;
							UnityEngine.Object.Instantiate(newplanka, dropPoint.transform.position, dropPoint.transform.rotation);
							placeObject = false;
							placeObjectButton.SetActive(false);
						}
						else if (havebattery)
						{
							battery.SetActive(false);
							havebattery = false;
							UnityEngine.Object.Instantiate(newbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb1)
						{
							tb1.SetActive(false);
							havetb1 = false;
							UnityEngine.Object.Instantiate(newtb1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb2)
						{
							tb2.SetActive(false);
							havetb2 = false;
							UnityEngine.Object.Instantiate(newtb2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb3)
						{
							tb3.SetActive(false);
							havetb3 = false;
							UnityEngine.Object.Instantiate(newtb3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb4)
						{
							tb4.SetActive(false);
							havetb4 = false;
							UnityEngine.Object.Instantiate(newtb4, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas2)
						{
							vas2.SetActive(false);
							havevas2 = false;
							UnityEngine.Object.Instantiate(newvas2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplayhouseKey)
						{
							playhouseKey.SetActive(false);
							haveplayhouseKey = false;
							UnityEngine.Object.Instantiate(newplayhouseKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemelon)
						{
							melon.SetActive(false);
							havemelon = false;
							UnityEngine.Object.Instantiate(newmelon, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveteddy)
						{
							teddy.SetActive(false);
							haveteddy = false;
							((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
							UnityEngine.Object.Instantiate(newteddy, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg1)
						{
							kugg1.SetActive(false);
							havekugg1 = false;
							UnityEngine.Object.Instantiate(newkugg1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg2)
						{
							kugg2.SetActive(false);
							havekugg2 = false;
							UnityEngine.Object.Instantiate(newkugg2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemessage)
						{
							message.SetActive(false);
							havemessage = false;
							UnityEngine.Object.Instantiate(newmessage, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havehanglockKey)
						{
							hanglockKey.SetActive(false);
							havehanglockKey = false;
							UnityEngine.Object.Instantiate(newhanglockKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveoldShotgun)
						{
							oldShotgun.SetActive(false);
							haveoldShotgun = false;
							shootButton.SetActive(false);
							shootRay.SetActive(false);
							UnityEngine.Object.Instantiate(newoldShotgun, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebrunnsvev)
						{
							brunnsvev.SetActive(false);
							havebrunnsvev = false;
							UnityEngine.Object.Instantiate(newbrunnsvev, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel1)
						{
							gunDel1.SetActive(false);
							havegunDel1 = false;
							UnityEngine.Object.Instantiate(newgunDel1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel2)
						{
							gunDel2.SetActive(false);
							havegunDel2 = false;
							UnityEngine.Object.Instantiate(newgunDel2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel3)
						{
							gunDel3.SetActive(false);
							havegunDel3 = false;
							UnityEngine.Object.Instantiate(newgunDel3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetopplock)
						{
							topplock.SetActive(false);
							havetopplock = false;
							UnityEngine.Object.Instantiate(newtopplock, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarbattery)
						{
							carbattery.SetActive(false);
							havecarbattery = false;
							UnityEngine.Object.Instantiate(newcarbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegascan)
						{
							gascan.SetActive(false);
							havegascan = false;
							UnityEngine.Object.Instantiate(newgascan, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havewrench)
						{
							wrench.SetActive(false);
							havewrench = false;
							UnityEngine.Object.Instantiate(newwrench, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesparkplug)
						{
							sparkplug.SetActive(false);
							havesparkplug = false;
							UnityEngine.Object.Instantiate(newsparkplug, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemeat)
						{
							meat.SetActive(false);
							havemeat = false;
							UnityEngine.Object.Instantiate(newmeat, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havespecialkey)
						{
							specialkey.SetActive(false);
							havespecialkey = false;
							UnityEngine.Object.Instantiate(newspecialkey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebook)
						{
							book.SetActive(false);
							havebook = false;
							UnityEngine.Object.Instantiate(newbook, dropPoint.transform.position, dropPoint.transform.rotation);
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "topplock")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					EnginePartText.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						topplock.SetActive(true);
						havetopplock = true;
						dropObjectButton.SetActive(true);
						mittenRing.SetActive(false);
						readyPickUp = false;
						EnginePartText.SetActive(false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
						if (haveAvbitare)
						{
							avbitare.SetActive(false);
							haveAvbitare = false;
							UnityEngine.Object.Instantiate(newAvbitare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveHammare)
						{
							hammare.SetActive(false);
							haveHammare = false;
							UnityEngine.Object.Instantiate(newHammare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas)
						{
							vas.SetActive(false);
							havevas = false;
							UnityEngine.Object.Instantiate(newvas, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesafeKey)
						{
							safeKey.SetActive(false);
							havesafeKey = false;
							UnityEngine.Object.Instantiate(newsafeKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveexitKey)
						{
							exitKey.SetActive(false);
							haveexitKey = false;
							UnityEngine.Object.Instantiate(newexitKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havepadlockCode)
						{
							padlockCode.SetActive(false);
							havepadlockCode = false;
							UnityEngine.Object.Instantiate(newpadlockCode, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havearmborst)
						{
							armborst.SetActive(false);
							havearmborst = false;
							arrowButton.SetActive(false);
							shootArrowRay.SetActive(false);
							UnityEngine.Object.Instantiate(newarmborst, dropPoint.transform.position, dropPoint.transform.rotation);
							if (armborstArrowOK)
							{
								UnityEngine.Object.Instantiate(newArrow, dropPoint.transform.position, dropPoint.transform.rotation);
								haveArrow = false;
								armborstArrowOK = false;
							}
						}
						else if (haveweaponKey)
						{
							weaponKey.SetActive(false);
							haveweaponKey = false;
							UnityEngine.Object.Instantiate(newweaponKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havescrewdriver)
						{
							screwdriver.SetActive(false);
							havescrewdriver = false;
							UnityEngine.Object.Instantiate(newscrewdriver, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplanka)
						{
							planka.SetActive(false);
							haveplanka = false;
							UnityEngine.Object.Instantiate(newplanka, dropPoint.transform.position, dropPoint.transform.rotation);
							placeObject = false;
							placeObjectButton.SetActive(false);
						}
						else if (havebattery)
						{
							battery.SetActive(false);
							havebattery = false;
							UnityEngine.Object.Instantiate(newbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb1)
						{
							tb1.SetActive(false);
							havetb1 = false;
							UnityEngine.Object.Instantiate(newtb1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb2)
						{
							tb2.SetActive(false);
							havetb2 = false;
							UnityEngine.Object.Instantiate(newtb2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb3)
						{
							tb3.SetActive(false);
							havetb3 = false;
							UnityEngine.Object.Instantiate(newtb3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb4)
						{
							tb4.SetActive(false);
							havetb4 = false;
							UnityEngine.Object.Instantiate(newtb4, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas2)
						{
							vas2.SetActive(false);
							havevas2 = false;
							UnityEngine.Object.Instantiate(newvas2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplayhouseKey)
						{
							playhouseKey.SetActive(false);
							haveplayhouseKey = false;
							UnityEngine.Object.Instantiate(newplayhouseKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemelon)
						{
							melon.SetActive(false);
							havemelon = false;
							UnityEngine.Object.Instantiate(newmelon, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveteddy)
						{
							teddy.SetActive(false);
							haveteddy = false;
							((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
							UnityEngine.Object.Instantiate(newteddy, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg1)
						{
							kugg1.SetActive(false);
							havekugg1 = false;
							UnityEngine.Object.Instantiate(newkugg1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg2)
						{
							kugg2.SetActive(false);
							havekugg2 = false;
							UnityEngine.Object.Instantiate(newkugg2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemessage)
						{
							message.SetActive(false);
							havemessage = false;
							UnityEngine.Object.Instantiate(newmessage, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havehanglockKey)
						{
							hanglockKey.SetActive(false);
							havehanglockKey = false;
							UnityEngine.Object.Instantiate(newhanglockKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveoldShotgun)
						{
							oldShotgun.SetActive(false);
							haveoldShotgun = false;
							shootButton.SetActive(false);
							shootRay.SetActive(false);
							UnityEngine.Object.Instantiate(newoldShotgun, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebrunnsvev)
						{
							brunnsvev.SetActive(false);
							havebrunnsvev = false;
							UnityEngine.Object.Instantiate(newbrunnsvev, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel1)
						{
							gunDel1.SetActive(false);
							havegunDel1 = false;
							UnityEngine.Object.Instantiate(newgunDel1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel2)
						{
							gunDel2.SetActive(false);
							havegunDel2 = false;
							UnityEngine.Object.Instantiate(newgunDel2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel3)
						{
							gunDel3.SetActive(false);
							havegunDel3 = false;
							UnityEngine.Object.Instantiate(newgunDel3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarKey)
						{
							carKey.SetActive(false);
							havecarKey = false;
							((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).playerHaveCarKey = false;
							UnityEngine.Object.Instantiate(newcarKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarbattery)
						{
							carbattery.SetActive(false);
							havecarbattery = false;
							UnityEngine.Object.Instantiate(newcarbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegascan)
						{
							gascan.SetActive(false);
							havegascan = false;
							UnityEngine.Object.Instantiate(newgascan, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havewrench)
						{
							wrench.SetActive(false);
							havewrench = false;
							UnityEngine.Object.Instantiate(newwrench, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesparkplug)
						{
							sparkplug.SetActive(false);
							havesparkplug = false;
							UnityEngine.Object.Instantiate(newsparkplug, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemeat)
						{
							meat.SetActive(false);
							havemeat = false;
							UnityEngine.Object.Instantiate(newmeat, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havespecialkey)
						{
							specialkey.SetActive(false);
							havespecialkey = false;
							UnityEngine.Object.Instantiate(newspecialkey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebook)
						{
							book.SetActive(false);
							havebook = false;
							UnityEngine.Object.Instantiate(newbook, dropPoint.transform.position, dropPoint.transform.rotation);
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "carbattery")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					CarBatteryText.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						carbattery.SetActive(true);
						havecarbattery = true;
						dropObjectButton.SetActive(true);
						mittenRing.SetActive(false);
						readyPickUp = false;
						CarBatteryText.SetActive(false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
						if (haveAvbitare)
						{
							avbitare.SetActive(false);
							haveAvbitare = false;
							UnityEngine.Object.Instantiate(newAvbitare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveHammare)
						{
							hammare.SetActive(false);
							haveHammare = false;
							UnityEngine.Object.Instantiate(newHammare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas)
						{
							vas.SetActive(false);
							havevas = false;
							UnityEngine.Object.Instantiate(newvas, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesafeKey)
						{
							safeKey.SetActive(false);
							havesafeKey = false;
							UnityEngine.Object.Instantiate(newsafeKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveexitKey)
						{
							exitKey.SetActive(false);
							haveexitKey = false;
							UnityEngine.Object.Instantiate(newexitKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havepadlockCode)
						{
							padlockCode.SetActive(false);
							havepadlockCode = false;
							UnityEngine.Object.Instantiate(newpadlockCode, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havearmborst)
						{
							armborst.SetActive(false);
							havearmborst = false;
							arrowButton.SetActive(false);
							shootArrowRay.SetActive(false);
							UnityEngine.Object.Instantiate(newarmborst, dropPoint.transform.position, dropPoint.transform.rotation);
							if (armborstArrowOK)
							{
								UnityEngine.Object.Instantiate(newArrow, dropPoint.transform.position, dropPoint.transform.rotation);
								haveArrow = false;
								armborstArrowOK = false;
							}
						}
						else if (haveweaponKey)
						{
							weaponKey.SetActive(false);
							haveweaponKey = false;
							UnityEngine.Object.Instantiate(newweaponKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havescrewdriver)
						{
							screwdriver.SetActive(false);
							havescrewdriver = false;
							UnityEngine.Object.Instantiate(newscrewdriver, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplanka)
						{
							planka.SetActive(false);
							haveplanka = false;
							UnityEngine.Object.Instantiate(newplanka, dropPoint.transform.position, dropPoint.transform.rotation);
							placeObject = false;
							placeObjectButton.SetActive(false);
						}
						else if (havebattery)
						{
							battery.SetActive(false);
							havebattery = false;
							UnityEngine.Object.Instantiate(newbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb1)
						{
							tb1.SetActive(false);
							havetb1 = false;
							UnityEngine.Object.Instantiate(newtb1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb2)
						{
							tb2.SetActive(false);
							havetb2 = false;
							UnityEngine.Object.Instantiate(newtb2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb3)
						{
							tb3.SetActive(false);
							havetb3 = false;
							UnityEngine.Object.Instantiate(newtb3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb4)
						{
							tb4.SetActive(false);
							havetb4 = false;
							UnityEngine.Object.Instantiate(newtb4, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas2)
						{
							vas2.SetActive(false);
							havevas2 = false;
							UnityEngine.Object.Instantiate(newvas2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplayhouseKey)
						{
							playhouseKey.SetActive(false);
							haveplayhouseKey = false;
							UnityEngine.Object.Instantiate(newplayhouseKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemelon)
						{
							melon.SetActive(false);
							havemelon = false;
							UnityEngine.Object.Instantiate(newmelon, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveteddy)
						{
							teddy.SetActive(false);
							haveteddy = false;
							((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
							UnityEngine.Object.Instantiate(newteddy, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg1)
						{
							kugg1.SetActive(false);
							havekugg1 = false;
							UnityEngine.Object.Instantiate(newkugg1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg2)
						{
							kugg2.SetActive(false);
							havekugg2 = false;
							UnityEngine.Object.Instantiate(newkugg2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemessage)
						{
							message.SetActive(false);
							havemessage = false;
							UnityEngine.Object.Instantiate(newmessage, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havehanglockKey)
						{
							hanglockKey.SetActive(false);
							havehanglockKey = false;
							UnityEngine.Object.Instantiate(newhanglockKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveoldShotgun)
						{
							oldShotgun.SetActive(false);
							haveoldShotgun = false;
							shootButton.SetActive(false);
							shootRay.SetActive(false);
							UnityEngine.Object.Instantiate(newoldShotgun, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebrunnsvev)
						{
							brunnsvev.SetActive(false);
							havebrunnsvev = false;
							UnityEngine.Object.Instantiate(newbrunnsvev, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel1)
						{
							gunDel1.SetActive(false);
							havegunDel1 = false;
							UnityEngine.Object.Instantiate(newgunDel1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel2)
						{
							gunDel2.SetActive(false);
							havegunDel2 = false;
							UnityEngine.Object.Instantiate(newgunDel2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel3)
						{
							gunDel3.SetActive(false);
							havegunDel3 = false;
							UnityEngine.Object.Instantiate(newgunDel3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarKey)
						{
							carKey.SetActive(false);
							havecarKey = false;
							((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).playerHaveCarKey = false;
							UnityEngine.Object.Instantiate(newcarKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetopplock)
						{
							topplock.SetActive(false);
							havetopplock = false;
							UnityEngine.Object.Instantiate(newtopplock, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegascan)
						{
							gascan.SetActive(false);
							havegascan = false;
							UnityEngine.Object.Instantiate(newgascan, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havewrench)
						{
							wrench.SetActive(false);
							havewrench = false;
							UnityEngine.Object.Instantiate(newwrench, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesparkplug)
						{
							sparkplug.SetActive(false);
							havesparkplug = false;
							UnityEngine.Object.Instantiate(newsparkplug, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemeat)
						{
							meat.SetActive(false);
							havemeat = false;
							UnityEngine.Object.Instantiate(newmeat, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havespecialkey)
						{
							specialkey.SetActive(false);
							havespecialkey = false;
							UnityEngine.Object.Instantiate(newspecialkey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebook)
						{
							book.SetActive(false);
							havebook = false;
							UnityEngine.Object.Instantiate(newbook, dropPoint.transform.position, dropPoint.transform.rotation);
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "gascan")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					GasolineCanText.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						gascan.SetActive(true);
						havegascan = true;
						dropObjectButton.SetActive(true);
						mittenRing.SetActive(false);
						readyPickUp = false;
						GasolineCanText.SetActive(false);
						GetComponent<AudioSource>().PlayOneShot(pickUpGascan);
						if (haveAvbitare)
						{
							avbitare.SetActive(false);
							haveAvbitare = false;
							UnityEngine.Object.Instantiate(newAvbitare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveHammare)
						{
							hammare.SetActive(false);
							haveHammare = false;
							UnityEngine.Object.Instantiate(newHammare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas)
						{
							vas.SetActive(false);
							havevas = false;
							UnityEngine.Object.Instantiate(newvas, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesafeKey)
						{
							safeKey.SetActive(false);
							havesafeKey = false;
							UnityEngine.Object.Instantiate(newsafeKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveexitKey)
						{
							exitKey.SetActive(false);
							haveexitKey = false;
							UnityEngine.Object.Instantiate(newexitKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havepadlockCode)
						{
							padlockCode.SetActive(false);
							havepadlockCode = false;
							UnityEngine.Object.Instantiate(newpadlockCode, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havearmborst)
						{
							armborst.SetActive(false);
							havearmborst = false;
							arrowButton.SetActive(false);
							shootArrowRay.SetActive(false);
							UnityEngine.Object.Instantiate(newarmborst, dropPoint.transform.position, dropPoint.transform.rotation);
							if (armborstArrowOK)
							{
								UnityEngine.Object.Instantiate(newArrow, dropPoint.transform.position, dropPoint.transform.rotation);
								haveArrow = false;
								armborstArrowOK = false;
							}
						}
						else if (haveweaponKey)
						{
							weaponKey.SetActive(false);
							haveweaponKey = false;
							UnityEngine.Object.Instantiate(newweaponKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havescrewdriver)
						{
							screwdriver.SetActive(false);
							havescrewdriver = false;
							UnityEngine.Object.Instantiate(newscrewdriver, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplanka)
						{
							planka.SetActive(false);
							haveplanka = false;
							UnityEngine.Object.Instantiate(newplanka, dropPoint.transform.position, dropPoint.transform.rotation);
							placeObject = false;
							placeObjectButton.SetActive(false);
						}
						else if (havebattery)
						{
							battery.SetActive(false);
							havebattery = false;
							UnityEngine.Object.Instantiate(newbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb1)
						{
							tb1.SetActive(false);
							havetb1 = false;
							UnityEngine.Object.Instantiate(newtb1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb2)
						{
							tb2.SetActive(false);
							havetb2 = false;
							UnityEngine.Object.Instantiate(newtb2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb3)
						{
							tb3.SetActive(false);
							havetb3 = false;
							UnityEngine.Object.Instantiate(newtb3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb4)
						{
							tb4.SetActive(false);
							havetb4 = false;
							UnityEngine.Object.Instantiate(newtb4, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas2)
						{
							vas2.SetActive(false);
							havevas2 = false;
							UnityEngine.Object.Instantiate(newvas2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplayhouseKey)
						{
							playhouseKey.SetActive(false);
							haveplayhouseKey = false;
							UnityEngine.Object.Instantiate(newplayhouseKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemelon)
						{
							melon.SetActive(false);
							havemelon = false;
							UnityEngine.Object.Instantiate(newmelon, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveteddy)
						{
							teddy.SetActive(false);
							haveteddy = false;
							((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
							UnityEngine.Object.Instantiate(newteddy, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg1)
						{
							kugg1.SetActive(false);
							havekugg1 = false;
							UnityEngine.Object.Instantiate(newkugg1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg2)
						{
							kugg2.SetActive(false);
							havekugg2 = false;
							UnityEngine.Object.Instantiate(newkugg2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemessage)
						{
							message.SetActive(false);
							havemessage = false;
							UnityEngine.Object.Instantiate(newmessage, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havehanglockKey)
						{
							hanglockKey.SetActive(false);
							havehanglockKey = false;
							UnityEngine.Object.Instantiate(newhanglockKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveoldShotgun)
						{
							oldShotgun.SetActive(false);
							haveoldShotgun = false;
							shootButton.SetActive(false);
							shootRay.SetActive(false);
							UnityEngine.Object.Instantiate(newoldShotgun, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebrunnsvev)
						{
							brunnsvev.SetActive(false);
							havebrunnsvev = false;
							UnityEngine.Object.Instantiate(newbrunnsvev, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel1)
						{
							gunDel1.SetActive(false);
							havegunDel1 = false;
							UnityEngine.Object.Instantiate(newgunDel1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel2)
						{
							gunDel2.SetActive(false);
							havegunDel2 = false;
							UnityEngine.Object.Instantiate(newgunDel2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel3)
						{
							gunDel3.SetActive(false);
							havegunDel3 = false;
							UnityEngine.Object.Instantiate(newgunDel3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarKey)
						{
							carKey.SetActive(false);
							havecarKey = false;
							((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).playerHaveCarKey = false;
							UnityEngine.Object.Instantiate(newcarKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetopplock)
						{
							topplock.SetActive(false);
							havetopplock = false;
							UnityEngine.Object.Instantiate(newtopplock, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarbattery)
						{
							carbattery.SetActive(false);
							havecarbattery = false;
							UnityEngine.Object.Instantiate(newcarbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havewrench)
						{
							wrench.SetActive(false);
							havewrench = false;
							UnityEngine.Object.Instantiate(newwrench, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesparkplug)
						{
							sparkplug.SetActive(false);
							havesparkplug = false;
							UnityEngine.Object.Instantiate(newsparkplug, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemeat)
						{
							meat.SetActive(false);
							havemeat = false;
							UnityEngine.Object.Instantiate(newmeat, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havespecialkey)
						{
							specialkey.SetActive(false);
							havespecialkey = false;
							UnityEngine.Object.Instantiate(newspecialkey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebook)
						{
							book.SetActive(false);
							havebook = false;
							UnityEngine.Object.Instantiate(newbook, dropPoint.transform.position, dropPoint.transform.rotation);
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "wrench")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					WrenchText.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						wrench.SetActive(true);
						havewrench = true;
						dropObjectButton.SetActive(true);
						mittenRing.SetActive(false);
						readyPickUp = false;
						WrenchText.SetActive(false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
						if (haveAvbitare)
						{
							avbitare.SetActive(false);
							haveAvbitare = false;
							UnityEngine.Object.Instantiate(newAvbitare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveHammare)
						{
							hammare.SetActive(false);
							haveHammare = false;
							UnityEngine.Object.Instantiate(newHammare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas)
						{
							vas.SetActive(false);
							havevas = false;
							UnityEngine.Object.Instantiate(newvas, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesafeKey)
						{
							safeKey.SetActive(false);
							havesafeKey = false;
							UnityEngine.Object.Instantiate(newsafeKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveexitKey)
						{
							exitKey.SetActive(false);
							haveexitKey = false;
							UnityEngine.Object.Instantiate(newexitKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havepadlockCode)
						{
							padlockCode.SetActive(false);
							havepadlockCode = false;
							UnityEngine.Object.Instantiate(newpadlockCode, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havearmborst)
						{
							armborst.SetActive(false);
							havearmborst = false;
							arrowButton.SetActive(false);
							shootArrowRay.SetActive(false);
							UnityEngine.Object.Instantiate(newarmborst, dropPoint.transform.position, dropPoint.transform.rotation);
							if (armborstArrowOK)
							{
								UnityEngine.Object.Instantiate(newArrow, dropPoint.transform.position, dropPoint.transform.rotation);
								haveArrow = false;
								armborstArrowOK = false;
							}
						}
						else if (haveweaponKey)
						{
							weaponKey.SetActive(false);
							haveweaponKey = false;
							UnityEngine.Object.Instantiate(newweaponKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havescrewdriver)
						{
							screwdriver.SetActive(false);
							havescrewdriver = false;
							UnityEngine.Object.Instantiate(newscrewdriver, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplanka)
						{
							planka.SetActive(false);
							haveplanka = false;
							UnityEngine.Object.Instantiate(newplanka, dropPoint.transform.position, dropPoint.transform.rotation);
							placeObject = false;
							placeObjectButton.SetActive(false);
						}
						else if (havebattery)
						{
							battery.SetActive(false);
							havebattery = false;
							UnityEngine.Object.Instantiate(newbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb1)
						{
							tb1.SetActive(false);
							havetb1 = false;
							UnityEngine.Object.Instantiate(newtb1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb2)
						{
							tb2.SetActive(false);
							havetb2 = false;
							UnityEngine.Object.Instantiate(newtb2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb3)
						{
							tb3.SetActive(false);
							havetb3 = false;
							UnityEngine.Object.Instantiate(newtb3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb4)
						{
							tb4.SetActive(false);
							havetb4 = false;
							UnityEngine.Object.Instantiate(newtb4, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas2)
						{
							vas2.SetActive(false);
							havevas2 = false;
							UnityEngine.Object.Instantiate(newvas2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplayhouseKey)
						{
							playhouseKey.SetActive(false);
							haveplayhouseKey = false;
							UnityEngine.Object.Instantiate(newplayhouseKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemelon)
						{
							melon.SetActive(false);
							havemelon = false;
							UnityEngine.Object.Instantiate(newmelon, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveteddy)
						{
							teddy.SetActive(false);
							haveteddy = false;
							((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
							UnityEngine.Object.Instantiate(newteddy, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg1)
						{
							kugg1.SetActive(false);
							havekugg1 = false;
							UnityEngine.Object.Instantiate(newkugg1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg2)
						{
							kugg2.SetActive(false);
							havekugg2 = false;
							UnityEngine.Object.Instantiate(newkugg2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemessage)
						{
							message.SetActive(false);
							havemessage = false;
							UnityEngine.Object.Instantiate(newmessage, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havehanglockKey)
						{
							hanglockKey.SetActive(false);
							havehanglockKey = false;
							UnityEngine.Object.Instantiate(newhanglockKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveoldShotgun)
						{
							oldShotgun.SetActive(false);
							haveoldShotgun = false;
							shootButton.SetActive(false);
							shootRay.SetActive(false);
							UnityEngine.Object.Instantiate(newoldShotgun, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebrunnsvev)
						{
							brunnsvev.SetActive(false);
							havebrunnsvev = false;
							UnityEngine.Object.Instantiate(newbrunnsvev, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel1)
						{
							gunDel1.SetActive(false);
							havegunDel1 = false;
							UnityEngine.Object.Instantiate(newgunDel1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel2)
						{
							gunDel2.SetActive(false);
							havegunDel2 = false;
							UnityEngine.Object.Instantiate(newgunDel2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel3)
						{
							gunDel3.SetActive(false);
							havegunDel3 = false;
							UnityEngine.Object.Instantiate(newgunDel3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarKey)
						{
							carKey.SetActive(false);
							havecarKey = false;
							((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).playerHaveCarKey = false;
							UnityEngine.Object.Instantiate(newcarKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetopplock)
						{
							topplock.SetActive(false);
							havetopplock = false;
							UnityEngine.Object.Instantiate(newtopplock, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarbattery)
						{
							carbattery.SetActive(false);
							havecarbattery = false;
							UnityEngine.Object.Instantiate(newcarbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegascan)
						{
							gascan.SetActive(false);
							havegascan = false;
							UnityEngine.Object.Instantiate(newgascan, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesparkplug)
						{
							sparkplug.SetActive(false);
							havesparkplug = false;
							UnityEngine.Object.Instantiate(newsparkplug, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemeat)
						{
							meat.SetActive(false);
							havemeat = false;
							UnityEngine.Object.Instantiate(newmeat, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havespecialkey)
						{
							specialkey.SetActive(false);
							havespecialkey = false;
							UnityEngine.Object.Instantiate(newspecialkey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebook)
						{
							book.SetActive(false);
							havebook = false;
							UnityEngine.Object.Instantiate(newbook, dropPoint.transform.position, dropPoint.transform.rotation);
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "sparkplug")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					SparkPlugText.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						sparkplug.SetActive(true);
						havesparkplug = true;
						dropObjectButton.SetActive(true);
						mittenRing.SetActive(false);
						readyPickUp = false;
						SparkPlugText.SetActive(false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
						if (haveAvbitare)
						{
							avbitare.SetActive(false);
							haveAvbitare = false;
							UnityEngine.Object.Instantiate(newAvbitare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveHammare)
						{
							hammare.SetActive(false);
							haveHammare = false;
							UnityEngine.Object.Instantiate(newHammare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas)
						{
							vas.SetActive(false);
							havevas = false;
							UnityEngine.Object.Instantiate(newvas, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesafeKey)
						{
							safeKey.SetActive(false);
							havesafeKey = false;
							UnityEngine.Object.Instantiate(newsafeKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveexitKey)
						{
							exitKey.SetActive(false);
							haveexitKey = false;
							UnityEngine.Object.Instantiate(newexitKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havepadlockCode)
						{
							padlockCode.SetActive(false);
							havepadlockCode = false;
							UnityEngine.Object.Instantiate(newpadlockCode, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havearmborst)
						{
							armborst.SetActive(false);
							havearmborst = false;
							arrowButton.SetActive(false);
							shootArrowRay.SetActive(false);
							UnityEngine.Object.Instantiate(newarmborst, dropPoint.transform.position, dropPoint.transform.rotation);
							if (armborstArrowOK)
							{
								UnityEngine.Object.Instantiate(newArrow, dropPoint.transform.position, dropPoint.transform.rotation);
								haveArrow = false;
								armborstArrowOK = false;
							}
						}
						else if (haveweaponKey)
						{
							weaponKey.SetActive(false);
							haveweaponKey = false;
							UnityEngine.Object.Instantiate(newweaponKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havescrewdriver)
						{
							screwdriver.SetActive(false);
							havescrewdriver = false;
							UnityEngine.Object.Instantiate(newscrewdriver, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplanka)
						{
							planka.SetActive(false);
							haveplanka = false;
							UnityEngine.Object.Instantiate(newplanka, dropPoint.transform.position, dropPoint.transform.rotation);
							placeObject = false;
							placeObjectButton.SetActive(false);
						}
						else if (havebattery)
						{
							battery.SetActive(false);
							havebattery = false;
							UnityEngine.Object.Instantiate(newbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb1)
						{
							tb1.SetActive(false);
							havetb1 = false;
							UnityEngine.Object.Instantiate(newtb1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb2)
						{
							tb2.SetActive(false);
							havetb2 = false;
							UnityEngine.Object.Instantiate(newtb2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb3)
						{
							tb3.SetActive(false);
							havetb3 = false;
							UnityEngine.Object.Instantiate(newtb3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb4)
						{
							tb4.SetActive(false);
							havetb4 = false;
							UnityEngine.Object.Instantiate(newtb4, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas2)
						{
							vas2.SetActive(false);
							havevas2 = false;
							UnityEngine.Object.Instantiate(newvas2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplayhouseKey)
						{
							playhouseKey.SetActive(false);
							haveplayhouseKey = false;
							UnityEngine.Object.Instantiate(newplayhouseKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemelon)
						{
							melon.SetActive(false);
							havemelon = false;
							UnityEngine.Object.Instantiate(newmelon, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveteddy)
						{
							teddy.SetActive(false);
							haveteddy = false;
							((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
							UnityEngine.Object.Instantiate(newteddy, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg1)
						{
							kugg1.SetActive(false);
							havekugg1 = false;
							UnityEngine.Object.Instantiate(newkugg1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg2)
						{
							kugg2.SetActive(false);
							havekugg2 = false;
							UnityEngine.Object.Instantiate(newkugg2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemessage)
						{
							message.SetActive(false);
							havemessage = false;
							UnityEngine.Object.Instantiate(newmessage, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havehanglockKey)
						{
							hanglockKey.SetActive(false);
							havehanglockKey = false;
							UnityEngine.Object.Instantiate(newhanglockKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveoldShotgun)
						{
							oldShotgun.SetActive(false);
							haveoldShotgun = false;
							shootButton.SetActive(false);
							shootRay.SetActive(false);
							UnityEngine.Object.Instantiate(newoldShotgun, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebrunnsvev)
						{
							brunnsvev.SetActive(false);
							havebrunnsvev = false;
							UnityEngine.Object.Instantiate(newbrunnsvev, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel1)
						{
							gunDel1.SetActive(false);
							havegunDel1 = false;
							UnityEngine.Object.Instantiate(newgunDel1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel2)
						{
							gunDel2.SetActive(false);
							havegunDel2 = false;
							UnityEngine.Object.Instantiate(newgunDel2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel3)
						{
							gunDel3.SetActive(false);
							havegunDel3 = false;
							UnityEngine.Object.Instantiate(newgunDel3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarKey)
						{
							carKey.SetActive(false);
							havecarKey = false;
							((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).playerHaveCarKey = false;
							UnityEngine.Object.Instantiate(newcarKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetopplock)
						{
							topplock.SetActive(false);
							havetopplock = false;
							UnityEngine.Object.Instantiate(newtopplock, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarbattery)
						{
							carbattery.SetActive(false);
							havecarbattery = false;
							UnityEngine.Object.Instantiate(newcarbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegascan)
						{
							gascan.SetActive(false);
							havegascan = false;
							UnityEngine.Object.Instantiate(newgascan, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havewrench)
						{
							wrench.SetActive(false);
							havewrench = false;
							UnityEngine.Object.Instantiate(newwrench, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemeat)
						{
							meat.SetActive(false);
							havemeat = false;
							UnityEngine.Object.Instantiate(newmeat, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havespecialkey)
						{
							specialkey.SetActive(false);
							havespecialkey = false;
							UnityEngine.Object.Instantiate(newspecialkey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebook)
						{
							book.SetActive(false);
							havebook = false;
							UnityEngine.Object.Instantiate(newbook, dropPoint.transform.position, dropPoint.transform.rotation);
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "meat")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					MeatText.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						meat.SetActive(true);
						havemeat = true;
						dropObjectButton.SetActive(true);
						mittenRing.SetActive(false);
						readyPickUp = false;
						MeatText.SetActive(false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
						if (haveAvbitare)
						{
							avbitare.SetActive(false);
							haveAvbitare = false;
							UnityEngine.Object.Instantiate(newAvbitare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveHammare)
						{
							hammare.SetActive(false);
							haveHammare = false;
							UnityEngine.Object.Instantiate(newHammare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas)
						{
							vas.SetActive(false);
							havevas = false;
							UnityEngine.Object.Instantiate(newvas, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesafeKey)
						{
							safeKey.SetActive(false);
							havesafeKey = false;
							UnityEngine.Object.Instantiate(newsafeKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveexitKey)
						{
							exitKey.SetActive(false);
							haveexitKey = false;
							UnityEngine.Object.Instantiate(newexitKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havepadlockCode)
						{
							padlockCode.SetActive(false);
							havepadlockCode = false;
							UnityEngine.Object.Instantiate(newpadlockCode, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havearmborst)
						{
							armborst.SetActive(false);
							havearmborst = false;
							arrowButton.SetActive(false);
							shootArrowRay.SetActive(false);
							UnityEngine.Object.Instantiate(newarmborst, dropPoint.transform.position, dropPoint.transform.rotation);
							if (armborstArrowOK)
							{
								UnityEngine.Object.Instantiate(newArrow, dropPoint.transform.position, dropPoint.transform.rotation);
								haveArrow = false;
								armborstArrowOK = false;
							}
						}
						else if (haveweaponKey)
						{
							weaponKey.SetActive(false);
							haveweaponKey = false;
							UnityEngine.Object.Instantiate(newweaponKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havescrewdriver)
						{
							screwdriver.SetActive(false);
							havescrewdriver = false;
							UnityEngine.Object.Instantiate(newscrewdriver, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplanka)
						{
							planka.SetActive(false);
							haveplanka = false;
							UnityEngine.Object.Instantiate(newplanka, dropPoint.transform.position, dropPoint.transform.rotation);
							placeObject = false;
							placeObjectButton.SetActive(false);
						}
						else if (havebattery)
						{
							battery.SetActive(false);
							havebattery = false;
							UnityEngine.Object.Instantiate(newbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb1)
						{
							tb1.SetActive(false);
							havetb1 = false;
							UnityEngine.Object.Instantiate(newtb1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb2)
						{
							tb2.SetActive(false);
							havetb2 = false;
							UnityEngine.Object.Instantiate(newtb2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb3)
						{
							tb3.SetActive(false);
							havetb3 = false;
							UnityEngine.Object.Instantiate(newtb3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb4)
						{
							tb4.SetActive(false);
							havetb4 = false;
							UnityEngine.Object.Instantiate(newtb4, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas2)
						{
							vas2.SetActive(false);
							havevas2 = false;
							UnityEngine.Object.Instantiate(newvas2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplayhouseKey)
						{
							playhouseKey.SetActive(false);
							haveplayhouseKey = false;
							UnityEngine.Object.Instantiate(newplayhouseKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemelon)
						{
							melon.SetActive(false);
							havemelon = false;
							UnityEngine.Object.Instantiate(newmelon, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveteddy)
						{
							teddy.SetActive(false);
							haveteddy = false;
							((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
							UnityEngine.Object.Instantiate(newteddy, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg1)
						{
							kugg1.SetActive(false);
							havekugg1 = false;
							UnityEngine.Object.Instantiate(newkugg1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg2)
						{
							kugg2.SetActive(false);
							havekugg2 = false;
							UnityEngine.Object.Instantiate(newkugg2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemessage)
						{
							message.SetActive(false);
							havemessage = false;
							UnityEngine.Object.Instantiate(newmessage, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havehanglockKey)
						{
							hanglockKey.SetActive(false);
							havehanglockKey = false;
							UnityEngine.Object.Instantiate(newhanglockKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveoldShotgun)
						{
							oldShotgun.SetActive(false);
							haveoldShotgun = false;
							shootButton.SetActive(false);
							shootRay.SetActive(false);
							UnityEngine.Object.Instantiate(newoldShotgun, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebrunnsvev)
						{
							brunnsvev.SetActive(false);
							havebrunnsvev = false;
							UnityEngine.Object.Instantiate(newbrunnsvev, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel1)
						{
							gunDel1.SetActive(false);
							havegunDel1 = false;
							UnityEngine.Object.Instantiate(newgunDel1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel2)
						{
							gunDel2.SetActive(false);
							havegunDel2 = false;
							UnityEngine.Object.Instantiate(newgunDel2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel3)
						{
							gunDel3.SetActive(false);
							havegunDel3 = false;
							UnityEngine.Object.Instantiate(newgunDel3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarKey)
						{
							carKey.SetActive(false);
							havecarKey = false;
							((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).playerHaveCarKey = false;
							UnityEngine.Object.Instantiate(newcarKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetopplock)
						{
							topplock.SetActive(false);
							havetopplock = false;
							UnityEngine.Object.Instantiate(newtopplock, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarbattery)
						{
							carbattery.SetActive(false);
							havecarbattery = false;
							UnityEngine.Object.Instantiate(newcarbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegascan)
						{
							gascan.SetActive(false);
							havegascan = false;
							UnityEngine.Object.Instantiate(newgascan, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havewrench)
						{
							wrench.SetActive(false);
							havewrench = false;
							UnityEngine.Object.Instantiate(newwrench, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesparkplug)
						{
							sparkplug.SetActive(false);
							havesparkplug = false;
							UnityEngine.Object.Instantiate(newsparkplug, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havespecialkey)
						{
							specialkey.SetActive(false);
							havespecialkey = false;
							UnityEngine.Object.Instantiate(newspecialkey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebook)
						{
							book.SetActive(false);
							havebook = false;
							UnityEngine.Object.Instantiate(newbook, dropPoint.transform.position, dropPoint.transform.rotation);
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "specialkey")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					specialKeyText.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						specialkey.SetActive(true);
						havespecialkey = true;
						dropObjectButton.SetActive(true);
						mittenRing.SetActive(false);
						readyPickUp = false;
						specialKeyText.SetActive(false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
						if (haveAvbitare)
						{
							avbitare.SetActive(false);
							haveAvbitare = false;
							UnityEngine.Object.Instantiate(newAvbitare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveHammare)
						{
							hammare.SetActive(false);
							haveHammare = false;
							UnityEngine.Object.Instantiate(newHammare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas)
						{
							vas.SetActive(false);
							havevas = false;
							UnityEngine.Object.Instantiate(newvas, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesafeKey)
						{
							safeKey.SetActive(false);
							havesafeKey = false;
							UnityEngine.Object.Instantiate(newsafeKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveexitKey)
						{
							exitKey.SetActive(false);
							haveexitKey = false;
							UnityEngine.Object.Instantiate(newexitKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havepadlockCode)
						{
							padlockCode.SetActive(false);
							havepadlockCode = false;
							UnityEngine.Object.Instantiate(newpadlockCode, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havearmborst)
						{
							armborst.SetActive(false);
							havearmborst = false;
							arrowButton.SetActive(false);
							shootArrowRay.SetActive(false);
							UnityEngine.Object.Instantiate(newarmborst, dropPoint.transform.position, dropPoint.transform.rotation);
							if (armborstArrowOK)
							{
								UnityEngine.Object.Instantiate(newArrow, dropPoint.transform.position, dropPoint.transform.rotation);
								haveArrow = false;
								armborstArrowOK = false;
							}
						}
						else if (haveweaponKey)
						{
							weaponKey.SetActive(false);
							haveweaponKey = false;
							UnityEngine.Object.Instantiate(newweaponKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havescrewdriver)
						{
							screwdriver.SetActive(false);
							havescrewdriver = false;
							UnityEngine.Object.Instantiate(newscrewdriver, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplanka)
						{
							planka.SetActive(false);
							haveplanka = false;
							UnityEngine.Object.Instantiate(newplanka, dropPoint.transform.position, dropPoint.transform.rotation);
							placeObject = false;
							placeObjectButton.SetActive(false);
						}
						else if (havebattery)
						{
							battery.SetActive(false);
							havebattery = false;
							UnityEngine.Object.Instantiate(newbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb1)
						{
							tb1.SetActive(false);
							havetb1 = false;
							UnityEngine.Object.Instantiate(newtb1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb2)
						{
							tb2.SetActive(false);
							havetb2 = false;
							UnityEngine.Object.Instantiate(newtb2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb3)
						{
							tb3.SetActive(false);
							havetb3 = false;
							UnityEngine.Object.Instantiate(newtb3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb4)
						{
							tb4.SetActive(false);
							havetb4 = false;
							UnityEngine.Object.Instantiate(newtb4, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas2)
						{
							vas2.SetActive(false);
							havevas2 = false;
							UnityEngine.Object.Instantiate(newvas2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplayhouseKey)
						{
							playhouseKey.SetActive(false);
							haveplayhouseKey = false;
							UnityEngine.Object.Instantiate(newplayhouseKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemelon)
						{
							melon.SetActive(false);
							havemelon = false;
							UnityEngine.Object.Instantiate(newmelon, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveteddy)
						{
							teddy.SetActive(false);
							haveteddy = false;
							((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
							UnityEngine.Object.Instantiate(newteddy, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg1)
						{
							kugg1.SetActive(false);
							havekugg1 = false;
							UnityEngine.Object.Instantiate(newkugg1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg2)
						{
							kugg2.SetActive(false);
							havekugg2 = false;
							UnityEngine.Object.Instantiate(newkugg2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemessage)
						{
							message.SetActive(false);
							havemessage = false;
							UnityEngine.Object.Instantiate(newmessage, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havehanglockKey)
						{
							hanglockKey.SetActive(false);
							havehanglockKey = false;
							UnityEngine.Object.Instantiate(newhanglockKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveoldShotgun)
						{
							oldShotgun.SetActive(false);
							haveoldShotgun = false;
							shootButton.SetActive(false);
							shootRay.SetActive(false);
							UnityEngine.Object.Instantiate(newoldShotgun, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebrunnsvev)
						{
							brunnsvev.SetActive(false);
							havebrunnsvev = false;
							UnityEngine.Object.Instantiate(newbrunnsvev, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel1)
						{
							gunDel1.SetActive(false);
							havegunDel1 = false;
							UnityEngine.Object.Instantiate(newgunDel1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel2)
						{
							gunDel2.SetActive(false);
							havegunDel2 = false;
							UnityEngine.Object.Instantiate(newgunDel2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel3)
						{
							gunDel3.SetActive(false);
							havegunDel3 = false;
							UnityEngine.Object.Instantiate(newgunDel3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarKey)
						{
							carKey.SetActive(false);
							havecarKey = false;
							((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).playerHaveCarKey = false;
							UnityEngine.Object.Instantiate(newcarKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetopplock)
						{
							topplock.SetActive(false);
							havetopplock = false;
							UnityEngine.Object.Instantiate(newtopplock, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarbattery)
						{
							carbattery.SetActive(false);
							havecarbattery = false;
							UnityEngine.Object.Instantiate(newcarbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegascan)
						{
							gascan.SetActive(false);
							havegascan = false;
							UnityEngine.Object.Instantiate(newgascan, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havewrench)
						{
							wrench.SetActive(false);
							havewrench = false;
							UnityEngine.Object.Instantiate(newwrench, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesparkplug)
						{
							sparkplug.SetActive(false);
							havesparkplug = false;
							UnityEngine.Object.Instantiate(newsparkplug, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemeat)
						{
							meat.SetActive(false);
							havemeat = false;
							UnityEngine.Object.Instantiate(newmeat, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebook)
						{
							book.SetActive(false);
							havebook = false;
							UnityEngine.Object.Instantiate(newbook, dropPoint.transform.position, dropPoint.transform.rotation);
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "book")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					bookText.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						book.SetActive(true);
						havebook = true;
						dropObjectButton.SetActive(true);
						mittenRing.SetActive(false);
						readyPickUp = false;
						bookText.SetActive(false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
						if (haveAvbitare)
						{
							avbitare.SetActive(false);
							haveAvbitare = false;
							UnityEngine.Object.Instantiate(newAvbitare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveHammare)
						{
							hammare.SetActive(false);
							haveHammare = false;
							UnityEngine.Object.Instantiate(newHammare, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas)
						{
							vas.SetActive(false);
							havevas = false;
							UnityEngine.Object.Instantiate(newvas, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesafeKey)
						{
							safeKey.SetActive(false);
							havesafeKey = false;
							UnityEngine.Object.Instantiate(newsafeKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveexitKey)
						{
							exitKey.SetActive(false);
							haveexitKey = false;
							UnityEngine.Object.Instantiate(newexitKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havepadlockCode)
						{
							padlockCode.SetActive(false);
							havepadlockCode = false;
							UnityEngine.Object.Instantiate(newpadlockCode, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havearmborst)
						{
							armborst.SetActive(false);
							havearmborst = false;
							arrowButton.SetActive(false);
							shootArrowRay.SetActive(false);
							UnityEngine.Object.Instantiate(newarmborst, dropPoint.transform.position, dropPoint.transform.rotation);
							if (armborstArrowOK)
							{
								UnityEngine.Object.Instantiate(newArrow, dropPoint.transform.position, dropPoint.transform.rotation);
								haveArrow = false;
								armborstArrowOK = false;
							}
						}
						else if (haveweaponKey)
						{
							weaponKey.SetActive(false);
							haveweaponKey = false;
							UnityEngine.Object.Instantiate(newweaponKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havescrewdriver)
						{
							screwdriver.SetActive(false);
							havescrewdriver = false;
							UnityEngine.Object.Instantiate(newscrewdriver, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplanka)
						{
							planka.SetActive(false);
							haveplanka = false;
							UnityEngine.Object.Instantiate(newplanka, dropPoint.transform.position, dropPoint.transform.rotation);
							placeObject = false;
							placeObjectButton.SetActive(false);
						}
						else if (havebattery)
						{
							battery.SetActive(false);
							havebattery = false;
							UnityEngine.Object.Instantiate(newbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb1)
						{
							tb1.SetActive(false);
							havetb1 = false;
							UnityEngine.Object.Instantiate(newtb1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb2)
						{
							tb2.SetActive(false);
							havetb2 = false;
							UnityEngine.Object.Instantiate(newtb2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb3)
						{
							tb3.SetActive(false);
							havetb3 = false;
							UnityEngine.Object.Instantiate(newtb3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetb4)
						{
							tb4.SetActive(false);
							havetb4 = false;
							UnityEngine.Object.Instantiate(newtb4, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havevas2)
						{
							vas2.SetActive(false);
							havevas2 = false;
							UnityEngine.Object.Instantiate(newvas2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveplayhouseKey)
						{
							playhouseKey.SetActive(false);
							haveplayhouseKey = false;
							UnityEngine.Object.Instantiate(newplayhouseKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemelon)
						{
							melon.SetActive(false);
							havemelon = false;
							UnityEngine.Object.Instantiate(newmelon, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveteddy)
						{
							teddy.SetActive(false);
							haveteddy = false;
							((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
							UnityEngine.Object.Instantiate(newteddy, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg1)
						{
							kugg1.SetActive(false);
							havekugg1 = false;
							UnityEngine.Object.Instantiate(newkugg1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havekugg2)
						{
							kugg2.SetActive(false);
							havekugg2 = false;
							UnityEngine.Object.Instantiate(newkugg2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemessage)
						{
							message.SetActive(false);
							havemessage = false;
							UnityEngine.Object.Instantiate(newmessage, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havehanglockKey)
						{
							hanglockKey.SetActive(false);
							havehanglockKey = false;
							UnityEngine.Object.Instantiate(newhanglockKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (haveoldShotgun)
						{
							oldShotgun.SetActive(false);
							haveoldShotgun = false;
							shootButton.SetActive(false);
							shootRay.SetActive(false);
							UnityEngine.Object.Instantiate(newoldShotgun, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havebrunnsvev)
						{
							brunnsvev.SetActive(false);
							havebrunnsvev = false;
							UnityEngine.Object.Instantiate(newbrunnsvev, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel1)
						{
							gunDel1.SetActive(false);
							havegunDel1 = false;
							UnityEngine.Object.Instantiate(newgunDel1, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel2)
						{
							gunDel2.SetActive(false);
							havegunDel2 = false;
							UnityEngine.Object.Instantiate(newgunDel2, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegunDel3)
						{
							gunDel3.SetActive(false);
							havegunDel3 = false;
							UnityEngine.Object.Instantiate(newgunDel3, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarKey)
						{
							carKey.SetActive(false);
							havecarKey = false;
							((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).playerHaveCarKey = false;
							UnityEngine.Object.Instantiate(newcarKey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havetopplock)
						{
							topplock.SetActive(false);
							havetopplock = false;
							UnityEngine.Object.Instantiate(newtopplock, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havecarbattery)
						{
							carbattery.SetActive(false);
							havecarbattery = false;
							UnityEngine.Object.Instantiate(newcarbattery, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havegascan)
						{
							gascan.SetActive(false);
							havegascan = false;
							UnityEngine.Object.Instantiate(newgascan, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havewrench)
						{
							wrench.SetActive(false);
							havewrench = false;
							UnityEngine.Object.Instantiate(newwrench, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havesparkplug)
						{
							sparkplug.SetActive(false);
							havesparkplug = false;
							UnityEngine.Object.Instantiate(newsparkplug, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havemeat)
						{
							meat.SetActive(false);
							havemeat = false;
							UnityEngine.Object.Instantiate(newmeat, dropPoint.transform.position, dropPoint.transform.rotation);
						}
						else if (havespecialkey)
						{
							specialkey.SetActive(false);
							havespecialkey = false;
							UnityEngine.Object.Instantiate(newspecialkey, dropPoint.transform.position, dropPoint.transform.rotation);
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "bluekabel")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (haveAvbitare)
						{
							if (!playSound)
							{
								playSound = true;
								GetComponent<AudioSource>().PlayOneShot(klippKabel);
								LampaDoor1.gameObject.GetComponent<Renderer>().material.color = new Color(0f, 1f, 0f);
								((CheckExitDoor)gameController.GetComponent(typeof(CheckExitDoor))).lampa1ok = true;
								((CheckExitDoor)gameController.GetComponent(typeof(CheckExitDoor))).counter = ((CheckExitDoor)gameController.GetComponent(typeof(CheckExitDoor))).counter + 1f;
							}
							UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
							avklipptKabel.SetActive(true);
						}
						else
						{
							textTimer = 0f;
							NeedAvbitarTongText.SetActive(true);
							textTimerOnOff = true;
							NeedhangLockKeyText.SetActive(false);
							NeedhammerText.SetActive(false);
							NeedsafeKeyText.SetActive(false);
							NeedHusnyckelText.SetActive(false);
							NeedpadlockCodeText.SetActive(false);
							NeedCrossbowText.SetActive(false);
							NeedweaponKeyText.SetActive(false);
							NeedscrewdriverText.SetActive(false);
							NeedbatteryText.SetActive(false);
							missinTavelbitarText.SetActive(false);
							NeedplayhouseKeyText.SetActive(false);
							cutThingsHereText.SetActive(false);
							SomethingMissingHereText.SetActive(false);
							NeedWinchhandleText.SetActive(false);
							NeedShotgunText.SetActive(false);
							ShotgunLoadedText.SetActive(false);
							NeedcarKeyText.SetActive(false);
							NeedCarBatteryText.SetActive(false);
							NeedSparkPlugText.SetActive(false);
							NeedEnginePartText.SetActive(false);
							NeedWrenchText.SetActive(false);
							NeedGasolineText.SetActive(false);
							emptyPlateText.SetActive(false);
							NeedSpecialKeyText.SetActive(false);
							NeedFindSwitchText.SetActive(false);
						}
					}
					audioPickUp();
				}
				else if (hitInfo.collider.gameObject.tag == "bluekabelcellar")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (haveAvbitare)
						{
							if (!playSound)
							{
								playSound = true;
								GetComponent<AudioSource>().PlayOneShot(klippKabel);
								LampaDoor2.gameObject.GetComponent<Renderer>().material.color = new Color(0f, 1f, 0f);
								((CheckExitDoor)gameController.GetComponent(typeof(CheckExitDoor))).lampa2ok = true;
								((CheckExitDoor)gameController.GetComponent(typeof(CheckExitDoor))).counter = ((CheckExitDoor)gameController.GetComponent(typeof(CheckExitDoor))).counter + 1f;
							}
							UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
							avklipptKabelCellar.SetActive(true);
						}
						else
						{
							textTimer = 0f;
							NeedAvbitarTongText.SetActive(true);
							textTimerOnOff = true;
							NeedhangLockKeyText.SetActive(false);
							NeedhammerText.SetActive(false);
							NeedsafeKeyText.SetActive(false);
							NeedHusnyckelText.SetActive(false);
							NeedpadlockCodeText.SetActive(false);
							NeedCrossbowText.SetActive(false);
							NeedweaponKeyText.SetActive(false);
							NeedscrewdriverText.SetActive(false);
							NeedbatteryText.SetActive(false);
							missinTavelbitarText.SetActive(false);
							NeedplayhouseKeyText.SetActive(false);
							cutThingsHereText.SetActive(false);
							SomethingMissingHereText.SetActive(false);
							NeedWinchhandleText.SetActive(false);
							NeedShotgunText.SetActive(false);
							ShotgunLoadedText.SetActive(false);
							NeedcarKeyText.SetActive(false);
							NeedCarBatteryText.SetActive(false);
							NeedSparkPlugText.SetActive(false);
							NeedEnginePartText.SetActive(false);
							NeedWrenchText.SetActive(false);
							NeedGasolineText.SetActive(false);
							emptyPlateText.SetActive(false);
							NeedSpecialKeyText.SetActive(false);
						}
					}
					audioPickUp();
				}
				else if (hitInfo.collider.gameObject.tag == "bluekabelvind")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (haveAvbitare)
						{
							if (!playSound)
							{
								playSound = true;
								GetComponent<AudioSource>().PlayOneShot(klippKabel);
								fan.GetComponent<Animation>().Stop("FanSpinn");
								fanCollider.SetActive(false);
							}
							UnityEngine.Object.Destroy(KabelVind);
							avklipptKabelVind.SetActive(true);
						}
						else
						{
							textTimer = 0f;
							NeedAvbitarTongText.SetActive(true);
							textTimerOnOff = true;
							NeedhangLockKeyText.SetActive(false);
							NeedhammerText.SetActive(false);
							NeedsafeKeyText.SetActive(false);
							NeedHusnyckelText.SetActive(false);
							NeedpadlockCodeText.SetActive(false);
							NeedCrossbowText.SetActive(false);
							NeedweaponKeyText.SetActive(false);
							NeedscrewdriverText.SetActive(false);
							NeedbatteryText.SetActive(false);
							missinTavelbitarText.SetActive(false);
							NeedplayhouseKeyText.SetActive(false);
							cutThingsHereText.SetActive(false);
							SomethingMissingHereText.SetActive(false);
							NeedWinchhandleText.SetActive(false);
							NeedShotgunText.SetActive(false);
							ShotgunLoadedText.SetActive(false);
							NeedcarKeyText.SetActive(false);
							NeedCarBatteryText.SetActive(false);
							NeedSparkPlugText.SetActive(false);
							NeedEnginePartText.SetActive(false);
							NeedWrenchText.SetActive(false);
							NeedGasolineText.SetActive(false);
							emptyPlateText.SetActive(false);
							NeedSpecialKeyText.SetActive(false);
						}
					}
					audioPickUp();
				}
				else if (hitInfo.collider.gameObject.tag == "planka")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (haveHammare)
						{
							if (!playSound)
							{
								if (((CheckExitDoor)gameController.GetComponent(typeof(CheckExitDoor))).planka1Bort)
								{
									playSound = true;
									UnityEngine.Object.Destroy((HingeJoint)hitInfo.collider.gameObject.GetComponent(typeof(HingeJoint)));
									GetComponent<AudioSource>().PlayOneShot(taBortPlanka);
									((CheckExitDoor)gameController.GetComponent(typeof(CheckExitDoor))).planka2Bort = true;
									((CheckExitDoor)gameController.GetComponent(typeof(CheckExitDoor))).counter = ((CheckExitDoor)gameController.GetComponent(typeof(CheckExitDoor))).counter + 1f;
									hitInfo.collider.gameObject.tag = "Untagged";
								}
								else
								{
									((Rigidbody)hitInfo.collider.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
									playSound = true;
									GetComponent<AudioSource>().PlayOneShot(taBortPlanka);
									((CheckExitDoor)gameController.GetComponent(typeof(CheckExitDoor))).planka1Bort = true;
								}
							}
						}
						else
						{
							textTimer = 0f;
							NeedhammerText.SetActive(true);
							textTimerOnOff = true;
							NeedhangLockKeyText.SetActive(false);
							NeedsafeKeyText.SetActive(false);
							NeedAvbitarTongText.SetActive(false);
							NeedHusnyckelText.SetActive(false);
							NeedpadlockCodeText.SetActive(false);
							NeedCrossbowText.SetActive(false);
							NeedweaponKeyText.SetActive(false);
							NeedscrewdriverText.SetActive(false);
							NeedbatteryText.SetActive(false);
							missinTavelbitarText.SetActive(false);
							NeedplayhouseKeyText.SetActive(false);
							cutThingsHereText.SetActive(false);
							SomethingMissingHereText.SetActive(false);
							NeedWinchhandleText.SetActive(false);
							NeedShotgunText.SetActive(false);
							ShotgunLoadedText.SetActive(false);
							NeedcarKeyText.SetActive(false);
							NeedCarBatteryText.SetActive(false);
							NeedSparkPlugText.SetActive(false);
							NeedEnginePartText.SetActive(false);
							NeedWrenchText.SetActive(false);
							NeedGasolineText.SetActive(false);
							emptyPlateText.SetActive(false);
							NeedSpecialKeyText.SetActive(false);
							NeedFindSwitchText.SetActive(false);
						}
					}
					audioPickUp();
				}
				else if (hitInfo.collider.gameObject.tag == "plankavind")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (haveHammare)
						{
							((Rigidbody)hitInfo.collider.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
							GetComponent<AudioSource>().PlayOneShot(taBortPlanka);
							hitInfo.collider.gameObject.tag = "plankawalk";
						}
						else
						{
							textTimer = 0f;
							NeedhammerText.SetActive(true);
							textTimerOnOff = true;
							NeedhangLockKeyText.SetActive(false);
							NeedsafeKeyText.SetActive(false);
							NeedAvbitarTongText.SetActive(false);
							NeedHusnyckelText.SetActive(false);
							NeedpadlockCodeText.SetActive(false);
							NeedCrossbowText.SetActive(false);
							NeedweaponKeyText.SetActive(false);
							NeedscrewdriverText.SetActive(false);
							NeedbatteryText.SetActive(false);
							missinTavelbitarText.SetActive(false);
							NeedplayhouseKeyText.SetActive(false);
							cutThingsHereText.SetActive(false);
							SomethingMissingHereText.SetActive(false);
							NeedWinchhandleText.SetActive(false);
							NeedShotgunText.SetActive(false);
							ShotgunLoadedText.SetActive(false);
							NeedcarKeyText.SetActive(false);
							NeedCarBatteryText.SetActive(false);
							NeedSparkPlugText.SetActive(false);
							NeedEnginePartText.SetActive(false);
							NeedWrenchText.SetActive(false);
							NeedGasolineText.SetActive(false);
							emptyPlateText.SetActive(false);
							NeedSpecialKeyText.SetActive(false);
						}
					}
					audioPickUp();
				}
				else if (hitInfo.collider.gameObject.tag == "exitdoor")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (haveexitKey)
						{
							if (!playSound)
							{
								playSound = true;
								StartCoroutine(((CheckExitDoor)gameController.GetComponent(typeof(CheckExitDoor))).openExitdoor());
							}
						}
						else
						{
							textTimer = 0f;
							GetComponent<AudioSource>().PlayOneShot(doorLocked);
							NeedHusnyckelText.SetActive(true);
							textTimerOnOff = true;
							NeedhangLockKeyText.SetActive(false);
							NeedhammerText.SetActive(false);
							NeedsafeKeyText.SetActive(false);
							NeedAvbitarTongText.SetActive(false);
							NeedpadlockCodeText.SetActive(false);
							NeedCrossbowText.SetActive(false);
							NeedweaponKeyText.SetActive(false);
							NeedscrewdriverText.SetActive(false);
							NeedbatteryText.SetActive(false);
							missinTavelbitarText.SetActive(false);
							NeedplayhouseKeyText.SetActive(false);
							cutThingsHereText.SetActive(false);
							SomethingMissingHereText.SetActive(false);
							NeedWinchhandleText.SetActive(false);
							NeedShotgunText.SetActive(false);
							ShotgunLoadedText.SetActive(false);
							NeedcarKeyText.SetActive(false);
							NeedCarBatteryText.SetActive(false);
							NeedSparkPlugText.SetActive(false);
							NeedEnginePartText.SetActive(false);
							NeedWrenchText.SetActive(false);
							NeedGasolineText.SetActive(false);
							emptyPlateText.SetActive(false);
							NeedSpecialKeyText.SetActive(false);
							NeedFindSwitchText.SetActive(false);
						}
					}
					audioPickUp();
				}
				else if (hitInfo.collider.gameObject.tag == "hanglock")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (havehanglockKey)
						{
							if (!playSound)
							{
								playSound = true;
								((Rigidbody)hitInfo.collider.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
								((Rigidbody)Bom.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
								((CheckExitDoor)gameController.GetComponent(typeof(CheckExitDoor))).hangLockBort = true;
								((CheckExitDoor)gameController.GetComponent(typeof(CheckExitDoor))).counter = ((CheckExitDoor)gameController.GetComponent(typeof(CheckExitDoor))).counter + 1f;
								GetComponent<AudioSource>().PlayOneShot(klippKabel);
								hitInfo.collider.gameObject.tag = "Untagged";
							}
						}
						else
						{
							textTimer = 0f;
							NeedhangLockKeyText.SetActive(true);
							textTimerOnOff = true;
							NeedhammerText.SetActive(false);
							NeedsafeKeyText.SetActive(false);
							NeedAvbitarTongText.SetActive(false);
							NeedHusnyckelText.SetActive(false);
							NeedpadlockCodeText.SetActive(false);
							NeedCrossbowText.SetActive(false);
							NeedweaponKeyText.SetActive(false);
							NeedscrewdriverText.SetActive(false);
							NeedbatteryText.SetActive(false);
							missinTavelbitarText.SetActive(false);
							NeedplayhouseKeyText.SetActive(false);
							cutThingsHereText.SetActive(false);
							SomethingMissingHereText.SetActive(false);
							NeedWinchhandleText.SetActive(false);
							NeedShotgunText.SetActive(false);
							ShotgunLoadedText.SetActive(false);
							NeedcarKeyText.SetActive(false);
							NeedCarBatteryText.SetActive(false);
							NeedSparkPlugText.SetActive(false);
							NeedEnginePartText.SetActive(false);
							NeedWrenchText.SetActive(false);
							NeedGasolineText.SetActive(false);
							emptyPlateText.SetActive(false);
							NeedSpecialKeyText.SetActive(false);
							NeedFindSwitchText.SetActive(false);
						}
					}
					audioPickUp();
				}
				else if (hitInfo.collider.gameObject.tag == "hanglockgarage")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (havehanglockKey)
						{
							if (!playSound)
							{
								playSound = true;
								((Rigidbody)hitInfo.collider.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
								((openDoors)doorRayHolder.GetComponent(typeof(openDoors))).garageportLock = true;
								GetComponent<AudioSource>().PlayOneShot(klippKabel);
								hitInfo.collider.gameObject.tag = "Untagged";
							}
						}
						else
						{
							textTimer = 0f;
							NeedhangLockKeyText.SetActive(true);
							textTimerOnOff = true;
							NeedhammerText.SetActive(false);
							NeedsafeKeyText.SetActive(false);
							NeedAvbitarTongText.SetActive(false);
							NeedHusnyckelText.SetActive(false);
							NeedpadlockCodeText.SetActive(false);
							NeedCrossbowText.SetActive(false);
							NeedweaponKeyText.SetActive(false);
							NeedscrewdriverText.SetActive(false);
							NeedbatteryText.SetActive(false);
							missinTavelbitarText.SetActive(false);
							NeedplayhouseKeyText.SetActive(false);
							cutThingsHereText.SetActive(false);
							SomethingMissingHereText.SetActive(false);
							NeedWinchhandleText.SetActive(false);
							NeedShotgunText.SetActive(false);
							ShotgunLoadedText.SetActive(false);
							NeedcarKeyText.SetActive(false);
							NeedCarBatteryText.SetActive(false);
							NeedSparkPlugText.SetActive(false);
							NeedEnginePartText.SetActive(false);
							NeedWrenchText.SetActive(false);
							NeedGasolineText.SetActive(false);
							emptyPlateText.SetActive(false);
							NeedSpecialKeyText.SetActive(false);
						}
					}
					audioPickUp();
				}
				else if (hitInfo.collider.gameObject.tag == "phpadlock")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (haveplayhouseKey)
						{
							if (!playSound)
							{
								playSound = true;
								((Rigidbody)hitInfo.collider.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
								playhouseDoor.gameObject.tag = "innerdoorClosed";
								GetComponent<AudioSource>().PlayOneShot(klippKabel);
								hitInfo.collider.gameObject.tag = "Untagged";
							}
						}
						else
						{
							textTimer = 0f;
							NeedplayhouseKeyText.SetActive(true);
							textTimerOnOff = true;
							NeedhangLockKeyText.SetActive(false);
							NeedhammerText.SetActive(false);
							NeedsafeKeyText.SetActive(false);
							NeedAvbitarTongText.SetActive(false);
							NeedHusnyckelText.SetActive(false);
							NeedpadlockCodeText.SetActive(false);
							NeedCrossbowText.SetActive(false);
							NeedweaponKeyText.SetActive(false);
							NeedscrewdriverText.SetActive(false);
							NeedbatteryText.SetActive(false);
							missinTavelbitarText.SetActive(false);
							cutThingsHereText.SetActive(false);
							SomethingMissingHereText.SetActive(false);
							NeedWinchhandleText.SetActive(false);
							NeedShotgunText.SetActive(false);
							ShotgunLoadedText.SetActive(false);
							NeedcarKeyText.SetActive(false);
							NeedCarBatteryText.SetActive(false);
							NeedSparkPlugText.SetActive(false);
							NeedEnginePartText.SetActive(false);
							NeedWrenchText.SetActive(false);
							NeedGasolineText.SetActive(false);
							emptyPlateText.SetActive(false);
							NeedSpecialKeyText.SetActive(false);
							NeedFindSwitchText.SetActive(false);
						}
					}
					audioPickUp();
				}
				else if (hitInfo.collider.gameObject.tag == "dpadlock")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (havepadlockCode)
						{
							if (!playSound)
							{
								playSound = true;
								((Rigidbody)hitInfo.collider.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
								DdoorLock.GetComponent<Animation>().Play("DlockAnim");
								((CheckExitDoor)gameController.GetComponent(typeof(CheckExitDoor))).DpadlockBort = true;
								GetComponent<AudioSource>().PlayOneShot(klippKabel);
								hitInfo.collider.gameObject.tag = "Untagged";
							}
						}
						else
						{
							textTimer = 0f;
							NeedpadlockCodeText.SetActive(true);
							textTimerOnOff = true;
							NeedhammerText.SetActive(false);
							NeedsafeKeyText.SetActive(false);
							NeedAvbitarTongText.SetActive(false);
							NeedHusnyckelText.SetActive(false);
							NeedhangLockKeyText.SetActive(false);
							NeedCrossbowText.SetActive(false);
							NeedweaponKeyText.SetActive(false);
							NeedscrewdriverText.SetActive(false);
							NeedbatteryText.SetActive(false);
							missinTavelbitarText.SetActive(false);
							NeedplayhouseKeyText.SetActive(false);
							cutThingsHereText.SetActive(false);
							SomethingMissingHereText.SetActive(false);
							NeedWinchhandleText.SetActive(false);
							NeedShotgunText.SetActive(false);
							ShotgunLoadedText.SetActive(false);
							NeedcarKeyText.SetActive(false);
							NeedCarBatteryText.SetActive(false);
							NeedSparkPlugText.SetActive(false);
							NeedEnginePartText.SetActive(false);
							NeedWrenchText.SetActive(false);
							NeedGasolineText.SetActive(false);
							emptyPlateText.SetActive(false);
							NeedSpecialKeyText.SetActive(false);
							NeedFindSwitchText.SetActive(false);
						}
					}
					audioPickUp();
				}
				else if (hitInfo.collider.gameObject.tag == "batteryholder")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (havebattery)
						{
							if (!playSound)
							{
								playSound = true;
								hitInfo.collider.GetComponent<Animation>().Play("BatteryLockOpen");
								((CheckExitDoor)gameController.GetComponent(typeof(CheckExitDoor))).batteryLockOk = true;
								batterySpak.GetComponent<Animation>().Play("BattSpakOK");
								battery.SetActive(false);
								havebattery = false;
								batteryOnPlace.SetActive(true);
								dropObjectButton.SetActive(false);
								GetComponent<AudioSource>().PlayOneShot(placeBattery);
								hitInfo.collider.gameObject.tag = "Untagged";
							}
						}
						else
						{
							textTimer = 0f;
							NeedpadlockCodeText.SetActive(false);
							textTimerOnOff = true;
							NeedhammerText.SetActive(false);
							NeedsafeKeyText.SetActive(false);
							NeedAvbitarTongText.SetActive(false);
							NeedHusnyckelText.SetActive(false);
							NeedhangLockKeyText.SetActive(false);
							NeedCrossbowText.SetActive(false);
							NeedweaponKeyText.SetActive(false);
							NeedscrewdriverText.SetActive(false);
							NeedbatteryText.SetActive(true);
							batterySpak.GetComponent<Animation>().Play("BattSpakNotOK");
							missinTavelbitarText.SetActive(false);
							NeedplayhouseKeyText.SetActive(false);
							cutThingsHereText.SetActive(false);
							SomethingMissingHereText.SetActive(false);
							NeedWinchhandleText.SetActive(false);
							NeedShotgunText.SetActive(false);
							ShotgunLoadedText.SetActive(false);
							NeedcarKeyText.SetActive(false);
							NeedCarBatteryText.SetActive(false);
							NeedSparkPlugText.SetActive(false);
							NeedEnginePartText.SetActive(false);
							NeedWrenchText.SetActive(false);
							NeedGasolineText.SetActive(false);
							emptyPlateText.SetActive(false);
							NeedSpecialKeyText.SetActive(false);
							NeedFindSwitchText.SetActive(false);
						}
					}
					audioPickUp();
				}
				else if (hitInfo.collider.gameObject.tag == "safedoor")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (havesafeKey)
						{
							if (!playSound)
							{
								playSound = true;
								hitInfo.collider.gameObject.GetComponent<Animation>().Play("safeDoorOpen");
								hitInfo.collider.gameObject.tag = "Untagged";
								GetComponent<AudioSource>().PlayOneShot(safeDoorOpen);
							}
						}
						else
						{
							textTimer = 0f;
							GetComponent<AudioSource>().PlayOneShot(safeDoordoorLocked);
							NeedsafeKeyText.SetActive(true);
							textTimerOnOff = true;
							NeedhangLockKeyText.SetActive(false);
							NeedhammerText.SetActive(false);
							NeedAvbitarTongText.SetActive(false);
							NeedHusnyckelText.SetActive(false);
							NeedpadlockCodeText.SetActive(false);
							NeedCrossbowText.SetActive(false);
							NeedweaponKeyText.SetActive(false);
							NeedscrewdriverText.SetActive(false);
							NeedbatteryText.SetActive(false);
							missinTavelbitarText.SetActive(false);
							NeedplayhouseKeyText.SetActive(false);
							cutThingsHereText.SetActive(false);
							SomethingMissingHereText.SetActive(false);
							NeedWinchhandleText.SetActive(false);
							NeedShotgunText.SetActive(false);
							ShotgunLoadedText.SetActive(false);
							NeedcarKeyText.SetActive(false);
							NeedCarBatteryText.SetActive(false);
							NeedSparkPlugText.SetActive(false);
							NeedEnginePartText.SetActive(false);
							NeedWrenchText.SetActive(false);
							NeedGasolineText.SetActive(false);
							emptyPlateText.SetActive(false);
							NeedSpecialKeyText.SetActive(false);
						}
					}
					audioPickUp();
				}
				else if (hitInfo.collider.gameObject.tag == "vapenskopdoor")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (haveweaponKey)
						{
							if (!playSound)
							{
								playSound = true;
								hitInfo.collider.gameObject.GetComponent<Animation>().Play("VapenDoorOpen");
								hitInfo.collider.gameObject.tag = "Untagged";
								GetComponent<AudioSource>().PlayOneShot(vapenDoorOpen);
							}
						}
						else
						{
							textTimer = 0f;
							GetComponent<AudioSource>().PlayOneShot(safeDoordoorLocked);
							NeedweaponKeyText.SetActive(true);
							textTimerOnOff = true;
							NeedhangLockKeyText.SetActive(false);
							NeedhammerText.SetActive(false);
							NeedAvbitarTongText.SetActive(false);
							NeedHusnyckelText.SetActive(false);
							NeedpadlockCodeText.SetActive(false);
							NeedCrossbowText.SetActive(false);
							NeedsafeKeyText.SetActive(false);
							NeedscrewdriverText.SetActive(false);
							NeedbatteryText.SetActive(false);
							missinTavelbitarText.SetActive(false);
							NeedplayhouseKeyText.SetActive(false);
							cutThingsHereText.SetActive(false);
							SomethingMissingHereText.SetActive(false);
							NeedWinchhandleText.SetActive(false);
							NeedShotgunText.SetActive(false);
							ShotgunLoadedText.SetActive(false);
							NeedcarKeyText.SetActive(false);
							NeedCarBatteryText.SetActive(false);
							NeedSparkPlugText.SetActive(false);
							NeedEnginePartText.SetActive(false);
							NeedWrenchText.SetActive(false);
							NeedGasolineText.SetActive(false);
							emptyPlateText.SetActive(false);
							NeedSpecialKeyText.SetActive(false);
						}
					}
					audioPickUp();
				}
				else if (hitInfo.collider.gameObject.tag == "tavelbitar")
				{
					if (!((startNewDay)gameController.GetComponent(typeof(startNewDay))).allaTavelbitarOnPlace)
					{
						readyPickUp = true;
						mittenRing.SetActive(true);
						if (pickUp)
						{
							pickUp = false;
							missinTavelbitarText.SetActive(true);
							textTimerOnOff = true;
						}
					}
					else
					{
						readyPickUp = false;
						mittenRing.SetActive(false);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "screw1")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (havescrewdriver)
						{
							if (!playSound)
							{
								playSound = true;
								hitInfo.collider.gameObject.GetComponent<Animation>().Play("Screw1Open");
								hitInfo.collider.gameObject.tag = "Untagged";
								((skruvplatta)skruvPlatta.GetComponent(typeof(skruvplatta))).skruv1 = true;
								StartCoroutine(((skruvplatta)skruvPlatta.GetComponent(typeof(skruvplatta))).Screw1Bort());
							}
						}
						else
						{
							textTimer = 0f;
							NeedscrewdriverText.SetActive(true);
							textTimerOnOff = true;
							NeedhangLockKeyText.SetActive(false);
							NeedhammerText.SetActive(false);
							NeedAvbitarTongText.SetActive(false);
							NeedHusnyckelText.SetActive(false);
							NeedpadlockCodeText.SetActive(false);
							NeedCrossbowText.SetActive(false);
							NeedsafeKeyText.SetActive(false);
							NeedweaponKeyText.SetActive(false);
							NeedbatteryText.SetActive(false);
							missinTavelbitarText.SetActive(false);
							NeedplayhouseKeyText.SetActive(false);
							cutThingsHereText.SetActive(false);
							SomethingMissingHereText.SetActive(false);
							NeedWinchhandleText.SetActive(false);
							NeedShotgunText.SetActive(false);
							ShotgunLoadedText.SetActive(false);
							NeedcarKeyText.SetActive(false);
							NeedCarBatteryText.SetActive(false);
							NeedSparkPlugText.SetActive(false);
							NeedEnginePartText.SetActive(false);
							NeedWrenchText.SetActive(false);
							NeedGasolineText.SetActive(false);
							emptyPlateText.SetActive(false);
							NeedSpecialKeyText.SetActive(false);
						}
					}
					audioPickUp();
				}
				else if (hitInfo.collider.gameObject.tag == "screw2")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (havescrewdriver)
						{
							if (!playSound)
							{
								playSound = true;
								hitInfo.collider.gameObject.GetComponent<Animation>().Play("Screw2Open");
								hitInfo.collider.gameObject.tag = "Untagged";
								((skruvplatta)skruvPlatta.GetComponent(typeof(skruvplatta))).skruv2 = true;
								StartCoroutine(((skruvplatta)skruvPlatta.GetComponent(typeof(skruvplatta))).Screw2Bort());
							}
						}
						else
						{
							textTimer = 0f;
							NeedscrewdriverText.SetActive(true);
							textTimerOnOff = true;
							NeedhangLockKeyText.SetActive(false);
							NeedhammerText.SetActive(false);
							NeedAvbitarTongText.SetActive(false);
							NeedHusnyckelText.SetActive(false);
							NeedpadlockCodeText.SetActive(false);
							NeedCrossbowText.SetActive(false);
							NeedsafeKeyText.SetActive(false);
							NeedweaponKeyText.SetActive(false);
							NeedbatteryText.SetActive(false);
							missinTavelbitarText.SetActive(false);
							NeedplayhouseKeyText.SetActive(false);
							cutThingsHereText.SetActive(false);
							SomethingMissingHereText.SetActive(false);
							NeedWinchhandleText.SetActive(false);
							NeedShotgunText.SetActive(false);
							ShotgunLoadedText.SetActive(false);
							NeedcarKeyText.SetActive(false);
							NeedCarBatteryText.SetActive(false);
							NeedSparkPlugText.SetActive(false);
							NeedEnginePartText.SetActive(false);
							NeedWrenchText.SetActive(false);
							NeedGasolineText.SetActive(false);
							emptyPlateText.SetActive(false);
							NeedSpecialKeyText.SetActive(false);
						}
					}
					audioPickUp();
				}
				else if (hitInfo.collider.gameObject.tag == "camera")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (haveHammare)
						{
							if (!playSound)
							{
								playSound = true;
								kamera.SetActive(false);
								kameraBroken.SetActive(true);
								if (!playerInPrison)
								{
									kameraSeeTrigger.SetActive(false);
									galler.GetComponent<Collider>().enabled = true;
									gallerColliders.SetActive(false);
								}
								hitInfo.collider.gameObject.tag = "Untagged";
								GetComponent<AudioSource>().PlayOneShot(hitCam);
							}
						}
						else
						{
							textTimer = 0f;
							NeedscrewdriverText.SetActive(false);
							textTimerOnOff = true;
							NeedhangLockKeyText.SetActive(false);
							NeedhammerText.SetActive(true);
							NeedAvbitarTongText.SetActive(false);
							NeedHusnyckelText.SetActive(false);
							NeedpadlockCodeText.SetActive(false);
							NeedCrossbowText.SetActive(false);
							NeedsafeKeyText.SetActive(false);
							NeedweaponKeyText.SetActive(false);
							NeedbatteryText.SetActive(false);
							missinTavelbitarText.SetActive(false);
							NeedplayhouseKeyText.SetActive(false);
							cutThingsHereText.SetActive(false);
							SomethingMissingHereText.SetActive(false);
							NeedWinchhandleText.SetActive(false);
							NeedShotgunText.SetActive(false);
							ShotgunLoadedText.SetActive(false);
							NeedcarKeyText.SetActive(false);
							NeedCarBatteryText.SetActive(false);
							NeedSparkPlugText.SetActive(false);
							NeedEnginePartText.SetActive(false);
							NeedWrenchText.SetActive(false);
							NeedGasolineText.SetActive(false);
							emptyPlateText.SetActive(false);
							NeedSpecialKeyText.SetActive(false);
						}
					}
					audioPickUp();
				}
				else if (hitInfo.collider.gameObject.tag == "giljocutarea")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (havemelon)
						{
							if (!playSound)
							{
								playSound = true;
								giljoCutArea.SetActive(false);
								melonInPlace.SetActive(true);
								((giljotinTrigger)giljotin.GetComponent(typeof(giljotinTrigger))).meloninPlace = true;
								GetComponent<AudioSource>().PlayOneShot(placeMelon);
								melon.SetActive(false);
								havemelon = false;
								pickUp = false;
								dropObject = false;
								dropObjectButton.SetActive(false);
								mittenRing.SetActive(false);
							}
						}
						else
						{
							textTimer = 0f;
							cutThingsHereText.SetActive(true);
							textTimerOnOff = true;
							NeedhangLockKeyText.SetActive(false);
							NeedhammerText.SetActive(false);
							NeedAvbitarTongText.SetActive(false);
							NeedHusnyckelText.SetActive(false);
							NeedpadlockCodeText.SetActive(false);
							NeedCrossbowText.SetActive(false);
							NeedsafeKeyText.SetActive(false);
							NeedweaponKeyText.SetActive(false);
							NeedbatteryText.SetActive(false);
							missinTavelbitarText.SetActive(false);
							NeedplayhouseKeyText.SetActive(false);
							NeedscrewdriverText.SetActive(false);
							SomethingMissingHereText.SetActive(false);
							NeedWinchhandleText.SetActive(false);
							NeedShotgunText.SetActive(false);
							ShotgunLoadedText.SetActive(false);
							NeedcarKeyText.SetActive(false);
							NeedCarBatteryText.SetActive(false);
							NeedSparkPlugText.SetActive(false);
							NeedEnginePartText.SetActive(false);
							NeedWrenchText.SetActive(false);
							NeedGasolineText.SetActive(false);
							emptyPlateText.SetActive(false);
							NeedSpecialKeyText.SetActive(false);
						}
					}
					audioPickUp();
				}
				else if (hitInfo.collider.gameObject.tag == "stortkugg")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (havekugg1)
						{
							if (!playSound)
							{
								playSound = true;
								kugg1inPlace.SetActive(true);
								kugg1OK = true;
								GetComponent<AudioSource>().PlayOneShot(placebrunnsvev);
								kugg1.SetActive(false);
								havekugg1 = false;
								pickUp = false;
								dropObject = false;
								dropObjectButton.SetActive(false);
								mittenRing.SetActive(false);
								if (kugg2OK)
								{
									playHouseLucka.gameObject.GetComponent<Animation>().Play("openToyLock");
									hitInfo.collider.gameObject.tag = "Untagged";
								}
							}
						}
						else if (havekugg2)
						{
							if (!playSound)
							{
								playSound = true;
								kugg2inPlace.SetActive(true);
								kugg2OK = true;
								GetComponent<AudioSource>().PlayOneShot(placebrunnsvev);
								kugg2.SetActive(false);
								havekugg2 = false;
								pickUp = false;
								dropObject = false;
								dropObjectButton.SetActive(false);
								mittenRing.SetActive(false);
								if (kugg1OK)
								{
									playHouseLucka.gameObject.GetComponent<Animation>().Play("openToyLock");
									hitInfo.collider.gameObject.tag = "Untagged";
								}
							}
						}
						else
						{
							textTimer = 0f;
							SomethingMissingHereText.SetActive(true);
							cutThingsHereText.SetActive(false);
							textTimerOnOff = true;
							NeedhangLockKeyText.SetActive(false);
							NeedhammerText.SetActive(false);
							NeedAvbitarTongText.SetActive(false);
							NeedHusnyckelText.SetActive(false);
							NeedpadlockCodeText.SetActive(false);
							NeedCrossbowText.SetActive(false);
							NeedsafeKeyText.SetActive(false);
							NeedweaponKeyText.SetActive(false);
							NeedbatteryText.SetActive(false);
							missinTavelbitarText.SetActive(false);
							NeedplayhouseKeyText.SetActive(false);
							NeedscrewdriverText.SetActive(false);
							NeedWinchhandleText.SetActive(false);
							NeedShotgunText.SetActive(false);
							ShotgunLoadedText.SetActive(false);
							NeedcarKeyText.SetActive(false);
							NeedCarBatteryText.SetActive(false);
							NeedSparkPlugText.SetActive(false);
							NeedEnginePartText.SetActive(false);
							NeedWrenchText.SetActive(false);
							NeedGasolineText.SetActive(false);
							emptyPlateText.SetActive(false);
							NeedSpecialKeyText.SetActive(false);
						}
					}
					audioPickUp();
				}
				else if (hitInfo.collider.gameObject.tag == "brunn")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (havebrunnsvev)
						{
							if (!playSound)
							{
								playSound = true;
								brunnsvevInPlace.SetActive(true);
								readyPickUp = false;
								((playerVevar)brunnsvevsHolder.GetComponent(typeof(playerVevar))).vevInPlace = true;
								hitInfo.collider.gameObject.GetComponent<Collider>().enabled = false;
								GetComponent<AudioSource>().PlayOneShot(placebrunnsvev);
								brunnsvev.SetActive(false);
								havebrunnsvev = false;
								pickUp = false;
								dropObject = false;
								dropObjectButton.SetActive(false);
								mittenRing.SetActive(false);
							}
						}
						else
						{
							textTimer = 0f;
							NeedWinchhandleText.SetActive(true);
							textTimerOnOff = true;
							NeedhangLockKeyText.SetActive(false);
							NeedhammerText.SetActive(false);
							NeedAvbitarTongText.SetActive(false);
							NeedHusnyckelText.SetActive(false);
							NeedpadlockCodeText.SetActive(false);
							NeedCrossbowText.SetActive(false);
							NeedsafeKeyText.SetActive(false);
							NeedweaponKeyText.SetActive(false);
							NeedbatteryText.SetActive(false);
							missinTavelbitarText.SetActive(false);
							NeedplayhouseKeyText.SetActive(false);
							NeedscrewdriverText.SetActive(false);
							SomethingMissingHereText.SetActive(false);
							cutThingsHereText.SetActive(false);
							NeedShotgunText.SetActive(false);
							ShotgunLoadedText.SetActive(false);
							NeedcarKeyText.SetActive(false);
							NeedCarBatteryText.SetActive(false);
							NeedSparkPlugText.SetActive(false);
							NeedEnginePartText.SetActive(false);
							NeedWrenchText.SetActive(false);
							NeedGasolineText.SetActive(false);
							emptyPlateText.SetActive(false);
							NeedSpecialKeyText.SetActive(false);
						}
					}
					audioPickUp();
				}
				else if (hitInfo.collider.gameObject.tag == "screwout1")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (havescrewdriver)
						{
							if (!playSound)
							{
								playSound = true;
								hitInfo.collider.gameObject.GetComponent<Animation>().Play("ELscrew");
								hitInfo.collider.gameObject.tag = "Untagged";
								((skruvplattaOutside)skruvPlattaOutside.GetComponent(typeof(skruvplattaOutside))).skruv1 = true;
								StartCoroutine(((skruvplattaOutside)skruvPlattaOutside.GetComponent(typeof(skruvplattaOutside))).Screw1Bort());
							}
						}
						else
						{
							textTimer = 0f;
							NeedscrewdriverText.SetActive(true);
							textTimerOnOff = true;
							NeedhangLockKeyText.SetActive(false);
							NeedhammerText.SetActive(false);
							NeedAvbitarTongText.SetActive(false);
							NeedHusnyckelText.SetActive(false);
							NeedpadlockCodeText.SetActive(false);
							NeedCrossbowText.SetActive(false);
							NeedsafeKeyText.SetActive(false);
							NeedweaponKeyText.SetActive(false);
							NeedbatteryText.SetActive(false);
							missinTavelbitarText.SetActive(false);
							NeedplayhouseKeyText.SetActive(false);
							cutThingsHereText.SetActive(false);
							SomethingMissingHereText.SetActive(false);
							NeedWinchhandleText.SetActive(false);
							NeedShotgunText.SetActive(false);
							ShotgunLoadedText.SetActive(false);
							NeedcarKeyText.SetActive(false);
							NeedCarBatteryText.SetActive(false);
							NeedSparkPlugText.SetActive(false);
							NeedEnginePartText.SetActive(false);
							NeedWrenchText.SetActive(false);
							NeedGasolineText.SetActive(false);
							emptyPlateText.SetActive(false);
							NeedSpecialKeyText.SetActive(false);
						}
					}
					audioPickUp();
				}
				else if (hitInfo.collider.gameObject.tag == "screwout2")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (havescrewdriver)
						{
							if (!playSound)
							{
								playSound = true;
								hitInfo.collider.gameObject.GetComponent<Animation>().Play("ELscrew");
								hitInfo.collider.gameObject.tag = "Untagged";
								((skruvplattaOutside)skruvPlattaOutside.GetComponent(typeof(skruvplattaOutside))).skruv2 = true;
								StartCoroutine(((skruvplattaOutside)skruvPlattaOutside.GetComponent(typeof(skruvplattaOutside))).Screw2Bort());
							}
						}
						else
						{
							textTimer = 0f;
							NeedscrewdriverText.SetActive(true);
							textTimerOnOff = true;
							NeedhangLockKeyText.SetActive(false);
							NeedhammerText.SetActive(false);
							NeedAvbitarTongText.SetActive(false);
							NeedHusnyckelText.SetActive(false);
							NeedpadlockCodeText.SetActive(false);
							NeedCrossbowText.SetActive(false);
							NeedsafeKeyText.SetActive(false);
							NeedweaponKeyText.SetActive(false);
							NeedbatteryText.SetActive(false);
							missinTavelbitarText.SetActive(false);
							NeedplayhouseKeyText.SetActive(false);
							cutThingsHereText.SetActive(false);
							SomethingMissingHereText.SetActive(false);
							NeedWinchhandleText.SetActive(false);
							NeedShotgunText.SetActive(false);
							ShotgunLoadedText.SetActive(false);
							NeedcarKeyText.SetActive(false);
							NeedCarBatteryText.SetActive(false);
							NeedSparkPlugText.SetActive(false);
							NeedEnginePartText.SetActive(false);
							NeedWrenchText.SetActive(false);
							NeedGasolineText.SetActive(false);
							emptyPlateText.SetActive(false);
							NeedSpecialKeyText.SetActive(false);
						}
					}
					audioPickUp();
				}
				else if (hitInfo.collider.gameObject.tag == "screwout3")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (havescrewdriver)
						{
							if (!playSound)
							{
								playSound = true;
								hitInfo.collider.gameObject.GetComponent<Animation>().Play("ELscrew");
								hitInfo.collider.gameObject.tag = "Untagged";
								((skruvplattaOutside)skruvPlattaOutside.GetComponent(typeof(skruvplattaOutside))).skruv3 = true;
								StartCoroutine(((skruvplattaOutside)skruvPlattaOutside.GetComponent(typeof(skruvplattaOutside))).Screw3Bort());
							}
						}
						else
						{
							textTimer = 0f;
							NeedscrewdriverText.SetActive(true);
							textTimerOnOff = true;
							NeedhangLockKeyText.SetActive(false);
							NeedhammerText.SetActive(false);
							NeedAvbitarTongText.SetActive(false);
							NeedHusnyckelText.SetActive(false);
							NeedpadlockCodeText.SetActive(false);
							NeedCrossbowText.SetActive(false);
							NeedsafeKeyText.SetActive(false);
							NeedweaponKeyText.SetActive(false);
							NeedbatteryText.SetActive(false);
							missinTavelbitarText.SetActive(false);
							NeedplayhouseKeyText.SetActive(false);
							cutThingsHereText.SetActive(false);
							SomethingMissingHereText.SetActive(false);
							NeedWinchhandleText.SetActive(false);
							NeedShotgunText.SetActive(false);
							ShotgunLoadedText.SetActive(false);
							NeedcarKeyText.SetActive(false);
							NeedCarBatteryText.SetActive(false);
							NeedSparkPlugText.SetActive(false);
							NeedEnginePartText.SetActive(false);
							NeedWrenchText.SetActive(false);
							NeedGasolineText.SetActive(false);
							emptyPlateText.SetActive(false);
							NeedSpecialKeyText.SetActive(false);
						}
					}
					audioPickUp();
				}
				else if (hitInfo.collider.gameObject.tag == "screwout4")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (havescrewdriver)
						{
							if (!playSound)
							{
								playSound = true;
								hitInfo.collider.gameObject.GetComponent<Animation>().Play("ELscrew");
								hitInfo.collider.gameObject.tag = "Untagged";
								((skruvplattaOutside)skruvPlattaOutside.GetComponent(typeof(skruvplattaOutside))).skruv4 = true;
								StartCoroutine(((skruvplattaOutside)skruvPlattaOutside.GetComponent(typeof(skruvplattaOutside))).Screw4Bort());
							}
						}
						else
						{
							textTimer = 0f;
							NeedscrewdriverText.SetActive(true);
							textTimerOnOff = true;
							NeedhangLockKeyText.SetActive(false);
							NeedhammerText.SetActive(false);
							NeedAvbitarTongText.SetActive(false);
							NeedHusnyckelText.SetActive(false);
							NeedpadlockCodeText.SetActive(false);
							NeedCrossbowText.SetActive(false);
							NeedsafeKeyText.SetActive(false);
							NeedweaponKeyText.SetActive(false);
							NeedbatteryText.SetActive(false);
							missinTavelbitarText.SetActive(false);
							NeedplayhouseKeyText.SetActive(false);
							cutThingsHereText.SetActive(false);
							SomethingMissingHereText.SetActive(false);
							NeedWinchhandleText.SetActive(false);
							NeedShotgunText.SetActive(false);
							ShotgunLoadedText.SetActive(false);
							NeedcarKeyText.SetActive(false);
							NeedCarBatteryText.SetActive(false);
							NeedSparkPlugText.SetActive(false);
							NeedEnginePartText.SetActive(false);
							NeedWrenchText.SetActive(false);
							NeedGasolineText.SetActive(false);
							emptyPlateText.SetActive(false);
							NeedSpecialKeyText.SetActive(false);
						}
					}
					audioPickUp();
				}
				else if (hitInfo.collider.gameObject.tag == "topplocksskruv")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (havewrench)
						{
							if (!playSound)
							{
								playSound = true;
								((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).topplocksskruvar = ((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).topplocksskruvar + 1f;
								UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
								GetComponent<AudioSource>().PlayOneShot(skruva);
							}
						}
						else
						{
							textTimer = 0f;
							NeedWrenchText.SetActive(true);
							textTimerOnOff = true;
							NeedhangLockKeyText.SetActive(false);
							NeedhammerText.SetActive(false);
							NeedAvbitarTongText.SetActive(false);
							NeedHusnyckelText.SetActive(false);
							NeedpadlockCodeText.SetActive(false);
							NeedCrossbowText.SetActive(false);
							NeedsafeKeyText.SetActive(false);
							NeedweaponKeyText.SetActive(false);
							NeedbatteryText.SetActive(false);
							missinTavelbitarText.SetActive(false);
							NeedplayhouseKeyText.SetActive(false);
							cutThingsHereText.SetActive(false);
							SomethingMissingHereText.SetActive(false);
							NeedWinchhandleText.SetActive(false);
							NeedShotgunText.SetActive(false);
							ShotgunLoadedText.SetActive(false);
							NeedcarKeyText.SetActive(false);
							NeedCarBatteryText.SetActive(false);
							NeedSparkPlugText.SetActive(false);
							NeedEnginePartText.SetActive(false);
							NeedGasolineText.SetActive(false);
							emptyPlateText.SetActive(false);
							NeedSpecialKeyText.SetActive(false);
						}
					}
					audioPickUp();
				}
				else if (hitInfo.collider.gameObject.tag == "topplockPlace")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (havetopplock)
						{
							if (!playSound)
							{
								playSound = true;
								((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).topplockOK = true;
								topplockInPlace.SetActive(true);
								topplock.SetActive(false);
								havetopplock = false;
								dropObjectButton.SetActive(false);
								UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
								GetComponent<AudioSource>().PlayOneShot(drarIspak);
							}
						}
						else
						{
							textTimer = 0f;
							NeedEnginePartText.SetActive(true);
							textTimerOnOff = true;
							NeedhangLockKeyText.SetActive(false);
							NeedhammerText.SetActive(false);
							NeedAvbitarTongText.SetActive(false);
							NeedHusnyckelText.SetActive(false);
							NeedpadlockCodeText.SetActive(false);
							NeedCrossbowText.SetActive(false);
							NeedsafeKeyText.SetActive(false);
							NeedweaponKeyText.SetActive(false);
							NeedbatteryText.SetActive(false);
							missinTavelbitarText.SetActive(false);
							NeedplayhouseKeyText.SetActive(false);
							cutThingsHereText.SetActive(false);
							SomethingMissingHereText.SetActive(false);
							NeedWinchhandleText.SetActive(false);
							NeedShotgunText.SetActive(false);
							ShotgunLoadedText.SetActive(false);
							NeedcarKeyText.SetActive(false);
							NeedCarBatteryText.SetActive(false);
							NeedSparkPlugText.SetActive(false);
							NeedWrenchText.SetActive(false);
							NeedGasolineText.SetActive(false);
							emptyPlateText.SetActive(false);
							NeedSpecialKeyText.SetActive(false);
						}
					}
					audioPickUp();
				}
				else if (hitInfo.collider.gameObject.tag == "carbatteryPlace")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (havecarbattery)
						{
							if (!playSound)
							{
								playSound = true;
								((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).batteryOK = true;
								carbatteryInPlace.SetActive(true);
								carbattery.SetActive(false);
								havecarbattery = false;
								dropObjectButton.SetActive(false);
								UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
								GetComponent<AudioSource>().PlayOneShot(drarIspak);
							}
						}
						else
						{
							textTimer = 0f;
							NeedCarBatteryText.SetActive(true);
							textTimerOnOff = true;
							NeedhangLockKeyText.SetActive(false);
							NeedhammerText.SetActive(false);
							NeedAvbitarTongText.SetActive(false);
							NeedHusnyckelText.SetActive(false);
							NeedpadlockCodeText.SetActive(false);
							NeedCrossbowText.SetActive(false);
							NeedsafeKeyText.SetActive(false);
							NeedweaponKeyText.SetActive(false);
							NeedbatteryText.SetActive(false);
							missinTavelbitarText.SetActive(false);
							NeedplayhouseKeyText.SetActive(false);
							cutThingsHereText.SetActive(false);
							SomethingMissingHereText.SetActive(false);
							NeedWinchhandleText.SetActive(false);
							NeedShotgunText.SetActive(false);
							ShotgunLoadedText.SetActive(false);
							NeedcarKeyText.SetActive(false);
							NeedSparkPlugText.SetActive(false);
							NeedEnginePartText.SetActive(false);
							NeedWrenchText.SetActive(false);
							NeedGasolineText.SetActive(false);
							emptyPlateText.SetActive(false);
							NeedSpecialKeyText.SetActive(false);
						}
					}
					audioPickUp();
				}
				else if (hitInfo.collider.gameObject.tag == "fueltankPlace")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (!havegascan && !playSound)
						{
							playSound = true;
							textTimer = 0f;
							NeedGasolineText.SetActive(true);
							textTimerOnOff = true;
							NeedhangLockKeyText.SetActive(false);
							NeedhammerText.SetActive(false);
							NeedAvbitarTongText.SetActive(false);
							NeedHusnyckelText.SetActive(false);
							NeedpadlockCodeText.SetActive(false);
							NeedCrossbowText.SetActive(false);
							NeedsafeKeyText.SetActive(false);
							NeedweaponKeyText.SetActive(false);
							NeedbatteryText.SetActive(false);
							missinTavelbitarText.SetActive(false);
							NeedplayhouseKeyText.SetActive(false);
							cutThingsHereText.SetActive(false);
							SomethingMissingHereText.SetActive(false);
							NeedWinchhandleText.SetActive(false);
							NeedShotgunText.SetActive(false);
							ShotgunLoadedText.SetActive(false);
							NeedcarKeyText.SetActive(false);
							NeedSparkPlugText.SetActive(false);
							NeedEnginePartText.SetActive(false);
							NeedWrenchText.SetActive(false);
							NeedSpecialKeyText.SetActive(false);
						}
					}
					audioPickUp();
				}
				else if (hitInfo.collider.gameObject.tag == "sparkplugPlace")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (havesparkplug)
						{
							if (!playSound)
							{
								playSound = true;
								((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).sparkplugOK = true;
								sparkPlugInPlace.SetActive(true);
								sparkPlugCable.SetActive(false);
								sparkplug.SetActive(false);
								havesparkplug = false;
								dropObjectButton.SetActive(false);
								GetComponent<AudioSource>().PlayOneShot(drarIspak);
							}
						}
						else
						{
							textTimer = 0f;
							NeedSparkPlugText.SetActive(true);
							textTimerOnOff = true;
							NeedhangLockKeyText.SetActive(false);
							NeedhammerText.SetActive(false);
							NeedAvbitarTongText.SetActive(false);
							NeedHusnyckelText.SetActive(false);
							NeedpadlockCodeText.SetActive(false);
							NeedCrossbowText.SetActive(false);
							NeedsafeKeyText.SetActive(false);
							NeedweaponKeyText.SetActive(false);
							NeedbatteryText.SetActive(false);
							missinTavelbitarText.SetActive(false);
							NeedplayhouseKeyText.SetActive(false);
							cutThingsHereText.SetActive(false);
							SomethingMissingHereText.SetActive(false);
							NeedWinchhandleText.SetActive(false);
							NeedShotgunText.SetActive(false);
							ShotgunLoadedText.SetActive(false);
							NeedcarKeyText.SetActive(false);
							NeedEnginePartText.SetActive(false);
							NeedWrenchText.SetActive(false);
							NeedGasolineText.SetActive(false);
							NeedCarBatteryText.SetActive(false);
							emptyPlateText.SetActive(false);
							NeedSpecialKeyText.SetActive(false);
						}
					}
					audioPickUp();
				}
				else if (hitInfo.collider.gameObject.tag == "platevind")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (havemeat)
						{
							if (!playSound)
							{
								playSound = true;
								if (spider.activeSelf)
								{
									((spiderControll)spider.GetComponent(typeof(spiderControll))).foodTime = true;
								}
								GetComponent<AudioSource>().PlayOneShot(meatPlate);
								meatOnPlate.SetActive(true);
								spiderTrigger.SetActive(false);
								meat.SetActive(false);
								havemeat = false;
								dropObjectButton.SetActive(false);
								UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
							}
						}
						else
						{
							textTimer = 0f;
							emptyPlateText.SetActive(true);
							textTimerOnOff = true;
							NeedhangLockKeyText.SetActive(false);
							NeedhammerText.SetActive(false);
							NeedAvbitarTongText.SetActive(false);
							NeedHusnyckelText.SetActive(false);
							NeedpadlockCodeText.SetActive(false);
							NeedCrossbowText.SetActive(false);
							NeedsafeKeyText.SetActive(false);
							NeedweaponKeyText.SetActive(false);
							NeedbatteryText.SetActive(false);
							missinTavelbitarText.SetActive(false);
							NeedplayhouseKeyText.SetActive(false);
							cutThingsHereText.SetActive(false);
							SomethingMissingHereText.SetActive(false);
							NeedWinchhandleText.SetActive(false);
							NeedShotgunText.SetActive(false);
							ShotgunLoadedText.SetActive(false);
							NeedcarKeyText.SetActive(false);
							NeedEnginePartText.SetActive(false);
							NeedWrenchText.SetActive(false);
							NeedGasolineText.SetActive(false);
							NeedCarBatteryText.SetActive(false);
							NeedSpecialKeyText.SetActive(false);
						}
					}
					audioPickUp();
				}
				else if (hitInfo.collider.gameObject.tag == "vind2lock")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (havespecialkey)
						{
							if (!playSound)
							{
								playSound = true;
								specialkeyLock.GetComponent<Animation>().Play("vind2LockOpen");
								specialkeyDoor.GetComponent<Animation>().Play("vind2DoorOpen");
								specialkeyLock.GetComponent<AudioSource>().PlayOneShot(vind2Lockopen);
								specialkeyDoor.GetComponent<AudioSource>().PlayOneShot(vind2Dooropen);
								specialkeyInPlace.SetActive(true);
								specialkey.SetActive(false);
								havespecialkey = false;
								dropObjectButton.SetActive(false);
								hitInfo.collider.gameObject.tag = "Untagged";
							}
						}
						else
						{
							textTimer = 0f;
							NeedSpecialKeyText.SetActive(true);
							textTimerOnOff = true;
							NeedhangLockKeyText.SetActive(false);
							NeedhammerText.SetActive(false);
							NeedAvbitarTongText.SetActive(false);
							NeedHusnyckelText.SetActive(false);
							NeedpadlockCodeText.SetActive(false);
							NeedCrossbowText.SetActive(false);
							NeedsafeKeyText.SetActive(false);
							NeedweaponKeyText.SetActive(false);
							NeedbatteryText.SetActive(false);
							missinTavelbitarText.SetActive(false);
							NeedplayhouseKeyText.SetActive(false);
							cutThingsHereText.SetActive(false);
							SomethingMissingHereText.SetActive(false);
							NeedWinchhandleText.SetActive(false);
							NeedShotgunText.SetActive(false);
							ShotgunLoadedText.SetActive(false);
							NeedcarKeyText.SetActive(false);
							NeedEnginePartText.SetActive(false);
							NeedWrenchText.SetActive(false);
							NeedGasolineText.SetActive(false);
							NeedCarBatteryText.SetActive(false);
						}
					}
					audioPickUp();
				}
				else if (hitInfo.collider.gameObject.tag == "bookplace")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (havebook)
						{
							if (!playSound)
							{
								playSound = true;
								secretWall.GetComponent<Animation>().Play("fakeWallMove");
								bookInPlace.SetActive(true);
								book.SetActive(false);
								havebook = false;
								dropObjectButton.SetActive(false);
								hitInfo.collider.gameObject.tag = "Untagged";
								Granny.SetActive(false);
								Granny.transform.position = GrannyStartPos.position;
								Granny.SetActive(true);
								((startNewDay)gameController.GetComponent(typeof(startNewDay))).slendrinaMomAppeard = true;
							}
						}
						else
						{
							textTimer = 0f;
							MaybePutSomethingHereText.SetActive(true);
							textTimerOnOff = true;
							NeedhangLockKeyText.SetActive(false);
							NeedhammerText.SetActive(false);
							NeedAvbitarTongText.SetActive(false);
							NeedHusnyckelText.SetActive(false);
							NeedpadlockCodeText.SetActive(false);
							NeedCrossbowText.SetActive(false);
							NeedsafeKeyText.SetActive(false);
							NeedweaponKeyText.SetActive(false);
							NeedbatteryText.SetActive(false);
							missinTavelbitarText.SetActive(false);
							NeedplayhouseKeyText.SetActive(false);
							cutThingsHereText.SetActive(false);
							SomethingMissingHereText.SetActive(false);
							NeedWinchhandleText.SetActive(false);
							NeedShotgunText.SetActive(false);
							ShotgunLoadedText.SetActive(false);
							NeedcarKeyText.SetActive(false);
							NeedEnginePartText.SetActive(false);
							NeedWrenchText.SetActive(false);
							NeedGasolineText.SetActive(false);
							NeedCarBatteryText.SetActive(false);
						}
					}
					audioPickUp();
				}
				else if (hitInfo.collider.gameObject.tag == "spak")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (!playSound)
						{
							playSound = true;
							hitInfo.collider.gameObject.GetComponent<Animation>().Play("Spak");
							hitInfo.collider.gameObject.tag = "Untagged";
							motorCollider.SetActive(false);
							((CheckExitDoor)gameController.GetComponent(typeof(CheckExitDoor))).extremeLockOk = true;
							extremeLockOn.SetActive(false);
							extremeLockOff.SetActive(true);
							GetComponent<AudioSource>().PlayOneShot(drarIspak);
						}
					}
					audioPickUp();
				}
				else if (hitInfo.collider.gameObject.tag == "lockmotor")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						textTimer = 0f;
						NeedFindSwitchText.SetActive(true);
						textTimerOnOff = true;
						NeedhangLockKeyText.SetActive(false);
						NeedhammerText.SetActive(false);
						NeedAvbitarTongText.SetActive(false);
						NeedHusnyckelText.SetActive(false);
						NeedpadlockCodeText.SetActive(false);
						NeedCrossbowText.SetActive(false);
						NeedsafeKeyText.SetActive(false);
						NeedweaponKeyText.SetActive(false);
						NeedbatteryText.SetActive(false);
						missinTavelbitarText.SetActive(false);
						NeedplayhouseKeyText.SetActive(false);
						cutThingsHereText.SetActive(false);
						SomethingMissingHereText.SetActive(false);
						NeedWinchhandleText.SetActive(false);
						NeedscrewdriverText.SetActive(false);
						NeedShotgunText.SetActive(false);
						ShotgunLoadedText.SetActive(false);
						NeedcarKeyText.SetActive(false);
						NeedCarBatteryText.SetActive(false);
						NeedEnginePartText.SetActive(false);
						NeedGasolineText.SetActive(false);
						emptyPlateText.SetActive(false);
						NeedSpecialKeyText.SetActive(false);
					}
					audioPickUp();
				}
				else if (hitInfo.collider.gameObject.tag == "sprint1")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (!playSound)
						{
							playSound = true;
							hitInfo.collider.gameObject.GetComponent<Animation>().Play("sprintAnim");
							hitInfo.collider.gameObject.tag = "Untagged";
							((prisonDoorOpenClose)prisonDoor.GetComponent(typeof(prisonDoorOpenClose))).sprint1Bort = true;
						}
					}
					audioPickUp();
				}
				else if (hitInfo.collider.gameObject.tag == "prisondoorlocked")
				{
					mittenRing.SetActive(false);
					pickUp = false;
				}
				else if (hitInfo.collider.gameObject.tag == "sprint2")
				{
					readyPickUp = true;
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (!playSound)
						{
							playSound = true;
							hitInfo.collider.gameObject.GetComponent<Animation>().Play("sprintAnim");
							hitInfo.collider.gameObject.tag = "Untagged";
							((prisonDoorOpenClose)prisonDoor.GetComponent(typeof(prisonDoorOpenClose))).sprint2Bort = true;
						}
					}
					audioPickUp();
				}
				else if (hitInfo.collider.gameObject.tag == "Untagged")
				{
					readyPickUp = false;
					mittenRing.SetActive(false);
					hangLockKeyText.SetActive(false);
					hammerText.SetActive(false);
					safeKeyText.SetActive(false);
					AvbitarTongText.SetActive(false);
					HusnyckelText.SetActive(false);
					padlockCodeText.SetActive(false);
					CrossbowText.SetActive(false);
					TranquilizerDartText.SetActive(false);
					weaponKeyText.SetActive(false);
					screwdriverText.SetActive(false);
					plankText.SetActive(false);
					batteryText.SetActive(false);
					tavelbitText.SetActive(false);
					playhouseKeyText.SetActive(false);
					melonText.SetActive(false);
					teddyText.SetActive(false);
					cogwheelText.SetActive(false);
					winchhandleText.SetActive(false);
					PartOfShotgunText.SetActive(false);
					ShotgunText.SetActive(false);
					AmmoText.SetActive(false);
					carKeyText.SetActive(false);
					EnginePartText.SetActive(false);
					SparkPlugText.SetActive(false);
					GasolineCanText.SetActive(false);
					CarBatteryText.SetActive(false);
					WrenchText.SetActive(false);
					MeatText.SetActive(false);
					specialKeyText.SetActive(false);
					bookText.SetActive(false);
				}
				else if (hitInfo.collider.gameObject.tag == "golv")
				{
					readyPickUp = false;
					mittenRing.SetActive(false);
					hangLockKeyText.SetActive(false);
					hammerText.SetActive(false);
					safeKeyText.SetActive(false);
					AvbitarTongText.SetActive(false);
					HusnyckelText.SetActive(false);
					padlockCodeText.SetActive(false);
					CrossbowText.SetActive(false);
					TranquilizerDartText.SetActive(false);
					weaponKeyText.SetActive(false);
					screwdriverText.SetActive(false);
					plankText.SetActive(false);
					batteryText.SetActive(false);
					tavelbitText.SetActive(false);
					playhouseKeyText.SetActive(false);
					melonText.SetActive(false);
					teddyText.SetActive(false);
					cogwheelText.SetActive(false);
					winchhandleText.SetActive(false);
					PartOfShotgunText.SetActive(false);
					ShotgunText.SetActive(false);
					AmmoText.SetActive(false);
					carKeyText.SetActive(false);
					EnginePartText.SetActive(false);
					SparkPlugText.SetActive(false);
					GasolineCanText.SetActive(false);
					CarBatteryText.SetActive(false);
					WrenchText.SetActive(false);
					MeatText.SetActive(false);
					specialKeyText.SetActive(false);
					bookText.SetActive(false);
				}
				else if (hitInfo.collider.gameObject.tag == "grus")
				{
					readyPickUp = false;
					mittenRing.SetActive(false);
					hangLockKeyText.SetActive(false);
					hammerText.SetActive(false);
					safeKeyText.SetActive(false);
					AvbitarTongText.SetActive(false);
					HusnyckelText.SetActive(false);
					padlockCodeText.SetActive(false);
					CrossbowText.SetActive(false);
					TranquilizerDartText.SetActive(false);
					weaponKeyText.SetActive(false);
					screwdriverText.SetActive(false);
					plankText.SetActive(false);
					batteryText.SetActive(false);
					tavelbitText.SetActive(false);
					playhouseKeyText.SetActive(false);
					melonText.SetActive(false);
					teddyText.SetActive(false);
					cogwheelText.SetActive(false);
					winchhandleText.SetActive(false);
					PartOfShotgunText.SetActive(false);
					ShotgunText.SetActive(false);
					AmmoText.SetActive(false);
					carKeyText.SetActive(false);
					EnginePartText.SetActive(false);
					SparkPlugText.SetActive(false);
					GasolineCanText.SetActive(false);
					CarBatteryText.SetActive(false);
					WrenchText.SetActive(false);
					MeatText.SetActive(false);
					specialKeyText.SetActive(false);
					bookText.SetActive(false);
				}
				else if (hitInfo.collider.gameObject.tag == "car")
				{
					readyPickUp = false;
					mittenRing.SetActive(false);
					hangLockKeyText.SetActive(false);
					hammerText.SetActive(false);
					safeKeyText.SetActive(false);
					AvbitarTongText.SetActive(false);
					HusnyckelText.SetActive(false);
					padlockCodeText.SetActive(false);
					CrossbowText.SetActive(false);
					TranquilizerDartText.SetActive(false);
					weaponKeyText.SetActive(false);
					screwdriverText.SetActive(false);
					plankText.SetActive(false);
					batteryText.SetActive(false);
					tavelbitText.SetActive(false);
					playhouseKeyText.SetActive(false);
					melonText.SetActive(false);
					teddyText.SetActive(false);
					cogwheelText.SetActive(false);
					winchhandleText.SetActive(false);
					PartOfShotgunText.SetActive(false);
					ShotgunText.SetActive(false);
					AmmoText.SetActive(false);
					carKeyText.SetActive(false);
					EnginePartText.SetActive(false);
					SparkPlugText.SetActive(false);
					GasolineCanText.SetActive(false);
					CarBatteryText.SetActive(false);
					WrenchText.SetActive(false);
					MeatText.SetActive(false);
					specialKeyText.SetActive(false);
					bookText.SetActive(false);
				}
				else
				{
					readyPickUp = false;
					mittenRing.SetActive(false);
					hangLockKeyText.SetActive(false);
					hammerText.SetActive(false);
					safeKeyText.SetActive(false);
					AvbitarTongText.SetActive(false);
					HusnyckelText.SetActive(false);
					padlockCodeText.SetActive(false);
					CrossbowText.SetActive(false);
					TranquilizerDartText.SetActive(false);
					weaponKeyText.SetActive(false);
					screwdriverText.SetActive(false);
					plankText.SetActive(false);
					batteryText.SetActive(false);
					tavelbitText.SetActive(false);
					playhouseKeyText.SetActive(false);
					melonText.SetActive(false);
					teddyText.SetActive(false);
					cogwheelText.SetActive(false);
					winchhandleText.SetActive(false);
					PartOfShotgunText.SetActive(false);
					ShotgunText.SetActive(false);
					AmmoText.SetActive(false);
					carKeyText.SetActive(false);
					EnginePartText.SetActive(false);
					SparkPlugText.SetActive(false);
					GasolineCanText.SetActive(false);
					CarBatteryText.SetActive(false);
					WrenchText.SetActive(false);
					MeatText.SetActive(false);
					specialKeyText.SetActive(false);
					bookText.SetActive(false);
				}
			}
			else
			{
				readyPickUp = false;
				mittenRing.SetActive(false);
				hangLockKeyText.SetActive(false);
				hammerText.SetActive(false);
				safeKeyText.SetActive(false);
				AvbitarTongText.SetActive(false);
				HusnyckelText.SetActive(false);
				padlockCodeText.SetActive(false);
				CrossbowText.SetActive(false);
				TranquilizerDartText.SetActive(false);
				weaponKeyText.SetActive(false);
				screwdriverText.SetActive(false);
				plankText.SetActive(false);
				batteryText.SetActive(false);
				tavelbitText.SetActive(false);
				playhouseKeyText.SetActive(false);
				melonText.SetActive(false);
				teddyText.SetActive(false);
				cogwheelText.SetActive(false);
				winchhandleText.SetActive(false);
				PartOfShotgunText.SetActive(false);
				ShotgunText.SetActive(false);
				AmmoText.SetActive(false);
				carKeyText.SetActive(false);
				EnginePartText.SetActive(false);
				SparkPlugText.SetActive(false);
				GasolineCanText.SetActive(false);
				CarBatteryText.SetActive(false);
				WrenchText.SetActive(false);
				MeatText.SetActive(false);
				specialKeyText.SetActive(false);
				bookText.SetActive(false);
				pickUp = false;
			}
		}
		else
		{
			readyPickUp = false;
			mittenRing.SetActive(false);
			hangLockKeyText.SetActive(false);
			hammerText.SetActive(false);
			safeKeyText.SetActive(false);
			AvbitarTongText.SetActive(false);
			HusnyckelText.SetActive(false);
			padlockCodeText.SetActive(false);
			CrossbowText.SetActive(false);
			TranquilizerDartText.SetActive(false);
			weaponKeyText.SetActive(false);
			screwdriverText.SetActive(false);
			plankText.SetActive(false);
			batteryText.SetActive(false);
			tavelbitText.SetActive(false);
			playhouseKeyText.SetActive(false);
			melonText.SetActive(false);
			teddyText.SetActive(false);
			cogwheelText.SetActive(false);
			winchhandleText.SetActive(false);
			PartOfShotgunText.SetActive(false);
			ShotgunText.SetActive(false);
			AmmoText.SetActive(false);
			carKeyText.SetActive(false);
			EnginePartText.SetActive(false);
			SparkPlugText.SetActive(false);
			GasolineCanText.SetActive(false);
			CarBatteryText.SetActive(false);
			WrenchText.SetActive(false);
			MeatText.SetActive(false);
			specialKeyText.SetActive(false);
			bookText.SetActive(false);
			pickUp = false;
		}
		if (dropObject)
		{
			if (haveAvbitare)
			{
				avbitare.SetActive(false);
				haveAvbitare = false;
				hammare.SetActive(false);
				haveHammare = false;
				pickUp = false;
				dropObject = false;
				UnityEngine.Object.Instantiate(newAvbitare, dropPoint.transform.position, dropPoint.transform.rotation);
				dropObjectButton.SetActive(false);
				mittenRing.SetActive(false);
			}
			if (haveHammare)
			{
				hammare.SetActive(false);
				haveHammare = false;
				pickUp = false;
				dropObject = false;
				UnityEngine.Object.Instantiate(newHammare, dropPoint.transform.position, dropPoint.transform.rotation);
				dropObjectButton.SetActive(false);
				mittenRing.SetActive(false);
			}
			if (havevas)
			{
				vas.SetActive(false);
				havevas = false;
				pickUp = false;
				dropObject = false;
				UnityEngine.Object.Instantiate(newvas, dropPoint.transform.position, dropPoint.transform.rotation);
				dropObjectButton.SetActive(false);
				mittenRing.SetActive(false);
			}
			if (havevas2)
			{
				vas2.SetActive(false);
				havevas2 = false;
				pickUp = false;
				dropObject = false;
				UnityEngine.Object.Instantiate(newvas2, dropPoint.transform.position, dropPoint.transform.rotation);
				dropObjectButton.SetActive(false);
				mittenRing.SetActive(false);
			}
			if (havesafeKey)
			{
				safeKey.SetActive(false);
				havesafeKey = false;
				pickUp = false;
				dropObject = false;
				UnityEngine.Object.Instantiate(newsafeKey, dropPoint.transform.position, dropPoint.transform.rotation);
				dropObjectButton.SetActive(false);
				mittenRing.SetActive(false);
			}
			if (haveexitKey)
			{
				exitKey.SetActive(false);
				haveexitKey = false;
				pickUp = false;
				dropObject = false;
				UnityEngine.Object.Instantiate(newexitKey, dropPoint.transform.position, dropPoint.transform.rotation);
				dropObjectButton.SetActive(false);
				mittenRing.SetActive(false);
			}
			if (havehanglockKey)
			{
				hanglockKey.SetActive(false);
				havehanglockKey = false;
				pickUp = false;
				dropObject = false;
				UnityEngine.Object.Instantiate(newhanglockKey, dropPoint.transform.position, dropPoint.transform.rotation);
				dropObjectButton.SetActive(false);
				mittenRing.SetActive(false);
			}
			if (havepadlockCode)
			{
				padlockCode.SetActive(false);
				havepadlockCode = false;
				pickUp = false;
				dropObject = false;
				UnityEngine.Object.Instantiate(newpadlockCode, dropPoint.transform.position, dropPoint.transform.rotation);
				dropObjectButton.SetActive(false);
				mittenRing.SetActive(false);
			}
			if (havearmborst)
			{
				armborst.SetActive(false);
				havearmborst = false;
				arrowButton.SetActive(false);
				shootArrowRay.SetActive(false);
				pickUp = false;
				dropObject = false;
				UnityEngine.Object.Instantiate(newarmborst, dropPoint.transform.position, dropPoint.transform.rotation);
				if (armborstArrowOK)
				{
					UnityEngine.Object.Instantiate(newArrow, dropPoint.transform.position, dropPoint.transform.rotation);
					haveArrow = false;
					armborstArrowOK = false;
				}
				dropObjectButton.SetActive(false);
				mittenRing.SetActive(false);
			}
			if (haveweaponKey)
			{
				weaponKey.SetActive(false);
				haveweaponKey = false;
				pickUp = false;
				dropObject = false;
				UnityEngine.Object.Instantiate(newweaponKey, dropPoint.transform.position, dropPoint.transform.rotation);
				dropObjectButton.SetActive(false);
				mittenRing.SetActive(false);
			}
			if (havescrewdriver)
			{
				screwdriver.SetActive(false);
				havescrewdriver = false;
				pickUp = false;
				dropObject = false;
				UnityEngine.Object.Instantiate(newscrewdriver, dropPoint.transform.position, dropPoint.transform.rotation);
				dropObjectButton.SetActive(false);
				mittenRing.SetActive(false);
			}
			if (haveplanka)
			{
				planka.SetActive(false);
				haveplanka = false;
				pickUp = false;
				dropObject = false;
				placeObject = false;
				placeObjectButton.SetActive(false);
				UnityEngine.Object.Instantiate(newplanka, dropPointPlanka.transform.position, dropPointPlanka.transform.rotation);
				dropObjectButton.SetActive(false);
				mittenRing.SetActive(false);
			}
			if (havebattery)
			{
				battery.SetActive(false);
				havebattery = false;
				pickUp = false;
				dropObject = false;
				UnityEngine.Object.Instantiate(newbattery, dropPoint.transform.position, dropPoint.transform.rotation);
				dropObjectButton.SetActive(false);
				mittenRing.SetActive(false);
			}
			if (havetb1)
			{
				tb1.SetActive(false);
				havetb1 = false;
				pickUp = false;
				dropObject = false;
				UnityEngine.Object.Instantiate(newtb1, dropPoint.transform.position, dropPoint.transform.rotation);
				dropObjectButton.SetActive(false);
				mittenRing.SetActive(false);
			}
			if (havetb2)
			{
				tb2.SetActive(false);
				havetb2 = false;
				pickUp = false;
				dropObject = false;
				UnityEngine.Object.Instantiate(newtb2, dropPoint.transform.position, dropPoint.transform.rotation);
				dropObjectButton.SetActive(false);
				mittenRing.SetActive(false);
			}
			if (havetb3)
			{
				tb3.SetActive(false);
				havetb3 = false;
				pickUp = false;
				dropObject = false;
				UnityEngine.Object.Instantiate(newtb3, dropPoint.transform.position, dropPoint.transform.rotation);
				dropObjectButton.SetActive(false);
				mittenRing.SetActive(false);
			}
			if (havetb4)
			{
				tb4.SetActive(false);
				havetb4 = false;
				pickUp = false;
				dropObject = false;
				UnityEngine.Object.Instantiate(newtb4, dropPoint.transform.position, dropPoint.transform.rotation);
				dropObjectButton.SetActive(false);
				mittenRing.SetActive(false);
			}
			if (haveplayhouseKey)
			{
				playhouseKey.SetActive(false);
				haveplayhouseKey = false;
				pickUp = false;
				dropObject = false;
				UnityEngine.Object.Instantiate(newplayhouseKey, dropPoint.transform.position, dropPoint.transform.rotation);
				dropObjectButton.SetActive(false);
				mittenRing.SetActive(false);
			}
			if (havemelon)
			{
				melon.SetActive(false);
				havemelon = false;
				pickUp = false;
				dropObject = false;
				UnityEngine.Object.Instantiate(newmelon, dropPoint.transform.position, dropPoint.transform.rotation);
				dropObjectButton.SetActive(false);
				mittenRing.SetActive(false);
			}
			if (haveteddy)
			{
				teddy.SetActive(false);
				haveteddy = false;
				((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
				pickUp = false;
				dropObject = false;
				UnityEngine.Object.Instantiate(newteddy, dropPoint.transform.position, dropPoint.transform.rotation);
				dropObjectButton.SetActive(false);
				mittenRing.SetActive(false);
			}
			if (havekugg1)
			{
				kugg1.SetActive(false);
				havekugg1 = false;
				pickUp = false;
				dropObject = false;
				UnityEngine.Object.Instantiate(newkugg1, dropPoint.transform.position, dropPoint.transform.rotation);
				dropObjectButton.SetActive(false);
				mittenRing.SetActive(false);
			}
			if (havekugg2)
			{
				kugg2.SetActive(false);
				havekugg2 = false;
				pickUp = false;
				dropObject = false;
				UnityEngine.Object.Instantiate(newkugg2, dropPoint.transform.position, dropPoint.transform.rotation);
				dropObjectButton.SetActive(false);
				mittenRing.SetActive(false);
			}
			if (havemessage)
			{
				message.SetActive(false);
				havemessage = false;
				pickUp = false;
				dropObject = false;
				UnityEngine.Object.Instantiate(newmessage, dropPoint.transform.position, dropPoint.transform.rotation);
				dropObjectButton.SetActive(false);
				mittenRing.SetActive(false);
			}
			if (havebrunnsvev)
			{
				brunnsvev.SetActive(false);
				havebrunnsvev = false;
				pickUp = false;
				dropObject = false;
				UnityEngine.Object.Instantiate(newbrunnsvev, dropPoint.transform.position, dropPoint.transform.rotation);
				dropObjectButton.SetActive(false);
				mittenRing.SetActive(false);
			}
			if (haveoldShotgun)
			{
				oldShotgun.SetActive(false);
				haveoldShotgun = false;
				pickUp = false;
				dropObject = false;
				shootButton.SetActive(false);
				shootRay.SetActive(false);
				UnityEngine.Object.Instantiate(newoldShotgun, dropPoint.transform.position, dropPoint.transform.rotation);
				dropObjectButton.SetActive(false);
				mittenRing.SetActive(false);
			}
			if (havegunDel1)
			{
				gunDel1.SetActive(false);
				havegunDel1 = false;
				pickUp = false;
				dropObject = false;
				UnityEngine.Object.Instantiate(newgunDel1, dropPoint.transform.position, dropPoint.transform.rotation);
				dropObjectButton.SetActive(false);
				mittenRing.SetActive(false);
			}
			if (havegunDel2)
			{
				gunDel2.SetActive(false);
				havegunDel2 = false;
				pickUp = false;
				dropObject = false;
				UnityEngine.Object.Instantiate(newgunDel2, dropPoint.transform.position, dropPoint.transform.rotation);
				dropObjectButton.SetActive(false);
				mittenRing.SetActive(false);
			}
			if (havegunDel3)
			{
				gunDel3.SetActive(false);
				havegunDel3 = false;
				pickUp = false;
				dropObject = false;
				UnityEngine.Object.Instantiate(newgunDel3, dropPoint.transform.position, dropPoint.transform.rotation);
				dropObjectButton.SetActive(false);
				mittenRing.SetActive(false);
			}
			if (havecarKey)
			{
				carKey.SetActive(false);
				havecarKey = false;
				((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).playerHaveCarKey = false;
				pickUp = false;
				dropObject = false;
				UnityEngine.Object.Instantiate(newcarKey, dropPoint.transform.position, dropPoint.transform.rotation);
				dropObjectButton.SetActive(false);
				mittenRing.SetActive(false);
			}
			if (havetopplock)
			{
				topplock.SetActive(false);
				havetopplock = false;
				pickUp = false;
				dropObject = false;
				UnityEngine.Object.Instantiate(newtopplock, dropPoint.transform.position, dropPoint.transform.rotation);
				dropObjectButton.SetActive(false);
				mittenRing.SetActive(false);
			}
			if (havecarbattery)
			{
				carbattery.SetActive(false);
				havecarbattery = false;
				pickUp = false;
				dropObject = false;
				UnityEngine.Object.Instantiate(newcarbattery, dropPoint.transform.position, dropPoint.transform.rotation);
				dropObjectButton.SetActive(false);
				mittenRing.SetActive(false);
			}
			if (havegascan)
			{
				gascan.SetActive(false);
				havegascan = false;
				pickUp = false;
				dropObject = false;
				UnityEngine.Object.Instantiate(newgascan, dropPoint.transform.position, dropPoint.transform.rotation);
				dropObjectButton.SetActive(false);
				mittenRing.SetActive(false);
			}
			if (havewrench)
			{
				wrench.SetActive(false);
				havewrench = false;
				pickUp = false;
				dropObject = false;
				UnityEngine.Object.Instantiate(newwrench, dropPoint.transform.position, dropPoint.transform.rotation);
				dropObjectButton.SetActive(false);
				mittenRing.SetActive(false);
			}
			if (havesparkplug)
			{
				sparkplug.SetActive(false);
				havesparkplug = false;
				pickUp = false;
				dropObject = false;
				UnityEngine.Object.Instantiate(newsparkplug, dropPoint.transform.position, dropPoint.transform.rotation);
				dropObjectButton.SetActive(false);
				mittenRing.SetActive(false);
			}
			if (havemeat)
			{
				meat.SetActive(false);
				havemeat = false;
				pickUp = false;
				dropObject = false;
				UnityEngine.Object.Instantiate(newmeat, dropPoint.transform.position, dropPoint.transform.rotation);
				dropObjectButton.SetActive(false);
				mittenRing.SetActive(false);
			}
			if (havespecialkey)
			{
				specialkey.SetActive(false);
				havespecialkey = false;
				pickUp = false;
				dropObject = false;
				UnityEngine.Object.Instantiate(newspecialkey, dropPoint.transform.position, dropPoint.transform.rotation);
				dropObjectButton.SetActive(false);
				mittenRing.SetActive(false);
			}
			if (havebook)
			{
				book.SetActive(false);
				havebook = false;
				pickUp = false;
				dropObject = false;
				UnityEngine.Object.Instantiate(newbook, dropPoint.transform.position, dropPoint.transform.rotation);
				dropObjectButton.SetActive(false);
				mittenRing.SetActive(false);
			}
		}
		else if (placeObject && plankaHighlighted)
		{
			plankaHighlighted = false;
			highlightedPlanka.SetActive(false);
			highlightedPlankaTrigger.SetActive(false);
			plankaHole.SetActive(true);
			planka.SetActive(false);
			haveplanka = false;
			pickUp = false;
			dropObject = false;
			placeObject = false;
			placeObjectButton.SetActive(false);
			dropObjectButton.SetActive(false);
			mittenRing.SetActive(false);
		}
		if (textTimerOnOff)
		{
			textTimer += Time.deltaTime;
			if (textTimer > 3f)
			{
				textTimerOnOff = false;
				textTimer = 0f;
				NeedhangLockKeyText.SetActive(false);
				NeedhammerText.SetActive(false);
				NeedsafeKeyText.SetActive(false);
				NeedAvbitarTongText.SetActive(false);
				NeedHusnyckelText.SetActive(false);
				NeedpadlockCodeText.SetActive(false);
				NeedCrossbowText.SetActive(false);
				CantopenDoorYetText.SetActive(false);
				NeedweaponKeyText.SetActive(false);
				NeedscrewdriverText.SetActive(false);
				NeedbatteryText.SetActive(false);
				missinTavelbitarText.SetActive(false);
				NeedplayhouseKeyText.SetActive(false);
				cutThingsHereText.SetActive(false);
				SomethingMissingHereText.SetActive(false);
				somethingInsideMelonText.SetActive(false);
				NeedWinchhandleText.SetActive(false);
				NeedFindSwitchText.SetActive(false);
				NeedShotgunText.SetActive(false);
				ShotgunLoadedText.SetActive(false);
				NeedcarKeyText.SetActive(false);
				NeedCarBatteryText.SetActive(false);
				NeedGasolineText.SetActive(false);
				NeedEnginePartText.SetActive(false);
				NeedWrenchText.SetActive(false);
				NeedSparkPlugText.SetActive(false);
				emptyPlateText.SetActive(false);
				NeedSpecialKeyText.SetActive(false);
				MaybePutSomethingHereText.SetActive(false);
			}
		}
	}

	public virtual void audioPickUp()
	{
		playSound = false;
	}
}

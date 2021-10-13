using System;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

[Serializable]
public class BearTrap : MonoBehaviour
{
	public bool beartrapOn;

	public bool beartrapShot;

	public GameObject Granny;

	public Transform spawnObject;

	public AudioClip ObjectLjud;

	public AudioClip BeartrapOnFloor;

	public GameObject player;

	public GameObject playerHead;

	public GameObject GrannyEye;

	public GameObject crawlButtonParent;

	public GameObject crawlButton;

	public GameObject allBedButtons;

	public float timer;

	public bool timerStart;

	public bool playerStuck;

	public GameObject gameController;

	public BearTrap()
	{
		timer = 120f;
	}

	public virtual void Start()
	{
		Granny = GameObject.Find("GrannyParent");
		gameController = GameObject.Find("GameController");
		timerStart = true;
	}

	public virtual void Update()
	{
		player = GameObject.Find("Player");
		playerHead = GameObject.Find("CameraShakeAnim");
		GrannyEye = GameObject.Find("GrannyEyes");
		crawlButtonParent = GameObject.Find("CrouchButtonParent");
		crawlButton = GameObject.Find("PlayerHukarSigButton");
		allBedButtons = GameObject.Find("AllhidePictures");
		if (timerStart && !playerStuck)
		{
			timer -= Time.deltaTime;
			if (timer < 0f)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		if (beartrapShot)
		{
			beartrapShot = false;
			beartrapDestroyed();
		}
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			if (!((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerInHole)
			{
				if (timerStart && !beartrapOn)
				{
					beartrapOn = true;
					playerStuck = true;
					((Rigidbody)base.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = true;
					base.gameObject.GetComponent<Animation>().Play("Beartrap");
					GetComponent<AudioSource>().PlayOneShot(ObjectLjud);
					((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).timerSearch = 0f;
					GameObject.Find("CameraPivot").GetComponent<Footsteps>().stopwalk();
					player.GetComponent<CharacterController>().height = 2.76f;
					player.GetComponent<CharacterController>().center = new Vector3(0f, 1.18f, 0.12f);
					playerHead.transform.transform.localPosition = new Vector3(0f, 1.007f, 0f);
					if (!((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).hitByArrow && !((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).hitByGun)
					{
						GameObject.Find("GrannyEyes").GetComponent<EnemyEye>().seeRange = 200f;
					}
					((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).playerInhole = true;
					((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).m_WalkSpeed = 0f;
					((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
					((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
					((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
					crawlButtonParent.SetActive(false);
					allBedButtons.SetActive(false);
					if ((bool)GameObject.Find("TempNavObjects(Clone)"))
					{
						GameObject.Find("TempNavObjects(Clone)").transform.name = "TempNavObjects(Clone)Old";
						UnityEngine.Object.Instantiate(spawnObject, base.transform.position, base.transform.rotation);
					}
					else if ((bool)GameObject.Find("TempNavObjects(Clone)Old"))
					{
						UnityEngine.Object.Destroy(GameObject.Find("TempNavObjects(Clone)Old"));
					}
					else
					{
						UnityEngine.Object.Instantiate(spawnObject, base.transform.position, base.transform.rotation);
					}
					((playerInBeartrap)gameController.GetComponent(typeof(playerInBeartrap))).playerStuck();
					base.gameObject.transform.tag = "BearTrapActivated";
				}
			}
			else if (!beartrapOn)
			{
				((Rigidbody)base.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = true;
				base.gameObject.GetComponent<Animation>().Play("Beartrap");
				GetComponent<AudioSource>().PlayOneShot(ObjectLjud);
				beartrapShot = true;
			}
		}
		else if ((other.gameObject.tag == "vas" || other.gameObject.tag == "vas2" || other.gameObject.tag == "hammer" || other.gameObject.tag == "hanglockkey" || other.gameObject.tag == "exitkey" || other.gameObject.tag == "avbitare" || other.gameObject.tag == "safekey" || other.gameObject.tag == "weaponkey" || other.gameObject.tag == "armborst" || other.gameObject.tag == "arrow" || other.gameObject.tag == "screwdriver" || other.gameObject.tag == "plankawalk" || other.gameObject.tag == "battery" || other.gameObject.tag == "kugg1" || other.gameObject.tag == "kugg2" || other.gameObject.tag == "melon" || other.gameObject.tag == "playhousekey" || other.gameObject.tag == "shotgun" || other.gameObject.tag == "book" || other.gameObject.tag == "specialkey" || other.gameObject.tag == "meat" || other.gameObject.tag == "wrench" || other.gameObject.tag == "gascan" || other.gameObject.tag == "carbattery" || other.gameObject.tag == "topplock" || other.gameObject.tag == "sparkplug") && !beartrapOn)
		{
			beartrapOn = true;
			timer = 20f;
			((Rigidbody)base.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = true;
			base.gameObject.GetComponent<Animation>().Play("Beartrap");
			GetComponent<AudioSource>().PlayOneShot(ObjectLjud);
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).timerSearch = 0f;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
			if ((bool)GameObject.Find("TempNavObjects(Clone)"))
			{
				GameObject.Find("TempNavObjects(Clone)").transform.name = "TempNavObjects(Clone)Old";
				UnityEngine.Object.Instantiate(spawnObject, base.transform.position, base.transform.rotation);
			}
			else if ((bool)GameObject.Find("TempNavObjects(Clone)Old"))
			{
				UnityEngine.Object.Destroy(GameObject.Find("TempNavObjects(Clone)Old"));
			}
			else
			{
				UnityEngine.Object.Instantiate(spawnObject, base.transform.position, base.transform.rotation);
			}
		}
		if (other.gameObject.tag == "golv")
		{
			GetComponent<AudioSource>().PlayOneShot(BeartrapOnFloor);
		}
	}

	public virtual void beartrapDestroyed()
	{
		if (!beartrapOn)
		{
			beartrapOn = true;
			timer = 10f;
			((Rigidbody)base.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = true;
			base.gameObject.GetComponent<Animation>().Play("Beartrap");
			GetComponent<AudioSource>().PlayOneShot(ObjectLjud);
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).timerSearch = 0f;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
			if ((bool)GameObject.Find("TempNavObjects(Clone)"))
			{
				GameObject.Find("TempNavObjects(Clone)").transform.name = "TempNavObjects(Clone)Old";
				UnityEngine.Object.Instantiate(spawnObject, base.transform.position, base.transform.rotation);
			}
			else if ((bool)GameObject.Find("TempNavObjects(Clone)Old"))
			{
				UnityEngine.Object.Destroy(GameObject.Find("TempNavObjects(Clone)Old"));
			}
			else
			{
				UnityEngine.Object.Instantiate(spawnObject, base.transform.position, base.transform.rotation);
			}
		}
	}
}

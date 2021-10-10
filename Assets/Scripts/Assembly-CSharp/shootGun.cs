using System;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

[Serializable]
public class shootGun : MonoBehaviour
{
	public GameObject SeeRay1;

	public GameObject Granny;

	public GameObject player;

	public GameObject playerShootAnim;

	public bool shooting;

	public GameObject shootButton;

	public int power;

	public GameObject ammoCheckHolder;

	public GameObject shotgunAnim;

	public GameObject soundHolder;

	public Transform grannyHearSound;

	public GameObject noiceDP;

	public Vector3 velocity;

	public GameObject Spider;

	public bool shootingOnGascan;

	public shootGun()
	{
		power = 500;
	}

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (Input.GetMouseButtonDown(0) && !((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).menuEnabled && ((PickUp)ammoCheckHolder.GetComponent(typeof(PickUp))).oldShotgunLoaded)
		{
			shooting = true;
		}
		RaycastHit hitInfo = default(RaycastHit);
		Vector3 vector = SeeRay1.transform.TransformDirection(Vector3.forward);
		Debug.DrawRay(SeeRay1.transform.position, SeeRay1.transform.forward, Color.green);
		if (shooting)
		{
			shooting = false;
			shotgunAnim.GetComponent<Animation>().Play("Shoot");
			playerShootAnim.GetComponent<Animation>().Play("shootGun");
			shootButton.SetActive(false);
			((PickUp)ammoCheckHolder.GetComponent(typeof(PickUp))).oldShotgunLoaded = false;
			((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).GunShoot();
			UnityEngine.Object.Instantiate(grannyHearSound, noiceDP.transform.position, noiceDP.transform.rotation);
			if (!Physics.Raycast(SeeRay1.transform.position, vector, out hitInfo, 13f))
			{
				return;
			}
			if ((bool)hitInfo.rigidbody)
			{
				hitInfo.rigidbody.AddForceAtPosition(vector * power, hitInfo.point);
			}
			if (hitInfo.collider.gameObject.tag == "granny")
			{
				((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).hitByGun = true;
				((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).spiderIsDead = false;
				((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
			}
			else if (hitInfo.collider.gameObject.tag == "beartrap")
			{
				((BearTrap)hitInfo.collider.gameObject.GetComponent(typeof(BearTrap))).beartrapShot = true;
			}
			else if (hitInfo.collider.gameObject.tag == "shootbutton")
			{
				((shootSpiderButton)hitInfo.collider.gameObject.GetComponent(typeof(shootSpiderButton))).closeSpiderlucka();
			}
			else if (hitInfo.collider.gameObject.tag == "spidernest")
			{
				if (!((spiderControll)Spider.GetComponent(typeof(spiderControll))).SpiderBitePlayer)
				{
					((spiderControll)Spider.GetComponent(typeof(spiderControll))).huntPlayer = true;
				}
			}
			else if (hitInfo.collider.gameObject.tag == "Spider")
			{
				((spiderControll)Spider.GetComponent(typeof(spiderControll))).spiderIsDead();
			}
			else if (hitInfo.collider.gameObject.tag == "gascan" && !shootingOnGascan)
			{
				shootingOnGascan = true;
				((explode)hitInfo.collider.gameObject.GetComponent(typeof(explode))).explodeNow();
			}
		}
		else
		{
			shooting = false;
		}
	}
}

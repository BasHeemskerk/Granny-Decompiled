using System;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

[Serializable]
public class ShootArrow : MonoBehaviour
{
	public GameObject SeeRay;

	public GameObject player;

	public Rigidbody arrow;

	public Transform bulletSpawn;

	public bool shooting;

	public GameObject shootButton;

	public GameObject arrowCheckHolder;

	public GameObject laddad;

	public GameObject Oladdad;

	public GameObject Arrow;

	public GameObject soundHolder;

	public Vector3 velocity;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (Input.GetMouseButtonDown(0) && !((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).menuEnabled && laddad.activeSelf)
		{
			shooting = true;
		}
		RaycastHit hitInfo = default(RaycastHit);
		Vector3 direction = SeeRay.transform.TransformDirection(Vector3.forward);
		if (Physics.Raycast(SeeRay.transform.position, direction, out hitInfo, 100f) && shooting)
		{
			shooting = false;
			shootButton.SetActive(false);
			laddad.SetActive(false);
			Oladdad.SetActive(true);
			Arrow.SetActive(false);
			((PickUp)arrowCheckHolder.GetComponent(typeof(PickUp))).armborstArrowOK = false;
			((PickUp)arrowCheckHolder.GetComponent(typeof(PickUp))).haveArrow = false;
			Rigidbody rigidbody = UnityEngine.Object.Instantiate(arrow, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
			rigidbody.velocity = (hitInfo.point - bulletSpawn.transform.position).normalized * 30f;
			rigidbody.rotation = Quaternion.LookRotation(rigidbody.velocity);
			((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).CrossbowShoot();
		}
	}
}

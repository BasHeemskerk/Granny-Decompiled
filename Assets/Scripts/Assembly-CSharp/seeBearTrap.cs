using System;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

[Serializable]
public class seeBearTrap : MonoBehaviour
{
	public int layerMask;

	public Image button;

	public Image removeBar;

	public GameObject SeeRay;

	public bool destroyTrap;

	public bool playerTaken;

	public GameObject player;

	public GameObject crawlButton;

	public GameObject allBedButtons;

	public AudioClip removeBeartrapSound;

	public seeBearTrap()
	{
		layerMask = 256;
	}

	public virtual void Start()
	{
		layerMask = ~layerMask;
	}

	public virtual void Update()
	{
		RaycastHit hitInfo = default(RaycastHit);
		Vector3 direction = SeeRay.transform.TransformDirection(Vector3.forward);
		if (playerTaken)
		{
			return;
		}
		if (Physics.Raycast(SeeRay.transform.position, direction, out hitInfo, 6f, layerMask))
		{
			if (hitInfo.collider.gameObject.tag == "BearTrapActivated")
			{
				button.enabled = true;
				((removeBeartrap)button.GetComponent(typeof(removeBeartrap))).seeTrap = true;
				if (!destroyTrap)
				{
					return;
				}
				removeBar.fillAmount += 0.5f * Time.deltaTime;
				if (removeBar.fillAmount == 1f)
				{
					removeBar.fillAmount = 0f;
					if (hitInfo.collider.gameObject.tag == "BearTrapActivated")
					{
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).playerInhole = false;
						((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).m_WalkSpeed = 6f;
						crawlButton.SetActive(true);
						allBedButtons.SetActive(true);
						((removeBeartrap)button.GetComponent(typeof(removeBeartrap))).seeTrap = false;
						player.GetComponent<CharacterController>().height = 2.76f;
						button.enabled = false;
						destroyTrap = false;
						GetComponent<AudioSource>().PlayOneShot(removeBeartrapSound);
					}
				}
			}
			else if (hitInfo.collider.gameObject.tag == "golv")
			{
				((removeBeartrap)button.GetComponent(typeof(removeBeartrap))).seeTrap = false;
				button.enabled = false;
				destroyTrap = false;
			}
		}
		else
		{
			((removeBeartrap)button.GetComponent(typeof(removeBeartrap))).seeTrap = false;
			button.enabled = false;
			destroyTrap = false;
		}
	}
}

using System;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

[Serializable]
public class removeBeartrap : MonoBehaviour
{
	public int layerMask;

	public Image removeBar;

	public bool PressButton;

	public GameObject rayHolder;

	public GameObject player;

	public bool seeTrap;

	public bool playerTaken;

	public removeBeartrap()
	{
		layerMask = 256;
	}

	public virtual void Start()
	{
		removeBar.fillAmount = 0f;
	}

	public virtual void Update()
	{
		if (playerTaken)
		{
			return;
		}
		if (seeTrap)
		{
			if (!((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).menuEnabled)
			{
				if (Input.GetKey(KeyCode.F))
				{
					PressButton = true;
					((seeBearTrap)rayHolder.GetComponent(typeof(seeBearTrap))).destroyTrap = true;
				}
				else if (Input.GetKeyUp(KeyCode.F))
				{
					PressButton = false;
					((seeBearTrap)rayHolder.GetComponent(typeof(seeBearTrap))).destroyTrap = false;
				}
			}
			if (!PressButton)
			{
				removeBar.fillAmount -= 1f * Time.deltaTime;
				((seeBearTrap)rayHolder.GetComponent(typeof(seeBearTrap))).destroyTrap = false;
			}
		}
		else
		{
			removeBar.fillAmount = 0f;
			((seeBearTrap)rayHolder.GetComponent(typeof(seeBearTrap))).destroyTrap = false;
		}
	}
}

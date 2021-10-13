using System;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

[Serializable]
public class pressFueltankButton : MonoBehaviour
{
	public GameObject fillFuelScriptHolder;

	public GameObject player;

	public virtual void Update()
	{
		if (!((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).menuEnabled)
		{
			if (Input.GetKey(KeyCode.F))
			{
				((fillingFuel)fillFuelScriptHolder.GetComponent(typeof(fillingFuel))).playerHoldButton = true;
			}
			else
			{
				((fillingFuel)fillFuelScriptHolder.GetComponent(typeof(fillingFuel))).playerHoldButton = false;
			}
		}
	}
}

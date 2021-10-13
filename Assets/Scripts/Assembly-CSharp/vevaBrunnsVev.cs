using System;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

[Serializable]
public class vevaBrunnsVev : MonoBehaviour
{
	public GameObject brunnsVevScriptHolder;

	public GameObject brunnsLjud;

	public GameObject player;

	public virtual void Update()
	{
		if (!((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).menuEnabled)
		{
			if (Input.GetKey(KeyCode.F))
			{
				((playerVevar)brunnsVevScriptHolder.GetComponent(typeof(playerVevar))).playerHoldButton = true;
				return;
			}
			((playerVevar)brunnsVevScriptHolder.GetComponent(typeof(playerVevar))).playerHoldButton = false;
			((vevarBrunnLjud)brunnsLjud.GetComponent(typeof(vevarBrunnLjud))).PlayerVevar = false;
		}
	}
}

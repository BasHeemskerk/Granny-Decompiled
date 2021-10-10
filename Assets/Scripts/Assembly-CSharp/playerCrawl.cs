using System;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

[Serializable]
public class playerCrawl : MonoBehaviour
{
	public GameObject player;

	public GameObject playerHead;

	public GameObject grannyParent;

	public GameObject granny;

	public GameObject soundHolder;

	public bool PlayerHukarSig;

	public virtual void Start()
	{
	}

	public virtual void crouching()
	{
		if (!PlayerHukarSig)
		{
			player.GetComponent<CharacterController>().height = 1.65f;
			player.GetComponent<CharacterController>().center = new Vector3(0f, 0.52f, 0.12f);
			((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).m_WalkSpeed = 1f;
			playerHead.transform.transform.localPosition = new Vector3(0f, -0.35f, 0f);
			PlayerHukarSig = true;
			GameObject.Find("CameraPivot").GetComponent<Footsteps>().playerCrouching = true;
			((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).hukarSig();
		}
		else
		{
			player.GetComponent<CharacterController>().height = 2.76f;
			player.GetComponent<CharacterController>().center = new Vector3(0f, 1.18f, 0.12f);
			((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).m_WalkSpeed = 6f;
			playerHead.transform.transform.localPosition = new Vector3(0f, 1.007f, 0f);
			PlayerHukarSig = false;
			GameObject.Find("CameraPivot").GetComponent<Footsteps>().playerCrouching = false;
			((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).standUp();
		}
	}

	public virtual void Update()
	{
	}

	public virtual void standUp()
	{
		player.GetComponent<CharacterController>().height = 2.76f;
		player.GetComponent<CharacterController>().center = new Vector3(0f, 1.18f, 0.12f);
		((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).m_WalkSpeed = 6f;
		playerHead.transform.transform.localPosition = new Vector3(0f, 1.007f, 0f);
		PlayerHukarSig = false;
		((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).standUp();
	}
}

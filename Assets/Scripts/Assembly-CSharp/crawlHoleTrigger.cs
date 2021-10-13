using System;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

[Serializable]
public class crawlHoleTrigger : MonoBehaviour
{
	public GameObject granny;

	public GameObject grannyEyes;

	public GameObject player;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerInHole = true;
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerHiding = true;
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).seePlayer = false;
			((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).playerInhole = true;
		}
	}

	public virtual void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerInHole = false;
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerHiding = false;
			((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).playerInhole = false;
		}
	}
}

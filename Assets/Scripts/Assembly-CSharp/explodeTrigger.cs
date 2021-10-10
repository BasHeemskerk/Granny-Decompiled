using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class explodeTrigger : MonoBehaviour
{
	public GameObject Granny;

	public GameObject gameController;

	public bool grannyHit;

	public virtual IEnumerator Start()
	{
		Granny = GameObject.Find("GrannyParent");
		gameController = GameObject.Find("GameController");
		yield return new WaitForSeconds(1f);
		grannyHit = true;
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (!grannyHit)
		{
			if (other.gameObject.tag == "granny")
			{
				((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).hitByGun = true;
				((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).spiderIsDead = false;
				((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
				grannyHit = true;
			}
			else if (other.gameObject.tag == "Player")
			{
				((playerCaught)other.GetComponent(typeof(playerCaught))).explodingPlayer = true;
				((playerInBeartrap)gameController.GetComponent(typeof(playerInBeartrap))).playerHit();
				grannyHit = true;
			}
		}
	}
}

using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class spiderControll : MonoBehaviour
{
	public GameObject gameController;

	public bool playerCaught;

	public bool spiderDead;

	public GameObject spiderParent;

	public Transform spiderStartPosition;

	public Transform spiderPlayerPosition;

	public bool huntPlayer;

	public bool foodTime;

	public float spiderDeadTimer;

	public float spiderEatTimer;

	public bool spiderStartEat;

	public bool SpiderBitePlayer;

	public Transform PlayerPos;

	public GameObject Player;

	public GameObject Granny;

	public Transform FoodPlate;

	public float spiderSpeed;

	public GameObject spiderAnimHolder;

	public GameObject foodCollider;

	public GameObject playerCollider;

	public float damping;

	public bool soundSeePlayed;

	public bool soundAttackPlayed;

	public bool spiderResetNow;

	public bool spiderInNest;

	public GameObject soundEffectHolder;

	public GameObject playerHukaKnapp;

	public GameObject playerHukaKnappParent;

	public GameObject inactivateSpider;

	public GameObject inactivateSpiderTrigger;

	public GameObject spiderTrigger2;

	public GameObject meatOnPlate;

	public GameObject leavetrigger;

	public Transform spiderNestPosition;

	public spiderControll()
	{
		spiderDeadTimer = 8f;
		spiderInNest = true;
	}

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (!spiderDead)
		{
			if (!spiderResetNow)
			{
				if (huntPlayer && !playerCaught)
				{
					spiderInNest = false;
					base.transform.Translate(Vector3.forward * Time.deltaTime * spiderSpeed);
					Vector3 forward = PlayerPos.position - base.transform.position;
					forward.y = 0f;
					Quaternion b = Quaternion.LookRotation(forward);
					base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b, Time.deltaTime * damping);
					spiderAnimHolder.GetComponent<Animation>()["Walk"].speed = 3f;
					foodCollider.SetActive(false);
					playerCollider.SetActive(true);
					running();
					if (!soundSeePlayed)
					{
						soundSeePlayed = true;
						((spiderSoundEffects)soundEffectHolder.GetComponent(typeof(spiderSoundEffects))).spiderSeePlayer();
					}
				}
				if (foodTime)
				{
					spiderInNest = false;
					base.transform.Translate(Vector3.forward * Time.deltaTime * 10f);
					base.transform.LookAt(FoodPlate);
					spiderAnimHolder.GetComponent<Animation>()["Walk"].speed = 3f;
					foodCollider.SetActive(true);
					playerCollider.SetActive(false);
					running();
				}
			}
			if (spiderResetNow && !spiderStartEat)
			{
				base.transform.Translate(Vector3.forward * Time.deltaTime * spiderSpeed);
				Vector3 forward2 = spiderNestPosition.position - base.transform.position;
				forward2.y = 0f;
				Quaternion b2 = Quaternion.LookRotation(forward2);
				base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b2, Time.deltaTime * damping);
				foodCollider.SetActive(false);
				playerCollider.SetActive(false);
				running();
			}
		}
		if (spiderDead)
		{
			spiderDeadTimer -= Time.deltaTime;
			if (spiderDeadTimer <= 0f)
			{
				inactivateSpider.SetActive(false);
				inactivateSpiderTrigger.SetActive(false);
			}
		}
		if (spiderStartEat)
		{
			spiderEatTimer += Time.deltaTime;
			if (spiderEatTimer >= 10f)
			{
				spiderStartEat = false;
				spiderTrigger2.SetActive(true);
				meatOnPlate.SetActive(false);
			}
		}
	}

	public virtual void running()
	{
		if (!spiderDead)
		{
			spiderAnimHolder.GetComponent<Animation>().CrossFade("Walk");
		}
	}

	public virtual void attack()
	{
		if (!spiderDead)
		{
			spiderAnimHolder.GetComponent<Animation>().CrossFade("attack");
			spiderAnimHolder.GetComponent<Animation>().Stop("Walk");
			spiderAnimHolder.GetComponent<Animation>().Stop("idle");
			playerDead();
		}
	}

	public virtual void idle()
	{
		if (!spiderDead)
		{
			spiderAnimHolder.GetComponent<Animation>().CrossFade("idle");
			spiderAnimHolder.GetComponent<Animation>().Stop("Walk");
			spiderAnimHolder.GetComponent<Animation>().Stop("attack");
		}
	}

	public virtual void playerDead()
	{
		if (!spiderDead && !SpiderBitePlayer)
		{
			foodCollider.SetActive(false);
			SpiderBitePlayer = true;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerGetCaught = true;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerFallDeath = true;
			huntPlayer = false;
			spiderAnimHolder.GetComponent<Animation>().CrossFade("attack");
			spiderAnimHolder.GetComponent<Animation>().Stop("Walk");
			spiderAnimHolder.GetComponent<Animation>().Stop("idle");
			((playerCrawl)playerHukaKnapp.GetComponent(typeof(playerCrawl))).standUp();
			playerHukaKnappParent.SetActive(false);
			if (!soundAttackPlayed)
			{
				soundAttackPlayed = true;
				((spiderSoundEffects)soundEffectHolder.GetComponent(typeof(spiderSoundEffects))).spiderAttackPlayer();
				((playerInBeartrap)gameController.GetComponent(typeof(playerInBeartrap))).playerBiten();
			}
			StartCoroutine(spiderToStartPos());
		}
	}

	public virtual IEnumerator spiderToStartPos()
	{
		if (!spiderDead)
		{
			yield return new WaitForSeconds(1f);
			spiderParent.transform.position = spiderPlayerPosition.position;
			spiderParent.transform.rotation = spiderPlayerPosition.rotation;
			yield return new WaitForSeconds(7f);
			spiderParent.transform.position = spiderStartPosition.position;
			spiderParent.transform.rotation = spiderStartPosition.rotation;
			spiderInNest = true;
			SpiderBitePlayer = false;
			soundSeePlayed = false;
			soundAttackPlayed = false;
			spiderTrigger2.SetActive(false);
			inactivateSpiderTrigger.SetActive(true);
		}
	}

	public virtual void grannyCaughtPlayer()
	{
		if (!spiderDead)
		{
			playerCaught = true;
			spiderAnimHolder.GetComponent<Animation>().CrossFade("idle_0");
			spiderAnimHolder.GetComponent<Animation>().Stop("Walk");
			spiderAnimHolder.GetComponent<Animation>().Stop("attack");
			spiderInNest = true;
			SpiderBitePlayer = false;
			soundSeePlayed = false;
			soundAttackPlayed = false;
			spiderTrigger2.SetActive(false);
			inactivateSpiderTrigger.SetActive(true);
		}
	}

	public virtual void grannyCaughtPlayerReset()
	{
		spiderParent.transform.position = spiderStartPosition.position;
		spiderParent.transform.rotation = spiderStartPosition.rotation;
		playerCaught = false;
		huntPlayer = false;
	}

	public virtual void spiderIsDead()
	{
		spiderDead = true;
		spiderAnimHolder.GetComponent<Animation>().CrossFade("dead");
		spiderAnimHolder.GetComponent<Animation>().Stop("Walk");
		spiderAnimHolder.GetComponent<Animation>().Stop("attack");
		spiderAnimHolder.GetComponent<Animation>().Stop("idle");
		SpiderBitePlayer = false;
		soundSeePlayed = false;
		soundAttackPlayed = false;
		foodCollider.SetActive(false);
		playerCollider.SetActive(false);
		spiderTrigger2.SetActive(false);
		((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = true;
		((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).spiderIsDead = true;
		leavetrigger.SetActive(false);
		((spiderSoundEffects)soundEffectHolder.GetComponent(typeof(spiderSoundEffects))).spiderDie();
	}
}

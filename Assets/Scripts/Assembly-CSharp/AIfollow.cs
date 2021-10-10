using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;

[Serializable]
public class AIfollow : MonoBehaviour
{
	public Transform myTransform;

	public GameObject slendrina;

	public GameObject slendrinaBody;

	public Transform target;

	public Transform nav1;

	public Transform nav2;

	public Transform nav3;

	public Transform nav4;

	public Transform nav5;

	public Transform nav6;

	public Transform nav7;

	public Transform nav8;

	public Transform nav9;

	public Transform nav10;

	public Transform nav11;

	public Transform nav12;

	public Transform nav13;

	public Transform nav14;

	public Transform nav15;

	public Transform nav16;

	public Transform nav17;

	public Transform nav18;

	public Transform nav19;

	public Transform player;

	public NavMeshAgent navComponent;

	public bool timerOnOff;

	public bool timerStop;

	public bool seePlayer;

	public bool attackingPlayer;

	public bool FollowPlayer;

	public bool stopFollow;

	public bool robotdead;

	public bool playerHiding;

	public bool monsterSearch;

	public bool waypointWaitTime;

	public bool breakDoor;

	public bool startHittingPlayer;

	public bool stopHittingPlayer;

	public bool PlayerVisible;

	public bool DoorOpenVisible;

	public bool DoorClosedVisible;

	public bool garderobVisible;

	public bool stopAndAttackPlayer;

	public bool slendrinaActive;

	public bool waypointStop;

	public bool huntingPlayer;

	public float timer;

	public float Stucktimer;

	public bool StucktimerOnOff;

	public float Huntingtimer;

	public bool HuntingtimerOn;

	public float number;

	public float numberRoar;

	public GameObject animationHolder;

	public float damping;

	public int damp;

	public float rotationSpeed;

	public float seeRange;

	public float attackRange;

	public float stopFollowRange;

	public float distance;

	public float distanceWaypoint;

	private bool soundEffectPlay;

	public float RobotRotatespeed;

	public GameObject robotEyes;

	public GameObject yellowRay1;

	public GameObject yellowRay2;

	public GameObject RedRay;

	public GameObject monsterAnimHandDoor;

	public GameObject roboteyeBack;

	public GameObject monsterHeadAnim;

	public GameObject followSoundHolder;

	public GameObject roarSoundHolder;

	public GameObject FootstepSoundHolder;

	public GameObject BreathingSoundHolder;

	public GameObject musicHolder;

	public GameObject HuntmusicHolder;

	public bool PlayerDead;

	public bool ManiacSeeLocker;

	public bool ManiacOpenLocker;

	public bool seeLockerDoor;

	public bool seeSmashDoor;

	public GameObject LockerButtons;

	public float playerVisibleTimer;

	public float yellowRayLenght;

	public GameObject maniacHandSmash;

	public bool reduseraTimerHiding;

	public GameObject soundeffectsHolder;

	public AudioClip maniacFootstepsWalk;

	public AudioClip maniacFootstepsFollow;

	public bool maniacSeePlayer;

	public GameObject breathSoundHolder;

	public GameObject screamSoundHolder;

	public bool maniacMoving;

	public bool footstepPlaying;

	public float seeOpenDoorTimer;

	public float seeClosedDoorTimer;

	public float seeClosedGarderobDoorTimer;

	public bool monsterHurt;

	public GameObject monsterHand;

	public float timerCount2;

	public bool monsterIsFreezed;

	public bool disableMonster;

	public GameObject gameController;

	public AIfollow()
	{
		timerOnOff = true;
		damp = 5;
		seeRange = 10f;
		attackRange = 4f;
		stopFollowRange = 4f;
		RobotRotatespeed = 0.1f;
		seeOpenDoorTimer = 5f;
		seeClosedDoorTimer = 3f;
		seeClosedGarderobDoorTimer = 3f;
		timerCount2 = 2f;
	}

	public virtual void Start()
	{
		AudioSource component = GetComponent<AudioSource>();
		component.clip = maniacFootstepsWalk;
		component.Play();
		stopFollow = true;
		number = UnityEngine.Random.Range(1, 39);
		if (number == 1f || number == 2f)
		{
			target = GameObject.Find("Nav1").transform;
		}
		if (number == 3f || number == 4f)
		{
			target = GameObject.Find("Nav2").transform;
		}
		if (number == 5f || number == 6f)
		{
			target = GameObject.Find("Nav3").transform;
		}
		if (number == 7f || number == 8f)
		{
			target = GameObject.Find("Nav4").transform;
		}
		if (number == 9f || number == 10f)
		{
			target = GameObject.Find("Nav5").transform;
		}
		if (number == 11f || number == 12f)
		{
			target = GameObject.Find("Nav6").transform;
		}
		if (number == 13f || number == 14f)
		{
			target = GameObject.Find("Nav7").transform;
		}
		if (number == 15f || number == 16f)
		{
			target = GameObject.Find("Nav8").transform;
		}
		if (number == 17f || number == 18f)
		{
			target = GameObject.Find("Nav9").transform;
		}
		if (number == 19f || number == 20f)
		{
			target = GameObject.Find("Nav10").transform;
		}
		if (number == 21f || number == 22f)
		{
			target = GameObject.Find("Nav11").transform;
		}
		if (number == 23f || number == 24f)
		{
			target = GameObject.Find("Nav12").transform;
		}
		if (number == 25f || number == 26f)
		{
			target = GameObject.Find("Nav13").transform;
		}
		if (number == 27f || number == 28f)
		{
			target = GameObject.Find("Nav14").transform;
		}
		if (number == 29f || number == 30f)
		{
			target = GameObject.Find("Nav15").transform;
		}
		if (number == 31f || number == 32f)
		{
			target = GameObject.Find("Nav16").transform;
		}
		if (number == 33f || number == 34f)
		{
			target = GameObject.Find("Nav17").transform;
		}
		if (number == 35f || number == 36f)
		{
			target = GameObject.Find("Nav18").transform;
		}
		if (number == 37f || number == 38f)
		{
			target = GameObject.Find("Nav19").transform;
		}
		monsterHeadAnim.GetComponent<Animation>().Play("ManiacHeadAnim");
		animationHolder.GetComponent<Animation>()["Walk"].speed = 1.4f;
		if (navComponent.velocity != Vector3.zero)
		{
			animationHolder.GetComponent<Animation>().CrossFade("Walk");
		}
		timer = 15f;
		navComponent = (NavMeshAgent)base.transform.GetComponent(typeof(NavMeshAgent));
		player = GameObject.Find("Player").transform;
		nav1 = GameObject.Find("Nav1").transform;
		nav2 = GameObject.Find("Nav2").transform;
		nav3 = GameObject.Find("Nav3").transform;
		nav4 = GameObject.Find("Nav4").transform;
		nav5 = GameObject.Find("Nav5").transform;
		nav6 = GameObject.Find("Nav6").transform;
		nav7 = GameObject.Find("Nav7").transform;
		nav8 = GameObject.Find("Nav8").transform;
		nav9 = GameObject.Find("Nav9").transform;
		nav10 = GameObject.Find("Nav10").transform;
		nav11 = GameObject.Find("Nav11").transform;
		nav12 = GameObject.Find("Nav12").transform;
		nav13 = GameObject.Find("Nav13").transform;
		nav14 = GameObject.Find("Nav14").transform;
		nav15 = GameObject.Find("Nav15").transform;
		nav16 = GameObject.Find("Nav16").transform;
		nav17 = GameObject.Find("Nav17").transform;
		nav18 = GameObject.Find("Nav18").transform;
		nav19 = GameObject.Find("Nav19").transform;
		StucktimerOnOff = true;
		((maniacBreath)breathSoundHolder.GetComponent(typeof(maniacBreath))).maniacBreathSlow();
	}

	public virtual void Update()
	{
		RaycastHit hitInfo = default(RaycastHit);
		if (monsterIsFreezed && !disableMonster)
		{
			disableMonster = true;
			navComponent.speed = 0f;
			animationHolder.GetComponent<Animation>()["attack"].speed = 0f;
			animationHolder.GetComponent<Animation>()["Walk"].speed = 0f;
			((maniacBreath)breathSoundHolder.GetComponent(typeof(maniacBreath))).maniafreezed();
			Debug.Log("NOS!!!");
		}
		if (monsterHurt && !monsterIsFreezed)
		{
			if (timerCount2 == 2f)
			{
				animationHolder.GetComponent<Animation>().CrossFade("hurt");
				monsterHand.GetComponent<Collider>().enabled = false;
			}
			navComponent.speed = 0f;
		}
		if (monsterHurt)
		{
			timerCount2 -= Time.deltaTime;
			if (timerCount2 < 0f)
			{
				monsterHurt = false;
				monsterHand.GetComponent<Collider>().enabled = true;
				timerCount2 = 2f;
			}
		}
		if (monsterHurt || monsterIsFreezed)
		{
			return;
		}
		if (!stopFollow)
		{
		}
		navComponent.updateRotation = true;
		distance = Vector3.Distance(player.position, base.transform.position);
		distanceWaypoint = Vector3.Distance(target.position, base.transform.position);
		if (navComponent.velocity != Vector3.zero)
		{
			maniacMoving = true;
			if (stopFollow)
			{
				if (navComponent.velocity != Vector3.zero)
				{
					animationHolder.GetComponent<Animation>().CrossFade("Walk");
				}
				animationHolder.GetComponent<Animation>()["Walk"].speed = 1.4f;
				if (!footstepPlaying)
				{
					footstepPlaying = true;
					GetComponent<AudioSource>().clip = maniacFootstepsWalk;
					GetComponent<AudioSource>().Play();
				}
			}
			else if (!stopFollow)
			{
				if (navComponent.velocity != Vector3.zero)
				{
					animationHolder.GetComponent<Animation>().CrossFade("Walk");
				}
				animationHolder.GetComponent<Animation>()["Walk"].speed = 1.4f;
				if (!footstepPlaying)
				{
					footstepPlaying = true;
					GetComponent<AudioSource>().clip = maniacFootstepsFollow;
					GetComponent<AudioSource>().Play();
				}
			}
		}
		else if (navComponent.velocity == Vector3.zero)
		{
			maniacMoving = false;
			if (stopFollow)
			{
				animationHolder.GetComponent<Animation>().CrossFade("idle");
				if (footstepPlaying)
				{
					footstepPlaying = false;
					GetComponent<AudioSource>().Stop();
				}
			}
			else if (!stopFollow)
			{
				animationHolder.GetComponent<Animation>().CrossFade("idle");
				if (footstepPlaying)
				{
					footstepPlaying = false;
					GetComponent<AudioSource>().Stop();
				}
			}
		}
		if (seePlayer)
		{
			maniacHandSmash.SetActive(true);
		}
		else if (!seePlayer)
		{
			maniacHandSmash.SetActive(false);
		}
		if (seePlayer && !attackingPlayer)
		{
			playerVisibleTimer -= Time.deltaTime;
		}
		if (playerVisibleTimer <= 0f)
		{
			seePlayer = false;
			if (!seePlayer)
			{
				Debug.Log("Timer på 0");
				seePlayer = false;
				playerVisibleTimer = 10f;
			}
		}
		if (playerHiding)
		{
			if (!reduseraTimerHiding && playerVisibleTimer > 4f)
			{
				reduseraTimerHiding = true;
				playerVisibleTimer = 4f;
			}
		}
		else if (!playerHiding)
		{
			reduseraTimerHiding = false;
		}
		if (playerHiding)
		{
			if (seePlayer)
			{
				if (!PlayerVisible)
				{
					attackingPlayer = false;
					followPlayer();
					if (!ManiacSeeLocker)
					{
						stopHittingPlayer = true;
					}
					else if (ManiacSeeLocker)
					{
						ManiacOpenLocker = true;
						Debug.Log("Står vid skåpet");
					}
				}
				else if (PlayerVisible)
				{
					if (distance < attackRange)
					{
						stopHittingPlayer = false;
						attackingPlayer = true;
						StartCoroutine(attackPlayer());
					}
					else if (seeLockerDoor)
					{
						stopHittingPlayer = true;
					}
				}
				else if (PlayerVisible)
				{
					if (ManiacSeeLocker)
					{
					}
				}
				else if (!PlayerVisible && !ManiacSeeLocker)
				{
				}
			}
			else if (!seePlayer && !PlayerVisible)
			{
				if (seeLockerDoor)
				{
					stopHittingPlayer = true;
				}
				attackingPlayer = false;
			}
		}
		else if (!playerHiding)
		{
			if (distance < attackRange && seePlayer)
			{
				if (!seeLockerDoor)
				{
					attackingPlayer = true;
					target = player;
					StartCoroutine(attackPlayer());
					stopHittingPlayer = false;
				}
			}
			else if (distance > attackRange && distance < seeRange && seePlayer)
			{
				attackingPlayer = false;
				followPlayer();
				if (!FollowPlayer)
				{
					FollowPlayer = true;
					GetComponent<AudioSource>().Play();
				}
			}
		}
		if (!timerStop && timerOnOff)
		{
			timer += Time.deltaTime;
		}
		if (distanceWaypoint < 7f && !attackingPlayer && stopFollow)
		{
			timerOnOff = true;
			randomNav();
		}
		if (timer >= 10f)
		{
			timerOnOff = false;
			timer = 0f;
		}
		if ((bool)target)
		{
			navComponent.SetDestination(target.position);
			if (!seePlayer)
			{
				if (distanceWaypoint < 3f)
				{
					if (timerOnOff && waypointStop)
					{
						Debug.Log("15");
						if (!maniacMoving)
						{
							animationHolder.GetComponent<Animation>().CrossFade("idle");
							GetComponent<AudioSource>().Stop();
						}
						else if (maniacMoving)
						{
							if (navComponent.velocity != Vector3.zero)
							{
								animationHolder.GetComponent<Animation>().CrossFade("Walk");
							}
							animationHolder.GetComponent<Animation>()["Walk"].speed = 1.4f;
							GetComponent<AudioSource>().clip = maniacFootstepsWalk;
							GetComponent<AudioSource>().Play();
						}
						waypointStop = false;
					}
				}
				else if (distanceWaypoint > 3f && !timerOnOff && !seePlayer && !waypointStop)
				{
					if (maniacMoving)
					{
						if (navComponent.velocity != Vector3.zero)
						{
							animationHolder.GetComponent<Animation>().CrossFade("Walk");
						}
						animationHolder.GetComponent<Animation>()["Walk"].speed = 1.4f;
						GetComponent<AudioSource>().clip = maniacFootstepsWalk;
						GetComponent<AudioSource>().Play();
					}
					else if (!maniacMoving)
					{
						animationHolder.GetComponent<Animation>().CrossFade("idle");
						GetComponent<AudioSource>().Stop();
					}
					waypointStop = true;
				}
			}
		}
		if (seePlayer)
		{
			target = player;
			if (distance < seeRange)
			{
				stopFollow = false;
				if (!attackingPlayer)
				{
					followPlayer();
				}
			}
		}
		else if (!seePlayer && !stopFollow)
		{
			StartCoroutine(stopfollowPlayer());
			stopFollow = true;
			animationHolder.GetComponent<Animation>().CrossFade("idle");
			GetComponent<AudioSource>().Stop();
			navComponent.speed = 0f;
			FollowPlayer = false;
		}
		if (!monsterIsFreezed)
		{
			Vector3 vector = yellowRay1.transform.TransformDirection(Vector3.forward);
			Debug.DrawRay(yellowRay1.transform.position, vector * 40f, Color.yellow);
			if (Physics.Raycast(yellowRay1.transform.position, vector, out hitInfo, yellowRayLenght) && seePlayer)
			{
				if (hitInfo.collider.gameObject.tag == "Player")
				{
					PlayerVisible = true;
					DoorClosedVisible = false;
					DoorOpenVisible = false;
					playerVisibleTimer = 10f;
				}
				if (hitInfo.collider.gameObject.tag != "Player")
				{
					PlayerVisible = false;
				}
				if (!(hitInfo.collider.gameObject.tag == "doorClosed") && !(hitInfo.collider.gameObject.tag == "doorOpen") && !(hitInfo.collider.gameObject.tag == "lockerDoor"))
				{
				}
			}
		}
		if (!monsterIsFreezed)
		{
			Vector3 vector2 = yellowRay2.transform.TransformDirection(Vector3.forward);
			Debug.DrawRay(yellowRay2.transform.position, vector2 * 6f, Color.green);
			if (Physics.Raycast(yellowRay2.transform.position, vector2, out hitInfo, 6f))
			{
				if (seePlayer)
				{
					if (hitInfo.collider.gameObject.tag == "doorClosed")
					{
						seeClosedDoorTimer -= 1f * Time.deltaTime;
						if (navComponent.velocity == Vector3.zero)
						{
							animationHolder.GetComponent<Animation>().CrossFade("idle");
							GetComponent<AudioSource>().Stop();
						}
						if (seeClosedDoorTimer < 0f)
						{
							hitInfo.collider.gameObject.GetComponent<Animation>().Play("InnerdoorOpen");
							if (stopFollow)
							{
								animationHolder.GetComponent<Animation>().CrossFade("idle");
								GetComponent<AudioSource>().Stop();
								seeClosedDoorTimer = 3f;
							}
						}
						if (!stopFollow)
						{
							animationHolder.GetComponent<Animation>().CrossFade("idle");
							GetComponent<AudioSource>().Stop();
						}
					}
					else if (hitInfo.collider.gameObject.tag == "garderobDoorV")
					{
						seeClosedGarderobDoorTimer -= 1f * Time.deltaTime;
						if (navComponent.velocity == Vector3.zero)
						{
							animationHolder.GetComponent<Animation>().CrossFade("idle");
						}
						if (seeClosedGarderobDoorTimer < 0f)
						{
							seeClosedGarderobDoorTimer = 3f;
							hitInfo.collider.gameObject.GetComponent<Animation>().Play("VgarderobDoorOpen");
							if (stopFollow)
							{
								animationHolder.GetComponent<Animation>().CrossFade("idle");
								GetComponent<AudioSource>().Stop();
								seeClosedGarderobDoorTimer = 3f;
							}
						}
						if (!stopFollow)
						{
							animationHolder.GetComponent<Animation>().CrossFade("idle");
							GetComponent<AudioSource>().Stop();
						}
					}
					else if (hitInfo.collider.gameObject.tag == "garderobDoorH")
					{
						MonoBehaviour.print("See garderobDoor");
						seeClosedGarderobDoorTimer -= 1f * Time.deltaTime;
						if (navComponent.velocity == Vector3.zero)
						{
							animationHolder.GetComponent<Animation>().CrossFade("idle");
						}
						if (seeClosedGarderobDoorTimer < 0f)
						{
							seeClosedGarderobDoorTimer = 3f;
							MonoBehaviour.print("See Closed Door");
							hitInfo.collider.gameObject.GetComponent<Animation>().Play("HgarderobDoorOpen");
							MonoBehaviour.print("Öppnar flera ggr!!!");
							if (stopFollow)
							{
								animationHolder.GetComponent<Animation>().CrossFade("idle");
								GetComponent<AudioSource>().Stop();
								seeClosedGarderobDoorTimer = 3f;
							}
						}
						if (!stopFollow)
						{
							animationHolder.GetComponent<Animation>().CrossFade("idle");
							GetComponent<AudioSource>().Stop();
						}
					}
					else
					{
						seeClosedDoorTimer = 3f;
					}
				}
				else if (!seePlayer)
				{
					if (hitInfo.collider.gameObject.tag == "doorClosed")
					{
						seeClosedDoorTimer -= 1f * Time.deltaTime;
						animationHolder.GetComponent<Animation>().CrossFade("idle");
						if (seeClosedDoorTimer < 0f)
						{
							hitInfo.collider.gameObject.GetComponent<Animation>().Play("InnerdoorOpen");
							if (stopFollow)
							{
								animationHolder.GetComponent<Animation>().CrossFade("idle");
								GetComponent<AudioSource>().Stop();
								seeClosedDoorTimer = 3f;
							}
						}
					}
					else if (hitInfo.collider.gameObject.tag == "doorLeftClosed")
					{
						seeClosedDoorTimer -= 1f * Time.deltaTime;
						if (seeClosedDoorTimer < 0f)
						{
							hitInfo.collider.gameObject.GetComponent<Animation>().Play("InnerdoorLeftOpen");
							if (stopFollow)
							{
								animationHolder.GetComponent<Animation>().CrossFade("idle");
								GetComponent<AudioSource>().Stop();
								seeClosedDoorTimer = 3f;
							}
						}
					}
				}
			}
		}
		if (seePlayer && !PlayerVisible && distance < attackRange)
		{
			Vector3 normalized = (target.position - base.transform.position).normalized;
			Quaternion b = Quaternion.LookRotation(normalized);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b, Time.deltaTime * RobotRotatespeed);
			navComponent.stoppingDistance = 4.5f;
		}
		if (StucktimerOnOff)
		{
			Stucktimer += Time.deltaTime;
		}
		if (Stucktimer > 40f && !FollowPlayer)
		{
			Stucktimer += Time.deltaTime;
			Stucktimer = 0f;
			StartCoroutine(randomNavAfterAttack());
		}
	}

	public virtual void letMomSwing()
	{
	}

	public virtual IEnumerator stopAndAttack()
	{
		yield return new WaitForSeconds(3f);
		if (!stopAndAttackPlayer)
		{
			Vector3 relativePos = target.position - base.transform.position;
			Quaternion rotation = Quaternion.LookRotation(relativePos);
			base.transform.rotation = Quaternion.RotateTowards(base.transform.rotation, rotation, Time.deltaTime * RobotRotatespeed);
			stopAndAttackPlayer = true;
			yield return new WaitForSeconds(6f);
			stopAndAttackPlayer = false;
		}
	}

	public virtual void playerStillHiding()
	{
	}

	public virtual void followPlayer()
	{
		if (monsterIsFreezed)
		{
			return;
		}
		if (!maniacSeePlayer)
		{
			maniacSeePlayer = true;
			((maniacBreath)breathSoundHolder.GetComponent(typeof(maniacBreath))).maniacBreathFast();
			((maniacScream)screamSoundHolder.GetComponent(typeof(maniacScream))).maniacSeePlayer();
		}
		GetComponent<AudioSource>().clip = maniacFootstepsFollow;
		navComponent.stoppingDistance = 4.5f;
		navComponent.speed = 7.6f;
		if (maniacMoving)
		{
			if (navComponent.velocity != Vector3.zero)
			{
				animationHolder.GetComponent<Animation>().CrossFade("Walk");
			}
			animationHolder.GetComponent<Animation>()["Walk"].speed = 2f;
		}
		else if (!maniacMoving)
		{
			animationHolder.GetComponent<Animation>().CrossFade("idle");
			GetComponent<AudioSource>().Stop();
		}
		if (startHittingPlayer)
		{
			startHittingPlayer = false;
		}
		if (playerHiding)
		{
		}
	}

	public virtual IEnumerator stopfollowPlayer()
	{
		if (!monsterIsFreezed)
		{
			if (maniacSeePlayer)
			{
				maniacSeePlayer = false;
				((maniacBreath)breathSoundHolder.GetComponent(typeof(maniacBreath))).maniacBreathSlow();
			}
			waypointWaitTime = true;
			timerStop = false;
			yield return new WaitForSeconds(5f);
			StartCoroutine(randomNavAfterAttack());
			FollowPlayer = false;
		}
	}

	public virtual IEnumerator attackPlayer()
	{
		if (monsterIsFreezed)
		{
			yield break;
		}
		FollowPlayer = false;
		if (PlayerVisible || !PlayerVisible)
		{
			if (!stopHittingPlayer)
			{
				animationHolder.GetComponent<Animation>()["attack"].speed = 1.2f;
				animationHolder.GetComponent<Animation>().CrossFade("attack");
				yield return new WaitForSeconds(0.5f);
				GetComponent<AudioSource>().Stop();
				startHittingPlayer = true;
			}
			else
			{
				startHittingPlayer = false;
				GetComponent<AudioSource>().Stop();
			}
			navComponent.speed = 0f;
		}
		else if (!PlayerVisible)
		{
			stopHittingPlayer = true;
			startHittingPlayer = false;
			GetComponent<AudioSource>().Stop();
		}
	}

	public virtual IEnumerator randomNavAfterAttack()
	{
		if (monsterIsFreezed)
		{
			yield break;
		}
		stopFollow = true;
		FollowPlayer = false;
		number = UnityEngine.Random.Range(1, 40);
		if (number == 1f || number == 2f)
		{
			target = GameObject.Find("Nav1").transform;
		}
		if (number == 3f || number == 4f)
		{
			target = GameObject.Find("Nav2").transform;
		}
		if (number == 5f || number == 6f)
		{
			target = GameObject.Find("Nav3").transform;
		}
		if (number == 7f || number == 8f)
		{
			target = GameObject.Find("Nav4").transform;
		}
		if (number == 9f || number == 10f)
		{
			target = GameObject.Find("Nav5").transform;
		}
		if (number == 11f || number == 12f)
		{
			target = GameObject.Find("Nav6").transform;
		}
		if (number == 13f || number == 14f)
		{
			target = GameObject.Find("Nav7").transform;
		}
		if (number == 15f || number == 16f)
		{
			target = GameObject.Find("Nav8").transform;
		}
		if (number == 17f || number == 18f)
		{
			target = GameObject.Find("Nav9").transform;
		}
		if (number == 19f || number == 20f)
		{
			target = GameObject.Find("Nav10").transform;
		}
		if (number == 21f || number == 22f)
		{
			target = GameObject.Find("Nav11").transform;
		}
		if (number == 23f || number == 24f)
		{
			target = GameObject.Find("Nav12").transform;
		}
		if (number == 25f || number == 26f)
		{
			target = GameObject.Find("Nav13").transform;
		}
		if (number == 27f || number == 28f)
		{
			target = GameObject.Find("Nav14").transform;
		}
		if (number == 29f || number == 30f)
		{
			target = GameObject.Find("Nav15").transform;
		}
		if (number == 31f || number == 32f)
		{
			target = GameObject.Find("Nav16").transform;
		}
		if (number == 33f || number == 34f)
		{
			target = GameObject.Find("Nav17").transform;
		}
		if (number == 35f || number == 36f)
		{
			target = GameObject.Find("Nav18").transform;
		}
		if (number == 37f || number == 39f)
		{
			target = GameObject.Find("Nav19").transform;
		}
		yield return new WaitForSeconds(10f);
		navComponent.speed = 3.8f;
		if (maniacMoving)
		{
			if (navComponent.velocity != Vector3.zero)
			{
				animationHolder.GetComponent<Animation>().CrossFade("Walk");
			}
			animationHolder.GetComponent<Animation>()["Walk"].speed = 1.4f;
			GetComponent<AudioSource>().clip = maniacFootstepsWalk;
			GetComponent<AudioSource>().Play();
		}
		else if (!maniacMoving)
		{
			animationHolder.GetComponent<Animation>().CrossFade("idle");
			GetComponent<AudioSource>().Stop();
		}
		attackingPlayer = false;
		Debug.Log("Now Move On!!");
		Stucktimer = 0f;
	}

	public virtual void randomNav()
	{
		if (monsterIsFreezed || !timerOnOff)
		{
			return;
		}
		waypointWaitTime = true;
		if (!(timer >= 10f))
		{
			return;
		}
		navComponent.speed = 0f;
		if (!maniacMoving)
		{
			animationHolder.GetComponent<Animation>().CrossFade("idle");
			GetComponent<AudioSource>().Stop();
		}
		else if (maniacMoving)
		{
			if (navComponent.velocity != Vector3.zero)
			{
				animationHolder.GetComponent<Animation>().CrossFade("Walk");
			}
			animationHolder.GetComponent<Animation>()["Walk"].speed = 1.4f;
			GetComponent<AudioSource>().clip = maniacFootstepsWalk;
			GetComponent<AudioSource>().Play();
		}
		number = UnityEngine.Random.Range(1, 8);
		newNav();
	}

	public virtual void newNav()
	{
		navComponent.speed = 3.8f;
		waypointWaitTime = false;
		if (number == 1f)
		{
			target = nav1;
		}
		if (number == 2f)
		{
			target = nav2;
		}
		if (number == 3f)
		{
			target = nav3;
		}
		if (number == 4f)
		{
			target = nav4;
		}
		if (number == 5f)
		{
			target = nav5;
		}
		if (number == 6f)
		{
			target = nav6;
		}
		if (number == 7f)
		{
			target = nav7;
		}
		if (number == 8f)
		{
			target = nav8;
		}
		if (number == 9f)
		{
			target = nav9;
		}
		if (number == 10f)
		{
			target = nav10;
		}
		if (number == 11f)
		{
			target = nav11;
		}
		if (number == 12f)
		{
			target = nav12;
		}
		if (number == 13f)
		{
			target = nav13;
		}
		if (number == 14f)
		{
			target = nav14;
		}
		if (number == 15f)
		{
			target = nav15;
		}
		if (number == 16f)
		{
			target = nav16;
		}
		if (number == 17f)
		{
			target = nav17;
		}
		if (number == 18f)
		{
			target = nav18;
		}
		if (number == 19f)
		{
			target = nav19;
		}
	}

	public virtual IEnumerator afterFollow()
	{
		yield return new WaitForSeconds(8f);
		Debug.Log("Now Move On!!");
	}
}

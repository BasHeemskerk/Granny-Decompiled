using System;
using UnityEngine;

[Serializable]
public class EnemyEye : MonoBehaviour
{
	public int layerMask;

	public Transform myTransform;

	public Transform target;

	public Camera cam;

	public GameObject granny;

	public float seeRange;

	public GameObject playerCrouch;

	public EnemyEye()
	{
		layerMask = 1024;
	}

	public virtual void Start()
	{
		layerMask = ~layerMask;
		if (PlayerPrefs.GetInt("DiffData") == 2)
		{
			seeRange = 250f;
		}
		else
		{
			seeRange = 200f;
		}
		cam = GetComponent<Camera>();
	}

	public virtual void Update()
	{
		RaycastHit hitInfo = default(RaycastHit);
		Vector3 vector = cam.WorldToViewportPoint(target.position);
		float sqrMagnitude = (target.position - myTransform.position).sqrMagnitude;
		if (((playerCrawl)playerCrouch.GetComponent(typeof(playerCrawl))).PlayerHukarSig && ((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerHiding)
		{
			if (PlayerPrefs.GetInt("DiffData") == 2 || PlayerPrefs.GetInt("DiffData") == 3)
			{
				seeRange = 400f;
			}
			else if (PlayerPrefs.GetInt("DiffData") == 0)
			{
				seeRange = 300f;
			}
			else
			{
				seeRange = 100f;
			}
		}
		else if (((playerCrawl)playerCrouch.GetComponent(typeof(playerCrawl))).PlayerHukarSig && !((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerHiding)
		{
			if (PlayerPrefs.GetInt("DiffData") == 2 || PlayerPrefs.GetInt("DiffData") == 3)
			{
				seeRange = 600f;
			}
			else if (PlayerPrefs.GetInt("DiffData") == 0)
			{
				seeRange = 500f;
			}
			else
			{
				seeRange = 150f;
			}
		}
		else if (!((playerCrawl)playerCrouch.GetComponent(typeof(playerCrawl))).PlayerHukarSig && ((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerHiding)
		{
			if (PlayerPrefs.GetInt("DiffData") == 2 || PlayerPrefs.GetInt("DiffData") == 3)
			{
				seeRange = 600f;
			}
			else if (PlayerPrefs.GetInt("DiffData") == 0)
			{
				seeRange = 500f;
			}
			else
			{
				seeRange = 150f;
			}
		}
		else if (!((playerCrawl)playerCrouch.GetComponent(typeof(playerCrawl))).PlayerHukarSig && !((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerHiding)
		{
			if (PlayerPrefs.GetInt("DiffData") == 2 || PlayerPrefs.GetInt("DiffData") == 3)
			{
				seeRange = 800f;
			}
			else if (PlayerPrefs.GetInt("DiffData") == 0)
			{
				seeRange = 700f;
			}
			else
			{
				seeRange = 200f;
			}
		}
		if (!Physics.Linecast(myTransform.position, target.position, out hitInfo, layerMask))
		{
			return;
		}
		if (hitInfo.collider.gameObject.name == target.name)
		{
			if (!(sqrMagnitude < seeRange))
			{
				return;
			}
			if (vector.z > 0f && vector.x > 0f && vector.x < 1f && vector.y > 0f && vector.y < 1f)
			{
				if (!((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerInPrison && !((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerInHole)
				{
					((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).seePlayer = true;
				}
			}
			else
			{
				((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).seePlayer = false;
			}
		}
		else
		{
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).seePlayer = false;
		}
	}
}

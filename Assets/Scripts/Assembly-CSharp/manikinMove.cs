using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class manikinMove : MonoBehaviour
{
	public bool startStopMoving;

	public bool soundPlayed;

	public Transform player;

	public int damping;

	public GameObject soundHolder;

	public GameObject gameController;

	public manikinMove()
	{
		damping = 2;
	}

	public virtual void Start()
	{
		player = GameObject.Find("Player").transform;
		soundHolder = GameObject.Find("SoundEffects");
		gameController = GameObject.Find("GameController");
	}

	public virtual void Update()
	{
		if (startStopMoving)
		{
			Vector3 forward = player.position - base.transform.position;
			forward.y = 0f;
			Quaternion b = Quaternion.LookRotation(forward);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b, Time.deltaTime * (float)damping);
		}
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			startStopMoving = true;
			if (!soundPlayed)
			{
				soundPlayed = true;
				((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).manakinLook();
			}
			StartCoroutine(Timer());
		}
	}

	public virtual IEnumerator Timer()
	{
		yield return new WaitForSeconds(5f);
		startStopMoving = false;
		yield return new WaitForSeconds(30f);
		UnityEngine.Object.Destroy(base.gameObject);
	}
}

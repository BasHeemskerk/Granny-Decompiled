using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class moveTunnellock : MonoBehaviour
{
	public bool LockMoved;

	public AudioClip ObjectLjud;

	public virtual void Start()
	{
	}

	public virtual IEnumerator OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player" && !LockMoved)
		{
			LockMoved = true;
			base.gameObject.GetComponent<Animation>().Play("TunnelLock");
			GetComponent<AudioSource>().PlayOneShot(ObjectLjud);
			Physics.IgnoreCollision(GetComponent<Collider>(), other.GetComponent<Collider>(), true);
			yield return new WaitForSeconds(20f);
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}

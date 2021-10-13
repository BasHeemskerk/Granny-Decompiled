using System;
using UnityEngine;

[Serializable]
public class stopGranny : MonoBehaviour
{
	public GameObject planka1;

	public GameObject planka2;

	public GameObject planka3;

	public AudioClip taBortPlanka;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "granny")
		{
			if (GameObject.Find("PlankaVind") != null)
			{
				((Rigidbody)planka1.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
				planka1.GetComponent<Collider>().gameObject.tag = "plankawalk";
				GetComponent<AudioSource>().PlayOneShot(taBortPlanka);
			}
			if (GameObject.Find("PlankaVind2") != null)
			{
				((Rigidbody)planka2.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
				planka2.GetComponent<Collider>().gameObject.tag = "plankawalk";
				GetComponent<AudioSource>().PlayOneShot(taBortPlanka);
			}
			if (GameObject.Find("PlankaVind3") != null)
			{
				((Rigidbody)planka3.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
				planka3.GetComponent<Collider>().gameObject.tag = "plankawalk";
				GetComponent<AudioSource>().PlayOneShot(taBortPlanka);
			}
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}

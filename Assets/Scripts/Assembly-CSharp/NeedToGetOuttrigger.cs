using System;
using UnityEngine;

[Serializable]
public class NeedToGetOuttrigger : MonoBehaviour
{
	public GameObject needToGetOutText;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			needToGetOutText.SetActive(true);
			((TextInactivate)needToGetOutText.GetComponent(typeof(TextInactivate))).travelDown = true;
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}

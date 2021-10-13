using System;
using UnityEngine;

[Serializable]
public class SeeDooropener : MonoBehaviour
{
	public GameObject yellowRay1;

	public GameObject hitDoorButton;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		RaycastHit hitInfo = default(RaycastHit);
		Vector3 vector = yellowRay1.transform.TransformDirection(Vector3.forward);
		Debug.DrawRay(yellowRay1.transform.position, vector * 3f, Color.yellow);
		if (Physics.Raycast(yellowRay1.transform.position, vector, out hitInfo, 4f))
		{
			if (hitInfo.collider.gameObject.tag == "dooropener")
			{
				hitDoorButton.SetActive(true);
			}
			else if (hitInfo.collider.gameObject.tag == "Untagged")
			{
				hitDoorButton.SetActive(false);
			}
		}
		else
		{
			hitDoorButton.SetActive(false);
		}
	}
}

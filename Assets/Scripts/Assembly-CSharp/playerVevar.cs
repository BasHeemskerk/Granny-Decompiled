using System;
using UnityEngine;

[Serializable]
public class playerVevar : MonoBehaviour
{
	public int layerMask;

	public bool playerHoldButton;

	public GameObject brunnsVevButton;

	public GameObject doorRay;

	public bool playerTaken;

	public bool playSound;

	public GameObject rope;

	public GameObject winch;

	public bool noMoreVev;

	public bool vevInPlace;

	public GameObject brunnsLjud;

	public playerVevar()
	{
		layerMask = 256;
	}

	public virtual void Start()
	{
		layerMask = ~layerMask;
	}

	public virtual void Update()
	{
		RaycastHit hitInfo = default(RaycastHit);
		if (!vevInPlace || noMoreVev)
		{
			return;
		}
		Vector3 direction = doorRay.transform.TransformDirection(Vector3.forward);
		if (!playerTaken)
		{
			if (Physics.Raycast(doorRay.transform.position, direction, out hitInfo, 4f, layerMask))
			{
				if (hitInfo.collider.gameObject.tag == "brunnsvev")
				{
					brunnsVevButton.SetActive(true);
					if (playerHoldButton)
					{
						hitInfo.collider.gameObject.transform.Rotate(0f, 0f, 0.8f, Space.Self);
						winch.gameObject.transform.Rotate(0f, 0f, 0.8f, Space.Self);
						rope.transform.Translate(-Vector3.forward * Time.deltaTime * 0.5f, Space.Self);
						((vevarBrunnLjud)brunnsLjud.GetComponent(typeof(vevarBrunnLjud))).PlayerVevar = true;
					}
				}
				else if (hitInfo.collider.gameObject.tag == "grus")
				{
					brunnsVevButton.SetActive(false);
					playerHoldButton = false;
					((vevarBrunnLjud)brunnsLjud.GetComponent(typeof(vevarBrunnLjud))).PlayerVevar = false;
				}
				else if (hitInfo.collider.gameObject.tag == "Untagged")
				{
					brunnsVevButton.SetActive(false);
					playerHoldButton = false;
					((vevarBrunnLjud)brunnsLjud.GetComponent(typeof(vevarBrunnLjud))).PlayerVevar = false;
				}
			}
			else
			{
				brunnsVevButton.SetActive(false);
				playerHoldButton = false;
				((vevarBrunnLjud)brunnsLjud.GetComponent(typeof(vevarBrunnLjud))).PlayerVevar = false;
			}
		}
		else
		{
			brunnsVevButton.SetActive(false);
			playerHoldButton = false;
			((vevarBrunnLjud)brunnsLjud.GetComponent(typeof(vevarBrunnLjud))).PlayerVevar = false;
		}
	}
}

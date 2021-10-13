using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class fillingFuel : MonoBehaviour
{
	public int layerMask;

	public GameObject gameController;

	public bool playerHoldButton;

	public GameObject fillFuelButton;

	public GameObject fillFuelMeter;

	public Image fillFuealBar;

	public GameObject doorRay;

	public bool playerTaken;

	public bool playSound;

	public bool noMoreFill;

	public GameObject pickUpHolder;

	public GameObject tanklockAnim;

	public GameObject fillingGasSoundHolder;

	public bool tanklockAnimPlayed;

	public fillingFuel()
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
		if (noMoreFill)
		{
			return;
		}
		Vector3 direction = doorRay.transform.TransformDirection(Vector3.forward);
		if (!playerTaken)
		{
			if (Physics.Raycast(doorRay.transform.position, direction, out hitInfo, 4f, layerMask))
			{
				if (hitInfo.collider.gameObject.tag == "fueltankPlace")
				{
					if (!((PickUp)pickUpHolder.GetComponent(typeof(PickUp))).havegascan)
					{
						return;
					}
					fillFuelMeter.SetActive(true);
					fillFuelButton.SetActive(true);
					if (playerHoldButton)
					{
						fillingGasSoundHolder.SetActive(true);
						if (!tanklockAnimPlayed)
						{
							tanklockAnimPlayed = true;
							tanklockAnim.GetComponent<Animation>().Play("tanklockOpen");
						}
						fillFuealBar.fillAmount += 0.1f * Time.deltaTime;
						if (fillFuealBar.fillAmount >= 1f)
						{
							((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).fuelOK = true;
							fillFuelMeter.SetActive(false);
							fillFuelButton.SetActive(false);
							UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
							tanklockAnim.GetComponent<Animation>().Play("tanklockClose");
							fillingGasSoundHolder.SetActive(false);
						}
					}
					else
					{
						fillingGasSoundHolder.SetActive(false);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "golv")
				{
					fillFuelButton.SetActive(false);
					fillFuelMeter.SetActive(false);
					playerHoldButton = false;
					fillingGasSoundHolder.SetActive(false);
				}
				else if (hitInfo.collider.gameObject.tag == "Untagged")
				{
					fillFuelButton.SetActive(false);
					fillFuelMeter.SetActive(false);
					playerHoldButton = false;
					fillingGasSoundHolder.SetActive(false);
				}
			}
			else
			{
				fillFuelButton.SetActive(false);
				fillFuelMeter.SetActive(false);
				playerHoldButton = false;
				fillingGasSoundHolder.SetActive(false);
			}
		}
		else
		{
			fillFuelButton.SetActive(false);
			fillFuelMeter.SetActive(false);
			playerHoldButton = false;
			fillingGasSoundHolder.SetActive(false);
		}
	}
}

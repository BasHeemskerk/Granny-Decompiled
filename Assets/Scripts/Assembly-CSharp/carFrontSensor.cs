using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class carFrontSensor : MonoBehaviour
{
	public GameObject gameController;

	public GameObject forwardButton;

	public GameObject ReverseButton;

	public GameObject outOffCarButton;

	public bool garagedoorOpen;

	public float hitGaragedoorCounter;

	public GameObject brickWallStart;

	public GameObject brickWallBroken;

	public GameObject mittPrick;

	public Texture2D brokenTextureMin;

	public Texture2D brokenTextureMax;

	public GameObject camInCar;

	public GameObject escapeCam;

	public GameObject escapeCamNoGranny;

	public GameObject granny;

	public GameObject dust1;

	public GameObject dust2;

	public GameObject headAnim;

	public GameObject carForwardSound;

	public GameObject engineOnSound;

	public GameObject crashSound;

	public GameObject crashSoundPort;

	public GameObject CarHitTriggers;

	public GameObject shouldOpenDoorFirstText;

	public GameObject optionButton;

	public bool textTimerOnOff;

	public float textTimer;

	public bool textShown;

	public virtual void Update()
	{
		if (textTimerOnOff)
		{
			textTimer += Time.deltaTime;
			if (textTimer > 3f)
			{
				textTimerOnOff = false;
				textTimer = 0f;
				shouldOpenDoorFirstText.SetActive(false);
			}
		}
	}

	public virtual IEnumerator OnTriggerEnter(Collider other)
	{
		if (!(other.gameObject.tag == "car"))
		{
			yield break;
		}
		((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).reverseOK = true;
		((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).forwardOK = false;
		if (garagedoorOpen)
		{
			if (hitGaragedoorCounter == 1f)
			{
				brickWallStart.GetComponent<Renderer>().material.mainTexture = brokenTextureMax;
				hitGaragedoorCounter += 1f;
				dust2.SetActive(true);
				headAnim.GetComponent<Animation>().Play("HeadForward");
				carForwardSound.SetActive(false);
				engineOnSound.SetActive(true);
				crashSound.SetActive(true);
				CarHitTriggers.SetActive(false);
				yield return new WaitForSeconds(1f);
				forwardButton.SetActive(false);
				ReverseButton.SetActive(true);
				optionButton.SetActive(true);
				outOffCarButton.SetActive(true);
				carForwardSound.SetActive(false);
				engineOnSound.SetActive(true);
				crashSound.SetActive(true);
			}
			else if (hitGaragedoorCounter == 2f)
			{
				brickWallStart.SetActive(false);
				brickWallBroken.SetActive(true);
				mittPrick.SetActive(false);
				camInCar.SetActive(false);
				granny.SetActive(false);
				if (PlayerPrefs.GetInt("DiffData") == 4)
				{
					escapeCamNoGranny.SetActive(true);
					RenderSettings.fog = false;
					optionButton.SetActive(false);
					if ((bool)GameObject.Find("GrannyRagdoll(Clone)"))
					{
						UnityEngine.Object.Destroy(GameObject.Find("GrannyRagdoll(Clone)"));
					}
				}
				else
				{
					escapeCam.SetActive(true);
					RenderSettings.fog = false;
					optionButton.SetActive(false);
					if ((bool)GameObject.Find("GrannyRagdoll(Clone)"))
					{
						UnityEngine.Object.Destroy(GameObject.Find("GrannyRagdoll(Clone)"));
					}
				}
				crashSound.SetActive(true);
				CarHitTriggers.SetActive(false);
			}
			else
			{
				hitGaragedoorCounter += 1f;
				brickWallStart.GetComponent<Renderer>().material.mainTexture = brokenTextureMin;
				dust1.SetActive(true);
				headAnim.GetComponent<Animation>().Play("HeadForward");
				carForwardSound.SetActive(false);
				engineOnSound.SetActive(true);
				crashSound.SetActive(true);
				CarHitTriggers.SetActive(false);
				yield return new WaitForSeconds(1f);
				forwardButton.SetActive(false);
				ReverseButton.SetActive(true);
				outOffCarButton.SetActive(true);
				optionButton.SetActive(true);
			}
		}
		else
		{
			headAnim.GetComponent<Animation>().Play("HeadForward");
			carForwardSound.SetActive(false);
			engineOnSound.SetActive(true);
			crashSoundPort.SetActive(true);
			CarHitTriggers.SetActive(false);
			yield return new WaitForSeconds(1f);
			forwardButton.SetActive(false);
			ReverseButton.SetActive(true);
			outOffCarButton.SetActive(true);
			optionButton.SetActive(true);
			if (!textShown)
			{
				textShown = true;
				textTimer = 0f;
				shouldOpenDoorFirstText.SetActive(true);
				textTimerOnOff = true;
			}
		}
	}
}

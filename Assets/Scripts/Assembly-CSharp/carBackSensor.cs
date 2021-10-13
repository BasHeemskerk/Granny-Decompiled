using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class carBackSensor : MonoBehaviour
{
	public GameObject gameController;

	public GameObject forwardButton;

	public GameObject ReverseButton;

	public GameObject baklucka;

	public bool bakluckaLoss;

	public GameObject outOffCarButton;

	public GameObject headAnim;

	public GameObject carReverseSound1;

	public GameObject engineOnSound;

	public GameObject crashSound;

	public GameObject CarHitTriggers;

	public GameObject optionButton;

	public virtual IEnumerator OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "car")
		{
			((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).reverseOK = false;
			((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).forwardOK = true;
			headAnim.GetComponent<Animation>().Play("HeadBackward");
			forwardButton.SetActive(true);
			ReverseButton.SetActive(false);
			outOffCarButton.SetActive(true);
			optionButton.SetActive(true);
			carReverseSound1.SetActive(false);
			engineOnSound.SetActive(true);
			crashSound.SetActive(true);
			CarHitTriggers.SetActive(false);
			if (!bakluckaLoss)
			{
				bakluckaLoss = true;
				baklucka.transform.parent = null;
				((Rigidbody)baklucka.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
				baklucka.gameObject.tag = "Untagged";
				yield return new WaitForSeconds(8f);
				UnityEngine.Object.Destroy(baklucka);
			}
		}
	}
}

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class playerDead : MonoBehaviour
{
	public Image blackScreenTexture;

	public float fadeBlackSpeed;

	public GameObject cam1;

	public GameObject cam2;

	public GameObject endScene2;

	public GameObject player;

	public GameObject granny;

	public GameObject grannyOverPlayer;

	public GameObject grannyOverPlayerAnim;

	public Transform GrannyEndPos;

	public GameObject cellarDoor;

	public GameObject gameController;

	public GameObject bloodscreenEnd;

	public GameObject gameOverText;

	public Image gameOverTexture;

	public GameObject soundHolder;

	public GameObject musicHolder;

	public GameObject BGnoiceHolder;

	public GameObject playerInBed;

	public bool endSceneRunning;

	public bool endSceneRunning2;

	public GameObject giljoAnimHolder;

	public GameObject giljoSoundHolder;

	public GameObject grannyAnimHolder;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
	}

	public virtual IEnumerator startEndScene()
	{
		if ((bool)GameObject.Find("GrannyRagdoll(Clone)"))
		{
			UnityEngine.Object.Destroy(GameObject.Find("GrannyRagdoll(Clone)"));
		}
		endSceneRunning = true;
		playerInBed.SetActive(false);
		bloodscreenEnd.SetActive(true);
		soundHolder.SetActive(true);
		cam1.SetActive(true);
		cellarDoor.SetActive(false);
		granny.SetActive(false);
		granny.transform.position = GrannyEndPos.position;
		granny.transform.rotation = GrannyEndPos.rotation;
		granny.SetActive(true);
		musicHolder.SetActive(false);
		blackScreenTexture.CrossFadeAlpha(0f, 2f, false);
		yield return new WaitForSeconds(0.9f);
		((playerInBeartrap)gameController.GetComponent(typeof(playerInBeartrap))).playerHit();
		yield return new WaitForSeconds(4f);
		blackScreenTexture.CrossFadeAlpha(1f, 0.5f, false);
		yield return new WaitForSeconds(2f);
		player.SetActive(false);
		cam1.SetActive(false);
		cam2.SetActive(true);
		yield return new WaitForSeconds(1f);
		blackScreenTexture.CrossFadeAlpha(0f, 3.5f, false);
		yield return new WaitForSeconds(3.2f);
		yield return new WaitForSeconds(4.1f);
		grannyOverPlayer.SetActive(true);
		grannyOverPlayerAnim.GetComponent<Animation>()["GrannyEnd"].speed = 3f;
		yield return new WaitForSeconds(0.7f);
		blackScreenTexture.CrossFadeAlpha(1f, 0.2f, false);
		yield return new WaitForSeconds(3f);
		gameOverText.SetActive(true);
		yield return new WaitForSeconds(4f);
		gameOverTexture.CrossFadeAlpha(0f, 2.2f, false);
		yield return new WaitForSeconds(3f);
		((FetchAds)gameController.GetComponent(typeof(FetchAds))).toMainMenu();
	}

	public virtual IEnumerator startEndScene2()
	{
		if ((bool)GameObject.Find("GrannyRagdoll(Clone)"))
		{
			UnityEngine.Object.Destroy(GameObject.Find("GrannyRagdoll(Clone)"));
		}
		endSceneRunning2 = true;
		playerInBed.SetActive(false);
		bloodscreenEnd.SetActive(true);
		BGnoiceHolder.SetActive(false);
		endScene2.SetActive(true);
		cellarDoor.SetActive(false);
		granny.SetActive(false);
		musicHolder.SetActive(false);
		blackScreenTexture.CrossFadeAlpha(0f, 6f, false);
		yield return new WaitForSeconds(9.5f);
		grannyAnimHolder.GetComponent<Animation>().CrossFade("GrannyLooking");
		yield return new WaitForSeconds(2.1f);
		giljoSoundHolder.SetActive(true);
		giljoAnimHolder.GetComponent<Animation>().Play("giljotinOn");
		grannyAnimHolder.GetComponent<Animation>().CrossFade("GrannyPullGiljotin");
		yield return new WaitForSeconds(0.9f);
		blackScreenTexture.CrossFadeAlpha(1f, 0.1f, false);
		yield return new WaitForSeconds(3f);
		gameOverText.SetActive(true);
		yield return new WaitForSeconds(4f);
		gameOverTexture.CrossFadeAlpha(0f, 2.2f, false);
		yield return new WaitForSeconds(3f);
		((FetchAds)gameController.GetComponent(typeof(FetchAds))).toMainMenu();
	}

	public virtual IEnumerator gameOverNoGranny()
	{
		gameOverText.SetActive(true);
		yield return new WaitForSeconds(4f);
		gameOverTexture.CrossFadeAlpha(0f, 2.2f, false);
		yield return new WaitForSeconds(3f);
		((FetchAds)gameController.GetComponent(typeof(FetchAds))).toMainMenu();
	}
}

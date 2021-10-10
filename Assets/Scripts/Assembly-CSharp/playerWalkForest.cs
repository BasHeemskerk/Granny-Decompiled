using System.Collections;
using UnityEngine;
//using UnityEngine.PostProcessing;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playerWalkForest : MonoBehaviour
{
	public Image m_Image;

	private bool m_Fading;

	private bool startFading;

	private bool DOF;

	public GameObject granny;

	public GameObject grannyAnim;

	//public PostProcessingProfile PlayerInForest;

	public AudioClip GrannyHit;

	public GameObject bloodScreenHolder;

	public GameObject skipText;

	public GameObject sparkle;

	public GameObject music;

	public GameObject music2;

	public virtual void Start()
	{
		StartCoroutine("fading");
	}

	private IEnumerator fading()
	{
		Cursor.visible = false;
		Screen.lockCursor = true;
		/*
		DepthOfFieldModel.Settings dof = PlayerInForest.depthOfField.settings;
		dof.focusDistance = 2.43f;
		dof.aperture = 10.5f;
		if (PlayerPrefs.GetInt("EffectsOnOff") == 1)
		{
			PlayerInForest.depthOfField.enabled = true;
			PlayerInForest.ambientOcclusion.enabled = true;
			PlayerInForest.motionBlur.enabled = true;
			PlayerInForest.vignette.enabled = true;
			PlayerInForest.depthOfField.settings = dof;
		}
		else if (PlayerPrefs.GetInt("EffectsOnOff") == 0)
		{
			PlayerInForest.depthOfField.enabled = false;
			PlayerInForest.ambientOcclusion.enabled = false;
			PlayerInForest.motionBlur.enabled = false;
			PlayerInForest.vignette.enabled = false;
		}
		*/
		yield return new WaitForSeconds(4f);
		startFading = true;
		yield return new WaitForSeconds(2f);
		skipText.SetActive(true);
		yield return new WaitForSeconds(19f);
		music.SetActive(true);
		sparkle.SetActive(true);
		yield return new WaitForSeconds(4f);
		sparkle.SetActive(false);
		yield return new WaitForSeconds(24f);
		granny.SetActive(true);
		yield return new WaitForSeconds(0.9f);
		music2.SetActive(true);
		//dof.focusDistance = 0.78f;
		//dof.aperture = 17.7f;
		if (PlayerPrefs.GetInt("EffectsOnOff") == 1)
		{
			//PlayerInForest.depthOfField.settings = dof;
		}
		else if (PlayerPrefs.GetInt("EffectsOnOff") == 0)
		{
			//PlayerInForest.depthOfField.enabled = false;
		}
		yield return new WaitForSeconds(1.5f);
		grannyAnim.GetComponent<Animation>().CrossFade("Hit");
		GetComponent<AudioSource>().PlayOneShot(GrannyHit);
		yield return new WaitForSeconds(0.9f);
		bloodScreenHolder.SetActive(true);
		yield return new WaitForSeconds(1.1f);
		m_Fading = true;
		yield return new WaitForSeconds(5f);
		SceneManager.LoadScene("Scene");
	}

	private void Update()
	{
		if (startFading)
		{
			if (m_Fading)
			{
				m_Image.CrossFadeAlpha(1f, 0.7f, false);
			}
			if (!m_Fading)
			{
				m_Image.CrossFadeAlpha(0f, 5f, false);
			}
		}
	}
}

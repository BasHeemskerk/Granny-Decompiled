using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class splashScreenStart : MonoBehaviour
{
	public AudioClip sound;

	public AudioClip sound2;

	public Sprite dvloperVanlig;

	public Sprite dvloperUtsmetad;

	public Image dvloper;

	private void Start()
	{
		Cursor.visible = false;
		Screen.lockCursor = true;
		StartCoroutine(readyToStart());
	}

	public virtual IEnumerator readyToStart()
	{
		yield return new WaitForSeconds(1.6f);
		GetComponent<AudioSource>().PlayOneShot(sound);
		yield return new WaitForSeconds(3.6f);
		GetComponent<AudioSource>().PlayOneShot(sound);
		yield return new WaitForSeconds(3.4f);
		GetComponent<AudioSource>().PlayOneShot(sound2);
		yield return new WaitForSeconds(2f);
		dvloper.sprite = dvloperUtsmetad;
		yield return new WaitForSeconds(0.05f);
		dvloper.sprite = dvloperVanlig;
		yield return new WaitForSeconds(5f);
		SceneManager.LoadScene("Menu");
	}
}

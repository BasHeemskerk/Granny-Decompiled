using UnityEngine;
using UnityEngine.SceneManagement;

public class clickSkipButton : MonoBehaviour
{
	private bool buttonPressed;

	public GameObject blackLoadingScreen;

	public GameObject sound;

	public void Update()
	{
		if (Input.GetKeyDown(KeyCode.JoystickButton0) && !buttonPressed)
		{
			buttonPressed = true;
			blackLoadingScreen.SetActive(true);
			sound.SetActive(false);
			Resources.UnloadUnusedAssets();
			SceneManager.LoadScene("Scene");
		}
	}
}

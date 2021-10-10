using UnityEngine;
using UnityEngine.UI;

public class clickMainMenuButton : MonoBehaviour
{
	public Button btn1;

	public Button menuButton;

	public Button ResumeButton;

	public GameObject AreYouSureMenu;

	public virtual void Start()
	{
		btn1.onClick.AddListener(TaskOnClick);
	}

	private void TaskOnClick()
	{
		AreYouSureMenu.SetActive(true);
		menuButton.interactable = false;
		ResumeButton.interactable = false;
	}
}

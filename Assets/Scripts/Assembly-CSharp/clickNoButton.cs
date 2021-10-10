using UnityEngine;
using UnityEngine.UI;

public class clickNoButton : MonoBehaviour
{
	public Button btn1;

	public GameObject AreYouSureMenu;

	public Button menuButton;

	public Button ResumeButton;

	public float height;

	public float width;

	public virtual void Start()
	{
		btn1.onClick.AddListener(TaskOnClick);
	}

	private void TaskOnClick()
	{
		btn1.GetComponent<RectTransform>().sizeDelta = new Vector2(width, height);
		AreYouSureMenu.SetActive(false);
		menuButton.interactable = true;
		ResumeButton.interactable = true;
	}
}

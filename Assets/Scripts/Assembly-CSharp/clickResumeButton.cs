using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class clickResumeButton : MonoBehaviour
{
	public GameObject optionMenu;

	public GameObject player;

	private bool buttonPressed;

	public Button btn1;

	public virtual void Start()
	{
		btn1.onClick.AddListener(TaskOnClick);
	}

	private void TaskOnClick()
	{
		Time.timeScale = 1f;
		Cursor.visible = false;
		Screen.lockCursor = true;
		((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).menuEnabled = false;
		btn1.GetComponent<RectTransform>().sizeDelta = new Vector2(160f, 30f);
		optionMenu.SetActive(false);
	}
}

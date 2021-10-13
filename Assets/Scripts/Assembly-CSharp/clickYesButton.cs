using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class clickYesButton : MonoBehaviour
{
	public Button btn1;

	public virtual void Start()
	{
		btn1.onClick.AddListener(TaskOnClick);
	}

	private void TaskOnClick()
	{
		btn1.GetComponent<RectTransform>().sizeDelta = new Vector2(160f, 30f);
		SceneManager.LoadScene("Menu");
	}
}

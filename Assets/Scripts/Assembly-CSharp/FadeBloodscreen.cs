using UnityEngine;
using UnityEngine.UI;

public class FadeBloodscreen : MonoBehaviour
{
	public Image bloodScreen;

	private void Start()
	{
		bloodScreen.CrossFadeAlpha(0f, 6f, false);
	}
}

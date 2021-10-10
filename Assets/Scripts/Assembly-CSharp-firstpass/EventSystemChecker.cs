using UnityEngine;
using UnityEngine.EventSystems;

public class EventSystemChecker : MonoBehaviour
{
	private void Awake()
	{
		if (!Object.FindObjectOfType<EventSystem>())
		{
			GameObject gameObject = new GameObject("EventSystem");
			gameObject.AddComponent<EventSystem>();
			gameObject.AddComponent<StandaloneInputModule>().forceModuleActive = true;
		}
	}
}

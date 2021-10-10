using UnityEngine;
using UnityEngine.EventSystems;

public class clickBeartrapMenu : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	public GameObject granny;

	public GameObject beartrapOpen;

	public GameObject beartrapClose;

	public GameObject SoundHolder;

	public bool beartrapOK;

	public void OnPointerClick(PointerEventData eventData)
	{
		if (eventData.pointerCurrentRaycast.gameObject != null && !beartrapOK)
		{
			beartrapOK = true;
			beartrapClose.SetActive(true);
			granny.GetComponent<Animation>().CrossFade("Look");
			((ButtonClicks)SoundHolder.GetComponent(typeof(ButtonClicks))).beartrap();
			beartrapOpen.SetActive(false);
		}
	}
}

using UnityEngine;
using UnityEngine.EventSystems;

public class OnMouseOver : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IEventSystemHandler
{
	private GameObject currentHover;

	public float Bheight;

	public float Bwidth;

	public float height;

	public float width;

	public virtual void Start()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
		if (eventData.pointerCurrentRaycast.gameObject != null)
		{
			currentHover = eventData.pointerCurrentRaycast.gameObject;
			currentHover.GetComponent<RectTransform>().sizeDelta = new Vector2(Bwidth, Bheight);
		}
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		currentHover.GetComponent<RectTransform>().sizeDelta = new Vector2(width, height);
		currentHover = null;
	}
}

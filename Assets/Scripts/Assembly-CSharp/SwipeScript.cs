using UnityEngine;

public class SwipeScript : MonoBehaviour
{
	private float fingerStartTime;

	private Vector2 fingerStartPos = Vector2.zero;

	private bool isSwipe;

	private float minSwipeDist = 50f;

	private float maxSwipeTime = 3.5f;

	public GameObject animationHolder;

	private void Update()
	{
		if (Input.touchCount <= 0)
		{
			return;
		}
		Touch[] touches = Input.touches;
		for (int i = 0; i < touches.Length; i++)
		{
			Touch touch = touches[i];
			switch (touch.phase)
			{
			case TouchPhase.Ended:
				isSwipe = true;
				fingerStartTime = Time.time;
				fingerStartPos = touch.position;
				break;
			case TouchPhase.Canceled:
				isSwipe = false;
				break;
			case TouchPhase.Began:
			{
				float num = Time.time - fingerStartTime;
				float magnitude = (touch.position - fingerStartPos).magnitude;
				if (!isSwipe || !(num < maxSwipeTime) || !(magnitude > minSwipeDist))
				{
					break;
				}
				Vector2 vector = touch.position - fingerStartPos;
				Vector2 zero = Vector2.zero;
				zero = ((!(Mathf.Abs(vector.x) > Mathf.Abs(vector.y))) ? (Vector2.up * Mathf.Sign(vector.y)) : (Vector2.right * Mathf.Sign(vector.x)));
				if (zero.x != 0f)
				{
					if (zero.x > 0f)
					{
						Debug.Log("Right");
					}
					else
					{
						Debug.Log("Left");
					}
				}
				if (zero.y != 0f && !(zero.y > 0f))
				{
				}
				break;
			}
			}
		}
	}
}

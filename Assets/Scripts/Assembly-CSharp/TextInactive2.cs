using System;
using UnityEngine;

[Serializable]
public class TextInactive2 : MonoBehaviour
{
	public bool travelDown;

	public float timer;

	public TextInactive2()
	{
		timer = 3f;
	}

	public virtual void Start()
	{
		float y = 14.27f;
		Vector3 localPosition = base.transform.localPosition;
		localPosition.y = y;
		base.transform.localPosition = localPosition;
		travelDown = true;
	}

	public virtual void Update()
	{
		if (travelDown)
		{
			timer -= Time.deltaTime;
			float y = base.transform.localPosition.y - 0.001f;
			Vector3 localPosition = base.transform.localPosition;
			localPosition.y = y;
			base.transform.localPosition = localPosition;
		}
		if (timer < 0f)
		{
			travelDown = false;
			timer = 3f;
			float y2 = 14.27f;
			Vector3 localPosition2 = base.transform.localPosition;
			localPosition2.y = y2;
			base.transform.localPosition = localPosition2;
			base.gameObject.SetActive(false);
		}
	}
}

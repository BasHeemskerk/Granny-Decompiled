using System;
using UnityEngine;

[Serializable]
public class movePlatta : MonoBehaviour
{
	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		RaycastHit hitInfo = default(RaycastHit);
		for (int i = 0; i < Input.touchCount; i++)
		{
			if (Input.GetTouch(i).phase == TouchPhase.Began)
			{
				Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
				if (Physics.Raycast(ray, out hitInfo, 8f) && hitInfo.collider.gameObject.tag == "platta")
				{
					((plattaflyttas)hitInfo.collider.gameObject.GetComponent(typeof(plattaflyttas))).MovePlatta();
					Debug.Log("Moving platta");
				}
			}
		}
	}
}

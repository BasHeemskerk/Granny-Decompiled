using System;
using UnityEngine;

[Serializable]
public class doorSlide : MonoBehaviour
{
	public bool plattaTryck;

	public bool maxH;

	public bool maxV;

	public AudioClip slidingDoor;

	public bool stopsound;

	public bool startsound;

	public virtual void Start()
	{
		float x = 20.60735f;
		Vector3 position = base.gameObject.transform.position;
		position.x = x;
		base.gameObject.transform.position = position;
	}

	public virtual void Update()
	{
		if (plattaTryck)
		{
			if (!maxH)
			{
				float x = base.gameObject.transform.position.x - 3f * Time.deltaTime;
				Vector3 position = base.gameObject.transform.position;
				position.x = x;
				base.gameObject.transform.position = position;
			}
		}
		else if (!plattaTryck && !maxV)
		{
			float x2 = base.gameObject.transform.position.x - -3f * Time.deltaTime;
			Vector3 position2 = base.gameObject.transform.position;
			position2.x = x2;
			base.gameObject.transform.position = position2;
		}
		if (base.gameObject.transform.position.x <= 16.31f)
		{
			maxH = true;
			StopSound();
		}
		else if (base.gameObject.transform.position.x > 16.31f && base.gameObject.transform.position.x < 20.60735f)
		{
			stopsound = false;
			maxH = false;
		}
		if (base.gameObject.transform.position.x >= 20.60735f)
		{
			maxV = true;
			StopSound();
		}
		else if (base.gameObject.transform.position.x < 20.60735f && base.gameObject.transform.position.x > 16.31f)
		{
			stopsound = false;
			maxV = false;
		}
	}

	public virtual void StartSound()
	{
		GetComponent<AudioSource>().Play();
		startsound = true;
	}

	public virtual void StopSound()
	{
		if (!stopsound)
		{
			stopsound = true;
			GetComponent<AudioSource>().Stop();
		}
	}
}

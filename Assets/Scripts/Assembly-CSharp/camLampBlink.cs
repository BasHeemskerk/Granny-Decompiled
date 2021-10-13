using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class camLampBlink : MonoBehaviour
{
	public bool startBlink;

	public bool soundOff;

	public Texture red;

	public Texture grey;

	public AudioClip pipljud;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (startBlink)
		{
			startBlink = false;
			StartCoroutine(blinking());
		}
	}

	public virtual IEnumerator blinking()
	{
		if (!soundOff)
		{
			base.gameObject.GetComponent<Renderer>().material.mainTexture = grey;
			yield return new WaitForSeconds(0.5f);
			base.gameObject.GetComponent<Renderer>().material.mainTexture = red;
			if (!soundOff)
			{
				GetComponent<AudioSource>().PlayOneShot(pipljud);
			}
			yield return new WaitForSeconds(0.5f);
			startBlink = true;
		}
		else
		{
			base.gameObject.GetComponent<Renderer>().material.mainTexture = grey;
		}
	}
}

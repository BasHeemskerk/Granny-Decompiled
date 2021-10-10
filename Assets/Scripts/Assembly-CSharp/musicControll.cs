using UnityEngine;

public class musicControll : MonoBehaviour
{
	public GameObject musicHolder;

	private void Start()
	{
		if (PlayerPrefs.GetInt("musikOnOff") == 0)
		{
			musicHolder.GetComponent<AudioSource>().Play();
		}
		else
		{
			musicHolder.GetComponent<AudioSource>().Stop();
		}
	}

	public virtual void setMusicOff()
	{
		PlayerPrefs.SetInt("musikOnOff", 1);
		musicHolder.GetComponent<AudioSource>().Stop();
	}

	public virtual void setMusicOn()
	{
		PlayerPrefs.SetInt("musikOnOff", 0);
		musicHolder.GetComponent<AudioSource>().Play();
	}
}

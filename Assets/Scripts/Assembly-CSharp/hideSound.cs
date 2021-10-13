using UnityEngine;

public class hideSound : MonoBehaviour
{
	public AudioClip sound;

	public void theSound()
	{
		GetComponent<AudioSource>().PlayOneShot(sound);
	}
}

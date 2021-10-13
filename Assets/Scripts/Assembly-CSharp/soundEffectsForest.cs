using UnityEngine;

public class soundEffectsForest : MonoBehaviour
{
	public AudioClip GrannyHit;

	public virtual void grannyHit()
	{
		AudioSource.PlayClipAtPoint(GrannyHit, base.transform.position);
	}
}

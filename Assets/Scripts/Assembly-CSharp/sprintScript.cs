using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class sprintScript : MonoBehaviour
{
	public bool sprintGone;

	public GameObject sparcle1;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (GetComponent<Animation>().IsPlaying("sprintAnim") && !sprintGone)
		{
			sprintGone = true;
			StartCoroutine(sprintTimer());
		}
	}

	public virtual IEnumerator sprintTimer()
	{
		yield return new WaitForSeconds(1f);
		((Rigidbody)GetComponent(typeof(Rigidbody))).isKinematic = false;
		sparcle1.SetActive(false);
		yield return new WaitForSeconds(5f);
		UnityEngine.Object.Destroy(base.gameObject);
	}
}

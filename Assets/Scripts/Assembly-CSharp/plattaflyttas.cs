using System;
using UnityEngine;

[Serializable]
public class plattaflyttas : MonoBehaviour
{
	public bool Upp;

	public bool H;

	public bool Ner;

	public bool V;

	public AudioClip flyttaPlatta;

	public virtual void update()
	{
	}

	public virtual void MovePlatta()
	{
		if (Upp)
		{
			float z = base.gameObject.transform.localPosition.z - 0.5f;
			Vector3 localPosition = base.gameObject.transform.localPosition;
			localPosition.z = z;
			base.gameObject.transform.localPosition = localPosition;
			AudioSource.PlayClipAtPoint(flyttaPlatta, base.transform.position);
		}
		else if (H)
		{
			float x = base.gameObject.transform.localPosition.x - 0.5f;
			Vector3 localPosition2 = base.gameObject.transform.localPosition;
			localPosition2.x = x;
			base.gameObject.transform.localPosition = localPosition2;
			AudioSource.PlayClipAtPoint(flyttaPlatta, base.transform.position);
		}
		else if (Ner)
		{
			float z2 = base.gameObject.transform.localPosition.z + 0.5f;
			Vector3 localPosition3 = base.gameObject.transform.localPosition;
			localPosition3.z = z2;
			base.gameObject.transform.localPosition = localPosition3;
			AudioSource.PlayClipAtPoint(flyttaPlatta, base.transform.position);
		}
		else if (V)
		{
			float x2 = base.gameObject.transform.localPosition.x + 0.5f;
			Vector3 localPosition4 = base.gameObject.transform.localPosition;
			localPosition4.x = x2;
			base.gameObject.transform.localPosition = localPosition4;
			AudioSource.PlayClipAtPoint(flyttaPlatta, base.transform.position);
		}
	}
}

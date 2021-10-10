using System;
using UnityEngine;

[Serializable]
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class CombineMesh : MonoBehaviour
{
	public virtual void Start()
	{
		MeshFilter[] componentsInChildren = GetComponentsInChildren<MeshFilter>();
		CombineInstance[] array = new CombineInstance[componentsInChildren.Length];
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			array[i].mesh = componentsInChildren[i].sharedMesh;
			array[i].transform = componentsInChildren[i].transform.localToWorldMatrix;
			componentsInChildren[i].gameObject.SetActive(false);
		}
		((MeshFilter)base.transform.GetComponent(typeof(MeshFilter))).mesh = new Mesh();
		((MeshFilter)base.transform.GetComponent(typeof(MeshFilter))).mesh.CombineMeshes(array);
		base.transform.localPosition = new Vector3(0f, 0f, 0f);
		base.gameObject.AddComponent(typeof(MeshCollider));
		base.transform.gameObject.SetActive(true);
	}
}

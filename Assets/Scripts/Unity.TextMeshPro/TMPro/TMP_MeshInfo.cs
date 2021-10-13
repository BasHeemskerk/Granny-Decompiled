using System;
using UnityEngine;

namespace TMPro
{
	public struct TMP_MeshInfo
	{
		public TMP_MeshInfo(Mesh mesh, int size) : this()
		{
		}

		public Mesh mesh;
		public int vertexCount;
		public Vector3[] vertices;
		public Vector3[] normals;
		public Vector4[] tangents;
		public Vector2[] uvs0;
		public Vector2[] uvs2;
		public Color32[] colors32;
		public int[] triangles;
	}
}

using UnityEngine;
using UnityEngine.AI;

[ExecuteInEditMode]
public class CalculatePathTest : MonoBehaviour
{
	public Transform target;

	private void OnDrawGizmos()
	{
		if (!(target == null))
		{
			NavMeshPath navMeshPath = new NavMeshPath();
			NavMesh.CalculatePath(base.transform.position, target.position, -1, navMeshPath);
			Gizmos.color = Color.red;
			Gizmos.DrawRay(base.transform.position, Vector3.up);
			Gizmos.DrawRay(target.transform.position, Vector3.up);
			Gizmos.color = Color.green;
			Vector3 vector = 0.2f * Vector3.up;
			for (int i = 1; i < navMeshPath.corners.Length; i++)
			{
				Gizmos.DrawLine(navMeshPath.corners[i - 1] + vector, navMeshPath.corners[i] + vector);
			}
		}
	}
}

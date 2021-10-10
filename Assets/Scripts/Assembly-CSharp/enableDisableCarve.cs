using System;
using UnityEngine;
using UnityEngine.AI;

[Serializable]
public class enableDisableCarve : MonoBehaviour
{
	private NavMeshObstacle Innerdoor;

	public bool doorOpenCarve;

	public virtual void Start()
	{
		Innerdoor = GetComponent<NavMeshObstacle>();
	}

	public virtual void Update()
	{
		if (doorOpenCarve)
		{
			Innerdoor.carving = base.enabled;
		}
		else if (!doorOpenCarve)
		{
			Innerdoor.carving = !base.enabled;
		}
	}
}

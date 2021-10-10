using UnityEngine;

namespace UnityStandardAssets.Water
{
	[ExecuteInEditMode]
	public class WaterTile : MonoBehaviour
	{
		public PlanarReflection reflection;

		public WaterBase waterBase;

		public void Start()
		{
			AcquireComponents();
		}

		private void AcquireComponents()
		{
			if (!reflection)
			{
				if ((bool)base.transform.parent)
				{
					reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!waterBase)
			{
				if ((bool)base.transform.parent)
				{
					waterBase = base.transform.parent.GetComponent<WaterBase>();
				}
				else
				{
					waterBase = base.transform.GetComponent<WaterBase>();
				}
			}
		}

		public void OnWillRenderObject()
		{
			if ((bool)reflection)
			{
				reflection.WaterTileBeingRendered(base.transform, Camera.current);
			}
			if ((bool)waterBase)
			{
				waterBase.WaterTileBeingRendered(base.transform, Camera.current);
			}
		}
	}
}

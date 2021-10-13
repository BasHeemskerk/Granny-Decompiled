using System;
using System.Collections;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	public class PlatformSpecificContent : MonoBehaviour
	{
		private enum BuildTargetGroup
		{
			Standalone,
			Mobile
		}

		[SerializeField]
		private BuildTargetGroup m_BuildTargetGroup;

		[SerializeField]
		private GameObject[] m_Content = new GameObject[0];

		[SerializeField]
		private MonoBehaviour[] m_MonoBehaviours = new MonoBehaviour[0];

		[SerializeField]
		private bool m_ChildrenOfThisObject;

		private void OnEnable()
		{
			CheckEnableContent();
		}

		private void CheckEnableContent()
		{
			if (m_BuildTargetGroup == BuildTargetGroup.Mobile)
			{
				EnableContent(false);
			}
			else
			{
				EnableContent(true);
			}
		}

		private void EnableContent(bool enabled)
		{
			if (m_Content.Length > 0)
			{
				GameObject[] content = m_Content;
				foreach (GameObject gameObject in content)
				{
					if (gameObject != null)
					{
						gameObject.SetActive(enabled);
					}
				}
			}
			if (m_ChildrenOfThisObject)
			{
				IEnumerator enumerator = base.transform.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Transform transform = (Transform)enumerator.Current;
						transform.gameObject.SetActive(enabled);
					}
				}
				finally
				{
					IDisposable disposable;
					if ((disposable = enumerator as IDisposable) != null)
					{
						disposable.Dispose();
					}
				}
			}
			if (m_MonoBehaviours.Length > 0)
			{
				MonoBehaviour[] monoBehaviours = m_MonoBehaviours;
				foreach (MonoBehaviour monoBehaviour in monoBehaviours)
				{
					monoBehaviour.enabled = enabled;
				}
			}
		}
	}
}

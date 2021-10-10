using System;
using System.Collections;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Serializable]
	public class LerpControlledBob
	{
		public float BobDuration;

		public float BobAmount;

		private float m_Offset;

		public float Offset()
		{
			return m_Offset;
		}

		public IEnumerator DoBobCycle()
		{
			float t2 = 0f;
			while (t2 < BobDuration)
			{
				m_Offset = Mathf.Lerp(0f, BobAmount, t2 / BobDuration);
				t2 += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			t2 = 0f;
			while (t2 < BobDuration)
			{
				m_Offset = Mathf.Lerp(BobAmount, 0f, t2 / BobDuration);
				t2 += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			m_Offset = 0f;
		}
	}
}

using System;
using UnityEngine;

namespace TMPro
{
	[Serializable]
	public class KerningPair
	{
		[SerializeField]
		private uint m_FirstGlyph;
		[SerializeField]
		private GlyphValueRecord m_FirstGlyphAdjustments;
		[SerializeField]
		private uint m_SecondGlyph;
		[SerializeField]
		private GlyphValueRecord m_SecondGlyphAdjustments;
		public float xOffset;
	}
}

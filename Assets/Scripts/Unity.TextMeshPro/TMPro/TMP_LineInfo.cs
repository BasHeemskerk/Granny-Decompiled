using System;

namespace TMPro
{
	public struct TMP_LineInfo
	{
		public int characterCount;
		public int visibleCharacterCount;
		public int spaceCount;
		public int wordCount;
		public int firstCharacterIndex;
		public int firstVisibleCharacterIndex;
		public int lastCharacterIndex;
		public int lastVisibleCharacterIndex;
		public float length;
		public float lineHeight;
		public float ascender;
		public float baseline;
		public float descender;
		public float maxAdvance;
		public float width;
		public float marginLeft;
		public float marginRight;
		public TextAlignmentOptions alignment;
	}
}

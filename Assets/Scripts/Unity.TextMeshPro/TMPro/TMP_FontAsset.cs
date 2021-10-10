using System;
using UnityEngine;
using System.Collections.Generic;

namespace TMPro
{
	[Serializable]
	public class TMP_FontAsset : TMP_Asset
	{
		public enum FontAssetTypes
		{
			None = 0,
			SDF = 1,
			Bitmap = 2,
		}

		public FontAssetTypes fontAssetType;
		[SerializeField]
		private FaceInfo m_fontInfo;
		[SerializeField]
		public Texture2D atlas;
		[SerializeField]
		private List<TMP_Glyph> m_glyphInfoList;
		[SerializeField]
		private KerningTable m_kerningInfo;
		[SerializeField]
		private KerningPair m_kerningPair;
		[SerializeField]
		public List<TMP_FontAsset> fallbackFontAssets;
		[SerializeField]
		public FontAssetCreationSettings m_CreationSettings;
		[SerializeField]
		public TMP_FontWeights[] fontWeights;
		public float normalStyle;
		public float normalSpacingOffset;
		public float boldStyle;
		public float boldSpacing;
		public byte italicStyle;
		public byte tabSize;
	}
}

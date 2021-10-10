using UnityEngine;
using System.Collections.Generic;

namespace TMPro
{
	public class TMP_SpriteAsset : TMP_Asset
	{
		public Texture spriteSheet;
		public List<TMP_Sprite> spriteInfoList;
		[SerializeField]
		public List<TMP_SpriteAsset> fallbackSpriteAssets;
	}
}

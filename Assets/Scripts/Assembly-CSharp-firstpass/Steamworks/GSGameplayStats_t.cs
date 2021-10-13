using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(207)]
	public struct GSGameplayStats_t
	{
		public const int k_iCallback = 207;

		public EResult m_eResult;

		public int m_nRank;

		public uint m_unTotalConnects;

		public uint m_unTotalMinutesPlayed;
	}
}

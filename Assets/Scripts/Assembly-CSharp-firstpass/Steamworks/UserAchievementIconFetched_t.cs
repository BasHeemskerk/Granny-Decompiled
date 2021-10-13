using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1109)]
	public struct UserAchievementIconFetched_t
	{
		public const int k_iCallback = 1109;

		public CGameID m_nGameID;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string m_rgchAchievementName;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bAchieved;

		public int m_nIconHandle;
	}
}

using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	[CallbackIdentity(345)]
	public struct FriendsIsFollowing_t
	{
		public const int k_iCallback = 345;

		public EResult m_eResult;

		public CSteamID m_steamID;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bIsFollowing;
	}
}

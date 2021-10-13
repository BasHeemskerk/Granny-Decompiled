using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(504)]
	public struct LobbyEnter_t
	{
		public const int k_iCallback = 504;

		public ulong m_ulSteamIDLobby;

		public uint m_rgfChatPermissions;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bLocked;

		public uint m_EChatRoomEnterResponse;
	}
}

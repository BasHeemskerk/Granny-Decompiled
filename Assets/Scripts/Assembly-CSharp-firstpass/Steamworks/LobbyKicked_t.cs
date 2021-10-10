using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(512)]
	public struct LobbyKicked_t
	{
		public const int k_iCallback = 512;

		public ulong m_ulSteamIDLobby;

		public ulong m_ulSteamIDAdmin;

		public byte m_bKickedDueToDisconnect;
	}
}

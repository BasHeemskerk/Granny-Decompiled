using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(505)]
	public struct LobbyDataUpdate_t
	{
		public const int k_iCallback = 505;

		public ulong m_ulSteamIDLobby;

		public ulong m_ulSteamIDMember;

		public byte m_bSuccess;
	}
}

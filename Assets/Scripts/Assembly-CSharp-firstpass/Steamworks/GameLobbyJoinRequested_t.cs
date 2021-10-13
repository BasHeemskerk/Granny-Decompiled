using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(333)]
	public struct GameLobbyJoinRequested_t
	{
		public const int k_iCallback = 333;

		public CSteamID m_steamIDLobby;

		public CSteamID m_steamIDFriend;
	}
}

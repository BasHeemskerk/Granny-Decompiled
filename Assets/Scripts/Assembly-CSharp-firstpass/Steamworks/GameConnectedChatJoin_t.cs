using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(339)]
	public struct GameConnectedChatJoin_t
	{
		public const int k_iCallback = 339;

		public CSteamID m_steamIDClanChat;

		public CSteamID m_steamIDUser;
	}
}

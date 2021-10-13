using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	[CallbackIdentity(343)]
	public struct GameConnectedFriendChatMsg_t
	{
		public const int k_iCallback = 343;

		public CSteamID m_steamIDUser;

		public int m_iMessageID;
	}
}

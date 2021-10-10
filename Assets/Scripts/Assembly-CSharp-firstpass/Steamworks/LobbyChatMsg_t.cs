using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(507)]
	public struct LobbyChatMsg_t
	{
		public const int k_iCallback = 507;

		public ulong m_ulSteamIDLobby;

		public ulong m_ulSteamIDUser;

		public byte m_eChatEntryType;

		public uint m_iChatID;
	}
}

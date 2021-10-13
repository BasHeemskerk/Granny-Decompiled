using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(510)]
	public struct LobbyMatchList_t
	{
		public const int k_iCallback = 510;

		public uint m_nLobbiesMatching;
	}
}

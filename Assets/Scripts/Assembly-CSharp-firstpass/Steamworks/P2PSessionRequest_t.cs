using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1202)]
	public struct P2PSessionRequest_t
	{
		public const int k_iCallback = 1202;

		public CSteamID m_steamIDRemote;
	}
}

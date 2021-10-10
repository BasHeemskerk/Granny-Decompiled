using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(103)]
	public struct SteamServersDisconnected_t
	{
		public const int k_iCallback = 103;

		public EResult m_eResult;
	}
}

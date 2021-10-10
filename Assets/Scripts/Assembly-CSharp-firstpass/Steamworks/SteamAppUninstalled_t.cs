using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(3902)]
	public struct SteamAppUninstalled_t
	{
		public const int k_iCallback = 3902;

		public AppId_t m_nAppID;
	}
}

using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(3901)]
	public struct SteamAppInstalled_t
	{
		public const int k_iCallback = 3901;

		public AppId_t m_nAppID;
	}
}

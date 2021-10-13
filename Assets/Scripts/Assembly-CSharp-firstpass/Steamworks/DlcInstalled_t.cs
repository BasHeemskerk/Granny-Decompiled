using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1005)]
	public struct DlcInstalled_t
	{
		public const int k_iCallback = 1005;

		public AppId_t m_nAppID;
	}
}

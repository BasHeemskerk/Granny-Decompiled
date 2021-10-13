using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(102)]
	public struct SteamServerConnectFailure_t
	{
		public const int k_iCallback = 102;

		public EResult m_eResult;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bStillRetrying;
	}
}

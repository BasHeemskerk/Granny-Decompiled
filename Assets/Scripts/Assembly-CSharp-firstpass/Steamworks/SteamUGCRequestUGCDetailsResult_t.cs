using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(3402)]
	public struct SteamUGCRequestUGCDetailsResult_t
	{
		public const int k_iCallback = 3402;

		public SteamUGCDetails_t m_details;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bCachedData;
	}
}

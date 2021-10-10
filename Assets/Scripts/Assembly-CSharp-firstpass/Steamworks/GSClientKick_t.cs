using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	[CallbackIdentity(203)]
	public struct GSClientKick_t
	{
		public const int k_iCallback = 203;

		public CSteamID m_SteamID;

		public EDenyReason m_eDenyReason;
	}
}

using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(201)]
	public struct GSClientApprove_t
	{
		public const int k_iCallback = 201;

		public CSteamID m_SteamID;

		public CSteamID m_OwnerSteamID;
	}
}

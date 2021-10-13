using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	[CallbackIdentity(1801)]
	public struct GSStatsStored_t
	{
		public const int k_iCallback = 1801;

		public EResult m_eResult;

		public CSteamID m_steamIDUser;
	}
}

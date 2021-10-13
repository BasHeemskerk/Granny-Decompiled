using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	[CallbackIdentity(1800)]
	public struct GSStatsReceived_t
	{
		public const int k_iCallback = 1800;

		public EResult m_eResult;

		public CSteamID m_steamIDUser;
	}
}

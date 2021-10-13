using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1105)]
	public struct LeaderboardScoresDownloaded_t
	{
		public const int k_iCallback = 1105;

		public SteamLeaderboard_t m_hSteamLeaderboard;

		public SteamLeaderboardEntries_t m_hSteamLeaderboardEntries;

		public int m_cEntryCount;
	}
}

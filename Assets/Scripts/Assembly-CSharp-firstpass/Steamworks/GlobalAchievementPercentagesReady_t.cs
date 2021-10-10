using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1110)]
	public struct GlobalAchievementPercentagesReady_t
	{
		public const int k_iCallback = 1110;

		public ulong m_nGameID;

		public EResult m_eResult;
	}
}

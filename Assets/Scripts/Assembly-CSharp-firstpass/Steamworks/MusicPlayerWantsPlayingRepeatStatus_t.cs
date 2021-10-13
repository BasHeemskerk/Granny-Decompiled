using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4114)]
	public struct MusicPlayerWantsPlayingRepeatStatus_t
	{
		public const int k_iCallback = 4114;

		public int m_nPlayingRepeatStatus;
	}
}

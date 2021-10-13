using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 1)]
	[CallbackIdentity(4107)]
	public struct MusicPlayerWantsPlayPrevious_t
	{
		public const int k_iCallback = 4107;
	}
}

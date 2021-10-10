using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4013)]
	public struct MusicPlayerSelectsPlaylistEntry_t
	{
		public const int k_iCallback = 4013;

		public int nID;
	}
}

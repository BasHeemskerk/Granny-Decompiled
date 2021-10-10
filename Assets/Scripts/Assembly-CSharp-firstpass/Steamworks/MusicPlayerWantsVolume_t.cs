using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4011)]
	public struct MusicPlayerWantsVolume_t
	{
		public const int k_iCallback = 4011;

		public float m_flNewVolume;
	}
}

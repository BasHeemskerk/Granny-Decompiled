using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4002)]
	public struct VolumeHasChanged_t
	{
		public const int k_iCallback = 4002;

		public float m_flNewVolume;
	}
}

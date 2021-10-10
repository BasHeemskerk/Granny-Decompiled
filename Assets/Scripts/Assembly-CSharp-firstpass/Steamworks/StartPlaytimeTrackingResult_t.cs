using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(3410)]
	public struct StartPlaytimeTrackingResult_t
	{
		public const int k_iCallback = 3410;

		public EResult m_eResult;
	}
}

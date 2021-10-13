using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(2301)]
	public struct ScreenshotReady_t
	{
		public const int k_iCallback = 2301;

		public ScreenshotHandle m_hLocal;

		public EResult m_eResult;
	}
}

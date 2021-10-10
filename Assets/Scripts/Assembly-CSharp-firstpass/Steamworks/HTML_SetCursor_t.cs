using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4522)]
	public struct HTML_SetCursor_t
	{
		public const int k_iCallback = 4522;

		public HHTMLBrowser unBrowserHandle;

		public uint eMouseCursor;
	}
}

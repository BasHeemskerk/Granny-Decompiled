using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4525)]
	public struct HTML_UpdateToolTip_t
	{
		public const int k_iCallback = 4525;

		public HHTMLBrowser unBrowserHandle;

		public string pchMsg;
	}
}

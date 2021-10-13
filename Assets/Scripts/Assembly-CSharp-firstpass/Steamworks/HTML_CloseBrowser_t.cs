using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4504)]
	public struct HTML_CloseBrowser_t
	{
		public const int k_iCallback = 4504;

		public HHTMLBrowser unBrowserHandle;
	}
}

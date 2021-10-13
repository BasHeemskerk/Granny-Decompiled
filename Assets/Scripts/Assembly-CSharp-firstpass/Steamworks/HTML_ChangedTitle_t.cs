using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4508)]
	public struct HTML_ChangedTitle_t
	{
		public const int k_iCallback = 4508;

		public HHTMLBrowser unBrowserHandle;

		public string pchTitle;
	}
}

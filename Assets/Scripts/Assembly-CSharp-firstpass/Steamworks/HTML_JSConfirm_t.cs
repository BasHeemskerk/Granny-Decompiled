using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4515)]
	public struct HTML_JSConfirm_t
	{
		public const int k_iCallback = 4515;

		public HHTMLBrowser unBrowserHandle;

		public string pchMessage;
	}
}

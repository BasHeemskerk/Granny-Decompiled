using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4505)]
	public struct HTML_URLChanged_t
	{
		public const int k_iCallback = 4505;

		public HHTMLBrowser unBrowserHandle;

		public string pchURL;

		public string pchPostData;

		[MarshalAs(UnmanagedType.I1)]
		public bool bIsRedirect;

		public string pchPageTitle;

		[MarshalAs(UnmanagedType.I1)]
		public bool bNewNavigation;
	}
}

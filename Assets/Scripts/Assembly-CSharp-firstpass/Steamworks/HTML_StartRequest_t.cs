using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4503)]
	public struct HTML_StartRequest_t
	{
		public const int k_iCallback = 4503;

		public HHTMLBrowser unBrowserHandle;

		public string pchURL;

		public string pchTarget;

		public string pchPostData;

		[MarshalAs(UnmanagedType.I1)]
		public bool bIsRedirect;
	}
}

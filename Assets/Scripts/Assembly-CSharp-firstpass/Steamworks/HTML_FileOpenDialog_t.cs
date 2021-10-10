using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4516)]
	public struct HTML_FileOpenDialog_t
	{
		public const int k_iCallback = 4516;

		public HHTMLBrowser unBrowserHandle;

		public string pchTitle;

		public string pchInitialFile;
	}
}

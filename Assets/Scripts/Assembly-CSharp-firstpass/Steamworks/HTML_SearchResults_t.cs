using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4509)]
	public struct HTML_SearchResults_t
	{
		public const int k_iCallback = 4509;

		public HHTMLBrowser unBrowserHandle;

		public uint unResults;

		public uint unCurrentMatch;
	}
}

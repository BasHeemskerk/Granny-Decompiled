using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(3405)]
	public struct ItemInstalled_t
	{
		public const int k_iCallback = 3405;

		public AppId_t m_unAppID;

		public PublishedFileId_t m_nPublishedFileId;
	}
}

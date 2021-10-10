using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1322)]
	public struct RemoteStoragePublishedFileUnsubscribed_t
	{
		public const int k_iCallback = 1322;

		public PublishedFileId_t m_nPublishedFileId;

		public AppId_t m_nAppID;
	}
}

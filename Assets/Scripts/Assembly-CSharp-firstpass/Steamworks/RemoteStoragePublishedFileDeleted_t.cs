using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1323)]
	public struct RemoteStoragePublishedFileDeleted_t
	{
		public const int k_iCallback = 1323;

		public PublishedFileId_t m_nPublishedFileId;

		public AppId_t m_nAppID;
	}
}

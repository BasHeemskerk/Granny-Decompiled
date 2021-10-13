using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1330)]
	public struct RemoteStoragePublishedFileUpdated_t
	{
		public const int k_iCallback = 1330;

		public PublishedFileId_t m_nPublishedFileId;

		public AppId_t m_nAppID;

		public ulong m_ulUnused;
	}
}

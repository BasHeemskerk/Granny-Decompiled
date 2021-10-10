using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(3406)]
	public struct DownloadItemResult_t
	{
		public const int k_iCallback = 3406;

		public AppId_t m_unAppID;

		public PublishedFileId_t m_nPublishedFileId;

		public EResult m_eResult;
	}
}

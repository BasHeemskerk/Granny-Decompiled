using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1324)]
	public struct RemoteStorageUpdateUserPublishedItemVoteResult_t
	{
		public const int k_iCallback = 1324;

		public EResult m_eResult;

		public PublishedFileId_t m_nPublishedFileId;
	}
}

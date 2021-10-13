using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1325)]
	public struct RemoteStorageUserVoteDetails_t
	{
		public const int k_iCallback = 1325;

		public EResult m_eResult;

		public PublishedFileId_t m_nPublishedFileId;

		public EWorkshopVote m_eVote;
	}
}

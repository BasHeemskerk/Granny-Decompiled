using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1326)]
	public struct RemoteStorageEnumerateUserSharedWorkshopFilesResult_t
	{
		public const int k_iCallback = 1326;

		public EResult m_eResult;

		public int m_nResultsReturned;

		public int m_nTotalResultCount;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
		public PublishedFileId_t[] m_rgPublishedFileId;
	}
}

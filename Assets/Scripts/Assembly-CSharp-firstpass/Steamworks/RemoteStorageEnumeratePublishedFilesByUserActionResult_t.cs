using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1328)]
	public struct RemoteStorageEnumeratePublishedFilesByUserActionResult_t
	{
		public const int k_iCallback = 1328;

		public EResult m_eResult;

		public EWorkshopFileAction m_eAction;

		public int m_nResultsReturned;

		public int m_nTotalResultCount;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
		public PublishedFileId_t[] m_rgPublishedFileId;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
		public uint[] m_rgRTimeUpdated;
	}
}

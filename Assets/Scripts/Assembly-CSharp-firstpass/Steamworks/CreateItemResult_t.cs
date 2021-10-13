using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(3403)]
	public struct CreateItemResult_t
	{
		public const int k_iCallback = 3403;

		public EResult m_eResult;

		public PublishedFileId_t m_nPublishedFileId;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;
	}
}

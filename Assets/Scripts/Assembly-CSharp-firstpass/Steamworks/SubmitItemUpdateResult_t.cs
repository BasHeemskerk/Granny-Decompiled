using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(3404)]
	public struct SubmitItemUpdateResult_t
	{
		public const int k_iCallback = 3404;

		public EResult m_eResult;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;

		public PublishedFileId_t m_nPublishedFileId;
	}
}

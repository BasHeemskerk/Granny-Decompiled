using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(154)]
	public struct EncryptedAppTicketResponse_t
	{
		public const int k_iCallback = 154;

		public EResult m_eResult;
	}
}

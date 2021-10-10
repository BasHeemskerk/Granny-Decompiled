using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(163)]
	public struct GetAuthSessionTicketResponse_t
	{
		public const int k_iCallback = 163;

		public HAuthTicket m_hAuthTicket;

		public EResult m_eResult;
	}
}

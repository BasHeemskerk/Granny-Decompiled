using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(210)]
	public struct AssociateWithClanResult_t
	{
		public const int k_iCallback = 210;

		public EResult m_eResult;
	}
}

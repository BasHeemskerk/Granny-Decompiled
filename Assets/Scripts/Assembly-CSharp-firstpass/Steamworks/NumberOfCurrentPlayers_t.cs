using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1107)]
	public struct NumberOfCurrentPlayers_t
	{
		public const int k_iCallback = 1107;

		public byte m_bSuccess;

		public int m_cPlayers;
	}
}

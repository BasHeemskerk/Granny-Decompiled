using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4700)]
	public struct SteamInventoryResultReady_t
	{
		public const int k_iCallback = 4700;

		public SteamInventoryResult_t m_handle;

		public EResult m_result;
	}
}

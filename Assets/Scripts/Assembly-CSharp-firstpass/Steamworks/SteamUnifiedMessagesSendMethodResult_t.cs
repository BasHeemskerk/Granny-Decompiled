using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(2501)]
	public struct SteamUnifiedMessagesSendMethodResult_t
	{
		public const int k_iCallback = 2501;

		public ClientUnifiedMessageHandle m_hHandle;

		public ulong m_unContext;

		public EResult m_eResult;

		public uint m_unResponseSize;
	}
}

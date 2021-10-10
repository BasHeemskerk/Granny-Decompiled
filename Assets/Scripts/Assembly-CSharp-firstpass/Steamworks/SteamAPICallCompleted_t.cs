using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(703)]
	public struct SteamAPICallCompleted_t
	{
		public const int k_iCallback = 703;

		public SteamAPICall_t m_hAsyncCall;

		public int m_iCallback;

		public uint m_cubParam;
	}
}

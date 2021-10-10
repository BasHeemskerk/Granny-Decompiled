using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1332)]
	public struct RemoteStorageFileReadAsyncComplete_t
	{
		public const int k_iCallback = 1332;

		public SteamAPICall_t m_hFileReadAsync;

		public EResult m_eResult;

		public uint m_nOffset;

		public uint m_cubRead;
	}
}

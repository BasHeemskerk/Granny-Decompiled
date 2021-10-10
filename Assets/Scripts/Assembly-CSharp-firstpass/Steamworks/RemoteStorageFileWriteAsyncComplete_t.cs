using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1331)]
	public struct RemoteStorageFileWriteAsyncComplete_t
	{
		public const int k_iCallback = 1331;

		public EResult m_eResult;
	}
}

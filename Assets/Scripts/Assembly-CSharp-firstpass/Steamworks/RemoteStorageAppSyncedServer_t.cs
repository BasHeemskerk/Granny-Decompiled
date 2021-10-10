using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1302)]
	public struct RemoteStorageAppSyncedServer_t
	{
		public const int k_iCallback = 1302;

		public AppId_t m_nAppID;

		public EResult m_eResult;

		public int m_unNumUploads;
	}
}

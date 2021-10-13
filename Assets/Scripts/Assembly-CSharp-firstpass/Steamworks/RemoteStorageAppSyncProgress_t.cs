using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1303)]
	public struct RemoteStorageAppSyncProgress_t
	{
		public const int k_iCallback = 1303;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string m_rgchCurrentFile;

		public AppId_t m_nAppID;

		public uint m_uBytesTransferredThisChunk;

		public double m_dAppPercentComplete;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bUploading;
	}
}

using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(3415)]
	public struct RemoveAppDependencyResult_t
	{
		public const int k_iCallback = 3415;

		public EResult m_eResult;

		public PublishedFileId_t m_nPublishedFileId;

		public AppId_t m_nAppID;
	}
}

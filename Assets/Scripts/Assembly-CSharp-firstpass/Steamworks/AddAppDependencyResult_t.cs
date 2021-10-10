using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(3414)]
	public struct AddAppDependencyResult_t
	{
		public const int k_iCallback = 3414;

		public EResult m_eResult;

		public PublishedFileId_t m_nPublishedFileId;

		public AppId_t m_nAppID;
	}
}

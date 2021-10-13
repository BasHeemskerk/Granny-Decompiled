using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 1)]
	[CallbackIdentity(4604)]
	public struct BroadcastUploadStart_t
	{
		public const int k_iCallback = 4604;
	}
}

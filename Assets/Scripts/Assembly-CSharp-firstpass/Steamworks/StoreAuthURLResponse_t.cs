using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(165)]
	public struct StoreAuthURLResponse_t
	{
		public const int k_iCallback = 165;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
		public string m_szURL;
	}
}

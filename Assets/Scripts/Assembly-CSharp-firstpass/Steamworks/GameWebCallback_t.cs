using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(164)]
	public struct GameWebCallback_t
	{
		public const int k_iCallback = 164;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string m_szURL;
	}
}

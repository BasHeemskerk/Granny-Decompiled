using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(115)]
	public struct GSPolicyResponse_t
	{
		public const int k_iCallback = 115;

		public byte m_bSecure;
	}
}

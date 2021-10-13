using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(2102)]
	public struct HTTPRequestHeadersReceived_t
	{
		public const int k_iCallback = 2102;

		public HTTPRequestHandle m_hRequest;

		public ulong m_ulContextValue;
	}
}

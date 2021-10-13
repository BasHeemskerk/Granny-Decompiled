using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(705)]
	public struct CheckFileSignature_t
	{
		public const int k_iCallback = 705;

		public ECheckFileSignature m_eCheckFileSignature;
	}
}

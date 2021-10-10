using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1008)]
	public struct RegisterActivationCodeResponse_t
	{
		public const int k_iCallback = 1008;

		public ERegisterActivationCodeResult m_eResult;

		public uint m_unPackageRegistered;
	}
}

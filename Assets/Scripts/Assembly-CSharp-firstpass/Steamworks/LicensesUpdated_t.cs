using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 1)]
	[CallbackIdentity(125)]
	public struct LicensesUpdated_t
	{
		public const int k_iCallback = 125;
	}
}

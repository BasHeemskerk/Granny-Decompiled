using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(702)]
	public struct LowBatteryPower_t
	{
		public const int k_iCallback = 702;

		public byte m_nMinutesBatteryLeft;
	}
}

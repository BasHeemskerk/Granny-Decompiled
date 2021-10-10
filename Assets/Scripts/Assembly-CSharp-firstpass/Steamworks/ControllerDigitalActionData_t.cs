using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ControllerDigitalActionData_t
	{
		public byte bState;

		public byte bActive;
	}
}

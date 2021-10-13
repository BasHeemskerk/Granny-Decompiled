using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ControllerAnalogActionData_t
	{
		public EControllerSourceMode eMode;

		public float x;

		public float y;

		public byte bActive;
	}
}

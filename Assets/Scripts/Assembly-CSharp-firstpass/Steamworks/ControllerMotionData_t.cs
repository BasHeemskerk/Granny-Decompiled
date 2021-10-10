using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct ControllerMotionData_t
	{
		public float rotQuatX;

		public float rotQuatY;

		public float rotQuatZ;

		public float rotQuatW;

		public float posAccelX;

		public float posAccelY;

		public float posAccelZ;

		public float rotVelX;

		public float rotVelY;

		public float rotVelZ;
	}
}

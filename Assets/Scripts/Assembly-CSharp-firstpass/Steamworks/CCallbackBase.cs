using System;
using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential)]
	internal class CCallbackBase
	{
		public const byte k_ECallbackFlagsRegistered = 1;

		public const byte k_ECallbackFlagsGameServer = 2;

		public IntPtr m_vfptr;

		public byte m_nCallbackFlags;

		public int m_iCallback;
	}
}

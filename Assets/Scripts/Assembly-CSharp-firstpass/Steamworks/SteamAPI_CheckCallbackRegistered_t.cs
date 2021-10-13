using System.Runtime.InteropServices;

namespace Steamworks
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void SteamAPI_CheckCallbackRegistered_t(int iCallbackNum);
}

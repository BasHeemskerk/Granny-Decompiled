using System;

namespace Steamworks
{
	[Flags]
	public enum ERemoteStoragePlatform
	{
		k_ERemoteStoragePlatformNone = 0x0,
		k_ERemoteStoragePlatformWindows = 0x1,
		k_ERemoteStoragePlatformOSX = 0x2,
		k_ERemoteStoragePlatformPS3 = 0x4,
		k_ERemoteStoragePlatformLinux = 0x8,
		k_ERemoteStoragePlatformReserved2 = 0x10,
		k_ERemoteStoragePlatformAll = -1
	}
}

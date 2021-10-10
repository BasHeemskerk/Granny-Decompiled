using System;

namespace Steamworks
{
	[Flags]
	public enum EItemState
	{
		k_EItemStateNone = 0x0,
		k_EItemStateSubscribed = 0x1,
		k_EItemStateLegacyItem = 0x2,
		k_EItemStateInstalled = 0x4,
		k_EItemStateNeedsUpdate = 0x8,
		k_EItemStateDownloading = 0x10,
		k_EItemStateDownloadPending = 0x20
	}
}

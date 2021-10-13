using System;

namespace Steamworks
{
	[Flags]
	public enum EMarketingMessageFlags
	{
		k_EMarketingMessageFlagsNone = 0x0,
		k_EMarketingMessageFlagsHighPriority = 0x1,
		k_EMarketingMessageFlagsPlatformWindows = 0x2,
		k_EMarketingMessageFlagsPlatformMac = 0x4,
		k_EMarketingMessageFlagsPlatformLinux = 0x8,
		k_EMarketingMessageFlagsPlatformRestrictions = 0xE
	}
}

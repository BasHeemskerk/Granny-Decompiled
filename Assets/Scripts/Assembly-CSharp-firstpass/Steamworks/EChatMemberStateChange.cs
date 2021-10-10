using System;

namespace Steamworks
{
	[Flags]
	public enum EChatMemberStateChange
	{
		k_EChatMemberStateChangeEntered = 0x1,
		k_EChatMemberStateChangeLeft = 0x2,
		k_EChatMemberStateChangeDisconnected = 0x4,
		k_EChatMemberStateChangeKicked = 0x8,
		k_EChatMemberStateChangeBanned = 0x10
	}
}

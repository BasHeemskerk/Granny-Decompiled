using System;

namespace Steamworks
{
	[Flags]
	public enum EFriendFlags
	{
		k_EFriendFlagNone = 0x0,
		k_EFriendFlagBlocked = 0x1,
		k_EFriendFlagFriendshipRequested = 0x2,
		k_EFriendFlagImmediate = 0x4,
		k_EFriendFlagClanMember = 0x8,
		k_EFriendFlagOnGameServer = 0x10,
		k_EFriendFlagRequestingFriendship = 0x80,
		k_EFriendFlagRequestingInfo = 0x100,
		k_EFriendFlagIgnored = 0x200,
		k_EFriendFlagIgnoredFriend = 0x400,
		k_EFriendFlagChatMember = 0x1000,
		k_EFriendFlagAll = 0xFFFF
	}
}

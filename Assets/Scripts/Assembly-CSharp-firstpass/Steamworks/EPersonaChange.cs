using System;

namespace Steamworks
{
	[Flags]
	public enum EPersonaChange
	{
		k_EPersonaChangeName = 0x1,
		k_EPersonaChangeStatus = 0x2,
		k_EPersonaChangeComeOnline = 0x4,
		k_EPersonaChangeGoneOffline = 0x8,
		k_EPersonaChangeGamePlayed = 0x10,
		k_EPersonaChangeGameServer = 0x20,
		k_EPersonaChangeAvatar = 0x40,
		k_EPersonaChangeJoinedSource = 0x80,
		k_EPersonaChangeLeftSource = 0x100,
		k_EPersonaChangeRelationshipChanged = 0x200,
		k_EPersonaChangeNameFirstSet = 0x400,
		k_EPersonaChangeFacebookInfo = 0x800,
		k_EPersonaChangeNickname = 0x1000,
		k_EPersonaChangeSteamLevel = 0x2000
	}
}

namespace Steamworks
{
	public enum EChatRoomEnterResponse
	{
		k_EChatRoomEnterResponseSuccess = 1,
		k_EChatRoomEnterResponseDoesntExist = 2,
		k_EChatRoomEnterResponseNotAllowed = 3,
		k_EChatRoomEnterResponseFull = 4,
		k_EChatRoomEnterResponseError = 5,
		k_EChatRoomEnterResponseBanned = 6,
		k_EChatRoomEnterResponseLimited = 7,
		k_EChatRoomEnterResponseClanDisabled = 8,
		k_EChatRoomEnterResponseCommunityBan = 9,
		k_EChatRoomEnterResponseMemberBlockedYou = 10,
		k_EChatRoomEnterResponseYouBlockedMember = 11,
		k_EChatRoomEnterResponseRatelimitExceeded = 0xF
	}
}

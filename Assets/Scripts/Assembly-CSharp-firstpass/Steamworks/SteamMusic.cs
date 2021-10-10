namespace Steamworks
{
	public static class SteamMusic
	{
		public static bool BIsEnabled()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusic_BIsEnabled(CSteamAPIContext.GetSteamMusic());
		}

		public static bool BIsPlaying()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusic_BIsPlaying(CSteamAPIContext.GetSteamMusic());
		}

		public static AudioPlayback_Status GetPlaybackStatus()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusic_GetPlaybackStatus(CSteamAPIContext.GetSteamMusic());
		}

		public static void Play()
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMusic_Play(CSteamAPIContext.GetSteamMusic());
		}

		public static void Pause()
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMusic_Pause(CSteamAPIContext.GetSteamMusic());
		}

		public static void PlayPrevious()
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMusic_PlayPrevious(CSteamAPIContext.GetSteamMusic());
		}

		public static void PlayNext()
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMusic_PlayNext(CSteamAPIContext.GetSteamMusic());
		}

		public static void SetVolume(float flVolume)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMusic_SetVolume(CSteamAPIContext.GetSteamMusic(), flVolume);
		}

		public static float GetVolume()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusic_GetVolume(CSteamAPIContext.GetSteamMusic());
		}
	}
}

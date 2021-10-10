namespace Steamworks
{
	public static class SteamScreenshots
	{
		public static ScreenshotHandle WriteScreenshot(byte[] pubRGB, uint cubRGB, int nWidth, int nHeight)
		{
			InteropHelp.TestIfAvailableClient();
			return (ScreenshotHandle)NativeMethods.ISteamScreenshots_WriteScreenshot(CSteamAPIContext.GetSteamScreenshots(), pubRGB, cubRGB, nWidth, nHeight);
		}

		public static ScreenshotHandle AddScreenshotToLibrary(string pchFilename, string pchThumbnailFilename, int nWidth, int nHeight)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchFilename2 = new InteropHelp.UTF8StringHandle(pchFilename))
			{
				using (InteropHelp.UTF8StringHandle pchThumbnailFilename2 = new InteropHelp.UTF8StringHandle(pchThumbnailFilename))
				{
					return (ScreenshotHandle)NativeMethods.ISteamScreenshots_AddScreenshotToLibrary(CSteamAPIContext.GetSteamScreenshots(), pchFilename2, pchThumbnailFilename2, nWidth, nHeight);
				}
			}
		}

		public static void TriggerScreenshot()
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamScreenshots_TriggerScreenshot(CSteamAPIContext.GetSteamScreenshots());
		}

		public static void HookScreenshots(bool bHook)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamScreenshots_HookScreenshots(CSteamAPIContext.GetSteamScreenshots(), bHook);
		}

		public static bool SetLocation(ScreenshotHandle hScreenshot, string pchLocation)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchLocation2 = new InteropHelp.UTF8StringHandle(pchLocation))
			{
				return NativeMethods.ISteamScreenshots_SetLocation(CSteamAPIContext.GetSteamScreenshots(), hScreenshot, pchLocation2);
			}
		}

		public static bool TagUser(ScreenshotHandle hScreenshot, CSteamID steamID)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamScreenshots_TagUser(CSteamAPIContext.GetSteamScreenshots(), hScreenshot, steamID);
		}

		public static bool TagPublishedFile(ScreenshotHandle hScreenshot, PublishedFileId_t unPublishedFileID)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamScreenshots_TagPublishedFile(CSteamAPIContext.GetSteamScreenshots(), hScreenshot, unPublishedFileID);
		}

		public static bool IsScreenshotsHooked()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamScreenshots_IsScreenshotsHooked(CSteamAPIContext.GetSteamScreenshots());
		}

		public static ScreenshotHandle AddVRScreenshotToLibrary(EVRScreenshotType eType, string pchFilename, string pchVRFilename)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchFilename2 = new InteropHelp.UTF8StringHandle(pchFilename))
			{
				using (InteropHelp.UTF8StringHandle pchVRFilename2 = new InteropHelp.UTF8StringHandle(pchVRFilename))
				{
					return (ScreenshotHandle)NativeMethods.ISteamScreenshots_AddVRScreenshotToLibrary(CSteamAPIContext.GetSteamScreenshots(), eType, pchFilename2, pchVRFilename2);
				}
			}
		}
	}
}

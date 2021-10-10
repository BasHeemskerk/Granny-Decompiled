using System;
using System.Runtime.InteropServices;

namespace Steamworks
{
	public static class SteamGameServerApps
	{
		public static bool BIsSubscribed()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamApps_BIsSubscribed(CSteamGameServerAPIContext.GetSteamApps());
		}

		public static bool BIsLowViolence()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamApps_BIsLowViolence(CSteamGameServerAPIContext.GetSteamApps());
		}

		public static bool BIsCybercafe()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamApps_BIsCybercafe(CSteamGameServerAPIContext.GetSteamApps());
		}

		public static bool BIsVACBanned()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamApps_BIsVACBanned(CSteamGameServerAPIContext.GetSteamApps());
		}

		public static string GetCurrentGameLanguage()
		{
			InteropHelp.TestIfAvailableGameServer();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamApps_GetCurrentGameLanguage(CSteamGameServerAPIContext.GetSteamApps()));
		}

		public static string GetAvailableGameLanguages()
		{
			InteropHelp.TestIfAvailableGameServer();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamApps_GetAvailableGameLanguages(CSteamGameServerAPIContext.GetSteamApps()));
		}

		public static bool BIsSubscribedApp(AppId_t appID)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamApps_BIsSubscribedApp(CSteamGameServerAPIContext.GetSteamApps(), appID);
		}

		public static bool BIsDlcInstalled(AppId_t appID)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamApps_BIsDlcInstalled(CSteamGameServerAPIContext.GetSteamApps(), appID);
		}

		public static uint GetEarliestPurchaseUnixTime(AppId_t nAppID)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamApps_GetEarliestPurchaseUnixTime(CSteamGameServerAPIContext.GetSteamApps(), nAppID);
		}

		public static bool BIsSubscribedFromFreeWeekend()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamApps_BIsSubscribedFromFreeWeekend(CSteamGameServerAPIContext.GetSteamApps());
		}

		public static int GetDLCCount()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamApps_GetDLCCount(CSteamGameServerAPIContext.GetSteamApps());
		}

		public static bool BGetDLCDataByIndex(int iDLC, out AppId_t pAppID, out bool pbAvailable, out string pchName, int cchNameBufferSize)
		{
			InteropHelp.TestIfAvailableGameServer();
			IntPtr intPtr = Marshal.AllocHGlobal(cchNameBufferSize);
			bool flag = NativeMethods.ISteamApps_BGetDLCDataByIndex(CSteamGameServerAPIContext.GetSteamApps(), iDLC, out pAppID, out pbAvailable, intPtr, cchNameBufferSize);
			pchName = ((!flag) ? null : InteropHelp.PtrToStringUTF8(intPtr));
			Marshal.FreeHGlobal(intPtr);
			return flag;
		}

		public static void InstallDLC(AppId_t nAppID)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamApps_InstallDLC(CSteamGameServerAPIContext.GetSteamApps(), nAppID);
		}

		public static void UninstallDLC(AppId_t nAppID)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamApps_UninstallDLC(CSteamGameServerAPIContext.GetSteamApps(), nAppID);
		}

		public static void RequestAppProofOfPurchaseKey(AppId_t nAppID)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamApps_RequestAppProofOfPurchaseKey(CSteamGameServerAPIContext.GetSteamApps(), nAppID);
		}

		public static bool GetCurrentBetaName(out string pchName, int cchNameBufferSize)
		{
			InteropHelp.TestIfAvailableGameServer();
			IntPtr intPtr = Marshal.AllocHGlobal(cchNameBufferSize);
			bool flag = NativeMethods.ISteamApps_GetCurrentBetaName(CSteamGameServerAPIContext.GetSteamApps(), intPtr, cchNameBufferSize);
			pchName = ((!flag) ? null : InteropHelp.PtrToStringUTF8(intPtr));
			Marshal.FreeHGlobal(intPtr);
			return flag;
		}

		public static bool MarkContentCorrupt(bool bMissingFilesOnly)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamApps_MarkContentCorrupt(CSteamGameServerAPIContext.GetSteamApps(), bMissingFilesOnly);
		}

		public static uint GetInstalledDepots(AppId_t appID, DepotId_t[] pvecDepots, uint cMaxDepots)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamApps_GetInstalledDepots(CSteamGameServerAPIContext.GetSteamApps(), appID, pvecDepots, cMaxDepots);
		}

		public static uint GetAppInstallDir(AppId_t appID, out string pchFolder, uint cchFolderBufferSize)
		{
			InteropHelp.TestIfAvailableGameServer();
			IntPtr intPtr = Marshal.AllocHGlobal((int)cchFolderBufferSize);
			uint num = NativeMethods.ISteamApps_GetAppInstallDir(CSteamGameServerAPIContext.GetSteamApps(), appID, intPtr, cchFolderBufferSize);
			pchFolder = ((num == 0) ? null : InteropHelp.PtrToStringUTF8(intPtr));
			Marshal.FreeHGlobal(intPtr);
			return num;
		}

		public static bool BIsAppInstalled(AppId_t appID)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamApps_BIsAppInstalled(CSteamGameServerAPIContext.GetSteamApps(), appID);
		}

		public static CSteamID GetAppOwner()
		{
			InteropHelp.TestIfAvailableGameServer();
			return (CSteamID)NativeMethods.ISteamApps_GetAppOwner(CSteamGameServerAPIContext.GetSteamApps());
		}

		public static string GetLaunchQueryParam(string pchKey)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle pchKey2 = new InteropHelp.UTF8StringHandle(pchKey))
			{
				return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamApps_GetLaunchQueryParam(CSteamGameServerAPIContext.GetSteamApps(), pchKey2));
			}
		}

		public static bool GetDlcDownloadProgress(AppId_t nAppID, out ulong punBytesDownloaded, out ulong punBytesTotal)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamApps_GetDlcDownloadProgress(CSteamGameServerAPIContext.GetSteamApps(), nAppID, out punBytesDownloaded, out punBytesTotal);
		}

		public static int GetAppBuildId()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamApps_GetAppBuildId(CSteamGameServerAPIContext.GetSteamApps());
		}

		public static void RequestAllProofOfPurchaseKeys()
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamApps_RequestAllProofOfPurchaseKeys(CSteamGameServerAPIContext.GetSteamApps());
		}

		public static SteamAPICall_t GetFileDetails(string pszFileName)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle pszFileName2 = new InteropHelp.UTF8StringHandle(pszFileName))
			{
				return (SteamAPICall_t)NativeMethods.ISteamApps_GetFileDetails(CSteamGameServerAPIContext.GetSteamApps(), pszFileName2);
			}
		}
	}
}

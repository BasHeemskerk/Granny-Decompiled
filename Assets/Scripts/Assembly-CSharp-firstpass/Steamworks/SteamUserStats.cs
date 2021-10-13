using System;
using System.Runtime.InteropServices;

namespace Steamworks
{
	public static class SteamUserStats
	{
		public static bool RequestCurrentStats()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUserStats_RequestCurrentStats(CSteamAPIContext.GetSteamUserStats());
		}

		public static bool GetStat(string pchName, out int pData)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName))
			{
				return NativeMethods.ISteamUserStats_GetStat(CSteamAPIContext.GetSteamUserStats(), pchName2, out pData);
			}
		}

		public static bool GetStat(string pchName, out float pData)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName))
			{
				return NativeMethods.ISteamUserStats_GetStat0(CSteamAPIContext.GetSteamUserStats(), pchName2, out pData);
			}
		}

		public static bool SetStat(string pchName, int nData)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName))
			{
				return NativeMethods.ISteamUserStats_SetStat(CSteamAPIContext.GetSteamUserStats(), pchName2, nData);
			}
		}

		public static bool SetStat(string pchName, float fData)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName))
			{
				return NativeMethods.ISteamUserStats_SetStat0(CSteamAPIContext.GetSteamUserStats(), pchName2, fData);
			}
		}

		public static bool UpdateAvgRateStat(string pchName, float flCountThisSession, double dSessionLength)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName))
			{
				return NativeMethods.ISteamUserStats_UpdateAvgRateStat(CSteamAPIContext.GetSteamUserStats(), pchName2, flCountThisSession, dSessionLength);
			}
		}

		public static bool GetAchievement(string pchName, out bool pbAchieved)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName))
			{
				return NativeMethods.ISteamUserStats_GetAchievement(CSteamAPIContext.GetSteamUserStats(), pchName2, out pbAchieved);
			}
		}

		public static bool SetAchievement(string pchName)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName))
			{
				return NativeMethods.ISteamUserStats_SetAchievement(CSteamAPIContext.GetSteamUserStats(), pchName2);
			}
		}

		public static bool ClearAchievement(string pchName)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName))
			{
				return NativeMethods.ISteamUserStats_ClearAchievement(CSteamAPIContext.GetSteamUserStats(), pchName2);
			}
		}

		public static bool GetAchievementAndUnlockTime(string pchName, out bool pbAchieved, out uint punUnlockTime)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName))
			{
				return NativeMethods.ISteamUserStats_GetAchievementAndUnlockTime(CSteamAPIContext.GetSteamUserStats(), pchName2, out pbAchieved, out punUnlockTime);
			}
		}

		public static bool StoreStats()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUserStats_StoreStats(CSteamAPIContext.GetSteamUserStats());
		}

		public static int GetAchievementIcon(string pchName)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName))
			{
				return NativeMethods.ISteamUserStats_GetAchievementIcon(CSteamAPIContext.GetSteamUserStats(), pchName2);
			}
		}

		public static string GetAchievementDisplayAttribute(string pchName, string pchKey)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName))
			{
				using (InteropHelp.UTF8StringHandle pchKey2 = new InteropHelp.UTF8StringHandle(pchKey))
				{
					return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamUserStats_GetAchievementDisplayAttribute(CSteamAPIContext.GetSteamUserStats(), pchName2, pchKey2));
				}
			}
		}

		public static bool IndicateAchievementProgress(string pchName, uint nCurProgress, uint nMaxProgress)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName))
			{
				return NativeMethods.ISteamUserStats_IndicateAchievementProgress(CSteamAPIContext.GetSteamUserStats(), pchName2, nCurProgress, nMaxProgress);
			}
		}

		public static uint GetNumAchievements()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUserStats_GetNumAchievements(CSteamAPIContext.GetSteamUserStats());
		}

		public static string GetAchievementName(uint iAchievement)
		{
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamUserStats_GetAchievementName(CSteamAPIContext.GetSteamUserStats(), iAchievement));
		}

		public static SteamAPICall_t RequestUserStats(CSteamID steamIDUser)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUserStats_RequestUserStats(CSteamAPIContext.GetSteamUserStats(), steamIDUser);
		}

		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out int pData)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName))
			{
				return NativeMethods.ISteamUserStats_GetUserStat(CSteamAPIContext.GetSteamUserStats(), steamIDUser, pchName2, out pData);
			}
		}

		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out float pData)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName))
			{
				return NativeMethods.ISteamUserStats_GetUserStat0(CSteamAPIContext.GetSteamUserStats(), steamIDUser, pchName2, out pData);
			}
		}

		public static bool GetUserAchievement(CSteamID steamIDUser, string pchName, out bool pbAchieved)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName))
			{
				return NativeMethods.ISteamUserStats_GetUserAchievement(CSteamAPIContext.GetSteamUserStats(), steamIDUser, pchName2, out pbAchieved);
			}
		}

		public static bool GetUserAchievementAndUnlockTime(CSteamID steamIDUser, string pchName, out bool pbAchieved, out uint punUnlockTime)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName))
			{
				return NativeMethods.ISteamUserStats_GetUserAchievementAndUnlockTime(CSteamAPIContext.GetSteamUserStats(), steamIDUser, pchName2, out pbAchieved, out punUnlockTime);
			}
		}

		public static bool ResetAllStats(bool bAchievementsToo)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUserStats_ResetAllStats(CSteamAPIContext.GetSteamUserStats(), bAchievementsToo);
		}

		public static SteamAPICall_t FindOrCreateLeaderboard(string pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchLeaderboardName2 = new InteropHelp.UTF8StringHandle(pchLeaderboardName))
			{
				return (SteamAPICall_t)NativeMethods.ISteamUserStats_FindOrCreateLeaderboard(CSteamAPIContext.GetSteamUserStats(), pchLeaderboardName2, eLeaderboardSortMethod, eLeaderboardDisplayType);
			}
		}

		public static SteamAPICall_t FindLeaderboard(string pchLeaderboardName)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchLeaderboardName2 = new InteropHelp.UTF8StringHandle(pchLeaderboardName))
			{
				return (SteamAPICall_t)NativeMethods.ISteamUserStats_FindLeaderboard(CSteamAPIContext.GetSteamUserStats(), pchLeaderboardName2);
			}
		}

		public static string GetLeaderboardName(SteamLeaderboard_t hSteamLeaderboard)
		{
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamUserStats_GetLeaderboardName(CSteamAPIContext.GetSteamUserStats(), hSteamLeaderboard));
		}

		public static int GetLeaderboardEntryCount(SteamLeaderboard_t hSteamLeaderboard)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUserStats_GetLeaderboardEntryCount(CSteamAPIContext.GetSteamUserStats(), hSteamLeaderboard);
		}

		public static ELeaderboardSortMethod GetLeaderboardSortMethod(SteamLeaderboard_t hSteamLeaderboard)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUserStats_GetLeaderboardSortMethod(CSteamAPIContext.GetSteamUserStats(), hSteamLeaderboard);
		}

		public static ELeaderboardDisplayType GetLeaderboardDisplayType(SteamLeaderboard_t hSteamLeaderboard)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUserStats_GetLeaderboardDisplayType(CSteamAPIContext.GetSteamUserStats(), hSteamLeaderboard);
		}

		public static SteamAPICall_t DownloadLeaderboardEntries(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUserStats_DownloadLeaderboardEntries(CSteamAPIContext.GetSteamUserStats(), hSteamLeaderboard, eLeaderboardDataRequest, nRangeStart, nRangeEnd);
		}

		public static SteamAPICall_t DownloadLeaderboardEntriesForUsers(SteamLeaderboard_t hSteamLeaderboard, CSteamID[] prgUsers, int cUsers)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUserStats_DownloadLeaderboardEntriesForUsers(CSteamAPIContext.GetSteamUserStats(), hSteamLeaderboard, prgUsers, cUsers);
		}

		public static bool GetDownloadedLeaderboardEntry(SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, out LeaderboardEntry_t pLeaderboardEntry, int[] pDetails, int cDetailsMax)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUserStats_GetDownloadedLeaderboardEntry(CSteamAPIContext.GetSteamUserStats(), hSteamLeaderboardEntries, index, out pLeaderboardEntry, pDetails, cDetailsMax);
		}

		public static SteamAPICall_t UploadLeaderboardScore(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, int[] pScoreDetails, int cScoreDetailsCount)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUserStats_UploadLeaderboardScore(CSteamAPIContext.GetSteamUserStats(), hSteamLeaderboard, eLeaderboardUploadScoreMethod, nScore, pScoreDetails, cScoreDetailsCount);
		}

		public static SteamAPICall_t AttachLeaderboardUGC(SteamLeaderboard_t hSteamLeaderboard, UGCHandle_t hUGC)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUserStats_AttachLeaderboardUGC(CSteamAPIContext.GetSteamUserStats(), hSteamLeaderboard, hUGC);
		}

		public static SteamAPICall_t GetNumberOfCurrentPlayers()
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUserStats_GetNumberOfCurrentPlayers(CSteamAPIContext.GetSteamUserStats());
		}

		public static SteamAPICall_t RequestGlobalAchievementPercentages()
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUserStats_RequestGlobalAchievementPercentages(CSteamAPIContext.GetSteamUserStats());
		}

		public static int GetMostAchievedAchievementInfo(out string pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr intPtr = Marshal.AllocHGlobal((int)unNameBufLen);
			int num = NativeMethods.ISteamUserStats_GetMostAchievedAchievementInfo(CSteamAPIContext.GetSteamUserStats(), intPtr, unNameBufLen, out pflPercent, out pbAchieved);
			pchName = ((num == -1) ? null : InteropHelp.PtrToStringUTF8(intPtr));
			Marshal.FreeHGlobal(intPtr);
			return num;
		}

		public static int GetNextMostAchievedAchievementInfo(int iIteratorPrevious, out string pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr intPtr = Marshal.AllocHGlobal((int)unNameBufLen);
			int num = NativeMethods.ISteamUserStats_GetNextMostAchievedAchievementInfo(CSteamAPIContext.GetSteamUserStats(), iIteratorPrevious, intPtr, unNameBufLen, out pflPercent, out pbAchieved);
			pchName = ((num == -1) ? null : InteropHelp.PtrToStringUTF8(intPtr));
			Marshal.FreeHGlobal(intPtr);
			return num;
		}

		public static bool GetAchievementAchievedPercent(string pchName, out float pflPercent)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName))
			{
				return NativeMethods.ISteamUserStats_GetAchievementAchievedPercent(CSteamAPIContext.GetSteamUserStats(), pchName2, out pflPercent);
			}
		}

		public static SteamAPICall_t RequestGlobalStats(int nHistoryDays)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUserStats_RequestGlobalStats(CSteamAPIContext.GetSteamUserStats(), nHistoryDays);
		}

		public static bool GetGlobalStat(string pchStatName, out long pData)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchStatName2 = new InteropHelp.UTF8StringHandle(pchStatName))
			{
				return NativeMethods.ISteamUserStats_GetGlobalStat(CSteamAPIContext.GetSteamUserStats(), pchStatName2, out pData);
			}
		}

		public static bool GetGlobalStat(string pchStatName, out double pData)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchStatName2 = new InteropHelp.UTF8StringHandle(pchStatName))
			{
				return NativeMethods.ISteamUserStats_GetGlobalStat0(CSteamAPIContext.GetSteamUserStats(), pchStatName2, out pData);
			}
		}

		public static int GetGlobalStatHistory(string pchStatName, long[] pData, uint cubData)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchStatName2 = new InteropHelp.UTF8StringHandle(pchStatName))
			{
				return NativeMethods.ISteamUserStats_GetGlobalStatHistory(CSteamAPIContext.GetSteamUserStats(), pchStatName2, pData, cubData);
			}
		}

		public static int GetGlobalStatHistory(string pchStatName, double[] pData, uint cubData)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchStatName2 = new InteropHelp.UTF8StringHandle(pchStatName))
			{
				return NativeMethods.ISteamUserStats_GetGlobalStatHistory0(CSteamAPIContext.GetSteamUserStats(), pchStatName2, pData, cubData);
			}
		}
	}
}

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Steamworks
{
	[SuppressUnmanagedCodeSecurity]
	internal static class NativeMethods
	{
		internal const string NativeLibraryName = "steam_api64";

		internal const string NativeLibrary_SDKEncryptedAppTicket = "sdkencryptedappticket64";

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_Init();

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_Shutdown();

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_RestartAppIfNecessary(AppId_t unOwnAppID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ReleaseCurrentThreadMemory();

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_WriteMiniDump(uint uStructuredExceptionCode, IntPtr pvExceptionInfo, uint uBuildID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_SetMiniDumpComment(InteropHelp.UTF8StringHandle pchMsg);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_RunCallbacks();

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_RegisterCallback(IntPtr pCallback, int iCallback);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_UnregisterCallback(IntPtr pCallback);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_RegisterCallResult(IntPtr pCallback, ulong hAPICall);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_UnregisterCallResult(IntPtr pCallback, ulong hAPICall);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_IsSteamRunning();

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Steam_RunCallbacks(HSteamPipe hSteamPipe, [MarshalAs(UnmanagedType.I1)] bool bGameServerCallbacks);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Steam_RegisterInterfaceFuncs(IntPtr hModule);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Steam_GetHSteamUserCurrent();

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_GetSteamInstallPath();

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_GetHSteamPipe();

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_SetTryCatchCallbacks([MarshalAs(UnmanagedType.I1)] bool bTryCatchCallbacks);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_GetHSteamUser();

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamInternal_ContextInit(IntPtr pContextInitData);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamInternal_CreateInterface(InteropHelp.UTF8StringHandle ver);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_UseBreakpadCrashHandler(InteropHelp.UTF8StringHandle pchVersion, InteropHelp.UTF8StringHandle pchDate, InteropHelp.UTF8StringHandle pchTime, [MarshalAs(UnmanagedType.I1)] bool bFullMemoryDumps, IntPtr pvContext, IntPtr m_pfnPreMinidumpCallback);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_SetBreakpadAppID(uint unAppID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamGameServer_InitSafe")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamGameServer_Init(uint unIP, ushort usSteamPort, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, InteropHelp.UTF8StringHandle pchVersionString);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamGameServer_Shutdown();

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamGameServer_RunCallbacks();

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamGameServer_ReleaseCurrentThreadMemory();

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamGameServer_BSecure();

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamGameServer_GetSteamID();

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamGameServer_GetHSteamPipe();

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamGameServer_GetHSteamUser();

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamInternal_GameServer_Init(uint unIP, ushort usPort, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, InteropHelp.UTF8StringHandle pchVersionString);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamClient();

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamGameServerClient();

		[DllImport("sdkencryptedappticket64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamEncryptedAppTicket_BDecryptTicket(byte[] rgubTicketEncrypted, uint cubTicketEncrypted, byte[] rgubTicketDecrypted, ref uint pcubTicketDecrypted, [MarshalAs(UnmanagedType.LPArray, SizeConst = 32)] byte[] rgubKey, int cubKey);

		[DllImport("sdkencryptedappticket64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamEncryptedAppTicket_BIsTicketForApp(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID);

		[DllImport("sdkencryptedappticket64", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint SteamEncryptedAppTicket_GetTicketIssueTime(byte[] rgubTicketDecrypted, uint cubTicketDecrypted);

		[DllImport("sdkencryptedappticket64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamEncryptedAppTicket_GetTicketSteamID(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out CSteamID psteamID);

		[DllImport("sdkencryptedappticket64", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint SteamEncryptedAppTicket_GetTicketAppID(byte[] rgubTicketDecrypted, uint cubTicketDecrypted);

		[DllImport("sdkencryptedappticket64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamEncryptedAppTicket_BUserOwnsAppInTicket(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID);

		[DllImport("sdkencryptedappticket64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamEncryptedAppTicket_BUserIsVacBanned(byte[] rgubTicketDecrypted, uint cubTicketDecrypted);

		[DllImport("sdkencryptedappticket64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamEncryptedAppTicket_GetUserVariableData(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out uint pcubUserData);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamAppList_GetNumInstalledApps")]
		public static extern uint ISteamAppList_GetNumInstalledApps(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamAppList_GetInstalledApps")]
		public static extern uint ISteamAppList_GetInstalledApps(IntPtr instancePtr, [In][Out] AppId_t[] pvecAppID, uint unMaxAppIDs);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamAppList_GetAppName")]
		public static extern int ISteamAppList_GetAppName(IntPtr instancePtr, AppId_t nAppID, IntPtr pchName, int cchNameMax);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamAppList_GetAppInstallDir")]
		public static extern int ISteamAppList_GetAppInstallDir(IntPtr instancePtr, AppId_t nAppID, IntPtr pchDirectory, int cchNameMax);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamAppList_GetAppBuildId")]
		public static extern int ISteamAppList_GetAppBuildId(IntPtr instancePtr, AppId_t nAppID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_BIsSubscribed")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamApps_BIsSubscribed(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_BIsLowViolence")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamApps_BIsLowViolence(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_BIsCybercafe")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamApps_BIsCybercafe(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_BIsVACBanned")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamApps_BIsVACBanned(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_GetCurrentGameLanguage")]
		public static extern IntPtr ISteamApps_GetCurrentGameLanguage(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_GetAvailableGameLanguages")]
		public static extern IntPtr ISteamApps_GetAvailableGameLanguages(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_BIsSubscribedApp")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamApps_BIsSubscribedApp(IntPtr instancePtr, AppId_t appID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_BIsDlcInstalled")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamApps_BIsDlcInstalled(IntPtr instancePtr, AppId_t appID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_GetEarliestPurchaseUnixTime")]
		public static extern uint ISteamApps_GetEarliestPurchaseUnixTime(IntPtr instancePtr, AppId_t nAppID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_BIsSubscribedFromFreeWeekend")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamApps_BIsSubscribedFromFreeWeekend(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_GetDLCCount")]
		public static extern int ISteamApps_GetDLCCount(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_BGetDLCDataByIndex")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamApps_BGetDLCDataByIndex(IntPtr instancePtr, int iDLC, out AppId_t pAppID, out bool pbAvailable, IntPtr pchName, int cchNameBufferSize);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_InstallDLC")]
		public static extern void ISteamApps_InstallDLC(IntPtr instancePtr, AppId_t nAppID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_UninstallDLC")]
		public static extern void ISteamApps_UninstallDLC(IntPtr instancePtr, AppId_t nAppID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_RequestAppProofOfPurchaseKey")]
		public static extern void ISteamApps_RequestAppProofOfPurchaseKey(IntPtr instancePtr, AppId_t nAppID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_GetCurrentBetaName")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamApps_GetCurrentBetaName(IntPtr instancePtr, IntPtr pchName, int cchNameBufferSize);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_MarkContentCorrupt")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamApps_MarkContentCorrupt(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bMissingFilesOnly);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_GetInstalledDepots")]
		public static extern uint ISteamApps_GetInstalledDepots(IntPtr instancePtr, AppId_t appID, [In][Out] DepotId_t[] pvecDepots, uint cMaxDepots);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_GetAppInstallDir")]
		public static extern uint ISteamApps_GetAppInstallDir(IntPtr instancePtr, AppId_t appID, IntPtr pchFolder, uint cchFolderBufferSize);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_BIsAppInstalled")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamApps_BIsAppInstalled(IntPtr instancePtr, AppId_t appID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_GetAppOwner")]
		public static extern ulong ISteamApps_GetAppOwner(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_GetLaunchQueryParam")]
		public static extern IntPtr ISteamApps_GetLaunchQueryParam(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKey);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_GetDlcDownloadProgress")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamApps_GetDlcDownloadProgress(IntPtr instancePtr, AppId_t nAppID, out ulong punBytesDownloaded, out ulong punBytesTotal);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_GetAppBuildId")]
		public static extern int ISteamApps_GetAppBuildId(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_RequestAllProofOfPurchaseKeys")]
		public static extern void ISteamApps_RequestAllProofOfPurchaseKeys(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_GetFileDetails")]
		public static extern ulong ISteamApps_GetFileDetails(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszFileName);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_CreateSteamPipe")]
		public static extern int ISteamClient_CreateSteamPipe(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_BReleaseSteamPipe")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamClient_BReleaseSteamPipe(IntPtr instancePtr, HSteamPipe hSteamPipe);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_ConnectToGlobalUser")]
		public static extern int ISteamClient_ConnectToGlobalUser(IntPtr instancePtr, HSteamPipe hSteamPipe);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_CreateLocalUser")]
		public static extern int ISteamClient_CreateLocalUser(IntPtr instancePtr, out HSteamPipe phSteamPipe, EAccountType eAccountType);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_ReleaseUser")]
		public static extern void ISteamClient_ReleaseUser(IntPtr instancePtr, HSteamPipe hSteamPipe, HSteamUser hUser);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamUser")]
		public static extern IntPtr ISteamClient_GetISteamUser(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamGameServer")]
		public static extern IntPtr ISteamClient_GetISteamGameServer(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_SetLocalIPBinding")]
		public static extern void ISteamClient_SetLocalIPBinding(IntPtr instancePtr, uint unIP, ushort usPort);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamFriends")]
		public static extern IntPtr ISteamClient_GetISteamFriends(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamUtils")]
		public static extern IntPtr ISteamClient_GetISteamUtils(IntPtr instancePtr, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamMatchmaking")]
		public static extern IntPtr ISteamClient_GetISteamMatchmaking(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamMatchmakingServers")]
		public static extern IntPtr ISteamClient_GetISteamMatchmakingServers(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamGenericInterface")]
		public static extern IntPtr ISteamClient_GetISteamGenericInterface(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamUserStats")]
		public static extern IntPtr ISteamClient_GetISteamUserStats(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamGameServerStats")]
		public static extern IntPtr ISteamClient_GetISteamGameServerStats(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamApps")]
		public static extern IntPtr ISteamClient_GetISteamApps(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamNetworking")]
		public static extern IntPtr ISteamClient_GetISteamNetworking(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamRemoteStorage")]
		public static extern IntPtr ISteamClient_GetISteamRemoteStorage(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamScreenshots")]
		public static extern IntPtr ISteamClient_GetISteamScreenshots(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetIPCCallCount")]
		public static extern uint ISteamClient_GetIPCCallCount(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_SetWarningMessageHook")]
		public static extern void ISteamClient_SetWarningMessageHook(IntPtr instancePtr, SteamAPIWarningMessageHook_t pFunction);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_BShutdownIfAllPipesClosed")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamClient_BShutdownIfAllPipesClosed(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamHTTP")]
		public static extern IntPtr ISteamClient_GetISteamHTTP(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamUnifiedMessages")]
		public static extern IntPtr ISteamClient_GetISteamUnifiedMessages(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamController")]
		public static extern IntPtr ISteamClient_GetISteamController(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamUGC")]
		public static extern IntPtr ISteamClient_GetISteamUGC(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamAppList")]
		public static extern IntPtr ISteamClient_GetISteamAppList(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamMusic")]
		public static extern IntPtr ISteamClient_GetISteamMusic(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamMusicRemote")]
		public static extern IntPtr ISteamClient_GetISteamMusicRemote(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamHTMLSurface")]
		public static extern IntPtr ISteamClient_GetISteamHTMLSurface(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamInventory")]
		public static extern IntPtr ISteamClient_GetISteamInventory(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamVideo")]
		public static extern IntPtr ISteamClient_GetISteamVideo(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamParentalSettings")]
		public static extern IntPtr ISteamClient_GetISteamParentalSettings(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_Init")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamController_Init(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_Shutdown")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamController_Shutdown(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_RunFrame")]
		public static extern void ISteamController_RunFrame(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_GetConnectedControllers")]
		public static extern int ISteamController_GetConnectedControllers(IntPtr instancePtr, [In][Out] ControllerHandle_t[] handlesOut);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_ShowBindingPanel")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamController_ShowBindingPanel(IntPtr instancePtr, ControllerHandle_t controllerHandle);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_GetActionSetHandle")]
		public static extern ulong ISteamController_GetActionSetHandle(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszActionSetName);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_ActivateActionSet")]
		public static extern void ISteamController_ActivateActionSet(IntPtr instancePtr, ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_GetCurrentActionSet")]
		public static extern ulong ISteamController_GetCurrentActionSet(IntPtr instancePtr, ControllerHandle_t controllerHandle);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_GetDigitalActionHandle")]
		public static extern ulong ISteamController_GetDigitalActionHandle(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszActionName);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_GetDigitalActionData")]
		public static extern ControllerDigitalActionData_t ISteamController_GetDigitalActionData(IntPtr instancePtr, ControllerHandle_t controllerHandle, ControllerDigitalActionHandle_t digitalActionHandle);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_GetDigitalActionOrigins")]
		public static extern int ISteamController_GetDigitalActionOrigins(IntPtr instancePtr, ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle, ControllerDigitalActionHandle_t digitalActionHandle, [In][Out] EControllerActionOrigin[] originsOut);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_GetAnalogActionHandle")]
		public static extern ulong ISteamController_GetAnalogActionHandle(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszActionName);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_GetAnalogActionData")]
		public static extern ControllerAnalogActionData_t ISteamController_GetAnalogActionData(IntPtr instancePtr, ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t analogActionHandle);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_GetAnalogActionOrigins")]
		public static extern int ISteamController_GetAnalogActionOrigins(IntPtr instancePtr, ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle, ControllerAnalogActionHandle_t analogActionHandle, [In][Out] EControllerActionOrigin[] originsOut);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_StopAnalogActionMomentum")]
		public static extern void ISteamController_StopAnalogActionMomentum(IntPtr instancePtr, ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t eAction);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_TriggerHapticPulse")]
		public static extern void ISteamController_TriggerHapticPulse(IntPtr instancePtr, ControllerHandle_t controllerHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_TriggerRepeatedHapticPulse")]
		public static extern void ISteamController_TriggerRepeatedHapticPulse(IntPtr instancePtr, ControllerHandle_t controllerHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_TriggerVibration")]
		public static extern void ISteamController_TriggerVibration(IntPtr instancePtr, ControllerHandle_t controllerHandle, ushort usLeftSpeed, ushort usRightSpeed);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_SetLEDColor")]
		public static extern void ISteamController_SetLEDColor(IntPtr instancePtr, ControllerHandle_t controllerHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_GetGamepadIndexForController")]
		public static extern int ISteamController_GetGamepadIndexForController(IntPtr instancePtr, ControllerHandle_t ulControllerHandle);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_GetControllerForGamepadIndex")]
		public static extern ulong ISteamController_GetControllerForGamepadIndex(IntPtr instancePtr, int nIndex);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_GetMotionData")]
		public static extern ControllerMotionData_t ISteamController_GetMotionData(IntPtr instancePtr, ControllerHandle_t controllerHandle);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_ShowDigitalActionOrigins")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamController_ShowDigitalActionOrigins(IntPtr instancePtr, ControllerHandle_t controllerHandle, ControllerDigitalActionHandle_t digitalActionHandle, float flScale, float flXPosition, float flYPosition);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_ShowAnalogActionOrigins")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamController_ShowAnalogActionOrigins(IntPtr instancePtr, ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t analogActionHandle, float flScale, float flXPosition, float flYPosition);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_GetStringForActionOrigin")]
		public static extern IntPtr ISteamController_GetStringForActionOrigin(IntPtr instancePtr, EControllerActionOrigin eOrigin);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamController_GetGlyphForActionOrigin")]
		public static extern IntPtr ISteamController_GetGlyphForActionOrigin(IntPtr instancePtr, EControllerActionOrigin eOrigin);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetPersonaName")]
		public static extern IntPtr ISteamFriends_GetPersonaName(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_SetPersonaName")]
		public static extern ulong ISteamFriends_SetPersonaName(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchPersonaName);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetPersonaState")]
		public static extern EPersonaState ISteamFriends_GetPersonaState(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendCount")]
		public static extern int ISteamFriends_GetFriendCount(IntPtr instancePtr, EFriendFlags iFriendFlags);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendByIndex")]
		public static extern ulong ISteamFriends_GetFriendByIndex(IntPtr instancePtr, int iFriend, EFriendFlags iFriendFlags);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendRelationship")]
		public static extern EFriendRelationship ISteamFriends_GetFriendRelationship(IntPtr instancePtr, CSteamID steamIDFriend);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendPersonaState")]
		public static extern EPersonaState ISteamFriends_GetFriendPersonaState(IntPtr instancePtr, CSteamID steamIDFriend);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendPersonaName")]
		public static extern IntPtr ISteamFriends_GetFriendPersonaName(IntPtr instancePtr, CSteamID steamIDFriend);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendGamePlayed")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_GetFriendGamePlayed(IntPtr instancePtr, CSteamID steamIDFriend, out FriendGameInfo_t pFriendGameInfo);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendPersonaNameHistory")]
		public static extern IntPtr ISteamFriends_GetFriendPersonaNameHistory(IntPtr instancePtr, CSteamID steamIDFriend, int iPersonaName);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendSteamLevel")]
		public static extern int ISteamFriends_GetFriendSteamLevel(IntPtr instancePtr, CSteamID steamIDFriend);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetPlayerNickname")]
		public static extern IntPtr ISteamFriends_GetPlayerNickname(IntPtr instancePtr, CSteamID steamIDPlayer);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendsGroupCount")]
		public static extern int ISteamFriends_GetFriendsGroupCount(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendsGroupIDByIndex")]
		public static extern short ISteamFriends_GetFriendsGroupIDByIndex(IntPtr instancePtr, int iFG);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendsGroupName")]
		public static extern IntPtr ISteamFriends_GetFriendsGroupName(IntPtr instancePtr, FriendsGroupID_t friendsGroupID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendsGroupMembersCount")]
		public static extern int ISteamFriends_GetFriendsGroupMembersCount(IntPtr instancePtr, FriendsGroupID_t friendsGroupID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendsGroupMembersList")]
		public static extern void ISteamFriends_GetFriendsGroupMembersList(IntPtr instancePtr, FriendsGroupID_t friendsGroupID, [In][Out] CSteamID[] pOutSteamIDMembers, int nMembersCount);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_HasFriend")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_HasFriend(IntPtr instancePtr, CSteamID steamIDFriend, EFriendFlags iFriendFlags);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetClanCount")]
		public static extern int ISteamFriends_GetClanCount(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetClanByIndex")]
		public static extern ulong ISteamFriends_GetClanByIndex(IntPtr instancePtr, int iClan);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetClanName")]
		public static extern IntPtr ISteamFriends_GetClanName(IntPtr instancePtr, CSteamID steamIDClan);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetClanTag")]
		public static extern IntPtr ISteamFriends_GetClanTag(IntPtr instancePtr, CSteamID steamIDClan);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetClanActivityCounts")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_GetClanActivityCounts(IntPtr instancePtr, CSteamID steamIDClan, out int pnOnline, out int pnInGame, out int pnChatting);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_DownloadClanActivityCounts")]
		public static extern ulong ISteamFriends_DownloadClanActivityCounts(IntPtr instancePtr, [In][Out] CSteamID[] psteamIDClans, int cClansToRequest);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendCountFromSource")]
		public static extern int ISteamFriends_GetFriendCountFromSource(IntPtr instancePtr, CSteamID steamIDSource);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendFromSourceByIndex")]
		public static extern ulong ISteamFriends_GetFriendFromSourceByIndex(IntPtr instancePtr, CSteamID steamIDSource, int iFriend);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_IsUserInSource")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_IsUserInSource(IntPtr instancePtr, CSteamID steamIDUser, CSteamID steamIDSource);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_SetInGameVoiceSpeaking")]
		public static extern void ISteamFriends_SetInGameVoiceSpeaking(IntPtr instancePtr, CSteamID steamIDUser, [MarshalAs(UnmanagedType.I1)] bool bSpeaking);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_ActivateGameOverlay")]
		public static extern void ISteamFriends_ActivateGameOverlay(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchDialog);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_ActivateGameOverlayToUser")]
		public static extern void ISteamFriends_ActivateGameOverlayToUser(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchDialog, CSteamID steamID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_ActivateGameOverlayToWebPage")]
		public static extern void ISteamFriends_ActivateGameOverlayToWebPage(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchURL);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_ActivateGameOverlayToStore")]
		public static extern void ISteamFriends_ActivateGameOverlayToStore(IntPtr instancePtr, AppId_t nAppID, EOverlayToStoreFlag eFlag);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_SetPlayedWith")]
		public static extern void ISteamFriends_SetPlayedWith(IntPtr instancePtr, CSteamID steamIDUserPlayedWith);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_ActivateGameOverlayInviteDialog")]
		public static extern void ISteamFriends_ActivateGameOverlayInviteDialog(IntPtr instancePtr, CSteamID steamIDLobby);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetSmallFriendAvatar")]
		public static extern int ISteamFriends_GetSmallFriendAvatar(IntPtr instancePtr, CSteamID steamIDFriend);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetMediumFriendAvatar")]
		public static extern int ISteamFriends_GetMediumFriendAvatar(IntPtr instancePtr, CSteamID steamIDFriend);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetLargeFriendAvatar")]
		public static extern int ISteamFriends_GetLargeFriendAvatar(IntPtr instancePtr, CSteamID steamIDFriend);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_RequestUserInformation")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_RequestUserInformation(IntPtr instancePtr, CSteamID steamIDUser, [MarshalAs(UnmanagedType.I1)] bool bRequireNameOnly);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_RequestClanOfficerList")]
		public static extern ulong ISteamFriends_RequestClanOfficerList(IntPtr instancePtr, CSteamID steamIDClan);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetClanOwner")]
		public static extern ulong ISteamFriends_GetClanOwner(IntPtr instancePtr, CSteamID steamIDClan);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetClanOfficerCount")]
		public static extern int ISteamFriends_GetClanOfficerCount(IntPtr instancePtr, CSteamID steamIDClan);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetClanOfficerByIndex")]
		public static extern ulong ISteamFriends_GetClanOfficerByIndex(IntPtr instancePtr, CSteamID steamIDClan, int iOfficer);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetUserRestrictions")]
		public static extern uint ISteamFriends_GetUserRestrictions(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_SetRichPresence")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_SetRichPresence(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_ClearRichPresence")]
		public static extern void ISteamFriends_ClearRichPresence(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendRichPresence")]
		public static extern IntPtr ISteamFriends_GetFriendRichPresence(IntPtr instancePtr, CSteamID steamIDFriend, InteropHelp.UTF8StringHandle pchKey);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendRichPresenceKeyCount")]
		public static extern int ISteamFriends_GetFriendRichPresenceKeyCount(IntPtr instancePtr, CSteamID steamIDFriend);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendRichPresenceKeyByIndex")]
		public static extern IntPtr ISteamFriends_GetFriendRichPresenceKeyByIndex(IntPtr instancePtr, CSteamID steamIDFriend, int iKey);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_RequestFriendRichPresence")]
		public static extern void ISteamFriends_RequestFriendRichPresence(IntPtr instancePtr, CSteamID steamIDFriend);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_InviteUserToGame")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_InviteUserToGame(IntPtr instancePtr, CSteamID steamIDFriend, InteropHelp.UTF8StringHandle pchConnectString);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetCoplayFriendCount")]
		public static extern int ISteamFriends_GetCoplayFriendCount(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetCoplayFriend")]
		public static extern ulong ISteamFriends_GetCoplayFriend(IntPtr instancePtr, int iCoplayFriend);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendCoplayTime")]
		public static extern int ISteamFriends_GetFriendCoplayTime(IntPtr instancePtr, CSteamID steamIDFriend);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendCoplayGame")]
		public static extern uint ISteamFriends_GetFriendCoplayGame(IntPtr instancePtr, CSteamID steamIDFriend);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_JoinClanChatRoom")]
		public static extern ulong ISteamFriends_JoinClanChatRoom(IntPtr instancePtr, CSteamID steamIDClan);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_LeaveClanChatRoom")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_LeaveClanChatRoom(IntPtr instancePtr, CSteamID steamIDClan);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetClanChatMemberCount")]
		public static extern int ISteamFriends_GetClanChatMemberCount(IntPtr instancePtr, CSteamID steamIDClan);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetChatMemberByIndex")]
		public static extern ulong ISteamFriends_GetChatMemberByIndex(IntPtr instancePtr, CSteamID steamIDClan, int iUser);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_SendClanChatMessage")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_SendClanChatMessage(IntPtr instancePtr, CSteamID steamIDClanChat, InteropHelp.UTF8StringHandle pchText);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetClanChatMessage")]
		public static extern int ISteamFriends_GetClanChatMessage(IntPtr instancePtr, CSteamID steamIDClanChat, int iMessage, IntPtr prgchText, int cchTextMax, out EChatEntryType peChatEntryType, out CSteamID psteamidChatter);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_IsClanChatAdmin")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_IsClanChatAdmin(IntPtr instancePtr, CSteamID steamIDClanChat, CSteamID steamIDUser);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_IsClanChatWindowOpenInSteam")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_IsClanChatWindowOpenInSteam(IntPtr instancePtr, CSteamID steamIDClanChat);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_OpenClanChatWindowInSteam")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_OpenClanChatWindowInSteam(IntPtr instancePtr, CSteamID steamIDClanChat);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_CloseClanChatWindowInSteam")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_CloseClanChatWindowInSteam(IntPtr instancePtr, CSteamID steamIDClanChat);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_SetListenForFriendsMessages")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_SetListenForFriendsMessages(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bInterceptEnabled);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_ReplyToFriendMessage")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_ReplyToFriendMessage(IntPtr instancePtr, CSteamID steamIDFriend, InteropHelp.UTF8StringHandle pchMsgToSend);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendMessage")]
		public static extern int ISteamFriends_GetFriendMessage(IntPtr instancePtr, CSteamID steamIDFriend, int iMessageID, IntPtr pvData, int cubData, out EChatEntryType peChatEntryType);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFollowerCount")]
		public static extern ulong ISteamFriends_GetFollowerCount(IntPtr instancePtr, CSteamID steamID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_IsFollowing")]
		public static extern ulong ISteamFriends_IsFollowing(IntPtr instancePtr, CSteamID steamID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_EnumerateFollowingList")]
		public static extern ulong ISteamFriends_EnumerateFollowingList(IntPtr instancePtr, uint unStartIndex);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_InitGameServer")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServer_InitGameServer(IntPtr instancePtr, uint unIP, ushort usGamePort, ushort usQueryPort, uint unFlags, AppId_t nGameAppId, InteropHelp.UTF8StringHandle pchVersionString);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetProduct")]
		public static extern void ISteamGameServer_SetProduct(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszProduct);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetGameDescription")]
		public static extern void ISteamGameServer_SetGameDescription(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszGameDescription);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetModDir")]
		public static extern void ISteamGameServer_SetModDir(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszModDir);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetDedicatedServer")]
		public static extern void ISteamGameServer_SetDedicatedServer(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bDedicated);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_LogOn")]
		public static extern void ISteamGameServer_LogOn(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszToken);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_LogOnAnonymous")]
		public static extern void ISteamGameServer_LogOnAnonymous(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_LogOff")]
		public static extern void ISteamGameServer_LogOff(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_BLoggedOn")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServer_BLoggedOn(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_BSecure")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServer_BSecure(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_GetSteamID")]
		public static extern ulong ISteamGameServer_GetSteamID(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_WasRestartRequested")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServer_WasRestartRequested(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetMaxPlayerCount")]
		public static extern void ISteamGameServer_SetMaxPlayerCount(IntPtr instancePtr, int cPlayersMax);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetBotPlayerCount")]
		public static extern void ISteamGameServer_SetBotPlayerCount(IntPtr instancePtr, int cBotplayers);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetServerName")]
		public static extern void ISteamGameServer_SetServerName(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszServerName);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetMapName")]
		public static extern void ISteamGameServer_SetMapName(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszMapName);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetPasswordProtected")]
		public static extern void ISteamGameServer_SetPasswordProtected(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bPasswordProtected);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetSpectatorPort")]
		public static extern void ISteamGameServer_SetSpectatorPort(IntPtr instancePtr, ushort unSpectatorPort);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetSpectatorServerName")]
		public static extern void ISteamGameServer_SetSpectatorServerName(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszSpectatorServerName);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_ClearAllKeyValues")]
		public static extern void ISteamGameServer_ClearAllKeyValues(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetKeyValue")]
		public static extern void ISteamGameServer_SetKeyValue(IntPtr instancePtr, InteropHelp.UTF8StringHandle pKey, InteropHelp.UTF8StringHandle pValue);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetGameTags")]
		public static extern void ISteamGameServer_SetGameTags(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchGameTags);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetGameData")]
		public static extern void ISteamGameServer_SetGameData(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchGameData);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetRegion")]
		public static extern void ISteamGameServer_SetRegion(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszRegion);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SendUserConnectAndAuthenticate")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServer_SendUserConnectAndAuthenticate(IntPtr instancePtr, uint unIPClient, byte[] pvAuthBlob, uint cubAuthBlobSize, out CSteamID pSteamIDUser);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_CreateUnauthenticatedUserConnection")]
		public static extern ulong ISteamGameServer_CreateUnauthenticatedUserConnection(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SendUserDisconnect")]
		public static extern void ISteamGameServer_SendUserDisconnect(IntPtr instancePtr, CSteamID steamIDUser);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_BUpdateUserData")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServer_BUpdateUserData(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchPlayerName, uint uScore);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_GetAuthSessionTicket")]
		public static extern uint ISteamGameServer_GetAuthSessionTicket(IntPtr instancePtr, byte[] pTicket, int cbMaxTicket, out uint pcbTicket);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_BeginAuthSession")]
		public static extern EBeginAuthSessionResult ISteamGameServer_BeginAuthSession(IntPtr instancePtr, byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_EndAuthSession")]
		public static extern void ISteamGameServer_EndAuthSession(IntPtr instancePtr, CSteamID steamID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_CancelAuthTicket")]
		public static extern void ISteamGameServer_CancelAuthTicket(IntPtr instancePtr, HAuthTicket hAuthTicket);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_UserHasLicenseForApp")]
		public static extern EUserHasLicenseForAppResult ISteamGameServer_UserHasLicenseForApp(IntPtr instancePtr, CSteamID steamID, AppId_t appID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_RequestUserGroupStatus")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServer_RequestUserGroupStatus(IntPtr instancePtr, CSteamID steamIDUser, CSteamID steamIDGroup);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_GetGameplayStats")]
		public static extern void ISteamGameServer_GetGameplayStats(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_GetServerReputation")]
		public static extern ulong ISteamGameServer_GetServerReputation(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_GetPublicIP")]
		public static extern uint ISteamGameServer_GetPublicIP(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_HandleIncomingPacket")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServer_HandleIncomingPacket(IntPtr instancePtr, byte[] pData, int cbData, uint srcIP, ushort srcPort);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_GetNextOutgoingPacket")]
		public static extern int ISteamGameServer_GetNextOutgoingPacket(IntPtr instancePtr, byte[] pOut, int cbMaxOut, out uint pNetAdr, out ushort pPort);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_EnableHeartbeats")]
		public static extern void ISteamGameServer_EnableHeartbeats(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bActive);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetHeartbeatInterval")]
		public static extern void ISteamGameServer_SetHeartbeatInterval(IntPtr instancePtr, int iHeartbeatInterval);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_ForceHeartbeat")]
		public static extern void ISteamGameServer_ForceHeartbeat(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_AssociateWithClan")]
		public static extern ulong ISteamGameServer_AssociateWithClan(IntPtr instancePtr, CSteamID steamIDClan);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_ComputeNewPlayerCompatibility")]
		public static extern ulong ISteamGameServer_ComputeNewPlayerCompatibility(IntPtr instancePtr, CSteamID steamIDNewPlayer);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServerStats_RequestUserStats")]
		public static extern ulong ISteamGameServerStats_RequestUserStats(IntPtr instancePtr, CSteamID steamIDUser);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServerStats_GetUserStat")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerStats_GetUserStat(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out int pData);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServerStats_GetUserStat0")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerStats_GetUserStat0(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out float pData);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServerStats_GetUserAchievement")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerStats_GetUserAchievement(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServerStats_SetUserStat")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerStats_SetUserStat(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, int nData);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServerStats_SetUserStat0")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerStats_SetUserStat0(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, float fData);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServerStats_UpdateUserAvgRateStat")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerStats_UpdateUserAvgRateStat(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, float flCountThisSession, double dSessionLength);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServerStats_SetUserAchievement")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerStats_SetUserAchievement(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServerStats_ClearUserAchievement")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerStats_ClearUserAchievement(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServerStats_StoreUserStats")]
		public static extern ulong ISteamGameServerStats_StoreUserStats(IntPtr instancePtr, CSteamID steamIDUser);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_Init")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTMLSurface_Init(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_Shutdown")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTMLSurface_Shutdown(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_CreateBrowser")]
		public static extern ulong ISteamHTMLSurface_CreateBrowser(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchUserAgent, InteropHelp.UTF8StringHandle pchUserCSS);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_RemoveBrowser")]
		public static extern void ISteamHTMLSurface_RemoveBrowser(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_LoadURL")]
		public static extern void ISteamHTMLSurface_LoadURL(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchURL, InteropHelp.UTF8StringHandle pchPostData);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_SetSize")]
		public static extern void ISteamHTMLSurface_SetSize(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint unWidth, uint unHeight);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_StopLoad")]
		public static extern void ISteamHTMLSurface_StopLoad(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_Reload")]
		public static extern void ISteamHTMLSurface_Reload(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_GoBack")]
		public static extern void ISteamHTMLSurface_GoBack(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_GoForward")]
		public static extern void ISteamHTMLSurface_GoForward(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_AddHeader")]
		public static extern void ISteamHTMLSurface_AddHeader(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_ExecuteJavascript")]
		public static extern void ISteamHTMLSurface_ExecuteJavascript(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchScript);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_MouseUp")]
		public static extern void ISteamHTMLSurface_MouseUp(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_MouseDown")]
		public static extern void ISteamHTMLSurface_MouseDown(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_MouseDoubleClick")]
		public static extern void ISteamHTMLSurface_MouseDoubleClick(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_MouseMove")]
		public static extern void ISteamHTMLSurface_MouseMove(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, int x, int y);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_MouseWheel")]
		public static extern void ISteamHTMLSurface_MouseWheel(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, int nDelta);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_KeyDown")]
		public static extern void ISteamHTMLSurface_KeyDown(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_KeyUp")]
		public static extern void ISteamHTMLSurface_KeyUp(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_KeyChar")]
		public static extern void ISteamHTMLSurface_KeyChar(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint cUnicodeChar, EHTMLKeyModifiers eHTMLKeyModifiers);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_SetHorizontalScroll")]
		public static extern void ISteamHTMLSurface_SetHorizontalScroll(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_SetVerticalScroll")]
		public static extern void ISteamHTMLSurface_SetVerticalScroll(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_SetKeyFocus")]
		public static extern void ISteamHTMLSurface_SetKeyFocus(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, [MarshalAs(UnmanagedType.I1)] bool bHasKeyFocus);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_ViewSource")]
		public static extern void ISteamHTMLSurface_ViewSource(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_CopyToClipboard")]
		public static extern void ISteamHTMLSurface_CopyToClipboard(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_PasteFromClipboard")]
		public static extern void ISteamHTMLSurface_PasteFromClipboard(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_Find")]
		public static extern void ISteamHTMLSurface_Find(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchSearchStr, [MarshalAs(UnmanagedType.I1)] bool bCurrentlyInFind, [MarshalAs(UnmanagedType.I1)] bool bReverse);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_StopFind")]
		public static extern void ISteamHTMLSurface_StopFind(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_GetLinkAtPosition")]
		public static extern void ISteamHTMLSurface_GetLinkAtPosition(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, int x, int y);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_SetCookie")]
		public static extern void ISteamHTMLSurface_SetCookie(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchHostname, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue, InteropHelp.UTF8StringHandle pchPath, uint nExpires, [MarshalAs(UnmanagedType.I1)] bool bSecure, [MarshalAs(UnmanagedType.I1)] bool bHTTPOnly);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_SetPageScaleFactor")]
		public static extern void ISteamHTMLSurface_SetPageScaleFactor(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_SetBackgroundMode")]
		public static extern void ISteamHTMLSurface_SetBackgroundMode(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, [MarshalAs(UnmanagedType.I1)] bool bBackgroundMode);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_SetDPIScalingFactor")]
		public static extern void ISteamHTMLSurface_SetDPIScalingFactor(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, float flDPIScaling);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_AllowStartRequest")]
		public static extern void ISteamHTMLSurface_AllowStartRequest(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, [MarshalAs(UnmanagedType.I1)] bool bAllowed);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_JSDialogResponse")]
		public static extern void ISteamHTMLSurface_JSDialogResponse(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, [MarshalAs(UnmanagedType.I1)] bool bResult);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_FileLoadDialogResponse")]
		public static extern void ISteamHTMLSurface_FileLoadDialogResponse(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, IntPtr pchSelectedFiles);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_CreateHTTPRequest")]
		public static extern uint ISteamHTTP_CreateHTTPRequest(IntPtr instancePtr, EHTTPMethod eHTTPRequestMethod, InteropHelp.UTF8StringHandle pchAbsoluteURL);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_SetHTTPRequestContextValue")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_SetHTTPRequestContextValue(IntPtr instancePtr, HTTPRequestHandle hRequest, ulong ulContextValue);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_SetHTTPRequestNetworkActivityTimeout")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_SetHTTPRequestNetworkActivityTimeout(IntPtr instancePtr, HTTPRequestHandle hRequest, uint unTimeoutSeconds);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_SetHTTPRequestHeaderValue")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_SetHTTPRequestHeaderValue(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, InteropHelp.UTF8StringHandle pchHeaderValue);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_SetHTTPRequestGetOrPostParameter")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_SetHTTPRequestGetOrPostParameter(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchParamName, InteropHelp.UTF8StringHandle pchParamValue);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_SendHTTPRequest")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_SendHTTPRequest(IntPtr instancePtr, HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_SendHTTPRequestAndStreamResponse")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_SendHTTPRequestAndStreamResponse(IntPtr instancePtr, HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_DeferHTTPRequest")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_DeferHTTPRequest(IntPtr instancePtr, HTTPRequestHandle hRequest);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_PrioritizeHTTPRequest")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_PrioritizeHTTPRequest(IntPtr instancePtr, HTTPRequestHandle hRequest);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_GetHTTPResponseHeaderSize")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_GetHTTPResponseHeaderSize(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, out uint unResponseHeaderSize);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_GetHTTPResponseHeaderValue")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_GetHTTPResponseHeaderValue(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, byte[] pHeaderValueBuffer, uint unBufferSize);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_GetHTTPResponseBodySize")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_GetHTTPResponseBodySize(IntPtr instancePtr, HTTPRequestHandle hRequest, out uint unBodySize);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_GetHTTPResponseBodyData")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_GetHTTPResponseBodyData(IntPtr instancePtr, HTTPRequestHandle hRequest, byte[] pBodyDataBuffer, uint unBufferSize);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_GetHTTPStreamingResponseBodyData")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_GetHTTPStreamingResponseBodyData(IntPtr instancePtr, HTTPRequestHandle hRequest, uint cOffset, byte[] pBodyDataBuffer, uint unBufferSize);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_ReleaseHTTPRequest")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_ReleaseHTTPRequest(IntPtr instancePtr, HTTPRequestHandle hRequest);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_GetHTTPDownloadProgressPct")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_GetHTTPDownloadProgressPct(IntPtr instancePtr, HTTPRequestHandle hRequest, out float pflPercentOut);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_SetHTTPRequestRawPostBody")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_SetHTTPRequestRawPostBody(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchContentType, byte[] pubBody, uint unBodyLen);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_CreateCookieContainer")]
		public static extern uint ISteamHTTP_CreateCookieContainer(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bAllowResponsesToModify);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_ReleaseCookieContainer")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_ReleaseCookieContainer(IntPtr instancePtr, HTTPCookieContainerHandle hCookieContainer);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_SetCookie")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_SetCookie(IntPtr instancePtr, HTTPCookieContainerHandle hCookieContainer, InteropHelp.UTF8StringHandle pchHost, InteropHelp.UTF8StringHandle pchUrl, InteropHelp.UTF8StringHandle pchCookie);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_SetHTTPRequestCookieContainer")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_SetHTTPRequestCookieContainer(IntPtr instancePtr, HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_SetHTTPRequestUserAgentInfo")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_SetHTTPRequestUserAgentInfo(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchUserAgentInfo);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_SetHTTPRequestRequiresVerifiedCertificate")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_SetHTTPRequestRequiresVerifiedCertificate(IntPtr instancePtr, HTTPRequestHandle hRequest, [MarshalAs(UnmanagedType.I1)] bool bRequireVerifiedCertificate);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_SetHTTPRequestAbsoluteTimeoutMS")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_SetHTTPRequestAbsoluteTimeoutMS(IntPtr instancePtr, HTTPRequestHandle hRequest, uint unMilliseconds);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_GetHTTPRequestWasTimedOut")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_GetHTTPRequestWasTimedOut(IntPtr instancePtr, HTTPRequestHandle hRequest, out bool pbWasTimedOut);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_GetResultStatus")]
		public static extern EResult ISteamInventory_GetResultStatus(IntPtr instancePtr, SteamInventoryResult_t resultHandle);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_GetResultItems")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_GetResultItems(IntPtr instancePtr, SteamInventoryResult_t resultHandle, [In][Out] SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_GetResultItemProperty")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_GetResultItemProperty(IntPtr instancePtr, SteamInventoryResult_t resultHandle, uint unItemIndex, InteropHelp.UTF8StringHandle pchPropertyName, IntPtr pchValueBuffer, ref uint punValueBufferSizeOut);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_GetResultTimestamp")]
		public static extern uint ISteamInventory_GetResultTimestamp(IntPtr instancePtr, SteamInventoryResult_t resultHandle);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_CheckResultSteamID")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_CheckResultSteamID(IntPtr instancePtr, SteamInventoryResult_t resultHandle, CSteamID steamIDExpected);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_DestroyResult")]
		public static extern void ISteamInventory_DestroyResult(IntPtr instancePtr, SteamInventoryResult_t resultHandle);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_GetAllItems")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_GetAllItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_GetItemsByID")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_GetItemsByID(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_SerializeResult")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_SerializeResult(IntPtr instancePtr, SteamInventoryResult_t resultHandle, byte[] pOutBuffer, out uint punOutBufferSize);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_DeserializeResult")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_DeserializeResult(IntPtr instancePtr, out SteamInventoryResult_t pOutResultHandle, byte[] pBuffer, uint unBufferSize, [MarshalAs(UnmanagedType.I1)] bool bRESERVED_MUST_BE_FALSE);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_GenerateItems")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_GenerateItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemDef_t[] pArrayItemDefs, [In][Out] uint[] punArrayQuantity, uint unArrayLength);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_GrantPromoItems")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_GrantPromoItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_AddPromoItem")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_AddPromoItem(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_AddPromoItems")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_AddPromoItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemDef_t[] pArrayItemDefs, uint unArrayLength);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_ConsumeItem")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_ConsumeItem(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_ExchangeItems")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_ExchangeItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemDef_t[] pArrayGenerate, [In][Out] uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, [In][Out] SteamItemInstanceID_t[] pArrayDestroy, [In][Out] uint[] punArrayDestroyQuantity, uint unArrayDestroyLength);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_TransferItemQuantity")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_TransferItemQuantity(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_SendItemDropHeartbeat")]
		public static extern void ISteamInventory_SendItemDropHeartbeat(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_TriggerItemDrop")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_TriggerItemDrop(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_TradeItems")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_TradeItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, [In][Out] SteamItemInstanceID_t[] pArrayGive, [In][Out] uint[] pArrayGiveQuantity, uint nArrayGiveLength, [In][Out] SteamItemInstanceID_t[] pArrayGet, [In][Out] uint[] pArrayGetQuantity, uint nArrayGetLength);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_LoadItemDefinitions")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_LoadItemDefinitions(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_GetItemDefinitionIDs")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_GetItemDefinitionIDs(IntPtr instancePtr, [In][Out] SteamItemDef_t[] pItemDefIDs, out uint punItemDefIDsArraySize);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_GetItemDefinitionProperty")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_GetItemDefinitionProperty(IntPtr instancePtr, SteamItemDef_t iDefinition, InteropHelp.UTF8StringHandle pchPropertyName, IntPtr pchValueBuffer, ref uint punValueBufferSizeOut);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_RequestEligiblePromoItemDefinitionsIDs")]
		public static extern ulong ISteamInventory_RequestEligiblePromoItemDefinitionsIDs(IntPtr instancePtr, CSteamID steamID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_GetEligiblePromoItemDefinitionIDs")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_GetEligiblePromoItemDefinitionIDs(IntPtr instancePtr, CSteamID steamID, [In][Out] SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_GetFavoriteGameCount")]
		public static extern int ISteamMatchmaking_GetFavoriteGameCount(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_GetFavoriteGame")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_GetFavoriteGame(IntPtr instancePtr, int iGame, out AppId_t pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_AddFavoriteGame")]
		public static extern int ISteamMatchmaking_AddFavoriteGame(IntPtr instancePtr, AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_RemoveFavoriteGame")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_RemoveFavoriteGame(IntPtr instancePtr, AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_RequestLobbyList")]
		public static extern ulong ISteamMatchmaking_RequestLobbyList(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_AddRequestLobbyListStringFilter")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListStringFilter(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKeyToMatch, InteropHelp.UTF8StringHandle pchValueToMatch, ELobbyComparison eComparisonType);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_AddRequestLobbyListNumericalFilter")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListNumericalFilter(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKeyToMatch, int nValueToMatch, ELobbyComparison eComparisonType);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_AddRequestLobbyListNearValueFilter")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListNearValueFilter(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKeyToMatch, int nValueToBeCloseTo);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_AddRequestLobbyListFilterSlotsAvailable")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListFilterSlotsAvailable(IntPtr instancePtr, int nSlotsAvailable);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_AddRequestLobbyListDistanceFilter")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListDistanceFilter(IntPtr instancePtr, ELobbyDistanceFilter eLobbyDistanceFilter);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_AddRequestLobbyListResultCountFilter")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListResultCountFilter(IntPtr instancePtr, int cMaxResults);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_AddRequestLobbyListCompatibleMembersFilter")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListCompatibleMembersFilter(IntPtr instancePtr, CSteamID steamIDLobby);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_GetLobbyByIndex")]
		public static extern ulong ISteamMatchmaking_GetLobbyByIndex(IntPtr instancePtr, int iLobby);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_CreateLobby")]
		public static extern ulong ISteamMatchmaking_CreateLobby(IntPtr instancePtr, ELobbyType eLobbyType, int cMaxMembers);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_JoinLobby")]
		public static extern ulong ISteamMatchmaking_JoinLobby(IntPtr instancePtr, CSteamID steamIDLobby);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_LeaveLobby")]
		public static extern void ISteamMatchmaking_LeaveLobby(IntPtr instancePtr, CSteamID steamIDLobby);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_InviteUserToLobby")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_InviteUserToLobby(IntPtr instancePtr, CSteamID steamIDLobby, CSteamID steamIDInvitee);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_GetNumLobbyMembers")]
		public static extern int ISteamMatchmaking_GetNumLobbyMembers(IntPtr instancePtr, CSteamID steamIDLobby);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_GetLobbyMemberByIndex")]
		public static extern ulong ISteamMatchmaking_GetLobbyMemberByIndex(IntPtr instancePtr, CSteamID steamIDLobby, int iMember);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_GetLobbyData")]
		public static extern IntPtr ISteamMatchmaking_GetLobbyData(IntPtr instancePtr, CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_SetLobbyData")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_SetLobbyData(IntPtr instancePtr, CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_GetLobbyDataCount")]
		public static extern int ISteamMatchmaking_GetLobbyDataCount(IntPtr instancePtr, CSteamID steamIDLobby);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_GetLobbyDataByIndex")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_GetLobbyDataByIndex(IntPtr instancePtr, CSteamID steamIDLobby, int iLobbyData, IntPtr pchKey, int cchKeyBufferSize, IntPtr pchValue, int cchValueBufferSize);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_DeleteLobbyData")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_DeleteLobbyData(IntPtr instancePtr, CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_GetLobbyMemberData")]
		public static extern IntPtr ISteamMatchmaking_GetLobbyMemberData(IntPtr instancePtr, CSteamID steamIDLobby, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchKey);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_SetLobbyMemberData")]
		public static extern void ISteamMatchmaking_SetLobbyMemberData(IntPtr instancePtr, CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_SendLobbyChatMsg")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_SendLobbyChatMsg(IntPtr instancePtr, CSteamID steamIDLobby, byte[] pvMsgBody, int cubMsgBody);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_GetLobbyChatEntry")]
		public static extern int ISteamMatchmaking_GetLobbyChatEntry(IntPtr instancePtr, CSteamID steamIDLobby, int iChatID, out CSteamID pSteamIDUser, byte[] pvData, int cubData, out EChatEntryType peChatEntryType);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_RequestLobbyData")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_RequestLobbyData(IntPtr instancePtr, CSteamID steamIDLobby);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_SetLobbyGameServer")]
		public static extern void ISteamMatchmaking_SetLobbyGameServer(IntPtr instancePtr, CSteamID steamIDLobby, uint unGameServerIP, ushort unGameServerPort, CSteamID steamIDGameServer);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_GetLobbyGameServer")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_GetLobbyGameServer(IntPtr instancePtr, CSteamID steamIDLobby, out uint punGameServerIP, out ushort punGameServerPort, out CSteamID psteamIDGameServer);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_SetLobbyMemberLimit")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_SetLobbyMemberLimit(IntPtr instancePtr, CSteamID steamIDLobby, int cMaxMembers);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_GetLobbyMemberLimit")]
		public static extern int ISteamMatchmaking_GetLobbyMemberLimit(IntPtr instancePtr, CSteamID steamIDLobby);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_SetLobbyType")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_SetLobbyType(IntPtr instancePtr, CSteamID steamIDLobby, ELobbyType eLobbyType);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_SetLobbyJoinable")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_SetLobbyJoinable(IntPtr instancePtr, CSteamID steamIDLobby, [MarshalAs(UnmanagedType.I1)] bool bLobbyJoinable);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_GetLobbyOwner")]
		public static extern ulong ISteamMatchmaking_GetLobbyOwner(IntPtr instancePtr, CSteamID steamIDLobby);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_SetLobbyOwner")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_SetLobbyOwner(IntPtr instancePtr, CSteamID steamIDLobby, CSteamID steamIDNewOwner);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_SetLinkedLobby")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_SetLinkedLobby(IntPtr instancePtr, CSteamID steamIDLobby, CSteamID steamIDLobbyDependent);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_RequestInternetServerList")]
		public static extern IntPtr ISteamMatchmakingServers_RequestInternetServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_RequestLANServerList")]
		public static extern IntPtr ISteamMatchmakingServers_RequestLANServerList(IntPtr instancePtr, AppId_t iApp, IntPtr pRequestServersResponse);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_RequestFriendsServerList")]
		public static extern IntPtr ISteamMatchmakingServers_RequestFriendsServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_RequestFavoritesServerList")]
		public static extern IntPtr ISteamMatchmakingServers_RequestFavoritesServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_RequestHistoryServerList")]
		public static extern IntPtr ISteamMatchmakingServers_RequestHistoryServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_RequestSpectatorServerList")]
		public static extern IntPtr ISteamMatchmakingServers_RequestSpectatorServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_ReleaseRequest")]
		public static extern void ISteamMatchmakingServers_ReleaseRequest(IntPtr instancePtr, HServerListRequest hServerListRequest);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_GetServerDetails")]
		public static extern IntPtr ISteamMatchmakingServers_GetServerDetails(IntPtr instancePtr, HServerListRequest hRequest, int iServer);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_CancelQuery")]
		public static extern void ISteamMatchmakingServers_CancelQuery(IntPtr instancePtr, HServerListRequest hRequest);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_RefreshQuery")]
		public static extern void ISteamMatchmakingServers_RefreshQuery(IntPtr instancePtr, HServerListRequest hRequest);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_IsRefreshing")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmakingServers_IsRefreshing(IntPtr instancePtr, HServerListRequest hRequest);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_GetServerCount")]
		public static extern int ISteamMatchmakingServers_GetServerCount(IntPtr instancePtr, HServerListRequest hRequest);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_RefreshServer")]
		public static extern void ISteamMatchmakingServers_RefreshServer(IntPtr instancePtr, HServerListRequest hRequest, int iServer);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_PingServer")]
		public static extern int ISteamMatchmakingServers_PingServer(IntPtr instancePtr, uint unIP, ushort usPort, IntPtr pRequestServersResponse);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_PlayerDetails")]
		public static extern int ISteamMatchmakingServers_PlayerDetails(IntPtr instancePtr, uint unIP, ushort usPort, IntPtr pRequestServersResponse);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_ServerRules")]
		public static extern int ISteamMatchmakingServers_ServerRules(IntPtr instancePtr, uint unIP, ushort usPort, IntPtr pRequestServersResponse);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_CancelServerQuery")]
		public static extern void ISteamMatchmakingServers_CancelServerQuery(IntPtr instancePtr, HServerQuery hServerQuery);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusic_BIsEnabled")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusic_BIsEnabled(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusic_BIsPlaying")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusic_BIsPlaying(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusic_GetPlaybackStatus")]
		public static extern AudioPlayback_Status ISteamMusic_GetPlaybackStatus(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusic_Play")]
		public static extern void ISteamMusic_Play(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusic_Pause")]
		public static extern void ISteamMusic_Pause(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusic_PlayPrevious")]
		public static extern void ISteamMusic_PlayPrevious(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusic_PlayNext")]
		public static extern void ISteamMusic_PlayNext(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusic_SetVolume")]
		public static extern void ISteamMusic_SetVolume(IntPtr instancePtr, float flVolume);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusic_GetVolume")]
		public static extern float ISteamMusic_GetVolume(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_RegisterSteamMusicRemote")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_RegisterSteamMusicRemote(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_DeregisterSteamMusicRemote")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_DeregisterSteamMusicRemote(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_BIsCurrentMusicRemote")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_BIsCurrentMusicRemote(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_BActivationSuccess")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_BActivationSuccess(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bValue);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_SetDisplayName")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_SetDisplayName(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchDisplayName);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_SetPNGIcon_64x64")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_SetPNGIcon_64x64(IntPtr instancePtr, byte[] pvBuffer, uint cbBufferLength);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_EnablePlayPrevious")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_EnablePlayPrevious(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bValue);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_EnablePlayNext")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_EnablePlayNext(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bValue);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_EnableShuffled")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_EnableShuffled(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bValue);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_EnableLooped")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_EnableLooped(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bValue);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_EnableQueue")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_EnableQueue(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bValue);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_EnablePlaylists")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_EnablePlaylists(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bValue);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_UpdatePlaybackStatus")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_UpdatePlaybackStatus(IntPtr instancePtr, AudioPlayback_Status nStatus);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_UpdateShuffled")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_UpdateShuffled(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bValue);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_UpdateLooped")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_UpdateLooped(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bValue);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_UpdateVolume")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_UpdateVolume(IntPtr instancePtr, float flValue);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_CurrentEntryWillChange")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_CurrentEntryWillChange(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_CurrentEntryIsAvailable")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_CurrentEntryIsAvailable(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bAvailable);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_UpdateCurrentEntryText")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_UpdateCurrentEntryText(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchText);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_UpdateCurrentEntryElapsedSeconds")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_UpdateCurrentEntryElapsedSeconds(IntPtr instancePtr, int nValue);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_UpdateCurrentEntryCoverArt")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_UpdateCurrentEntryCoverArt(IntPtr instancePtr, byte[] pvBuffer, uint cbBufferLength);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_CurrentEntryDidChange")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_CurrentEntryDidChange(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_QueueWillChange")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_QueueWillChange(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_ResetQueueEntries")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_ResetQueueEntries(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_SetQueueEntry")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_SetQueueEntry(IntPtr instancePtr, int nID, int nPosition, InteropHelp.UTF8StringHandle pchEntryText);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_SetCurrentQueueEntry")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_SetCurrentQueueEntry(IntPtr instancePtr, int nID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_QueueDidChange")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_QueueDidChange(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_PlaylistWillChange")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_PlaylistWillChange(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_ResetPlaylistEntries")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_ResetPlaylistEntries(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_SetPlaylistEntry")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_SetPlaylistEntry(IntPtr instancePtr, int nID, int nPosition, InteropHelp.UTF8StringHandle pchEntryText);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_SetCurrentPlaylistEntry")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_SetCurrentPlaylistEntry(IntPtr instancePtr, int nID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_PlaylistDidChange")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_PlaylistDidChange(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_SendP2PPacket")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_SendP2PPacket(IntPtr instancePtr, CSteamID steamIDRemote, byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_IsP2PPacketAvailable")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_IsP2PPacketAvailable(IntPtr instancePtr, out uint pcubMsgSize, int nChannel);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_ReadP2PPacket")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_ReadP2PPacket(IntPtr instancePtr, byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_AcceptP2PSessionWithUser")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_AcceptP2PSessionWithUser(IntPtr instancePtr, CSteamID steamIDRemote);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_CloseP2PSessionWithUser")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_CloseP2PSessionWithUser(IntPtr instancePtr, CSteamID steamIDRemote);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_CloseP2PChannelWithUser")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_CloseP2PChannelWithUser(IntPtr instancePtr, CSteamID steamIDRemote, int nChannel);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_GetP2PSessionState")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_GetP2PSessionState(IntPtr instancePtr, CSteamID steamIDRemote, out P2PSessionState_t pConnectionState);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_AllowP2PPacketRelay")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_AllowP2PPacketRelay(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bAllow);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_CreateListenSocket")]
		public static extern uint ISteamNetworking_CreateListenSocket(IntPtr instancePtr, int nVirtualP2PPort, uint nIP, ushort nPort, [MarshalAs(UnmanagedType.I1)] bool bAllowUseOfPacketRelay);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_CreateP2PConnectionSocket")]
		public static extern uint ISteamNetworking_CreateP2PConnectionSocket(IntPtr instancePtr, CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, [MarshalAs(UnmanagedType.I1)] bool bAllowUseOfPacketRelay);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_CreateConnectionSocket")]
		public static extern uint ISteamNetworking_CreateConnectionSocket(IntPtr instancePtr, uint nIP, ushort nPort, int nTimeoutSec);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_DestroySocket")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_DestroySocket(IntPtr instancePtr, SNetSocket_t hSocket, [MarshalAs(UnmanagedType.I1)] bool bNotifyRemoteEnd);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_DestroyListenSocket")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_DestroyListenSocket(IntPtr instancePtr, SNetListenSocket_t hSocket, [MarshalAs(UnmanagedType.I1)] bool bNotifyRemoteEnd);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_SendDataOnSocket")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_SendDataOnSocket(IntPtr instancePtr, SNetSocket_t hSocket, byte[] pubData, uint cubData, [MarshalAs(UnmanagedType.I1)] bool bReliable);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_IsDataAvailableOnSocket")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_IsDataAvailableOnSocket(IntPtr instancePtr, SNetSocket_t hSocket, out uint pcubMsgSize);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_RetrieveDataFromSocket")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_RetrieveDataFromSocket(IntPtr instancePtr, SNetSocket_t hSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_IsDataAvailable")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_IsDataAvailable(IntPtr instancePtr, SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_RetrieveData")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_RetrieveData(IntPtr instancePtr, SNetListenSocket_t hListenSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_GetSocketInfo")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_GetSocketInfo(IntPtr instancePtr, SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out uint punIPRemote, out ushort punPortRemote);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_GetListenSocketInfo")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_GetListenSocketInfo(IntPtr instancePtr, SNetListenSocket_t hListenSocket, out uint pnIP, out ushort pnPort);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_GetSocketConnectionType")]
		public static extern ESNetSocketConnectionType ISteamNetworking_GetSocketConnectionType(IntPtr instancePtr, SNetSocket_t hSocket);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_GetMaxPacketSize")]
		public static extern int ISteamNetworking_GetMaxPacketSize(IntPtr instancePtr, SNetSocket_t hSocket);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamParentalSettings_BIsParentalLockEnabled")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamParentalSettings_BIsParentalLockEnabled(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamParentalSettings_BIsParentalLockLocked")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamParentalSettings_BIsParentalLockLocked(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamParentalSettings_BIsAppBlocked")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamParentalSettings_BIsAppBlocked(IntPtr instancePtr, AppId_t nAppID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamParentalSettings_BIsAppInBlockList")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamParentalSettings_BIsAppInBlockList(IntPtr instancePtr, AppId_t nAppID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamParentalSettings_BIsFeatureBlocked")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamParentalSettings_BIsFeatureBlocked(IntPtr instancePtr, EParentalFeature eFeature);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamParentalSettings_BIsFeatureInBlockList")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamParentalSettings_BIsFeatureInBlockList(IntPtr instancePtr, EParentalFeature eFeature);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileWrite")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_FileWrite(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, byte[] pvData, int cubData);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileRead")]
		public static extern int ISteamRemoteStorage_FileRead(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, byte[] pvData, int cubDataToRead);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileWriteAsync")]
		public static extern ulong ISteamRemoteStorage_FileWriteAsync(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, byte[] pvData, uint cubData);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileReadAsync")]
		public static extern ulong ISteamRemoteStorage_FileReadAsync(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, uint nOffset, uint cubToRead);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileReadAsyncComplete")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_FileReadAsyncComplete(IntPtr instancePtr, SteamAPICall_t hReadCall, byte[] pvBuffer, uint cubToRead);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileForget")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_FileForget(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileDelete")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_FileDelete(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileShare")]
		public static extern ulong ISteamRemoteStorage_FileShare(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_SetSyncPlatforms")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_SetSyncPlatforms(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, ERemoteStoragePlatform eRemoteStoragePlatform);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileWriteStreamOpen")]
		public static extern ulong ISteamRemoteStorage_FileWriteStreamOpen(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileWriteStreamWriteChunk")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_FileWriteStreamWriteChunk(IntPtr instancePtr, UGCFileWriteStreamHandle_t writeHandle, byte[] pvData, int cubData);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileWriteStreamClose")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_FileWriteStreamClose(IntPtr instancePtr, UGCFileWriteStreamHandle_t writeHandle);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileWriteStreamCancel")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_FileWriteStreamCancel(IntPtr instancePtr, UGCFileWriteStreamHandle_t writeHandle);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileExists")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_FileExists(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FilePersisted")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_FilePersisted(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetFileSize")]
		public static extern int ISteamRemoteStorage_GetFileSize(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetFileTimestamp")]
		public static extern long ISteamRemoteStorage_GetFileTimestamp(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetSyncPlatforms")]
		public static extern ERemoteStoragePlatform ISteamRemoteStorage_GetSyncPlatforms(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetFileCount")]
		public static extern int ISteamRemoteStorage_GetFileCount(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetFileNameAndSize")]
		public static extern IntPtr ISteamRemoteStorage_GetFileNameAndSize(IntPtr instancePtr, int iFile, out int pnFileSizeInBytes);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetQuota")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_GetQuota(IntPtr instancePtr, out ulong pnTotalBytes, out ulong puAvailableBytes);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_IsCloudEnabledForAccount")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_IsCloudEnabledForAccount(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_IsCloudEnabledForApp")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_IsCloudEnabledForApp(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_SetCloudEnabledForApp")]
		public static extern void ISteamRemoteStorage_SetCloudEnabledForApp(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bEnabled);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_UGCDownload")]
		public static extern ulong ISteamRemoteStorage_UGCDownload(IntPtr instancePtr, UGCHandle_t hContent, uint unPriority);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetUGCDownloadProgress")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_GetUGCDownloadProgress(IntPtr instancePtr, UGCHandle_t hContent, out int pnBytesDownloaded, out int pnBytesExpected);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetUGCDetails")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_GetUGCDetails(IntPtr instancePtr, UGCHandle_t hContent, out AppId_t pnAppID, out IntPtr ppchName, out int pnFileSizeInBytes, out CSteamID pSteamIDOwner);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_UGCRead")]
		public static extern int ISteamRemoteStorage_UGCRead(IntPtr instancePtr, UGCHandle_t hContent, byte[] pvData, int cubDataToRead, uint cOffset, EUGCReadAction eAction);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetCachedUGCCount")]
		public static extern int ISteamRemoteStorage_GetCachedUGCCount(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetCachedUGCHandle")]
		public static extern ulong ISteamRemoteStorage_GetCachedUGCHandle(IntPtr instancePtr, int iCachedContent);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_PublishWorkshopFile")]
		public static extern ulong ISteamRemoteStorage_PublishWorkshopFile(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, InteropHelp.UTF8StringHandle pchPreviewFile, AppId_t nConsumerAppId, InteropHelp.UTF8StringHandle pchTitle, InteropHelp.UTF8StringHandle pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IntPtr pTags, EWorkshopFileType eWorkshopFileType);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_CreatePublishedFileUpdateRequest")]
		public static extern ulong ISteamRemoteStorage_CreatePublishedFileUpdateRequest(IntPtr instancePtr, PublishedFileId_t unPublishedFileId);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_UpdatePublishedFileFile")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileFile(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchFile);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_UpdatePublishedFilePreviewFile")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFilePreviewFile(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchPreviewFile);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_UpdatePublishedFileTitle")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileTitle(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchTitle);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_UpdatePublishedFileDescription")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileDescription(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchDescription);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_UpdatePublishedFileVisibility")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileVisibility(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, ERemoteStoragePublishedFileVisibility eVisibility);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_UpdatePublishedFileTags")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileTags(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, IntPtr pTags);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_CommitPublishedFileUpdate")]
		public static extern ulong ISteamRemoteStorage_CommitPublishedFileUpdate(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetPublishedFileDetails")]
		public static extern ulong ISteamRemoteStorage_GetPublishedFileDetails(IntPtr instancePtr, PublishedFileId_t unPublishedFileId, uint unMaxSecondsOld);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_DeletePublishedFile")]
		public static extern ulong ISteamRemoteStorage_DeletePublishedFile(IntPtr instancePtr, PublishedFileId_t unPublishedFileId);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_EnumerateUserPublishedFiles")]
		public static extern ulong ISteamRemoteStorage_EnumerateUserPublishedFiles(IntPtr instancePtr, uint unStartIndex);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_SubscribePublishedFile")]
		public static extern ulong ISteamRemoteStorage_SubscribePublishedFile(IntPtr instancePtr, PublishedFileId_t unPublishedFileId);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_EnumerateUserSubscribedFiles")]
		public static extern ulong ISteamRemoteStorage_EnumerateUserSubscribedFiles(IntPtr instancePtr, uint unStartIndex);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_UnsubscribePublishedFile")]
		public static extern ulong ISteamRemoteStorage_UnsubscribePublishedFile(IntPtr instancePtr, PublishedFileId_t unPublishedFileId);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_UpdatePublishedFileSetChangeDescription")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileSetChangeDescription(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchChangeDescription);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetPublishedItemVoteDetails")]
		public static extern ulong ISteamRemoteStorage_GetPublishedItemVoteDetails(IntPtr instancePtr, PublishedFileId_t unPublishedFileId);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_UpdateUserPublishedItemVote")]
		public static extern ulong ISteamRemoteStorage_UpdateUserPublishedItemVote(IntPtr instancePtr, PublishedFileId_t unPublishedFileId, [MarshalAs(UnmanagedType.I1)] bool bVoteUp);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetUserPublishedItemVoteDetails")]
		public static extern ulong ISteamRemoteStorage_GetUserPublishedItemVoteDetails(IntPtr instancePtr, PublishedFileId_t unPublishedFileId);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_EnumerateUserSharedWorkshopFiles")]
		public static extern ulong ISteamRemoteStorage_EnumerateUserSharedWorkshopFiles(IntPtr instancePtr, CSteamID steamId, uint unStartIndex, IntPtr pRequiredTags, IntPtr pExcludedTags);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_PublishVideo")]
		public static extern ulong ISteamRemoteStorage_PublishVideo(IntPtr instancePtr, EWorkshopVideoProvider eVideoProvider, InteropHelp.UTF8StringHandle pchVideoAccount, InteropHelp.UTF8StringHandle pchVideoIdentifier, InteropHelp.UTF8StringHandle pchPreviewFile, AppId_t nConsumerAppId, InteropHelp.UTF8StringHandle pchTitle, InteropHelp.UTF8StringHandle pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IntPtr pTags);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_SetUserPublishedFileAction")]
		public static extern ulong ISteamRemoteStorage_SetUserPublishedFileAction(IntPtr instancePtr, PublishedFileId_t unPublishedFileId, EWorkshopFileAction eAction);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_EnumeratePublishedFilesByUserAction")]
		public static extern ulong ISteamRemoteStorage_EnumeratePublishedFilesByUserAction(IntPtr instancePtr, EWorkshopFileAction eAction, uint unStartIndex);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_EnumeratePublishedWorkshopFiles")]
		public static extern ulong ISteamRemoteStorage_EnumeratePublishedWorkshopFiles(IntPtr instancePtr, EWorkshopEnumerationType eEnumerationType, uint unStartIndex, uint unCount, uint unDays, IntPtr pTags, IntPtr pUserTags);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_UGCDownloadToLocation")]
		public static extern ulong ISteamRemoteStorage_UGCDownloadToLocation(IntPtr instancePtr, UGCHandle_t hContent, InteropHelp.UTF8StringHandle pchLocation, uint unPriority);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamScreenshots_WriteScreenshot")]
		public static extern uint ISteamScreenshots_WriteScreenshot(IntPtr instancePtr, byte[] pubRGB, uint cubRGB, int nWidth, int nHeight);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamScreenshots_AddScreenshotToLibrary")]
		public static extern uint ISteamScreenshots_AddScreenshotToLibrary(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFilename, InteropHelp.UTF8StringHandle pchThumbnailFilename, int nWidth, int nHeight);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamScreenshots_TriggerScreenshot")]
		public static extern void ISteamScreenshots_TriggerScreenshot(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamScreenshots_HookScreenshots")]
		public static extern void ISteamScreenshots_HookScreenshots(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bHook);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamScreenshots_SetLocation")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamScreenshots_SetLocation(IntPtr instancePtr, ScreenshotHandle hScreenshot, InteropHelp.UTF8StringHandle pchLocation);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamScreenshots_TagUser")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamScreenshots_TagUser(IntPtr instancePtr, ScreenshotHandle hScreenshot, CSteamID steamID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamScreenshots_TagPublishedFile")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamScreenshots_TagPublishedFile(IntPtr instancePtr, ScreenshotHandle hScreenshot, PublishedFileId_t unPublishedFileID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamScreenshots_IsScreenshotsHooked")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamScreenshots_IsScreenshotsHooked(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamScreenshots_AddVRScreenshotToLibrary")]
		public static extern uint ISteamScreenshots_AddVRScreenshotToLibrary(IntPtr instancePtr, EVRScreenshotType eType, InteropHelp.UTF8StringHandle pchFilename, InteropHelp.UTF8StringHandle pchVRFilename);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_CreateQueryUserUGCRequest")]
		public static extern ulong ISteamUGC_CreateQueryUserUGCRequest(IntPtr instancePtr, AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_CreateQueryAllUGCRequest")]
		public static extern ulong ISteamUGC_CreateQueryAllUGCRequest(IntPtr instancePtr, EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_CreateQueryUGCDetailsRequest")]
		public static extern ulong ISteamUGC_CreateQueryUGCDetailsRequest(IntPtr instancePtr, [In][Out] PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SendQueryUGCRequest")]
		public static extern ulong ISteamUGC_SendQueryUGCRequest(IntPtr instancePtr, UGCQueryHandle_t handle);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCResult")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_GetQueryUGCResult(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCPreviewURL")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_GetQueryUGCPreviewURL(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, IntPtr pchURL, uint cchURLSize);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCMetadata")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_GetQueryUGCMetadata(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, IntPtr pchMetadata, uint cchMetadatasize);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCChildren")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_GetQueryUGCChildren(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, [In][Out] PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCStatistic")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_GetQueryUGCStatistic(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, EItemStatistic eStatType, out ulong pStatValue);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCNumAdditionalPreviews")]
		public static extern uint ISteamUGC_GetQueryUGCNumAdditionalPreviews(IntPtr instancePtr, UGCQueryHandle_t handle, uint index);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCAdditionalPreview")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_GetQueryUGCAdditionalPreview(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, uint previewIndex, IntPtr pchURLOrVideoID, uint cchURLSize, IntPtr pchOriginalFileName, uint cchOriginalFileNameSize, out EItemPreviewType pPreviewType);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCNumKeyValueTags")]
		public static extern uint ISteamUGC_GetQueryUGCNumKeyValueTags(IntPtr instancePtr, UGCQueryHandle_t handle, uint index);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCKeyValueTag")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_GetQueryUGCKeyValueTag(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, IntPtr pchKey, uint cchKeySize, IntPtr pchValue, uint cchValueSize);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_ReleaseQueryUGCRequest")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_ReleaseQueryUGCRequest(IntPtr instancePtr, UGCQueryHandle_t handle);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_AddRequiredTag")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_AddRequiredTag(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pTagName);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_AddExcludedTag")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_AddExcludedTag(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pTagName);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetReturnOnlyIDs")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetReturnOnlyIDs(IntPtr instancePtr, UGCQueryHandle_t handle, [MarshalAs(UnmanagedType.I1)] bool bReturnOnlyIDs);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetReturnKeyValueTags")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetReturnKeyValueTags(IntPtr instancePtr, UGCQueryHandle_t handle, [MarshalAs(UnmanagedType.I1)] bool bReturnKeyValueTags);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetReturnLongDescription")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetReturnLongDescription(IntPtr instancePtr, UGCQueryHandle_t handle, [MarshalAs(UnmanagedType.I1)] bool bReturnLongDescription);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetReturnMetadata")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetReturnMetadata(IntPtr instancePtr, UGCQueryHandle_t handle, [MarshalAs(UnmanagedType.I1)] bool bReturnMetadata);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetReturnChildren")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetReturnChildren(IntPtr instancePtr, UGCQueryHandle_t handle, [MarshalAs(UnmanagedType.I1)] bool bReturnChildren);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetReturnAdditionalPreviews")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetReturnAdditionalPreviews(IntPtr instancePtr, UGCQueryHandle_t handle, [MarshalAs(UnmanagedType.I1)] bool bReturnAdditionalPreviews);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetReturnTotalOnly")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetReturnTotalOnly(IntPtr instancePtr, UGCQueryHandle_t handle, [MarshalAs(UnmanagedType.I1)] bool bReturnTotalOnly);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetReturnPlaytimeStats")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetReturnPlaytimeStats(IntPtr instancePtr, UGCQueryHandle_t handle, uint unDays);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetLanguage")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetLanguage(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pchLanguage);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetAllowCachedResponse")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetAllowCachedResponse(IntPtr instancePtr, UGCQueryHandle_t handle, uint unMaxAgeSeconds);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetCloudFileNameFilter")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetCloudFileNameFilter(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pMatchCloudFileName);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetMatchAnyTag")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetMatchAnyTag(IntPtr instancePtr, UGCQueryHandle_t handle, [MarshalAs(UnmanagedType.I1)] bool bMatchAnyTag);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetSearchText")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetSearchText(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pSearchText);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetRankedByTrendDays")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetRankedByTrendDays(IntPtr instancePtr, UGCQueryHandle_t handle, uint unDays);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_AddRequiredKeyValueTag")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_AddRequiredKeyValueTag(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pKey, InteropHelp.UTF8StringHandle pValue);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_RequestUGCDetails")]
		public static extern ulong ISteamUGC_RequestUGCDetails(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_CreateItem")]
		public static extern ulong ISteamUGC_CreateItem(IntPtr instancePtr, AppId_t nConsumerAppId, EWorkshopFileType eFileType);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_StartItemUpdate")]
		public static extern ulong ISteamUGC_StartItemUpdate(IntPtr instancePtr, AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetItemTitle")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetItemTitle(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchTitle);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetItemDescription")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetItemDescription(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchDescription);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetItemUpdateLanguage")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetItemUpdateLanguage(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchLanguage);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetItemMetadata")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetItemMetadata(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchMetaData);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetItemVisibility")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetItemVisibility(IntPtr instancePtr, UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetItemTags")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetItemTags(IntPtr instancePtr, UGCUpdateHandle_t updateHandle, IntPtr pTags);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetItemContent")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetItemContent(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszContentFolder);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetItemPreview")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetItemPreview(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszPreviewFile);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_RemoveItemKeyValueTags")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_RemoveItemKeyValueTags(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchKey);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_AddItemKeyValueTag")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_AddItemKeyValueTag(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_AddItemPreviewFile")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_AddItemPreviewFile(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszPreviewFile, EItemPreviewType type);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_AddItemPreviewVideo")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_AddItemPreviewVideo(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszVideoID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_UpdateItemPreviewFile")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_UpdateItemPreviewFile(IntPtr instancePtr, UGCUpdateHandle_t handle, uint index, InteropHelp.UTF8StringHandle pszPreviewFile);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_UpdateItemPreviewVideo")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_UpdateItemPreviewVideo(IntPtr instancePtr, UGCUpdateHandle_t handle, uint index, InteropHelp.UTF8StringHandle pszVideoID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_RemoveItemPreview")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_RemoveItemPreview(IntPtr instancePtr, UGCUpdateHandle_t handle, uint index);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SubmitItemUpdate")]
		public static extern ulong ISteamUGC_SubmitItemUpdate(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchChangeNote);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetItemUpdateProgress")]
		public static extern EItemUpdateStatus ISteamUGC_GetItemUpdateProgress(IntPtr instancePtr, UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetUserItemVote")]
		public static extern ulong ISteamUGC_SetUserItemVote(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, [MarshalAs(UnmanagedType.I1)] bool bVoteUp);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetUserItemVote")]
		public static extern ulong ISteamUGC_GetUserItemVote(IntPtr instancePtr, PublishedFileId_t nPublishedFileID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_AddItemToFavorites")]
		public static extern ulong ISteamUGC_AddItemToFavorites(IntPtr instancePtr, AppId_t nAppId, PublishedFileId_t nPublishedFileID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_RemoveItemFromFavorites")]
		public static extern ulong ISteamUGC_RemoveItemFromFavorites(IntPtr instancePtr, AppId_t nAppId, PublishedFileId_t nPublishedFileID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SubscribeItem")]
		public static extern ulong ISteamUGC_SubscribeItem(IntPtr instancePtr, PublishedFileId_t nPublishedFileID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_UnsubscribeItem")]
		public static extern ulong ISteamUGC_UnsubscribeItem(IntPtr instancePtr, PublishedFileId_t nPublishedFileID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetNumSubscribedItems")]
		public static extern uint ISteamUGC_GetNumSubscribedItems(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetSubscribedItems")]
		public static extern uint ISteamUGC_GetSubscribedItems(IntPtr instancePtr, [In][Out] PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetItemState")]
		public static extern uint ISteamUGC_GetItemState(IntPtr instancePtr, PublishedFileId_t nPublishedFileID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetItemInstallInfo")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_GetItemInstallInfo(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, IntPtr pchFolder, uint cchFolderSize, out uint punTimeStamp);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetItemDownloadInfo")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_GetItemDownloadInfo(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, out ulong punBytesDownloaded, out ulong punBytesTotal);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_DownloadItem")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_DownloadItem(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, [MarshalAs(UnmanagedType.I1)] bool bHighPriority);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_BInitWorkshopForGameServer")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_BInitWorkshopForGameServer(IntPtr instancePtr, DepotId_t unWorkshopDepotID, InteropHelp.UTF8StringHandle pszFolder);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SuspendDownloads")]
		public static extern void ISteamUGC_SuspendDownloads(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bSuspend);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_StartPlaytimeTracking")]
		public static extern ulong ISteamUGC_StartPlaytimeTracking(IntPtr instancePtr, [In][Out] PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_StopPlaytimeTracking")]
		public static extern ulong ISteamUGC_StopPlaytimeTracking(IntPtr instancePtr, [In][Out] PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_StopPlaytimeTrackingForAllItems")]
		public static extern ulong ISteamUGC_StopPlaytimeTrackingForAllItems(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_AddDependency")]
		public static extern ulong ISteamUGC_AddDependency(IntPtr instancePtr, PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_RemoveDependency")]
		public static extern ulong ISteamUGC_RemoveDependency(IntPtr instancePtr, PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_AddAppDependency")]
		public static extern ulong ISteamUGC_AddAppDependency(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, AppId_t nAppID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_RemoveAppDependency")]
		public static extern ulong ISteamUGC_RemoveAppDependency(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, AppId_t nAppID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetAppDependencies")]
		public static extern ulong ISteamUGC_GetAppDependencies(IntPtr instancePtr, PublishedFileId_t nPublishedFileID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_DeleteItem")]
		public static extern ulong ISteamUGC_DeleteItem(IntPtr instancePtr, PublishedFileId_t nPublishedFileID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUnifiedMessages_SendMethod")]
		public static extern ulong ISteamUnifiedMessages_SendMethod(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchServiceMethod, byte[] pRequestBuffer, uint unRequestBufferSize, ulong unContext);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUnifiedMessages_GetMethodResponseInfo")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUnifiedMessages_GetMethodResponseInfo(IntPtr instancePtr, ClientUnifiedMessageHandle hHandle, out uint punResponseSize, out EResult peResult);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUnifiedMessages_GetMethodResponseData")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUnifiedMessages_GetMethodResponseData(IntPtr instancePtr, ClientUnifiedMessageHandle hHandle, byte[] pResponseBuffer, uint unResponseBufferSize, [MarshalAs(UnmanagedType.I1)] bool bAutoRelease);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUnifiedMessages_ReleaseMethod")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUnifiedMessages_ReleaseMethod(IntPtr instancePtr, ClientUnifiedMessageHandle hHandle);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUnifiedMessages_SendNotification")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUnifiedMessages_SendNotification(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchServiceNotification, byte[] pNotificationBuffer, uint unNotificationBufferSize);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_GetHSteamUser")]
		public static extern int ISteamUser_GetHSteamUser(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_BLoggedOn")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUser_BLoggedOn(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_GetSteamID")]
		public static extern ulong ISteamUser_GetSteamID(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_InitiateGameConnection")]
		public static extern int ISteamUser_InitiateGameConnection(IntPtr instancePtr, byte[] pAuthBlob, int cbMaxAuthBlob, CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer, [MarshalAs(UnmanagedType.I1)] bool bSecure);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_TerminateGameConnection")]
		public static extern void ISteamUser_TerminateGameConnection(IntPtr instancePtr, uint unIPServer, ushort usPortServer);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_TrackAppUsageEvent")]
		public static extern void ISteamUser_TrackAppUsageEvent(IntPtr instancePtr, CGameID gameID, int eAppUsageEvent, InteropHelp.UTF8StringHandle pchExtraInfo);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_GetUserDataFolder")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUser_GetUserDataFolder(IntPtr instancePtr, IntPtr pchBuffer, int cubBuffer);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_StartVoiceRecording")]
		public static extern void ISteamUser_StartVoiceRecording(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_StopVoiceRecording")]
		public static extern void ISteamUser_StopVoiceRecording(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_GetAvailableVoice")]
		public static extern EVoiceResult ISteamUser_GetAvailableVoice(IntPtr instancePtr, out uint pcbCompressed, IntPtr pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_GetVoice")]
		public static extern EVoiceResult ISteamUser_GetVoice(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bWantCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, [MarshalAs(UnmanagedType.I1)] bool bWantUncompressed_Deprecated, IntPtr pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, IntPtr nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_DecompressVoice")]
		public static extern EVoiceResult ISteamUser_DecompressVoice(IntPtr instancePtr, byte[] pCompressed, uint cbCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, uint nDesiredSampleRate);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_GetVoiceOptimalSampleRate")]
		public static extern uint ISteamUser_GetVoiceOptimalSampleRate(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_GetAuthSessionTicket")]
		public static extern uint ISteamUser_GetAuthSessionTicket(IntPtr instancePtr, byte[] pTicket, int cbMaxTicket, out uint pcbTicket);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_BeginAuthSession")]
		public static extern EBeginAuthSessionResult ISteamUser_BeginAuthSession(IntPtr instancePtr, byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_EndAuthSession")]
		public static extern void ISteamUser_EndAuthSession(IntPtr instancePtr, CSteamID steamID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_CancelAuthTicket")]
		public static extern void ISteamUser_CancelAuthTicket(IntPtr instancePtr, HAuthTicket hAuthTicket);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_UserHasLicenseForApp")]
		public static extern EUserHasLicenseForAppResult ISteamUser_UserHasLicenseForApp(IntPtr instancePtr, CSteamID steamID, AppId_t appID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_BIsBehindNAT")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUser_BIsBehindNAT(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_AdvertiseGame")]
		public static extern void ISteamUser_AdvertiseGame(IntPtr instancePtr, CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_RequestEncryptedAppTicket")]
		public static extern ulong ISteamUser_RequestEncryptedAppTicket(IntPtr instancePtr, byte[] pDataToInclude, int cbDataToInclude);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_GetEncryptedAppTicket")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUser_GetEncryptedAppTicket(IntPtr instancePtr, byte[] pTicket, int cbMaxTicket, out uint pcbTicket);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_GetGameBadgeLevel")]
		public static extern int ISteamUser_GetGameBadgeLevel(IntPtr instancePtr, int nSeries, [MarshalAs(UnmanagedType.I1)] bool bFoil);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_GetPlayerSteamLevel")]
		public static extern int ISteamUser_GetPlayerSteamLevel(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_RequestStoreAuthURL")]
		public static extern ulong ISteamUser_RequestStoreAuthURL(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchRedirectURL);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_BIsPhoneVerified")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUser_BIsPhoneVerified(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_BIsTwoFactorEnabled")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUser_BIsTwoFactorEnabled(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_BIsPhoneIdentifying")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUser_BIsPhoneIdentifying(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_BIsPhoneRequiringVerification")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUser_BIsPhoneRequiringVerification(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_RequestCurrentStats")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_RequestCurrentStats(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetStat")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_GetStat(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out int pData);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetStat0")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_GetStat0(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out float pData);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_SetStat")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_SetStat(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, int nData);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_SetStat0")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_SetStat0(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, float fData);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_UpdateAvgRateStat")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_UpdateAvgRateStat(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, float flCountThisSession, double dSessionLength);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetAchievement")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_GetAchievement(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_SetAchievement")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_SetAchievement(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_ClearAchievement")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_ClearAchievement(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetAchievementAndUnlockTime")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_GetAchievementAndUnlockTime(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved, out uint punUnlockTime);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_StoreStats")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_StoreStats(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetAchievementIcon")]
		public static extern int ISteamUserStats_GetAchievementIcon(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetAchievementDisplayAttribute")]
		public static extern IntPtr ISteamUserStats_GetAchievementDisplayAttribute(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, InteropHelp.UTF8StringHandle pchKey);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_IndicateAchievementProgress")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_IndicateAchievementProgress(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, uint nCurProgress, uint nMaxProgress);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetNumAchievements")]
		public static extern uint ISteamUserStats_GetNumAchievements(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetAchievementName")]
		public static extern IntPtr ISteamUserStats_GetAchievementName(IntPtr instancePtr, uint iAchievement);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_RequestUserStats")]
		public static extern ulong ISteamUserStats_RequestUserStats(IntPtr instancePtr, CSteamID steamIDUser);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetUserStat")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_GetUserStat(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out int pData);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetUserStat0")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_GetUserStat0(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out float pData);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetUserAchievement")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_GetUserAchievement(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetUserAchievementAndUnlockTime")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_GetUserAchievementAndUnlockTime(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved, out uint punUnlockTime);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_ResetAllStats")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_ResetAllStats(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bAchievementsToo);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_FindOrCreateLeaderboard")]
		public static extern ulong ISteamUserStats_FindOrCreateLeaderboard(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_FindLeaderboard")]
		public static extern ulong ISteamUserStats_FindLeaderboard(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchLeaderboardName);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetLeaderboardName")]
		public static extern IntPtr ISteamUserStats_GetLeaderboardName(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetLeaderboardEntryCount")]
		public static extern int ISteamUserStats_GetLeaderboardEntryCount(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetLeaderboardSortMethod")]
		public static extern ELeaderboardSortMethod ISteamUserStats_GetLeaderboardSortMethod(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetLeaderboardDisplayType")]
		public static extern ELeaderboardDisplayType ISteamUserStats_GetLeaderboardDisplayType(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_DownloadLeaderboardEntries")]
		public static extern ulong ISteamUserStats_DownloadLeaderboardEntries(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_DownloadLeaderboardEntriesForUsers")]
		public static extern ulong ISteamUserStats_DownloadLeaderboardEntriesForUsers(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard, [In][Out] CSteamID[] prgUsers, int cUsers);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetDownloadedLeaderboardEntry")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_GetDownloadedLeaderboardEntry(IntPtr instancePtr, SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, out LeaderboardEntry_t pLeaderboardEntry, [In][Out] int[] pDetails, int cDetailsMax);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_UploadLeaderboardScore")]
		public static extern ulong ISteamUserStats_UploadLeaderboardScore(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, [In][Out] int[] pScoreDetails, int cScoreDetailsCount);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_AttachLeaderboardUGC")]
		public static extern ulong ISteamUserStats_AttachLeaderboardUGC(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard, UGCHandle_t hUGC);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetNumberOfCurrentPlayers")]
		public static extern ulong ISteamUserStats_GetNumberOfCurrentPlayers(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_RequestGlobalAchievementPercentages")]
		public static extern ulong ISteamUserStats_RequestGlobalAchievementPercentages(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetMostAchievedAchievementInfo")]
		public static extern int ISteamUserStats_GetMostAchievedAchievementInfo(IntPtr instancePtr, IntPtr pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetNextMostAchievedAchievementInfo")]
		public static extern int ISteamUserStats_GetNextMostAchievedAchievementInfo(IntPtr instancePtr, int iIteratorPrevious, IntPtr pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetAchievementAchievedPercent")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_GetAchievementAchievedPercent(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out float pflPercent);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_RequestGlobalStats")]
		public static extern ulong ISteamUserStats_RequestGlobalStats(IntPtr instancePtr, int nHistoryDays);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetGlobalStat")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_GetGlobalStat(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchStatName, out long pData);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetGlobalStat0")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_GetGlobalStat0(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchStatName, out double pData);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetGlobalStatHistory")]
		public static extern int ISteamUserStats_GetGlobalStatHistory(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchStatName, [In][Out] long[] pData, uint cubData);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetGlobalStatHistory0")]
		public static extern int ISteamUserStats_GetGlobalStatHistory0(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchStatName, [In][Out] double[] pData, uint cubData);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetSecondsSinceAppActive")]
		public static extern uint ISteamUtils_GetSecondsSinceAppActive(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetSecondsSinceComputerActive")]
		public static extern uint ISteamUtils_GetSecondsSinceComputerActive(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetConnectedUniverse")]
		public static extern EUniverse ISteamUtils_GetConnectedUniverse(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetServerRealTime")]
		public static extern uint ISteamUtils_GetServerRealTime(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetIPCountry")]
		public static extern IntPtr ISteamUtils_GetIPCountry(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetImageSize")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUtils_GetImageSize(IntPtr instancePtr, int iImage, out uint pnWidth, out uint pnHeight);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetImageRGBA")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUtils_GetImageRGBA(IntPtr instancePtr, int iImage, byte[] pubDest, int nDestBufferSize);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetCSERIPPort")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUtils_GetCSERIPPort(IntPtr instancePtr, out uint unIP, out ushort usPort);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetCurrentBatteryPower")]
		public static extern byte ISteamUtils_GetCurrentBatteryPower(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetAppID")]
		public static extern uint ISteamUtils_GetAppID(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_SetOverlayNotificationPosition")]
		public static extern void ISteamUtils_SetOverlayNotificationPosition(IntPtr instancePtr, ENotificationPosition eNotificationPosition);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_IsAPICallCompleted")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUtils_IsAPICallCompleted(IntPtr instancePtr, SteamAPICall_t hSteamAPICall, out bool pbFailed);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetAPICallFailureReason")]
		public static extern ESteamAPICallFailure ISteamUtils_GetAPICallFailureReason(IntPtr instancePtr, SteamAPICall_t hSteamAPICall);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetAPICallResult")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUtils_GetAPICallResult(IntPtr instancePtr, SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetIPCCallCount")]
		public static extern uint ISteamUtils_GetIPCCallCount(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_SetWarningMessageHook")]
		public static extern void ISteamUtils_SetWarningMessageHook(IntPtr instancePtr, SteamAPIWarningMessageHook_t pFunction);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_IsOverlayEnabled")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUtils_IsOverlayEnabled(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_BOverlayNeedsPresent")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUtils_BOverlayNeedsPresent(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_CheckFileSignature")]
		public static extern ulong ISteamUtils_CheckFileSignature(IntPtr instancePtr, InteropHelp.UTF8StringHandle szFileName);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_ShowGamepadTextInput")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUtils_ShowGamepadTextInput(IntPtr instancePtr, EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, InteropHelp.UTF8StringHandle pchDescription, uint unCharMax, InteropHelp.UTF8StringHandle pchExistingText);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetEnteredGamepadTextLength")]
		public static extern uint ISteamUtils_GetEnteredGamepadTextLength(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetEnteredGamepadTextInput")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUtils_GetEnteredGamepadTextInput(IntPtr instancePtr, IntPtr pchText, uint cchText);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetSteamUILanguage")]
		public static extern IntPtr ISteamUtils_GetSteamUILanguage(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_IsSteamRunningInVR")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUtils_IsSteamRunningInVR(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_SetOverlayNotificationInset")]
		public static extern void ISteamUtils_SetOverlayNotificationInset(IntPtr instancePtr, int nHorizontalInset, int nVerticalInset);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_IsSteamInBigPictureMode")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUtils_IsSteamInBigPictureMode(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_StartVRDashboard")]
		public static extern void ISteamUtils_StartVRDashboard(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_IsVRHeadsetStreamingEnabled")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUtils_IsVRHeadsetStreamingEnabled(IntPtr instancePtr);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_SetVRHeadsetStreamingEnabled")]
		public static extern void ISteamUtils_SetVRHeadsetStreamingEnabled(IntPtr instancePtr, [MarshalAs(UnmanagedType.I1)] bool bEnabled);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamVideo_GetVideoURL")]
		public static extern void ISteamVideo_GetVideoURL(IntPtr instancePtr, AppId_t unVideoAppID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamVideo_IsBroadcasting")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamVideo_IsBroadcasting(IntPtr instancePtr, out int pnNumViewers);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamVideo_GetOPFSettings")]
		public static extern void ISteamVideo_GetOPFSettings(IntPtr instancePtr, AppId_t unVideoAppID);

		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamVideo_GetOPFStringForApp")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamVideo_GetOPFStringForApp(IntPtr instancePtr, AppId_t unVideoAppID, IntPtr pchBuffer, ref int pnBufferSize);
	}
}

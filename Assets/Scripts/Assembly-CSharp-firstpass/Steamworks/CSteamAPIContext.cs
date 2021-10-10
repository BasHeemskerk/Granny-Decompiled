using System;

namespace Steamworks
{
	internal static class CSteamAPIContext
	{
		private static IntPtr m_pSteamClient;

		private static IntPtr m_pSteamUser;

		private static IntPtr m_pSteamFriends;

		private static IntPtr m_pSteamUtils;

		private static IntPtr m_pSteamMatchmaking;

		private static IntPtr m_pSteamUserStats;

		private static IntPtr m_pSteamApps;

		private static IntPtr m_pSteamMatchmakingServers;

		private static IntPtr m_pSteamNetworking;

		private static IntPtr m_pSteamRemoteStorage;

		private static IntPtr m_pSteamScreenshots;

		private static IntPtr m_pSteamHTTP;

		private static IntPtr m_pSteamUnifiedMessages;

		private static IntPtr m_pController;

		private static IntPtr m_pSteamUGC;

		private static IntPtr m_pSteamAppList;

		private static IntPtr m_pSteamMusic;

		private static IntPtr m_pSteamMusicRemote;

		private static IntPtr m_pSteamHTMLSurface;

		private static IntPtr m_pSteamInventory;

		private static IntPtr m_pSteamVideo;

		private static IntPtr m_pSteamParentalSettings;

		internal static void Clear()
		{
			m_pSteamClient = IntPtr.Zero;
			m_pSteamUser = IntPtr.Zero;
			m_pSteamFriends = IntPtr.Zero;
			m_pSteamUtils = IntPtr.Zero;
			m_pSteamMatchmaking = IntPtr.Zero;
			m_pSteamUserStats = IntPtr.Zero;
			m_pSteamApps = IntPtr.Zero;
			m_pSteamMatchmakingServers = IntPtr.Zero;
			m_pSteamNetworking = IntPtr.Zero;
			m_pSteamRemoteStorage = IntPtr.Zero;
			m_pSteamHTTP = IntPtr.Zero;
			m_pSteamScreenshots = IntPtr.Zero;
			m_pSteamMusic = IntPtr.Zero;
			m_pSteamUnifiedMessages = IntPtr.Zero;
			m_pController = IntPtr.Zero;
			m_pSteamUGC = IntPtr.Zero;
			m_pSteamAppList = IntPtr.Zero;
			m_pSteamMusic = IntPtr.Zero;
			m_pSteamMusicRemote = IntPtr.Zero;
			m_pSteamHTMLSurface = IntPtr.Zero;
			m_pSteamInventory = IntPtr.Zero;
			m_pSteamVideo = IntPtr.Zero;
			m_pSteamParentalSettings = IntPtr.Zero;
		}

		internal static bool Init()
		{
			HSteamUser hSteamUser = SteamAPI.GetHSteamUser();
			HSteamPipe hSteamPipe = SteamAPI.GetHSteamPipe();
			if (hSteamPipe == (HSteamPipe)0)
			{
				return false;
			}
			using (InteropHelp.UTF8StringHandle ver = new InteropHelp.UTF8StringHandle("SteamClient017"))
			{
				m_pSteamClient = NativeMethods.SteamInternal_CreateInterface(ver);
			}
			if (m_pSteamClient == IntPtr.Zero)
			{
				return false;
			}
			m_pSteamUser = SteamClient.GetISteamUser(hSteamUser, hSteamPipe, "SteamUser019");
			if (m_pSteamUser == IntPtr.Zero)
			{
				return false;
			}
			m_pSteamFriends = SteamClient.GetISteamFriends(hSteamUser, hSteamPipe, "SteamFriends015");
			if (m_pSteamFriends == IntPtr.Zero)
			{
				return false;
			}
			m_pSteamUtils = SteamClient.GetISteamUtils(hSteamPipe, "SteamUtils009");
			if (m_pSteamUtils == IntPtr.Zero)
			{
				return false;
			}
			m_pSteamMatchmaking = SteamClient.GetISteamMatchmaking(hSteamUser, hSteamPipe, "SteamMatchMaking009");
			if (m_pSteamMatchmaking == IntPtr.Zero)
			{
				return false;
			}
			m_pSteamMatchmakingServers = SteamClient.GetISteamMatchmakingServers(hSteamUser, hSteamPipe, "SteamMatchMakingServers002");
			if (m_pSteamMatchmakingServers == IntPtr.Zero)
			{
				return false;
			}
			m_pSteamUserStats = SteamClient.GetISteamUserStats(hSteamUser, hSteamPipe, "STEAMUSERSTATS_INTERFACE_VERSION011");
			if (m_pSteamUserStats == IntPtr.Zero)
			{
				return false;
			}
			m_pSteamApps = SteamClient.GetISteamApps(hSteamUser, hSteamPipe, "STEAMAPPS_INTERFACE_VERSION008");
			if (m_pSteamApps == IntPtr.Zero)
			{
				return false;
			}
			m_pSteamNetworking = SteamClient.GetISteamNetworking(hSteamUser, hSteamPipe, "SteamNetworking005");
			if (m_pSteamNetworking == IntPtr.Zero)
			{
				return false;
			}
			m_pSteamRemoteStorage = SteamClient.GetISteamRemoteStorage(hSteamUser, hSteamPipe, "STEAMREMOTESTORAGE_INTERFACE_VERSION014");
			if (m_pSteamRemoteStorage == IntPtr.Zero)
			{
				return false;
			}
			m_pSteamScreenshots = SteamClient.GetISteamScreenshots(hSteamUser, hSteamPipe, "STEAMSCREENSHOTS_INTERFACE_VERSION003");
			if (m_pSteamScreenshots == IntPtr.Zero)
			{
				return false;
			}
			m_pSteamHTTP = SteamClient.GetISteamHTTP(hSteamUser, hSteamPipe, "STEAMHTTP_INTERFACE_VERSION002");
			if (m_pSteamHTTP == IntPtr.Zero)
			{
				return false;
			}
			m_pSteamUnifiedMessages = SteamClient.GetISteamUnifiedMessages(hSteamUser, hSteamPipe, "STEAMUNIFIEDMESSAGES_INTERFACE_VERSION001");
			if (m_pSteamUnifiedMessages == IntPtr.Zero)
			{
				return false;
			}
			m_pController = SteamClient.GetISteamController(hSteamUser, hSteamPipe, "SteamController005");
			if (m_pController == IntPtr.Zero)
			{
				return false;
			}
			m_pSteamUGC = SteamClient.GetISteamUGC(hSteamUser, hSteamPipe, "STEAMUGC_INTERFACE_VERSION010");
			if (m_pSteamUGC == IntPtr.Zero)
			{
				return false;
			}
			m_pSteamAppList = SteamClient.GetISteamAppList(hSteamUser, hSteamPipe, "STEAMAPPLIST_INTERFACE_VERSION001");
			if (m_pSteamAppList == IntPtr.Zero)
			{
				return false;
			}
			m_pSteamMusic = SteamClient.GetISteamMusic(hSteamUser, hSteamPipe, "STEAMMUSIC_INTERFACE_VERSION001");
			if (m_pSteamMusic == IntPtr.Zero)
			{
				return false;
			}
			m_pSteamMusicRemote = SteamClient.GetISteamMusicRemote(hSteamUser, hSteamPipe, "STEAMMUSICREMOTE_INTERFACE_VERSION001");
			if (m_pSteamMusicRemote == IntPtr.Zero)
			{
				return false;
			}
			m_pSteamHTMLSurface = SteamClient.GetISteamHTMLSurface(hSteamUser, hSteamPipe, "STEAMHTMLSURFACE_INTERFACE_VERSION_004");
			if (m_pSteamHTMLSurface == IntPtr.Zero)
			{
				return false;
			}
			m_pSteamInventory = SteamClient.GetISteamInventory(hSteamUser, hSteamPipe, "STEAMINVENTORY_INTERFACE_V002");
			if (m_pSteamInventory == IntPtr.Zero)
			{
				return false;
			}
			m_pSteamVideo = SteamClient.GetISteamVideo(hSteamUser, hSteamPipe, "STEAMVIDEO_INTERFACE_V002");
			if (m_pSteamVideo == IntPtr.Zero)
			{
				return false;
			}
			m_pSteamParentalSettings = SteamClient.GetISteamParentalSettings(hSteamUser, hSteamPipe, "STEAMPARENTALSETTINGS_INTERFACE_VERSION001");
			if (m_pSteamParentalSettings == IntPtr.Zero)
			{
				return false;
			}
			return true;
		}

		internal static IntPtr GetSteamClient()
		{
			return m_pSteamClient;
		}

		internal static IntPtr GetSteamUser()
		{
			return m_pSteamUser;
		}

		internal static IntPtr GetSteamFriends()
		{
			return m_pSteamFriends;
		}

		internal static IntPtr GetSteamUtils()
		{
			return m_pSteamUtils;
		}

		internal static IntPtr GetSteamMatchmaking()
		{
			return m_pSteamMatchmaking;
		}

		internal static IntPtr GetSteamUserStats()
		{
			return m_pSteamUserStats;
		}

		internal static IntPtr GetSteamApps()
		{
			return m_pSteamApps;
		}

		internal static IntPtr GetSteamMatchmakingServers()
		{
			return m_pSteamMatchmakingServers;
		}

		internal static IntPtr GetSteamNetworking()
		{
			return m_pSteamNetworking;
		}

		internal static IntPtr GetSteamRemoteStorage()
		{
			return m_pSteamRemoteStorage;
		}

		internal static IntPtr GetSteamScreenshots()
		{
			return m_pSteamScreenshots;
		}

		internal static IntPtr GetSteamHTTP()
		{
			return m_pSteamHTTP;
		}

		internal static IntPtr GetSteamUnifiedMessages()
		{
			return m_pSteamUnifiedMessages;
		}

		internal static IntPtr GetSteamController()
		{
			return m_pController;
		}

		internal static IntPtr GetSteamUGC()
		{
			return m_pSteamUGC;
		}

		internal static IntPtr GetSteamAppList()
		{
			return m_pSteamAppList;
		}

		internal static IntPtr GetSteamMusic()
		{
			return m_pSteamMusic;
		}

		internal static IntPtr GetSteamMusicRemote()
		{
			return m_pSteamMusicRemote;
		}

		internal static IntPtr GetSteamHTMLSurface()
		{
			return m_pSteamHTMLSurface;
		}

		internal static IntPtr GetSteamInventory()
		{
			return m_pSteamInventory;
		}

		internal static IntPtr GetSteamVideo()
		{
			return m_pSteamVideo;
		}

		internal static IntPtr GetSteamParentalSettings()
		{
			return m_pSteamParentalSettings;
		}
	}
}

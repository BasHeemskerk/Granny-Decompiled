using System;

namespace Steamworks
{
	public static class SteamClient
	{
		public static HSteamPipe CreateSteamPipe()
		{
			InteropHelp.TestIfAvailableClient();
			return (HSteamPipe)NativeMethods.ISteamClient_CreateSteamPipe(CSteamAPIContext.GetSteamClient());
		}

		public static bool BReleaseSteamPipe(HSteamPipe hSteamPipe)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamClient_BReleaseSteamPipe(CSteamAPIContext.GetSteamClient(), hSteamPipe);
		}

		public static HSteamUser ConnectToGlobalUser(HSteamPipe hSteamPipe)
		{
			InteropHelp.TestIfAvailableClient();
			return (HSteamUser)NativeMethods.ISteamClient_ConnectToGlobalUser(CSteamAPIContext.GetSteamClient(), hSteamPipe);
		}

		public static HSteamUser CreateLocalUser(out HSteamPipe phSteamPipe, EAccountType eAccountType)
		{
			InteropHelp.TestIfAvailableClient();
			return (HSteamUser)NativeMethods.ISteamClient_CreateLocalUser(CSteamAPIContext.GetSteamClient(), out phSteamPipe, eAccountType);
		}

		public static void ReleaseUser(HSteamPipe hSteamPipe, HSteamUser hUser)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamClient_ReleaseUser(CSteamAPIContext.GetSteamClient(), hSteamPipe, hUser);
		}

		public static IntPtr GetISteamUser(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				return NativeMethods.ISteamClient_GetISteamUser(CSteamAPIContext.GetSteamClient(), hSteamUser, hSteamPipe, pchVersion2);
			}
		}

		public static IntPtr GetISteamGameServer(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				return NativeMethods.ISteamClient_GetISteamGameServer(CSteamAPIContext.GetSteamClient(), hSteamUser, hSteamPipe, pchVersion2);
			}
		}

		public static void SetLocalIPBinding(uint unIP, ushort usPort)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamClient_SetLocalIPBinding(CSteamAPIContext.GetSteamClient(), unIP, usPort);
		}

		public static IntPtr GetISteamFriends(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				return NativeMethods.ISteamClient_GetISteamFriends(CSteamAPIContext.GetSteamClient(), hSteamUser, hSteamPipe, pchVersion2);
			}
		}

		public static IntPtr GetISteamUtils(HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				return NativeMethods.ISteamClient_GetISteamUtils(CSteamAPIContext.GetSteamClient(), hSteamPipe, pchVersion2);
			}
		}

		public static IntPtr GetISteamMatchmaking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				return NativeMethods.ISteamClient_GetISteamMatchmaking(CSteamAPIContext.GetSteamClient(), hSteamUser, hSteamPipe, pchVersion2);
			}
		}

		public static IntPtr GetISteamMatchmakingServers(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				return NativeMethods.ISteamClient_GetISteamMatchmakingServers(CSteamAPIContext.GetSteamClient(), hSteamUser, hSteamPipe, pchVersion2);
			}
		}

		public static IntPtr GetISteamGenericInterface(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				return NativeMethods.ISteamClient_GetISteamGenericInterface(CSteamAPIContext.GetSteamClient(), hSteamUser, hSteamPipe, pchVersion2);
			}
		}

		public static IntPtr GetISteamUserStats(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				return NativeMethods.ISteamClient_GetISteamUserStats(CSteamAPIContext.GetSteamClient(), hSteamUser, hSteamPipe, pchVersion2);
			}
		}

		public static IntPtr GetISteamGameServerStats(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				return NativeMethods.ISteamClient_GetISteamGameServerStats(CSteamAPIContext.GetSteamClient(), hSteamuser, hSteamPipe, pchVersion2);
			}
		}

		public static IntPtr GetISteamApps(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				return NativeMethods.ISteamClient_GetISteamApps(CSteamAPIContext.GetSteamClient(), hSteamUser, hSteamPipe, pchVersion2);
			}
		}

		public static IntPtr GetISteamNetworking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				return NativeMethods.ISteamClient_GetISteamNetworking(CSteamAPIContext.GetSteamClient(), hSteamUser, hSteamPipe, pchVersion2);
			}
		}

		public static IntPtr GetISteamRemoteStorage(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				return NativeMethods.ISteamClient_GetISteamRemoteStorage(CSteamAPIContext.GetSteamClient(), hSteamuser, hSteamPipe, pchVersion2);
			}
		}

		public static IntPtr GetISteamScreenshots(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				return NativeMethods.ISteamClient_GetISteamScreenshots(CSteamAPIContext.GetSteamClient(), hSteamuser, hSteamPipe, pchVersion2);
			}
		}

		public static uint GetIPCCallCount()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamClient_GetIPCCallCount(CSteamAPIContext.GetSteamClient());
		}

		public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamClient_SetWarningMessageHook(CSteamAPIContext.GetSteamClient(), pFunction);
		}

		public static bool BShutdownIfAllPipesClosed()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamClient_BShutdownIfAllPipesClosed(CSteamAPIContext.GetSteamClient());
		}

		public static IntPtr GetISteamHTTP(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				return NativeMethods.ISteamClient_GetISteamHTTP(CSteamAPIContext.GetSteamClient(), hSteamuser, hSteamPipe, pchVersion2);
			}
		}

		public static IntPtr GetISteamUnifiedMessages(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				return NativeMethods.ISteamClient_GetISteamUnifiedMessages(CSteamAPIContext.GetSteamClient(), hSteamuser, hSteamPipe, pchVersion2);
			}
		}

		public static IntPtr GetISteamController(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				return NativeMethods.ISteamClient_GetISteamController(CSteamAPIContext.GetSteamClient(), hSteamUser, hSteamPipe, pchVersion2);
			}
		}

		public static IntPtr GetISteamUGC(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				return NativeMethods.ISteamClient_GetISteamUGC(CSteamAPIContext.GetSteamClient(), hSteamUser, hSteamPipe, pchVersion2);
			}
		}

		public static IntPtr GetISteamAppList(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				return NativeMethods.ISteamClient_GetISteamAppList(CSteamAPIContext.GetSteamClient(), hSteamUser, hSteamPipe, pchVersion2);
			}
		}

		public static IntPtr GetISteamMusic(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				return NativeMethods.ISteamClient_GetISteamMusic(CSteamAPIContext.GetSteamClient(), hSteamuser, hSteamPipe, pchVersion2);
			}
		}

		public static IntPtr GetISteamMusicRemote(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				return NativeMethods.ISteamClient_GetISteamMusicRemote(CSteamAPIContext.GetSteamClient(), hSteamuser, hSteamPipe, pchVersion2);
			}
		}

		public static IntPtr GetISteamHTMLSurface(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				return NativeMethods.ISteamClient_GetISteamHTMLSurface(CSteamAPIContext.GetSteamClient(), hSteamuser, hSteamPipe, pchVersion2);
			}
		}

		public static IntPtr GetISteamInventory(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				return NativeMethods.ISteamClient_GetISteamInventory(CSteamAPIContext.GetSteamClient(), hSteamuser, hSteamPipe, pchVersion2);
			}
		}

		public static IntPtr GetISteamVideo(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				return NativeMethods.ISteamClient_GetISteamVideo(CSteamAPIContext.GetSteamClient(), hSteamuser, hSteamPipe, pchVersion2);
			}
		}

		public static IntPtr GetISteamParentalSettings(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion))
			{
				return NativeMethods.ISteamClient_GetISteamParentalSettings(CSteamAPIContext.GetSteamClient(), hSteamuser, hSteamPipe, pchVersion2);
			}
		}
	}
}

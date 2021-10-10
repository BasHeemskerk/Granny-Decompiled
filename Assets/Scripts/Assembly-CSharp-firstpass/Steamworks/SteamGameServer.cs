namespace Steamworks
{
	public static class SteamGameServer
	{
		public static bool InitGameServer(uint unIP, ushort usGamePort, ushort usQueryPort, uint unFlags, AppId_t nGameAppId, string pchVersionString)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle pchVersionString2 = new InteropHelp.UTF8StringHandle(pchVersionString))
			{
				return NativeMethods.ISteamGameServer_InitGameServer(CSteamGameServerAPIContext.GetSteamGameServer(), unIP, usGamePort, usQueryPort, unFlags, nGameAppId, pchVersionString2);
			}
		}

		public static void SetProduct(string pszProduct)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle pszProduct2 = new InteropHelp.UTF8StringHandle(pszProduct))
			{
				NativeMethods.ISteamGameServer_SetProduct(CSteamGameServerAPIContext.GetSteamGameServer(), pszProduct2);
			}
		}

		public static void SetGameDescription(string pszGameDescription)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle pszGameDescription2 = new InteropHelp.UTF8StringHandle(pszGameDescription))
			{
				NativeMethods.ISteamGameServer_SetGameDescription(CSteamGameServerAPIContext.GetSteamGameServer(), pszGameDescription2);
			}
		}

		public static void SetModDir(string pszModDir)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle pszModDir2 = new InteropHelp.UTF8StringHandle(pszModDir))
			{
				NativeMethods.ISteamGameServer_SetModDir(CSteamGameServerAPIContext.GetSteamGameServer(), pszModDir2);
			}
		}

		public static void SetDedicatedServer(bool bDedicated)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_SetDedicatedServer(CSteamGameServerAPIContext.GetSteamGameServer(), bDedicated);
		}

		public static void LogOn(string pszToken)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle pszToken2 = new InteropHelp.UTF8StringHandle(pszToken))
			{
				NativeMethods.ISteamGameServer_LogOn(CSteamGameServerAPIContext.GetSteamGameServer(), pszToken2);
			}
		}

		public static void LogOnAnonymous()
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_LogOnAnonymous(CSteamGameServerAPIContext.GetSteamGameServer());
		}

		public static void LogOff()
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_LogOff(CSteamGameServerAPIContext.GetSteamGameServer());
		}

		public static bool BLoggedOn()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServer_BLoggedOn(CSteamGameServerAPIContext.GetSteamGameServer());
		}

		public static bool BSecure()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServer_BSecure(CSteamGameServerAPIContext.GetSteamGameServer());
		}

		public static CSteamID GetSteamID()
		{
			InteropHelp.TestIfAvailableGameServer();
			return (CSteamID)NativeMethods.ISteamGameServer_GetSteamID(CSteamGameServerAPIContext.GetSteamGameServer());
		}

		public static bool WasRestartRequested()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServer_WasRestartRequested(CSteamGameServerAPIContext.GetSteamGameServer());
		}

		public static void SetMaxPlayerCount(int cPlayersMax)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_SetMaxPlayerCount(CSteamGameServerAPIContext.GetSteamGameServer(), cPlayersMax);
		}

		public static void SetBotPlayerCount(int cBotplayers)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_SetBotPlayerCount(CSteamGameServerAPIContext.GetSteamGameServer(), cBotplayers);
		}

		public static void SetServerName(string pszServerName)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle pszServerName2 = new InteropHelp.UTF8StringHandle(pszServerName))
			{
				NativeMethods.ISteamGameServer_SetServerName(CSteamGameServerAPIContext.GetSteamGameServer(), pszServerName2);
			}
		}

		public static void SetMapName(string pszMapName)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle pszMapName2 = new InteropHelp.UTF8StringHandle(pszMapName))
			{
				NativeMethods.ISteamGameServer_SetMapName(CSteamGameServerAPIContext.GetSteamGameServer(), pszMapName2);
			}
		}

		public static void SetPasswordProtected(bool bPasswordProtected)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_SetPasswordProtected(CSteamGameServerAPIContext.GetSteamGameServer(), bPasswordProtected);
		}

		public static void SetSpectatorPort(ushort unSpectatorPort)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_SetSpectatorPort(CSteamGameServerAPIContext.GetSteamGameServer(), unSpectatorPort);
		}

		public static void SetSpectatorServerName(string pszSpectatorServerName)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle pszSpectatorServerName2 = new InteropHelp.UTF8StringHandle(pszSpectatorServerName))
			{
				NativeMethods.ISteamGameServer_SetSpectatorServerName(CSteamGameServerAPIContext.GetSteamGameServer(), pszSpectatorServerName2);
			}
		}

		public static void ClearAllKeyValues()
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_ClearAllKeyValues(CSteamGameServerAPIContext.GetSteamGameServer());
		}

		public static void SetKeyValue(string pKey, string pValue)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle pKey2 = new InteropHelp.UTF8StringHandle(pKey))
			{
				using (InteropHelp.UTF8StringHandle pValue2 = new InteropHelp.UTF8StringHandle(pValue))
				{
					NativeMethods.ISteamGameServer_SetKeyValue(CSteamGameServerAPIContext.GetSteamGameServer(), pKey2, pValue2);
				}
			}
		}

		public static void SetGameTags(string pchGameTags)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle pchGameTags2 = new InteropHelp.UTF8StringHandle(pchGameTags))
			{
				NativeMethods.ISteamGameServer_SetGameTags(CSteamGameServerAPIContext.GetSteamGameServer(), pchGameTags2);
			}
		}

		public static void SetGameData(string pchGameData)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle pchGameData2 = new InteropHelp.UTF8StringHandle(pchGameData))
			{
				NativeMethods.ISteamGameServer_SetGameData(CSteamGameServerAPIContext.GetSteamGameServer(), pchGameData2);
			}
		}

		public static void SetRegion(string pszRegion)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle pszRegion2 = new InteropHelp.UTF8StringHandle(pszRegion))
			{
				NativeMethods.ISteamGameServer_SetRegion(CSteamGameServerAPIContext.GetSteamGameServer(), pszRegion2);
			}
		}

		public static bool SendUserConnectAndAuthenticate(uint unIPClient, byte[] pvAuthBlob, uint cubAuthBlobSize, out CSteamID pSteamIDUser)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServer_SendUserConnectAndAuthenticate(CSteamGameServerAPIContext.GetSteamGameServer(), unIPClient, pvAuthBlob, cubAuthBlobSize, out pSteamIDUser);
		}

		public static CSteamID CreateUnauthenticatedUserConnection()
		{
			InteropHelp.TestIfAvailableGameServer();
			return (CSteamID)NativeMethods.ISteamGameServer_CreateUnauthenticatedUserConnection(CSteamGameServerAPIContext.GetSteamGameServer());
		}

		public static void SendUserDisconnect(CSteamID steamIDUser)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_SendUserDisconnect(CSteamGameServerAPIContext.GetSteamGameServer(), steamIDUser);
		}

		public static bool BUpdateUserData(CSteamID steamIDUser, string pchPlayerName, uint uScore)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle pchPlayerName2 = new InteropHelp.UTF8StringHandle(pchPlayerName))
			{
				return NativeMethods.ISteamGameServer_BUpdateUserData(CSteamGameServerAPIContext.GetSteamGameServer(), steamIDUser, pchPlayerName2, uScore);
			}
		}

		public static HAuthTicket GetAuthSessionTicket(byte[] pTicket, int cbMaxTicket, out uint pcbTicket)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (HAuthTicket)NativeMethods.ISteamGameServer_GetAuthSessionTicket(CSteamGameServerAPIContext.GetSteamGameServer(), pTicket, cbMaxTicket, out pcbTicket);
		}

		public static EBeginAuthSessionResult BeginAuthSession(byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServer_BeginAuthSession(CSteamGameServerAPIContext.GetSteamGameServer(), pAuthTicket, cbAuthTicket, steamID);
		}

		public static void EndAuthSession(CSteamID steamID)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_EndAuthSession(CSteamGameServerAPIContext.GetSteamGameServer(), steamID);
		}

		public static void CancelAuthTicket(HAuthTicket hAuthTicket)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_CancelAuthTicket(CSteamGameServerAPIContext.GetSteamGameServer(), hAuthTicket);
		}

		public static EUserHasLicenseForAppResult UserHasLicenseForApp(CSteamID steamID, AppId_t appID)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServer_UserHasLicenseForApp(CSteamGameServerAPIContext.GetSteamGameServer(), steamID, appID);
		}

		public static bool RequestUserGroupStatus(CSteamID steamIDUser, CSteamID steamIDGroup)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServer_RequestUserGroupStatus(CSteamGameServerAPIContext.GetSteamGameServer(), steamIDUser, steamIDGroup);
		}

		public static void GetGameplayStats()
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_GetGameplayStats(CSteamGameServerAPIContext.GetSteamGameServer());
		}

		public static SteamAPICall_t GetServerReputation()
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamGameServer_GetServerReputation(CSteamGameServerAPIContext.GetSteamGameServer());
		}

		public static uint GetPublicIP()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServer_GetPublicIP(CSteamGameServerAPIContext.GetSteamGameServer());
		}

		public static bool HandleIncomingPacket(byte[] pData, int cbData, uint srcIP, ushort srcPort)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServer_HandleIncomingPacket(CSteamGameServerAPIContext.GetSteamGameServer(), pData, cbData, srcIP, srcPort);
		}

		public static int GetNextOutgoingPacket(byte[] pOut, int cbMaxOut, out uint pNetAdr, out ushort pPort)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServer_GetNextOutgoingPacket(CSteamGameServerAPIContext.GetSteamGameServer(), pOut, cbMaxOut, out pNetAdr, out pPort);
		}

		public static void EnableHeartbeats(bool bActive)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_EnableHeartbeats(CSteamGameServerAPIContext.GetSteamGameServer(), bActive);
		}

		public static void SetHeartbeatInterval(int iHeartbeatInterval)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_SetHeartbeatInterval(CSteamGameServerAPIContext.GetSteamGameServer(), iHeartbeatInterval);
		}

		public static void ForceHeartbeat()
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_ForceHeartbeat(CSteamGameServerAPIContext.GetSteamGameServer());
		}

		public static SteamAPICall_t AssociateWithClan(CSteamID steamIDClan)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamGameServer_AssociateWithClan(CSteamGameServerAPIContext.GetSteamGameServer(), steamIDClan);
		}

		public static SteamAPICall_t ComputeNewPlayerCompatibility(CSteamID steamIDNewPlayer)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamGameServer_ComputeNewPlayerCompatibility(CSteamGameServerAPIContext.GetSteamGameServer(), steamIDNewPlayer);
		}
	}
}

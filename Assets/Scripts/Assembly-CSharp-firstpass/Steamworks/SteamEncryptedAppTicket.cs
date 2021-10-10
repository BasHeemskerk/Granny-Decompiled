using System;
using System.Runtime.InteropServices;

namespace Steamworks
{
	public static class SteamEncryptedAppTicket
	{
		public static bool BDecryptTicket(byte[] rgubTicketEncrypted, uint cubTicketEncrypted, byte[] rgubTicketDecrypted, ref uint pcubTicketDecrypted, byte[] rgubKey, int cubKey)
		{
			InteropHelp.TestIfPlatformSupported();
			return NativeMethods.SteamEncryptedAppTicket_BDecryptTicket(rgubTicketEncrypted, cubTicketEncrypted, rgubTicketDecrypted, ref pcubTicketDecrypted, rgubKey, cubKey);
		}

		public static bool BIsTicketForApp(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID)
		{
			InteropHelp.TestIfPlatformSupported();
			return NativeMethods.SteamEncryptedAppTicket_BIsTicketForApp(rgubTicketDecrypted, cubTicketDecrypted, nAppID);
		}

		public static uint GetTicketIssueTime(byte[] rgubTicketDecrypted, uint cubTicketDecrypted)
		{
			InteropHelp.TestIfPlatformSupported();
			return NativeMethods.SteamEncryptedAppTicket_GetTicketIssueTime(rgubTicketDecrypted, cubTicketDecrypted);
		}

		public static void GetTicketSteamID(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out CSteamID psteamID)
		{
			InteropHelp.TestIfPlatformSupported();
			NativeMethods.SteamEncryptedAppTicket_GetTicketSteamID(rgubTicketDecrypted, cubTicketDecrypted, out psteamID);
		}

		public static uint GetTicketAppID(byte[] rgubTicketDecrypted, uint cubTicketDecrypted)
		{
			InteropHelp.TestIfPlatformSupported();
			return NativeMethods.SteamEncryptedAppTicket_GetTicketAppID(rgubTicketDecrypted, cubTicketDecrypted);
		}

		public static bool BUserOwnsAppInTicket(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID)
		{
			InteropHelp.TestIfPlatformSupported();
			return NativeMethods.SteamEncryptedAppTicket_BUserOwnsAppInTicket(rgubTicketDecrypted, cubTicketDecrypted, nAppID);
		}

		public static bool BUserIsVacBanned(byte[] rgubTicketDecrypted, uint cubTicketDecrypted)
		{
			InteropHelp.TestIfPlatformSupported();
			return NativeMethods.SteamEncryptedAppTicket_BUserIsVacBanned(rgubTicketDecrypted, cubTicketDecrypted);
		}

		public static byte[] GetUserVariableData(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out uint pcubUserData)
		{
			InteropHelp.TestIfPlatformSupported();
			IntPtr source = NativeMethods.SteamEncryptedAppTicket_GetUserVariableData(rgubTicketDecrypted, cubTicketDecrypted, out pcubUserData);
			byte[] array = new byte[pcubUserData];
			Marshal.Copy(source, array, 0, (int)pcubUserData);
			return array;
		}
	}
}

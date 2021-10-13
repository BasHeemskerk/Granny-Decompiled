using System;
using System.Collections.Generic;

namespace Steamworks
{
	public static class SteamRemoteStorage
	{
		public static bool FileWrite(string pchFile, byte[] pvData, int cubData)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchFile2 = new InteropHelp.UTF8StringHandle(pchFile))
			{
				return NativeMethods.ISteamRemoteStorage_FileWrite(CSteamAPIContext.GetSteamRemoteStorage(), pchFile2, pvData, cubData);
			}
		}

		public static int FileRead(string pchFile, byte[] pvData, int cubDataToRead)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchFile2 = new InteropHelp.UTF8StringHandle(pchFile))
			{
				return NativeMethods.ISteamRemoteStorage_FileRead(CSteamAPIContext.GetSteamRemoteStorage(), pchFile2, pvData, cubDataToRead);
			}
		}

		public static SteamAPICall_t FileWriteAsync(string pchFile, byte[] pvData, uint cubData)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchFile2 = new InteropHelp.UTF8StringHandle(pchFile))
			{
				return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_FileWriteAsync(CSteamAPIContext.GetSteamRemoteStorage(), pchFile2, pvData, cubData);
			}
		}

		public static SteamAPICall_t FileReadAsync(string pchFile, uint nOffset, uint cubToRead)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchFile2 = new InteropHelp.UTF8StringHandle(pchFile))
			{
				return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_FileReadAsync(CSteamAPIContext.GetSteamRemoteStorage(), pchFile2, nOffset, cubToRead);
			}
		}

		public static bool FileReadAsyncComplete(SteamAPICall_t hReadCall, byte[] pvBuffer, uint cubToRead)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemoteStorage_FileReadAsyncComplete(CSteamAPIContext.GetSteamRemoteStorage(), hReadCall, pvBuffer, cubToRead);
		}

		public static bool FileForget(string pchFile)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchFile2 = new InteropHelp.UTF8StringHandle(pchFile))
			{
				return NativeMethods.ISteamRemoteStorage_FileForget(CSteamAPIContext.GetSteamRemoteStorage(), pchFile2);
			}
		}

		public static bool FileDelete(string pchFile)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchFile2 = new InteropHelp.UTF8StringHandle(pchFile))
			{
				return NativeMethods.ISteamRemoteStorage_FileDelete(CSteamAPIContext.GetSteamRemoteStorage(), pchFile2);
			}
		}

		public static SteamAPICall_t FileShare(string pchFile)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchFile2 = new InteropHelp.UTF8StringHandle(pchFile))
			{
				return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_FileShare(CSteamAPIContext.GetSteamRemoteStorage(), pchFile2);
			}
		}

		public static bool SetSyncPlatforms(string pchFile, ERemoteStoragePlatform eRemoteStoragePlatform)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchFile2 = new InteropHelp.UTF8StringHandle(pchFile))
			{
				return NativeMethods.ISteamRemoteStorage_SetSyncPlatforms(CSteamAPIContext.GetSteamRemoteStorage(), pchFile2, eRemoteStoragePlatform);
			}
		}

		public static UGCFileWriteStreamHandle_t FileWriteStreamOpen(string pchFile)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchFile2 = new InteropHelp.UTF8StringHandle(pchFile))
			{
				return (UGCFileWriteStreamHandle_t)NativeMethods.ISteamRemoteStorage_FileWriteStreamOpen(CSteamAPIContext.GetSteamRemoteStorage(), pchFile2);
			}
		}

		public static bool FileWriteStreamWriteChunk(UGCFileWriteStreamHandle_t writeHandle, byte[] pvData, int cubData)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemoteStorage_FileWriteStreamWriteChunk(CSteamAPIContext.GetSteamRemoteStorage(), writeHandle, pvData, cubData);
		}

		public static bool FileWriteStreamClose(UGCFileWriteStreamHandle_t writeHandle)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemoteStorage_FileWriteStreamClose(CSteamAPIContext.GetSteamRemoteStorage(), writeHandle);
		}

		public static bool FileWriteStreamCancel(UGCFileWriteStreamHandle_t writeHandle)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemoteStorage_FileWriteStreamCancel(CSteamAPIContext.GetSteamRemoteStorage(), writeHandle);
		}

		public static bool FileExists(string pchFile)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchFile2 = new InteropHelp.UTF8StringHandle(pchFile))
			{
				return NativeMethods.ISteamRemoteStorage_FileExists(CSteamAPIContext.GetSteamRemoteStorage(), pchFile2);
			}
		}

		public static bool FilePersisted(string pchFile)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchFile2 = new InteropHelp.UTF8StringHandle(pchFile))
			{
				return NativeMethods.ISteamRemoteStorage_FilePersisted(CSteamAPIContext.GetSteamRemoteStorage(), pchFile2);
			}
		}

		public static int GetFileSize(string pchFile)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchFile2 = new InteropHelp.UTF8StringHandle(pchFile))
			{
				return NativeMethods.ISteamRemoteStorage_GetFileSize(CSteamAPIContext.GetSteamRemoteStorage(), pchFile2);
			}
		}

		public static long GetFileTimestamp(string pchFile)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchFile2 = new InteropHelp.UTF8StringHandle(pchFile))
			{
				return NativeMethods.ISteamRemoteStorage_GetFileTimestamp(CSteamAPIContext.GetSteamRemoteStorage(), pchFile2);
			}
		}

		public static ERemoteStoragePlatform GetSyncPlatforms(string pchFile)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchFile2 = new InteropHelp.UTF8StringHandle(pchFile))
			{
				return NativeMethods.ISteamRemoteStorage_GetSyncPlatforms(CSteamAPIContext.GetSteamRemoteStorage(), pchFile2);
			}
		}

		public static int GetFileCount()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemoteStorage_GetFileCount(CSteamAPIContext.GetSteamRemoteStorage());
		}

		public static string GetFileNameAndSize(int iFile, out int pnFileSizeInBytes)
		{
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamRemoteStorage_GetFileNameAndSize(CSteamAPIContext.GetSteamRemoteStorage(), iFile, out pnFileSizeInBytes));
		}

		public static bool GetQuota(out ulong pnTotalBytes, out ulong puAvailableBytes)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemoteStorage_GetQuota(CSteamAPIContext.GetSteamRemoteStorage(), out pnTotalBytes, out puAvailableBytes);
		}

		public static bool IsCloudEnabledForAccount()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemoteStorage_IsCloudEnabledForAccount(CSteamAPIContext.GetSteamRemoteStorage());
		}

		public static bool IsCloudEnabledForApp()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemoteStorage_IsCloudEnabledForApp(CSteamAPIContext.GetSteamRemoteStorage());
		}

		public static void SetCloudEnabledForApp(bool bEnabled)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamRemoteStorage_SetCloudEnabledForApp(CSteamAPIContext.GetSteamRemoteStorage(), bEnabled);
		}

		public static SteamAPICall_t UGCDownload(UGCHandle_t hContent, uint unPriority)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_UGCDownload(CSteamAPIContext.GetSteamRemoteStorage(), hContent, unPriority);
		}

		public static bool GetUGCDownloadProgress(UGCHandle_t hContent, out int pnBytesDownloaded, out int pnBytesExpected)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemoteStorage_GetUGCDownloadProgress(CSteamAPIContext.GetSteamRemoteStorage(), hContent, out pnBytesDownloaded, out pnBytesExpected);
		}

		public static bool GetUGCDetails(UGCHandle_t hContent, out AppId_t pnAppID, out string ppchName, out int pnFileSizeInBytes, out CSteamID pSteamIDOwner)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr ppchName2;
			bool flag = NativeMethods.ISteamRemoteStorage_GetUGCDetails(CSteamAPIContext.GetSteamRemoteStorage(), hContent, out pnAppID, out ppchName2, out pnFileSizeInBytes, out pSteamIDOwner);
			ppchName = ((!flag) ? null : InteropHelp.PtrToStringUTF8(ppchName2));
			return flag;
		}

		public static int UGCRead(UGCHandle_t hContent, byte[] pvData, int cubDataToRead, uint cOffset, EUGCReadAction eAction)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemoteStorage_UGCRead(CSteamAPIContext.GetSteamRemoteStorage(), hContent, pvData, cubDataToRead, cOffset, eAction);
		}

		public static int GetCachedUGCCount()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemoteStorage_GetCachedUGCCount(CSteamAPIContext.GetSteamRemoteStorage());
		}

		public static UGCHandle_t GetCachedUGCHandle(int iCachedContent)
		{
			InteropHelp.TestIfAvailableClient();
			return (UGCHandle_t)NativeMethods.ISteamRemoteStorage_GetCachedUGCHandle(CSteamAPIContext.GetSteamRemoteStorage(), iCachedContent);
		}

		public static SteamAPICall_t PublishWorkshopFile(string pchFile, string pchPreviewFile, AppId_t nConsumerAppId, string pchTitle, string pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IList<string> pTags, EWorkshopFileType eWorkshopFileType)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchFile2 = new InteropHelp.UTF8StringHandle(pchFile))
			{
				using (InteropHelp.UTF8StringHandle pchPreviewFile2 = new InteropHelp.UTF8StringHandle(pchPreviewFile))
				{
					using (InteropHelp.UTF8StringHandle pchTitle2 = new InteropHelp.UTF8StringHandle(pchTitle))
					{
						using (InteropHelp.UTF8StringHandle pchDescription2 = new InteropHelp.UTF8StringHandle(pchDescription))
						{
							return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_PublishWorkshopFile(CSteamAPIContext.GetSteamRemoteStorage(), pchFile2, pchPreviewFile2, nConsumerAppId, pchTitle2, pchDescription2, eVisibility, new InteropHelp.SteamParamStringArray(pTags), eWorkshopFileType);
						}
					}
				}
			}
		}

		public static PublishedFileUpdateHandle_t CreatePublishedFileUpdateRequest(PublishedFileId_t unPublishedFileId)
		{
			InteropHelp.TestIfAvailableClient();
			return (PublishedFileUpdateHandle_t)NativeMethods.ISteamRemoteStorage_CreatePublishedFileUpdateRequest(CSteamAPIContext.GetSteamRemoteStorage(), unPublishedFileId);
		}

		public static bool UpdatePublishedFileFile(PublishedFileUpdateHandle_t updateHandle, string pchFile)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchFile2 = new InteropHelp.UTF8StringHandle(pchFile))
			{
				return NativeMethods.ISteamRemoteStorage_UpdatePublishedFileFile(CSteamAPIContext.GetSteamRemoteStorage(), updateHandle, pchFile2);
			}
		}

		public static bool UpdatePublishedFilePreviewFile(PublishedFileUpdateHandle_t updateHandle, string pchPreviewFile)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchPreviewFile2 = new InteropHelp.UTF8StringHandle(pchPreviewFile))
			{
				return NativeMethods.ISteamRemoteStorage_UpdatePublishedFilePreviewFile(CSteamAPIContext.GetSteamRemoteStorage(), updateHandle, pchPreviewFile2);
			}
		}

		public static bool UpdatePublishedFileTitle(PublishedFileUpdateHandle_t updateHandle, string pchTitle)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchTitle2 = new InteropHelp.UTF8StringHandle(pchTitle))
			{
				return NativeMethods.ISteamRemoteStorage_UpdatePublishedFileTitle(CSteamAPIContext.GetSteamRemoteStorage(), updateHandle, pchTitle2);
			}
		}

		public static bool UpdatePublishedFileDescription(PublishedFileUpdateHandle_t updateHandle, string pchDescription)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchDescription2 = new InteropHelp.UTF8StringHandle(pchDescription))
			{
				return NativeMethods.ISteamRemoteStorage_UpdatePublishedFileDescription(CSteamAPIContext.GetSteamRemoteStorage(), updateHandle, pchDescription2);
			}
		}

		public static bool UpdatePublishedFileVisibility(PublishedFileUpdateHandle_t updateHandle, ERemoteStoragePublishedFileVisibility eVisibility)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemoteStorage_UpdatePublishedFileVisibility(CSteamAPIContext.GetSteamRemoteStorage(), updateHandle, eVisibility);
		}

		public static bool UpdatePublishedFileTags(PublishedFileUpdateHandle_t updateHandle, IList<string> pTags)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemoteStorage_UpdatePublishedFileTags(CSteamAPIContext.GetSteamRemoteStorage(), updateHandle, new InteropHelp.SteamParamStringArray(pTags));
		}

		public static SteamAPICall_t CommitPublishedFileUpdate(PublishedFileUpdateHandle_t updateHandle)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_CommitPublishedFileUpdate(CSteamAPIContext.GetSteamRemoteStorage(), updateHandle);
		}

		public static SteamAPICall_t GetPublishedFileDetails(PublishedFileId_t unPublishedFileId, uint unMaxSecondsOld)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_GetPublishedFileDetails(CSteamAPIContext.GetSteamRemoteStorage(), unPublishedFileId, unMaxSecondsOld);
		}

		public static SteamAPICall_t DeletePublishedFile(PublishedFileId_t unPublishedFileId)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_DeletePublishedFile(CSteamAPIContext.GetSteamRemoteStorage(), unPublishedFileId);
		}

		public static SteamAPICall_t EnumerateUserPublishedFiles(uint unStartIndex)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_EnumerateUserPublishedFiles(CSteamAPIContext.GetSteamRemoteStorage(), unStartIndex);
		}

		public static SteamAPICall_t SubscribePublishedFile(PublishedFileId_t unPublishedFileId)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_SubscribePublishedFile(CSteamAPIContext.GetSteamRemoteStorage(), unPublishedFileId);
		}

		public static SteamAPICall_t EnumerateUserSubscribedFiles(uint unStartIndex)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_EnumerateUserSubscribedFiles(CSteamAPIContext.GetSteamRemoteStorage(), unStartIndex);
		}

		public static SteamAPICall_t UnsubscribePublishedFile(PublishedFileId_t unPublishedFileId)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_UnsubscribePublishedFile(CSteamAPIContext.GetSteamRemoteStorage(), unPublishedFileId);
		}

		public static bool UpdatePublishedFileSetChangeDescription(PublishedFileUpdateHandle_t updateHandle, string pchChangeDescription)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchChangeDescription2 = new InteropHelp.UTF8StringHandle(pchChangeDescription))
			{
				return NativeMethods.ISteamRemoteStorage_UpdatePublishedFileSetChangeDescription(CSteamAPIContext.GetSteamRemoteStorage(), updateHandle, pchChangeDescription2);
			}
		}

		public static SteamAPICall_t GetPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_GetPublishedItemVoteDetails(CSteamAPIContext.GetSteamRemoteStorage(), unPublishedFileId);
		}

		public static SteamAPICall_t UpdateUserPublishedItemVote(PublishedFileId_t unPublishedFileId, bool bVoteUp)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_UpdateUserPublishedItemVote(CSteamAPIContext.GetSteamRemoteStorage(), unPublishedFileId, bVoteUp);
		}

		public static SteamAPICall_t GetUserPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_GetUserPublishedItemVoteDetails(CSteamAPIContext.GetSteamRemoteStorage(), unPublishedFileId);
		}

		public static SteamAPICall_t EnumerateUserSharedWorkshopFiles(CSteamID steamId, uint unStartIndex, IList<string> pRequiredTags, IList<string> pExcludedTags)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_EnumerateUserSharedWorkshopFiles(CSteamAPIContext.GetSteamRemoteStorage(), steamId, unStartIndex, new InteropHelp.SteamParamStringArray(pRequiredTags), new InteropHelp.SteamParamStringArray(pExcludedTags));
		}

		public static SteamAPICall_t PublishVideo(EWorkshopVideoProvider eVideoProvider, string pchVideoAccount, string pchVideoIdentifier, string pchPreviewFile, AppId_t nConsumerAppId, string pchTitle, string pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IList<string> pTags)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchVideoAccount2 = new InteropHelp.UTF8StringHandle(pchVideoAccount))
			{
				using (InteropHelp.UTF8StringHandle pchVideoIdentifier2 = new InteropHelp.UTF8StringHandle(pchVideoIdentifier))
				{
					using (InteropHelp.UTF8StringHandle pchPreviewFile2 = new InteropHelp.UTF8StringHandle(pchPreviewFile))
					{
						using (InteropHelp.UTF8StringHandle pchTitle2 = new InteropHelp.UTF8StringHandle(pchTitle))
						{
							using (InteropHelp.UTF8StringHandle pchDescription2 = new InteropHelp.UTF8StringHandle(pchDescription))
							{
								return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_PublishVideo(CSteamAPIContext.GetSteamRemoteStorage(), eVideoProvider, pchVideoAccount2, pchVideoIdentifier2, pchPreviewFile2, nConsumerAppId, pchTitle2, pchDescription2, eVisibility, new InteropHelp.SteamParamStringArray(pTags));
							}
						}
					}
				}
			}
		}

		public static SteamAPICall_t SetUserPublishedFileAction(PublishedFileId_t unPublishedFileId, EWorkshopFileAction eAction)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_SetUserPublishedFileAction(CSteamAPIContext.GetSteamRemoteStorage(), unPublishedFileId, eAction);
		}

		public static SteamAPICall_t EnumeratePublishedFilesByUserAction(EWorkshopFileAction eAction, uint unStartIndex)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_EnumeratePublishedFilesByUserAction(CSteamAPIContext.GetSteamRemoteStorage(), eAction, unStartIndex);
		}

		public static SteamAPICall_t EnumeratePublishedWorkshopFiles(EWorkshopEnumerationType eEnumerationType, uint unStartIndex, uint unCount, uint unDays, IList<string> pTags, IList<string> pUserTags)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_EnumeratePublishedWorkshopFiles(CSteamAPIContext.GetSteamRemoteStorage(), eEnumerationType, unStartIndex, unCount, unDays, new InteropHelp.SteamParamStringArray(pTags), new InteropHelp.SteamParamStringArray(pUserTags));
		}

		public static SteamAPICall_t UGCDownloadToLocation(UGCHandle_t hContent, string pchLocation, uint unPriority)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchLocation2 = new InteropHelp.UTF8StringHandle(pchLocation))
			{
				return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_UGCDownloadToLocation(CSteamAPIContext.GetSteamRemoteStorage(), hContent, pchLocation2, unPriority);
			}
		}
	}
}

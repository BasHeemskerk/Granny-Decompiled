using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Steamworks
{
	public static class SteamGameServerUGC
	{
		public static UGCQueryHandle_t CreateQueryUserUGCRequest(AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (UGCQueryHandle_t)NativeMethods.ISteamUGC_CreateQueryUserUGCRequest(CSteamGameServerAPIContext.GetSteamUGC(), unAccountID, eListType, eMatchingUGCType, eSortOrder, nCreatorAppID, nConsumerAppID, unPage);
		}

		public static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (UGCQueryHandle_t)NativeMethods.ISteamUGC_CreateQueryAllUGCRequest(CSteamGameServerAPIContext.GetSteamUGC(), eQueryType, eMatchingeMatchingUGCTypeFileType, nCreatorAppID, nConsumerAppID, unPage);
		}

		public static UGCQueryHandle_t CreateQueryUGCDetailsRequest(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (UGCQueryHandle_t)NativeMethods.ISteamUGC_CreateQueryUGCDetailsRequest(CSteamGameServerAPIContext.GetSteamUGC(), pvecPublishedFileID, unNumPublishedFileIDs);
		}

		public static SteamAPICall_t SendQueryUGCRequest(UGCQueryHandle_t handle)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_SendQueryUGCRequest(CSteamGameServerAPIContext.GetSteamUGC(), handle);
		}

		public static bool GetQueryUGCResult(UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUGC_GetQueryUGCResult(CSteamGameServerAPIContext.GetSteamUGC(), handle, index, out pDetails);
		}

		public static bool GetQueryUGCPreviewURL(UGCQueryHandle_t handle, uint index, out string pchURL, uint cchURLSize)
		{
			InteropHelp.TestIfAvailableGameServer();
			IntPtr intPtr = Marshal.AllocHGlobal((int)cchURLSize);
			bool flag = NativeMethods.ISteamUGC_GetQueryUGCPreviewURL(CSteamGameServerAPIContext.GetSteamUGC(), handle, index, intPtr, cchURLSize);
			pchURL = ((!flag) ? null : InteropHelp.PtrToStringUTF8(intPtr));
			Marshal.FreeHGlobal(intPtr);
			return flag;
		}

		public static bool GetQueryUGCMetadata(UGCQueryHandle_t handle, uint index, out string pchMetadata, uint cchMetadatasize)
		{
			InteropHelp.TestIfAvailableGameServer();
			IntPtr intPtr = Marshal.AllocHGlobal((int)cchMetadatasize);
			bool flag = NativeMethods.ISteamUGC_GetQueryUGCMetadata(CSteamGameServerAPIContext.GetSteamUGC(), handle, index, intPtr, cchMetadatasize);
			pchMetadata = ((!flag) ? null : InteropHelp.PtrToStringUTF8(intPtr));
			Marshal.FreeHGlobal(intPtr);
			return flag;
		}

		public static bool GetQueryUGCChildren(UGCQueryHandle_t handle, uint index, PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUGC_GetQueryUGCChildren(CSteamGameServerAPIContext.GetSteamUGC(), handle, index, pvecPublishedFileID, cMaxEntries);
		}

		public static bool GetQueryUGCStatistic(UGCQueryHandle_t handle, uint index, EItemStatistic eStatType, out ulong pStatValue)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUGC_GetQueryUGCStatistic(CSteamGameServerAPIContext.GetSteamUGC(), handle, index, eStatType, out pStatValue);
		}

		public static uint GetQueryUGCNumAdditionalPreviews(UGCQueryHandle_t handle, uint index)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUGC_GetQueryUGCNumAdditionalPreviews(CSteamGameServerAPIContext.GetSteamUGC(), handle, index);
		}

		public static bool GetQueryUGCAdditionalPreview(UGCQueryHandle_t handle, uint index, uint previewIndex, out string pchURLOrVideoID, uint cchURLSize, out string pchOriginalFileName, uint cchOriginalFileNameSize, out EItemPreviewType pPreviewType)
		{
			InteropHelp.TestIfAvailableGameServer();
			IntPtr intPtr = Marshal.AllocHGlobal((int)cchURLSize);
			IntPtr intPtr2 = Marshal.AllocHGlobal((int)cchOriginalFileNameSize);
			bool flag = NativeMethods.ISteamUGC_GetQueryUGCAdditionalPreview(CSteamGameServerAPIContext.GetSteamUGC(), handle, index, previewIndex, intPtr, cchURLSize, intPtr2, cchOriginalFileNameSize, out pPreviewType);
			pchURLOrVideoID = ((!flag) ? null : InteropHelp.PtrToStringUTF8(intPtr));
			Marshal.FreeHGlobal(intPtr);
			pchOriginalFileName = ((!flag) ? null : InteropHelp.PtrToStringUTF8(intPtr2));
			Marshal.FreeHGlobal(intPtr2);
			return flag;
		}

		public static uint GetQueryUGCNumKeyValueTags(UGCQueryHandle_t handle, uint index)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUGC_GetQueryUGCNumKeyValueTags(CSteamGameServerAPIContext.GetSteamUGC(), handle, index);
		}

		public static bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, out string pchKey, uint cchKeySize, out string pchValue, uint cchValueSize)
		{
			InteropHelp.TestIfAvailableGameServer();
			IntPtr intPtr = Marshal.AllocHGlobal((int)cchKeySize);
			IntPtr intPtr2 = Marshal.AllocHGlobal((int)cchValueSize);
			bool flag = NativeMethods.ISteamUGC_GetQueryUGCKeyValueTag(CSteamGameServerAPIContext.GetSteamUGC(), handle, index, keyValueTagIndex, intPtr, cchKeySize, intPtr2, cchValueSize);
			pchKey = ((!flag) ? null : InteropHelp.PtrToStringUTF8(intPtr));
			Marshal.FreeHGlobal(intPtr);
			pchValue = ((!flag) ? null : InteropHelp.PtrToStringUTF8(intPtr2));
			Marshal.FreeHGlobal(intPtr2);
			return flag;
		}

		public static bool ReleaseQueryUGCRequest(UGCQueryHandle_t handle)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUGC_ReleaseQueryUGCRequest(CSteamGameServerAPIContext.GetSteamUGC(), handle);
		}

		public static bool AddRequiredTag(UGCQueryHandle_t handle, string pTagName)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle pTagName2 = new InteropHelp.UTF8StringHandle(pTagName))
			{
				return NativeMethods.ISteamUGC_AddRequiredTag(CSteamGameServerAPIContext.GetSteamUGC(), handle, pTagName2);
			}
		}

		public static bool AddExcludedTag(UGCQueryHandle_t handle, string pTagName)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle pTagName2 = new InteropHelp.UTF8StringHandle(pTagName))
			{
				return NativeMethods.ISteamUGC_AddExcludedTag(CSteamGameServerAPIContext.GetSteamUGC(), handle, pTagName2);
			}
		}

		public static bool SetReturnOnlyIDs(UGCQueryHandle_t handle, bool bReturnOnlyIDs)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUGC_SetReturnOnlyIDs(CSteamGameServerAPIContext.GetSteamUGC(), handle, bReturnOnlyIDs);
		}

		public static bool SetReturnKeyValueTags(UGCQueryHandle_t handle, bool bReturnKeyValueTags)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUGC_SetReturnKeyValueTags(CSteamGameServerAPIContext.GetSteamUGC(), handle, bReturnKeyValueTags);
		}

		public static bool SetReturnLongDescription(UGCQueryHandle_t handle, bool bReturnLongDescription)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUGC_SetReturnLongDescription(CSteamGameServerAPIContext.GetSteamUGC(), handle, bReturnLongDescription);
		}

		public static bool SetReturnMetadata(UGCQueryHandle_t handle, bool bReturnMetadata)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUGC_SetReturnMetadata(CSteamGameServerAPIContext.GetSteamUGC(), handle, bReturnMetadata);
		}

		public static bool SetReturnChildren(UGCQueryHandle_t handle, bool bReturnChildren)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUGC_SetReturnChildren(CSteamGameServerAPIContext.GetSteamUGC(), handle, bReturnChildren);
		}

		public static bool SetReturnAdditionalPreviews(UGCQueryHandle_t handle, bool bReturnAdditionalPreviews)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUGC_SetReturnAdditionalPreviews(CSteamGameServerAPIContext.GetSteamUGC(), handle, bReturnAdditionalPreviews);
		}

		public static bool SetReturnTotalOnly(UGCQueryHandle_t handle, bool bReturnTotalOnly)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUGC_SetReturnTotalOnly(CSteamGameServerAPIContext.GetSteamUGC(), handle, bReturnTotalOnly);
		}

		public static bool SetReturnPlaytimeStats(UGCQueryHandle_t handle, uint unDays)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUGC_SetReturnPlaytimeStats(CSteamGameServerAPIContext.GetSteamUGC(), handle, unDays);
		}

		public static bool SetLanguage(UGCQueryHandle_t handle, string pchLanguage)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle pchLanguage2 = new InteropHelp.UTF8StringHandle(pchLanguage))
			{
				return NativeMethods.ISteamUGC_SetLanguage(CSteamGameServerAPIContext.GetSteamUGC(), handle, pchLanguage2);
			}
		}

		public static bool SetAllowCachedResponse(UGCQueryHandle_t handle, uint unMaxAgeSeconds)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUGC_SetAllowCachedResponse(CSteamGameServerAPIContext.GetSteamUGC(), handle, unMaxAgeSeconds);
		}

		public static bool SetCloudFileNameFilter(UGCQueryHandle_t handle, string pMatchCloudFileName)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle pMatchCloudFileName2 = new InteropHelp.UTF8StringHandle(pMatchCloudFileName))
			{
				return NativeMethods.ISteamUGC_SetCloudFileNameFilter(CSteamGameServerAPIContext.GetSteamUGC(), handle, pMatchCloudFileName2);
			}
		}

		public static bool SetMatchAnyTag(UGCQueryHandle_t handle, bool bMatchAnyTag)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUGC_SetMatchAnyTag(CSteamGameServerAPIContext.GetSteamUGC(), handle, bMatchAnyTag);
		}

		public static bool SetSearchText(UGCQueryHandle_t handle, string pSearchText)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle pSearchText2 = new InteropHelp.UTF8StringHandle(pSearchText))
			{
				return NativeMethods.ISteamUGC_SetSearchText(CSteamGameServerAPIContext.GetSteamUGC(), handle, pSearchText2);
			}
		}

		public static bool SetRankedByTrendDays(UGCQueryHandle_t handle, uint unDays)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUGC_SetRankedByTrendDays(CSteamGameServerAPIContext.GetSteamUGC(), handle, unDays);
		}

		public static bool AddRequiredKeyValueTag(UGCQueryHandle_t handle, string pKey, string pValue)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle pKey2 = new InteropHelp.UTF8StringHandle(pKey))
			{
				using (InteropHelp.UTF8StringHandle pValue2 = new InteropHelp.UTF8StringHandle(pValue))
				{
					return NativeMethods.ISteamUGC_AddRequiredKeyValueTag(CSteamGameServerAPIContext.GetSteamUGC(), handle, pKey2, pValue2);
				}
			}
		}

		public static SteamAPICall_t RequestUGCDetails(PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_RequestUGCDetails(CSteamGameServerAPIContext.GetSteamUGC(), nPublishedFileID, unMaxAgeSeconds);
		}

		public static SteamAPICall_t CreateItem(AppId_t nConsumerAppId, EWorkshopFileType eFileType)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_CreateItem(CSteamGameServerAPIContext.GetSteamUGC(), nConsumerAppId, eFileType);
		}

		public static UGCUpdateHandle_t StartItemUpdate(AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (UGCUpdateHandle_t)NativeMethods.ISteamUGC_StartItemUpdate(CSteamGameServerAPIContext.GetSteamUGC(), nConsumerAppId, nPublishedFileID);
		}

		public static bool SetItemTitle(UGCUpdateHandle_t handle, string pchTitle)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle pchTitle2 = new InteropHelp.UTF8StringHandle(pchTitle))
			{
				return NativeMethods.ISteamUGC_SetItemTitle(CSteamGameServerAPIContext.GetSteamUGC(), handle, pchTitle2);
			}
		}

		public static bool SetItemDescription(UGCUpdateHandle_t handle, string pchDescription)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle pchDescription2 = new InteropHelp.UTF8StringHandle(pchDescription))
			{
				return NativeMethods.ISteamUGC_SetItemDescription(CSteamGameServerAPIContext.GetSteamUGC(), handle, pchDescription2);
			}
		}

		public static bool SetItemUpdateLanguage(UGCUpdateHandle_t handle, string pchLanguage)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle pchLanguage2 = new InteropHelp.UTF8StringHandle(pchLanguage))
			{
				return NativeMethods.ISteamUGC_SetItemUpdateLanguage(CSteamGameServerAPIContext.GetSteamUGC(), handle, pchLanguage2);
			}
		}

		public static bool SetItemMetadata(UGCUpdateHandle_t handle, string pchMetaData)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle pchMetaData2 = new InteropHelp.UTF8StringHandle(pchMetaData))
			{
				return NativeMethods.ISteamUGC_SetItemMetadata(CSteamGameServerAPIContext.GetSteamUGC(), handle, pchMetaData2);
			}
		}

		public static bool SetItemVisibility(UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUGC_SetItemVisibility(CSteamGameServerAPIContext.GetSteamUGC(), handle, eVisibility);
		}

		public static bool SetItemTags(UGCUpdateHandle_t updateHandle, IList<string> pTags)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUGC_SetItemTags(CSteamGameServerAPIContext.GetSteamUGC(), updateHandle, new InteropHelp.SteamParamStringArray(pTags));
		}

		public static bool SetItemContent(UGCUpdateHandle_t handle, string pszContentFolder)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle pszContentFolder2 = new InteropHelp.UTF8StringHandle(pszContentFolder))
			{
				return NativeMethods.ISteamUGC_SetItemContent(CSteamGameServerAPIContext.GetSteamUGC(), handle, pszContentFolder2);
			}
		}

		public static bool SetItemPreview(UGCUpdateHandle_t handle, string pszPreviewFile)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle pszPreviewFile2 = new InteropHelp.UTF8StringHandle(pszPreviewFile))
			{
				return NativeMethods.ISteamUGC_SetItemPreview(CSteamGameServerAPIContext.GetSteamUGC(), handle, pszPreviewFile2);
			}
		}

		public static bool RemoveItemKeyValueTags(UGCUpdateHandle_t handle, string pchKey)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle pchKey2 = new InteropHelp.UTF8StringHandle(pchKey))
			{
				return NativeMethods.ISteamUGC_RemoveItemKeyValueTags(CSteamGameServerAPIContext.GetSteamUGC(), handle, pchKey2);
			}
		}

		public static bool AddItemKeyValueTag(UGCUpdateHandle_t handle, string pchKey, string pchValue)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle pchKey2 = new InteropHelp.UTF8StringHandle(pchKey))
			{
				using (InteropHelp.UTF8StringHandle pchValue2 = new InteropHelp.UTF8StringHandle(pchValue))
				{
					return NativeMethods.ISteamUGC_AddItemKeyValueTag(CSteamGameServerAPIContext.GetSteamUGC(), handle, pchKey2, pchValue2);
				}
			}
		}

		public static bool AddItemPreviewFile(UGCUpdateHandle_t handle, string pszPreviewFile, EItemPreviewType type)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle pszPreviewFile2 = new InteropHelp.UTF8StringHandle(pszPreviewFile))
			{
				return NativeMethods.ISteamUGC_AddItemPreviewFile(CSteamGameServerAPIContext.GetSteamUGC(), handle, pszPreviewFile2, type);
			}
		}

		public static bool AddItemPreviewVideo(UGCUpdateHandle_t handle, string pszVideoID)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle pszVideoID2 = new InteropHelp.UTF8StringHandle(pszVideoID))
			{
				return NativeMethods.ISteamUGC_AddItemPreviewVideo(CSteamGameServerAPIContext.GetSteamUGC(), handle, pszVideoID2);
			}
		}

		public static bool UpdateItemPreviewFile(UGCUpdateHandle_t handle, uint index, string pszPreviewFile)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle pszPreviewFile2 = new InteropHelp.UTF8StringHandle(pszPreviewFile))
			{
				return NativeMethods.ISteamUGC_UpdateItemPreviewFile(CSteamGameServerAPIContext.GetSteamUGC(), handle, index, pszPreviewFile2);
			}
		}

		public static bool UpdateItemPreviewVideo(UGCUpdateHandle_t handle, uint index, string pszVideoID)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle pszVideoID2 = new InteropHelp.UTF8StringHandle(pszVideoID))
			{
				return NativeMethods.ISteamUGC_UpdateItemPreviewVideo(CSteamGameServerAPIContext.GetSteamUGC(), handle, index, pszVideoID2);
			}
		}

		public static bool RemoveItemPreview(UGCUpdateHandle_t handle, uint index)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUGC_RemoveItemPreview(CSteamGameServerAPIContext.GetSteamUGC(), handle, index);
		}

		public static SteamAPICall_t SubmitItemUpdate(UGCUpdateHandle_t handle, string pchChangeNote)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle pchChangeNote2 = new InteropHelp.UTF8StringHandle(pchChangeNote))
			{
				return (SteamAPICall_t)NativeMethods.ISteamUGC_SubmitItemUpdate(CSteamGameServerAPIContext.GetSteamUGC(), handle, pchChangeNote2);
			}
		}

		public static EItemUpdateStatus GetItemUpdateProgress(UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUGC_GetItemUpdateProgress(CSteamGameServerAPIContext.GetSteamUGC(), handle, out punBytesProcessed, out punBytesTotal);
		}

		public static SteamAPICall_t SetUserItemVote(PublishedFileId_t nPublishedFileID, bool bVoteUp)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_SetUserItemVote(CSteamGameServerAPIContext.GetSteamUGC(), nPublishedFileID, bVoteUp);
		}

		public static SteamAPICall_t GetUserItemVote(PublishedFileId_t nPublishedFileID)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_GetUserItemVote(CSteamGameServerAPIContext.GetSteamUGC(), nPublishedFileID);
		}

		public static SteamAPICall_t AddItemToFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_AddItemToFavorites(CSteamGameServerAPIContext.GetSteamUGC(), nAppId, nPublishedFileID);
		}

		public static SteamAPICall_t RemoveItemFromFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_RemoveItemFromFavorites(CSteamGameServerAPIContext.GetSteamUGC(), nAppId, nPublishedFileID);
		}

		public static SteamAPICall_t SubscribeItem(PublishedFileId_t nPublishedFileID)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_SubscribeItem(CSteamGameServerAPIContext.GetSteamUGC(), nPublishedFileID);
		}

		public static SteamAPICall_t UnsubscribeItem(PublishedFileId_t nPublishedFileID)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_UnsubscribeItem(CSteamGameServerAPIContext.GetSteamUGC(), nPublishedFileID);
		}

		public static uint GetNumSubscribedItems()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUGC_GetNumSubscribedItems(CSteamGameServerAPIContext.GetSteamUGC());
		}

		public static uint GetSubscribedItems(PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUGC_GetSubscribedItems(CSteamGameServerAPIContext.GetSteamUGC(), pvecPublishedFileID, cMaxEntries);
		}

		public static uint GetItemState(PublishedFileId_t nPublishedFileID)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUGC_GetItemState(CSteamGameServerAPIContext.GetSteamUGC(), nPublishedFileID);
		}

		public static bool GetItemInstallInfo(PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, out string pchFolder, uint cchFolderSize, out uint punTimeStamp)
		{
			InteropHelp.TestIfAvailableGameServer();
			IntPtr intPtr = Marshal.AllocHGlobal((int)cchFolderSize);
			bool flag = NativeMethods.ISteamUGC_GetItemInstallInfo(CSteamGameServerAPIContext.GetSteamUGC(), nPublishedFileID, out punSizeOnDisk, intPtr, cchFolderSize, out punTimeStamp);
			pchFolder = ((!flag) ? null : InteropHelp.PtrToStringUTF8(intPtr));
			Marshal.FreeHGlobal(intPtr);
			return flag;
		}

		public static bool GetItemDownloadInfo(PublishedFileId_t nPublishedFileID, out ulong punBytesDownloaded, out ulong punBytesTotal)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUGC_GetItemDownloadInfo(CSteamGameServerAPIContext.GetSteamUGC(), nPublishedFileID, out punBytesDownloaded, out punBytesTotal);
		}

		public static bool DownloadItem(PublishedFileId_t nPublishedFileID, bool bHighPriority)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamUGC_DownloadItem(CSteamGameServerAPIContext.GetSteamUGC(), nPublishedFileID, bHighPriority);
		}

		public static bool BInitWorkshopForGameServer(DepotId_t unWorkshopDepotID, string pszFolder)
		{
			InteropHelp.TestIfAvailableGameServer();
			using (InteropHelp.UTF8StringHandle pszFolder2 = new InteropHelp.UTF8StringHandle(pszFolder))
			{
				return NativeMethods.ISteamUGC_BInitWorkshopForGameServer(CSteamGameServerAPIContext.GetSteamUGC(), unWorkshopDepotID, pszFolder2);
			}
		}

		public static void SuspendDownloads(bool bSuspend)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamUGC_SuspendDownloads(CSteamGameServerAPIContext.GetSteamUGC(), bSuspend);
		}

		public static SteamAPICall_t StartPlaytimeTracking(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_StartPlaytimeTracking(CSteamGameServerAPIContext.GetSteamUGC(), pvecPublishedFileID, unNumPublishedFileIDs);
		}

		public static SteamAPICall_t StopPlaytimeTracking(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_StopPlaytimeTracking(CSteamGameServerAPIContext.GetSteamUGC(), pvecPublishedFileID, unNumPublishedFileIDs);
		}

		public static SteamAPICall_t StopPlaytimeTrackingForAllItems()
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_StopPlaytimeTrackingForAllItems(CSteamGameServerAPIContext.GetSteamUGC());
		}

		public static SteamAPICall_t AddDependency(PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_AddDependency(CSteamGameServerAPIContext.GetSteamUGC(), nParentPublishedFileID, nChildPublishedFileID);
		}

		public static SteamAPICall_t RemoveDependency(PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_RemoveDependency(CSteamGameServerAPIContext.GetSteamUGC(), nParentPublishedFileID, nChildPublishedFileID);
		}

		public static SteamAPICall_t AddAppDependency(PublishedFileId_t nPublishedFileID, AppId_t nAppID)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_AddAppDependency(CSteamGameServerAPIContext.GetSteamUGC(), nPublishedFileID, nAppID);
		}

		public static SteamAPICall_t RemoveAppDependency(PublishedFileId_t nPublishedFileID, AppId_t nAppID)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_RemoveAppDependency(CSteamGameServerAPIContext.GetSteamUGC(), nPublishedFileID, nAppID);
		}

		public static SteamAPICall_t GetAppDependencies(PublishedFileId_t nPublishedFileID)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_GetAppDependencies(CSteamGameServerAPIContext.GetSteamUGC(), nPublishedFileID);
		}

		public static SteamAPICall_t DeleteItem(PublishedFileId_t nPublishedFileID)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_DeleteItem(CSteamGameServerAPIContext.GetSteamUGC(), nPublishedFileID);
		}
	}
}

using System;
using System.Runtime.InteropServices;

namespace Steamworks
{
	public static class SteamInventory
	{
		public static EResult GetResultStatus(SteamInventoryResult_t resultHandle)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamInventory_GetResultStatus(CSteamAPIContext.GetSteamInventory(), resultHandle);
		}

		public static bool GetResultItems(SteamInventoryResult_t resultHandle, SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamInventory_GetResultItems(CSteamAPIContext.GetSteamInventory(), resultHandle, pOutItemsArray, ref punOutItemsArraySize);
		}

		public static bool GetResultItemProperty(SteamInventoryResult_t resultHandle, uint unItemIndex, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr intPtr = Marshal.AllocHGlobal((int)punValueBufferSizeOut);
			using (InteropHelp.UTF8StringHandle pchPropertyName2 = new InteropHelp.UTF8StringHandle(pchPropertyName))
			{
				bool flag = NativeMethods.ISteamInventory_GetResultItemProperty(CSteamAPIContext.GetSteamInventory(), resultHandle, unItemIndex, pchPropertyName2, intPtr, ref punValueBufferSizeOut);
				pchValueBuffer = ((!flag) ? null : InteropHelp.PtrToStringUTF8(intPtr));
				Marshal.FreeHGlobal(intPtr);
				return flag;
			}
		}

		public static uint GetResultTimestamp(SteamInventoryResult_t resultHandle)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamInventory_GetResultTimestamp(CSteamAPIContext.GetSteamInventory(), resultHandle);
		}

		public static bool CheckResultSteamID(SteamInventoryResult_t resultHandle, CSteamID steamIDExpected)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamInventory_CheckResultSteamID(CSteamAPIContext.GetSteamInventory(), resultHandle, steamIDExpected);
		}

		public static void DestroyResult(SteamInventoryResult_t resultHandle)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamInventory_DestroyResult(CSteamAPIContext.GetSteamInventory(), resultHandle);
		}

		public static bool GetAllItems(out SteamInventoryResult_t pResultHandle)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamInventory_GetAllItems(CSteamAPIContext.GetSteamInventory(), out pResultHandle);
		}

		public static bool GetItemsByID(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamInventory_GetItemsByID(CSteamAPIContext.GetSteamInventory(), out pResultHandle, pInstanceIDs, unCountInstanceIDs);
		}

		public static bool SerializeResult(SteamInventoryResult_t resultHandle, byte[] pOutBuffer, out uint punOutBufferSize)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamInventory_SerializeResult(CSteamAPIContext.GetSteamInventory(), resultHandle, pOutBuffer, out punOutBufferSize);
		}

		public static bool DeserializeResult(out SteamInventoryResult_t pOutResultHandle, byte[] pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE = false)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamInventory_DeserializeResult(CSteamAPIContext.GetSteamInventory(), out pOutResultHandle, pBuffer, unBufferSize, bRESERVED_MUST_BE_FALSE);
		}

		public static bool GenerateItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint[] punArrayQuantity, uint unArrayLength)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamInventory_GenerateItems(CSteamAPIContext.GetSteamInventory(), out pResultHandle, pArrayItemDefs, punArrayQuantity, unArrayLength);
		}

		public static bool GrantPromoItems(out SteamInventoryResult_t pResultHandle)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamInventory_GrantPromoItems(CSteamAPIContext.GetSteamInventory(), out pResultHandle);
		}

		public static bool AddPromoItem(out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamInventory_AddPromoItem(CSteamAPIContext.GetSteamInventory(), out pResultHandle, itemDef);
		}

		public static bool AddPromoItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint unArrayLength)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamInventory_AddPromoItems(CSteamAPIContext.GetSteamInventory(), out pResultHandle, pArrayItemDefs, unArrayLength);
		}

		public static bool ConsumeItem(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamInventory_ConsumeItem(CSteamAPIContext.GetSteamInventory(), out pResultHandle, itemConsume, unQuantity);
		}

		public static bool ExchangeItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayGenerate, uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, SteamItemInstanceID_t[] pArrayDestroy, uint[] punArrayDestroyQuantity, uint unArrayDestroyLength)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamInventory_ExchangeItems(CSteamAPIContext.GetSteamInventory(), out pResultHandle, pArrayGenerate, punArrayGenerateQuantity, unArrayGenerateLength, pArrayDestroy, punArrayDestroyQuantity, unArrayDestroyLength);
		}

		public static bool TransferItemQuantity(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamInventory_TransferItemQuantity(CSteamAPIContext.GetSteamInventory(), out pResultHandle, itemIdSource, unQuantity, itemIdDest);
		}

		public static void SendItemDropHeartbeat()
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamInventory_SendItemDropHeartbeat(CSteamAPIContext.GetSteamInventory());
		}

		public static bool TriggerItemDrop(out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamInventory_TriggerItemDrop(CSteamAPIContext.GetSteamInventory(), out pResultHandle, dropListDefinition);
		}

		public static bool TradeItems(out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, SteamItemInstanceID_t[] pArrayGive, uint[] pArrayGiveQuantity, uint nArrayGiveLength, SteamItemInstanceID_t[] pArrayGet, uint[] pArrayGetQuantity, uint nArrayGetLength)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamInventory_TradeItems(CSteamAPIContext.GetSteamInventory(), out pResultHandle, steamIDTradePartner, pArrayGive, pArrayGiveQuantity, nArrayGiveLength, pArrayGet, pArrayGetQuantity, nArrayGetLength);
		}

		public static bool LoadItemDefinitions()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamInventory_LoadItemDefinitions(CSteamAPIContext.GetSteamInventory());
		}

		public static bool GetItemDefinitionIDs(SteamItemDef_t[] pItemDefIDs, out uint punItemDefIDsArraySize)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamInventory_GetItemDefinitionIDs(CSteamAPIContext.GetSteamInventory(), pItemDefIDs, out punItemDefIDsArraySize);
		}

		public static bool GetItemDefinitionProperty(SteamItemDef_t iDefinition, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr intPtr = Marshal.AllocHGlobal((int)punValueBufferSizeOut);
			using (InteropHelp.UTF8StringHandle pchPropertyName2 = new InteropHelp.UTF8StringHandle(pchPropertyName))
			{
				bool flag = NativeMethods.ISteamInventory_GetItemDefinitionProperty(CSteamAPIContext.GetSteamInventory(), iDefinition, pchPropertyName2, intPtr, ref punValueBufferSizeOut);
				pchValueBuffer = ((!flag) ? null : InteropHelp.PtrToStringUTF8(intPtr));
				Marshal.FreeHGlobal(intPtr);
				return flag;
			}
		}

		public static SteamAPICall_t RequestEligiblePromoItemDefinitionsIDs(CSteamID steamID)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamInventory_RequestEligiblePromoItemDefinitionsIDs(CSteamAPIContext.GetSteamInventory(), steamID);
		}

		public static bool GetEligiblePromoItemDefinitionIDs(CSteamID steamID, SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamInventory_GetEligiblePromoItemDefinitionIDs(CSteamAPIContext.GetSteamInventory(), steamID, pItemDefIDs, ref punItemDefIDsArraySize);
		}
	}
}

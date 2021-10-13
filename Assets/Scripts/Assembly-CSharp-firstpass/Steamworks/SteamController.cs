using System;

namespace Steamworks
{
	public static class SteamController
	{
		public static bool Init()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamController_Init(CSteamAPIContext.GetSteamController());
		}

		public static bool Shutdown()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamController_Shutdown(CSteamAPIContext.GetSteamController());
		}

		public static void RunFrame()
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamController_RunFrame(CSteamAPIContext.GetSteamController());
		}

		public static int GetConnectedControllers(ControllerHandle_t[] handlesOut)
		{
			InteropHelp.TestIfAvailableClient();
			if (handlesOut.Length != 16)
			{
				throw new ArgumentException("handlesOut must be the same size as Constants.STEAM_CONTROLLER_MAX_COUNT!");
			}
			return NativeMethods.ISteamController_GetConnectedControllers(CSteamAPIContext.GetSteamController(), handlesOut);
		}

		public static bool ShowBindingPanel(ControllerHandle_t controllerHandle)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamController_ShowBindingPanel(CSteamAPIContext.GetSteamController(), controllerHandle);
		}

		public static ControllerActionSetHandle_t GetActionSetHandle(string pszActionSetName)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pszActionSetName2 = new InteropHelp.UTF8StringHandle(pszActionSetName))
			{
				return (ControllerActionSetHandle_t)NativeMethods.ISteamController_GetActionSetHandle(CSteamAPIContext.GetSteamController(), pszActionSetName2);
			}
		}

		public static void ActivateActionSet(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamController_ActivateActionSet(CSteamAPIContext.GetSteamController(), controllerHandle, actionSetHandle);
		}

		public static ControllerActionSetHandle_t GetCurrentActionSet(ControllerHandle_t controllerHandle)
		{
			InteropHelp.TestIfAvailableClient();
			return (ControllerActionSetHandle_t)NativeMethods.ISteamController_GetCurrentActionSet(CSteamAPIContext.GetSteamController(), controllerHandle);
		}

		public static ControllerDigitalActionHandle_t GetDigitalActionHandle(string pszActionName)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pszActionName2 = new InteropHelp.UTF8StringHandle(pszActionName))
			{
				return (ControllerDigitalActionHandle_t)NativeMethods.ISteamController_GetDigitalActionHandle(CSteamAPIContext.GetSteamController(), pszActionName2);
			}
		}

		public static ControllerDigitalActionData_t GetDigitalActionData(ControllerHandle_t controllerHandle, ControllerDigitalActionHandle_t digitalActionHandle)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamController_GetDigitalActionData(CSteamAPIContext.GetSteamController(), controllerHandle, digitalActionHandle);
		}

		public static int GetDigitalActionOrigins(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle, ControllerDigitalActionHandle_t digitalActionHandle, EControllerActionOrigin[] originsOut)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamController_GetDigitalActionOrigins(CSteamAPIContext.GetSteamController(), controllerHandle, actionSetHandle, digitalActionHandle, originsOut);
		}

		public static ControllerAnalogActionHandle_t GetAnalogActionHandle(string pszActionName)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pszActionName2 = new InteropHelp.UTF8StringHandle(pszActionName))
			{
				return (ControllerAnalogActionHandle_t)NativeMethods.ISteamController_GetAnalogActionHandle(CSteamAPIContext.GetSteamController(), pszActionName2);
			}
		}

		public static ControllerAnalogActionData_t GetAnalogActionData(ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t analogActionHandle)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamController_GetAnalogActionData(CSteamAPIContext.GetSteamController(), controllerHandle, analogActionHandle);
		}

		public static int GetAnalogActionOrigins(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle, ControllerAnalogActionHandle_t analogActionHandle, EControllerActionOrigin[] originsOut)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamController_GetAnalogActionOrigins(CSteamAPIContext.GetSteamController(), controllerHandle, actionSetHandle, analogActionHandle, originsOut);
		}

		public static void StopAnalogActionMomentum(ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t eAction)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamController_StopAnalogActionMomentum(CSteamAPIContext.GetSteamController(), controllerHandle, eAction);
		}

		public static void TriggerHapticPulse(ControllerHandle_t controllerHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamController_TriggerHapticPulse(CSteamAPIContext.GetSteamController(), controllerHandle, eTargetPad, usDurationMicroSec);
		}

		public static void TriggerRepeatedHapticPulse(ControllerHandle_t controllerHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamController_TriggerRepeatedHapticPulse(CSteamAPIContext.GetSteamController(), controllerHandle, eTargetPad, usDurationMicroSec, usOffMicroSec, unRepeat, nFlags);
		}

		public static void TriggerVibration(ControllerHandle_t controllerHandle, ushort usLeftSpeed, ushort usRightSpeed)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamController_TriggerVibration(CSteamAPIContext.GetSteamController(), controllerHandle, usLeftSpeed, usRightSpeed);
		}

		public static void SetLEDColor(ControllerHandle_t controllerHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamController_SetLEDColor(CSteamAPIContext.GetSteamController(), controllerHandle, nColorR, nColorG, nColorB, nFlags);
		}

		public static int GetGamepadIndexForController(ControllerHandle_t ulControllerHandle)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamController_GetGamepadIndexForController(CSteamAPIContext.GetSteamController(), ulControllerHandle);
		}

		public static ControllerHandle_t GetControllerForGamepadIndex(int nIndex)
		{
			InteropHelp.TestIfAvailableClient();
			return (ControllerHandle_t)NativeMethods.ISteamController_GetControllerForGamepadIndex(CSteamAPIContext.GetSteamController(), nIndex);
		}

		public static ControllerMotionData_t GetMotionData(ControllerHandle_t controllerHandle)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamController_GetMotionData(CSteamAPIContext.GetSteamController(), controllerHandle);
		}

		public static bool ShowDigitalActionOrigins(ControllerHandle_t controllerHandle, ControllerDigitalActionHandle_t digitalActionHandle, float flScale, float flXPosition, float flYPosition)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamController_ShowDigitalActionOrigins(CSteamAPIContext.GetSteamController(), controllerHandle, digitalActionHandle, flScale, flXPosition, flYPosition);
		}

		public static bool ShowAnalogActionOrigins(ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t analogActionHandle, float flScale, float flXPosition, float flYPosition)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamController_ShowAnalogActionOrigins(CSteamAPIContext.GetSteamController(), controllerHandle, analogActionHandle, flScale, flXPosition, flYPosition);
		}

		public static string GetStringForActionOrigin(EControllerActionOrigin eOrigin)
		{
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamController_GetStringForActionOrigin(CSteamAPIContext.GetSteamController(), eOrigin));
		}

		public static string GetGlyphForActionOrigin(EControllerActionOrigin eOrigin)
		{
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamController_GetGlyphForActionOrigin(CSteamAPIContext.GetSteamController(), eOrigin));
		}
	}
}

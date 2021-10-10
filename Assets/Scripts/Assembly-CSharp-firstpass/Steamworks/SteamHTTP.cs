namespace Steamworks
{
	public static class SteamHTTP
	{
		public static HTTPRequestHandle CreateHTTPRequest(EHTTPMethod eHTTPRequestMethod, string pchAbsoluteURL)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchAbsoluteURL2 = new InteropHelp.UTF8StringHandle(pchAbsoluteURL))
			{
				return (HTTPRequestHandle)NativeMethods.ISteamHTTP_CreateHTTPRequest(CSteamAPIContext.GetSteamHTTP(), eHTTPRequestMethod, pchAbsoluteURL2);
			}
		}

		public static bool SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_SetHTTPRequestContextValue(CSteamAPIContext.GetSteamHTTP(), hRequest, ulContextValue);
		}

		public static bool SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_SetHTTPRequestNetworkActivityTimeout(CSteamAPIContext.GetSteamHTTP(), hRequest, unTimeoutSeconds);
		}

		public static bool SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, string pchHeaderValue)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchHeaderName2 = new InteropHelp.UTF8StringHandle(pchHeaderName))
			{
				using (InteropHelp.UTF8StringHandle pchHeaderValue2 = new InteropHelp.UTF8StringHandle(pchHeaderValue))
				{
					return NativeMethods.ISteamHTTP_SetHTTPRequestHeaderValue(CSteamAPIContext.GetSteamHTTP(), hRequest, pchHeaderName2, pchHeaderValue2);
				}
			}
		}

		public static bool SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, string pchParamName, string pchParamValue)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchParamName2 = new InteropHelp.UTF8StringHandle(pchParamName))
			{
				using (InteropHelp.UTF8StringHandle pchParamValue2 = new InteropHelp.UTF8StringHandle(pchParamValue))
				{
					return NativeMethods.ISteamHTTP_SetHTTPRequestGetOrPostParameter(CSteamAPIContext.GetSteamHTTP(), hRequest, pchParamName2, pchParamValue2);
				}
			}
		}

		public static bool SendHTTPRequest(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_SendHTTPRequest(CSteamAPIContext.GetSteamHTTP(), hRequest, out pCallHandle);
		}

		public static bool SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_SendHTTPRequestAndStreamResponse(CSteamAPIContext.GetSteamHTTP(), hRequest, out pCallHandle);
		}

		public static bool DeferHTTPRequest(HTTPRequestHandle hRequest)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_DeferHTTPRequest(CSteamAPIContext.GetSteamHTTP(), hRequest);
		}

		public static bool PrioritizeHTTPRequest(HTTPRequestHandle hRequest)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_PrioritizeHTTPRequest(CSteamAPIContext.GetSteamHTTP(), hRequest);
		}

		public static bool GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, string pchHeaderName, out uint unResponseHeaderSize)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchHeaderName2 = new InteropHelp.UTF8StringHandle(pchHeaderName))
			{
				return NativeMethods.ISteamHTTP_GetHTTPResponseHeaderSize(CSteamAPIContext.GetSteamHTTP(), hRequest, pchHeaderName2, out unResponseHeaderSize);
			}
		}

		public static bool GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, byte[] pHeaderValueBuffer, uint unBufferSize)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchHeaderName2 = new InteropHelp.UTF8StringHandle(pchHeaderName))
			{
				return NativeMethods.ISteamHTTP_GetHTTPResponseHeaderValue(CSteamAPIContext.GetSteamHTTP(), hRequest, pchHeaderName2, pHeaderValueBuffer, unBufferSize);
			}
		}

		public static bool GetHTTPResponseBodySize(HTTPRequestHandle hRequest, out uint unBodySize)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_GetHTTPResponseBodySize(CSteamAPIContext.GetSteamHTTP(), hRequest, out unBodySize);
		}

		public static bool GetHTTPResponseBodyData(HTTPRequestHandle hRequest, byte[] pBodyDataBuffer, uint unBufferSize)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_GetHTTPResponseBodyData(CSteamAPIContext.GetSteamHTTP(), hRequest, pBodyDataBuffer, unBufferSize);
		}

		public static bool GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, byte[] pBodyDataBuffer, uint unBufferSize)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_GetHTTPStreamingResponseBodyData(CSteamAPIContext.GetSteamHTTP(), hRequest, cOffset, pBodyDataBuffer, unBufferSize);
		}

		public static bool ReleaseHTTPRequest(HTTPRequestHandle hRequest)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_ReleaseHTTPRequest(CSteamAPIContext.GetSteamHTTP(), hRequest);
		}

		public static bool GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, out float pflPercentOut)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_GetHTTPDownloadProgressPct(CSteamAPIContext.GetSteamHTTP(), hRequest, out pflPercentOut);
		}

		public static bool SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, string pchContentType, byte[] pubBody, uint unBodyLen)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchContentType2 = new InteropHelp.UTF8StringHandle(pchContentType))
			{
				return NativeMethods.ISteamHTTP_SetHTTPRequestRawPostBody(CSteamAPIContext.GetSteamHTTP(), hRequest, pchContentType2, pubBody, unBodyLen);
			}
		}

		public static HTTPCookieContainerHandle CreateCookieContainer(bool bAllowResponsesToModify)
		{
			InteropHelp.TestIfAvailableClient();
			return (HTTPCookieContainerHandle)NativeMethods.ISteamHTTP_CreateCookieContainer(CSteamAPIContext.GetSteamHTTP(), bAllowResponsesToModify);
		}

		public static bool ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_ReleaseCookieContainer(CSteamAPIContext.GetSteamHTTP(), hCookieContainer);
		}

		public static bool SetCookie(HTTPCookieContainerHandle hCookieContainer, string pchHost, string pchUrl, string pchCookie)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchHost2 = new InteropHelp.UTF8StringHandle(pchHost))
			{
				using (InteropHelp.UTF8StringHandle pchUrl2 = new InteropHelp.UTF8StringHandle(pchUrl))
				{
					using (InteropHelp.UTF8StringHandle pchCookie2 = new InteropHelp.UTF8StringHandle(pchCookie))
					{
						return NativeMethods.ISteamHTTP_SetCookie(CSteamAPIContext.GetSteamHTTP(), hCookieContainer, pchHost2, pchUrl2, pchCookie2);
					}
				}
			}
		}

		public static bool SetHTTPRequestCookieContainer(HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_SetHTTPRequestCookieContainer(CSteamAPIContext.GetSteamHTTP(), hRequest, hCookieContainer);
		}

		public static bool SetHTTPRequestUserAgentInfo(HTTPRequestHandle hRequest, string pchUserAgentInfo)
		{
			InteropHelp.TestIfAvailableClient();
			using (InteropHelp.UTF8StringHandle pchUserAgentInfo2 = new InteropHelp.UTF8StringHandle(pchUserAgentInfo))
			{
				return NativeMethods.ISteamHTTP_SetHTTPRequestUserAgentInfo(CSteamAPIContext.GetSteamHTTP(), hRequest, pchUserAgentInfo2);
			}
		}

		public static bool SetHTTPRequestRequiresVerifiedCertificate(HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_SetHTTPRequestRequiresVerifiedCertificate(CSteamAPIContext.GetSteamHTTP(), hRequest, bRequireVerifiedCertificate);
		}

		public static bool SetHTTPRequestAbsoluteTimeoutMS(HTTPRequestHandle hRequest, uint unMilliseconds)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_SetHTTPRequestAbsoluteTimeoutMS(CSteamAPIContext.GetSteamHTTP(), hRequest, unMilliseconds);
		}

		public static bool GetHTTPRequestWasTimedOut(HTTPRequestHandle hRequest, out bool pbWasTimedOut)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_GetHTTPRequestWasTimedOut(CSteamAPIContext.GetSteamHTTP(), hRequest, out pbWasTimedOut);
		}
	}
}

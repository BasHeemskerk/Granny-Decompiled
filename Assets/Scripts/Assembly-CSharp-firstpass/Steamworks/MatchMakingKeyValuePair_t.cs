using System.Runtime.InteropServices;

namespace Steamworks
{
	public struct MatchMakingKeyValuePair_t
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string m_szKey;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string m_szValue;

		private MatchMakingKeyValuePair_t(string strKey, string strValue)
		{
			m_szKey = strKey;
			m_szValue = strValue;
		}
	}
}

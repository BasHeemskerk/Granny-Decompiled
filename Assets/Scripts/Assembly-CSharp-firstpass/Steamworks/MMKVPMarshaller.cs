using System;
using System.Runtime.InteropServices;

namespace Steamworks
{
	public class MMKVPMarshaller
	{
		private IntPtr m_pNativeArray;

		private IntPtr m_pArrayEntries;

		public MMKVPMarshaller(MatchMakingKeyValuePair_t[] filters)
		{
			if (filters != null)
			{
				int num = Marshal.SizeOf(typeof(MatchMakingKeyValuePair_t));
				m_pNativeArray = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(IntPtr)) * filters.Length);
				m_pArrayEntries = Marshal.AllocHGlobal(num * filters.Length);
				for (int i = 0; i < filters.Length; i++)
				{
					Marshal.StructureToPtr(filters[i], new IntPtr(m_pArrayEntries.ToInt64() + i * num), false);
				}
				Marshal.WriteIntPtr(m_pNativeArray, m_pArrayEntries);
			}
		}

		~MMKVPMarshaller()
		{
			if (m_pArrayEntries != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(m_pArrayEntries);
			}
			if (m_pNativeArray != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(m_pNativeArray);
			}
		}

		public static implicit operator IntPtr(MMKVPMarshaller that)
		{
			return that.m_pNativeArray;
		}
	}
}

using System;

namespace Steamworks
{
	[Serializable]
	public struct UGCFileWriteStreamHandle_t : IEquatable<UGCFileWriteStreamHandle_t>, IComparable<UGCFileWriteStreamHandle_t>
	{
		public static readonly UGCFileWriteStreamHandle_t Invalid = new UGCFileWriteStreamHandle_t(ulong.MaxValue);

		public ulong m_UGCFileWriteStreamHandle;

		public UGCFileWriteStreamHandle_t(ulong value)
		{
			m_UGCFileWriteStreamHandle = value;
		}

		public override string ToString()
		{
			return m_UGCFileWriteStreamHandle.ToString();
		}

		public override bool Equals(object other)
		{
			return other is UGCFileWriteStreamHandle_t && this == (UGCFileWriteStreamHandle_t)other;
		}

		public override int GetHashCode()
		{
			return m_UGCFileWriteStreamHandle.GetHashCode();
		}

		public static bool operator ==(UGCFileWriteStreamHandle_t x, UGCFileWriteStreamHandle_t y)
		{
			return x.m_UGCFileWriteStreamHandle == y.m_UGCFileWriteStreamHandle;
		}

		public static bool operator !=(UGCFileWriteStreamHandle_t x, UGCFileWriteStreamHandle_t y)
		{
			return !(x == y);
		}

		public static explicit operator UGCFileWriteStreamHandle_t(ulong value)
		{
			return new UGCFileWriteStreamHandle_t(value);
		}

		public static explicit operator ulong(UGCFileWriteStreamHandle_t that)
		{
			return that.m_UGCFileWriteStreamHandle;
		}

		public bool Equals(UGCFileWriteStreamHandle_t other)
		{
			return m_UGCFileWriteStreamHandle == other.m_UGCFileWriteStreamHandle;
		}

		public int CompareTo(UGCFileWriteStreamHandle_t other)
		{
			return m_UGCFileWriteStreamHandle.CompareTo(other.m_UGCFileWriteStreamHandle);
		}
	}
}

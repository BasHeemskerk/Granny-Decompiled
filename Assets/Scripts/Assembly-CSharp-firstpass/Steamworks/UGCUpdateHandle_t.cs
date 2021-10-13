using System;

namespace Steamworks
{
	[Serializable]
	public struct UGCUpdateHandle_t : IEquatable<UGCUpdateHandle_t>, IComparable<UGCUpdateHandle_t>
	{
		public static readonly UGCUpdateHandle_t Invalid = new UGCUpdateHandle_t(ulong.MaxValue);

		public ulong m_UGCUpdateHandle;

		public UGCUpdateHandle_t(ulong value)
		{
			m_UGCUpdateHandle = value;
		}

		public override string ToString()
		{
			return m_UGCUpdateHandle.ToString();
		}

		public override bool Equals(object other)
		{
			return other is UGCUpdateHandle_t && this == (UGCUpdateHandle_t)other;
		}

		public override int GetHashCode()
		{
			return m_UGCUpdateHandle.GetHashCode();
		}

		public static bool operator ==(UGCUpdateHandle_t x, UGCUpdateHandle_t y)
		{
			return x.m_UGCUpdateHandle == y.m_UGCUpdateHandle;
		}

		public static bool operator !=(UGCUpdateHandle_t x, UGCUpdateHandle_t y)
		{
			return !(x == y);
		}

		public static explicit operator UGCUpdateHandle_t(ulong value)
		{
			return new UGCUpdateHandle_t(value);
		}

		public static explicit operator ulong(UGCUpdateHandle_t that)
		{
			return that.m_UGCUpdateHandle;
		}

		public bool Equals(UGCUpdateHandle_t other)
		{
			return m_UGCUpdateHandle == other.m_UGCUpdateHandle;
		}

		public int CompareTo(UGCUpdateHandle_t other)
		{
			return m_UGCUpdateHandle.CompareTo(other.m_UGCUpdateHandle);
		}
	}
}

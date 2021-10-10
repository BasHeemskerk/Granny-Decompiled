using System;

namespace Steamworks
{
	[Serializable]
	public struct HAuthTicket : IEquatable<HAuthTicket>, IComparable<HAuthTicket>
	{
		public static readonly HAuthTicket Invalid = new HAuthTicket(0u);

		public uint m_HAuthTicket;

		public HAuthTicket(uint value)
		{
			m_HAuthTicket = value;
		}

		public override string ToString()
		{
			return m_HAuthTicket.ToString();
		}

		public override bool Equals(object other)
		{
			return other is HAuthTicket && this == (HAuthTicket)other;
		}

		public override int GetHashCode()
		{
			return m_HAuthTicket.GetHashCode();
		}

		public static bool operator ==(HAuthTicket x, HAuthTicket y)
		{
			return x.m_HAuthTicket == y.m_HAuthTicket;
		}

		public static bool operator !=(HAuthTicket x, HAuthTicket y)
		{
			return !(x == y);
		}

		public static explicit operator HAuthTicket(uint value)
		{
			return new HAuthTicket(value);
		}

		public static explicit operator uint(HAuthTicket that)
		{
			return that.m_HAuthTicket;
		}

		public bool Equals(HAuthTicket other)
		{
			return m_HAuthTicket == other.m_HAuthTicket;
		}

		public int CompareTo(HAuthTicket other)
		{
			return m_HAuthTicket.CompareTo(other.m_HAuthTicket);
		}
	}
}

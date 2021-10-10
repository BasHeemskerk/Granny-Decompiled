using System;

namespace Steamworks
{
	[Serializable]
	public struct HServerQuery : IEquatable<HServerQuery>, IComparable<HServerQuery>
	{
		public static readonly HServerQuery Invalid = new HServerQuery(-1);

		public int m_HServerQuery;

		public HServerQuery(int value)
		{
			m_HServerQuery = value;
		}

		public override string ToString()
		{
			return m_HServerQuery.ToString();
		}

		public override bool Equals(object other)
		{
			return other is HServerQuery && this == (HServerQuery)other;
		}

		public override int GetHashCode()
		{
			return m_HServerQuery.GetHashCode();
		}

		public static bool operator ==(HServerQuery x, HServerQuery y)
		{
			return x.m_HServerQuery == y.m_HServerQuery;
		}

		public static bool operator !=(HServerQuery x, HServerQuery y)
		{
			return !(x == y);
		}

		public static explicit operator HServerQuery(int value)
		{
			return new HServerQuery(value);
		}

		public static explicit operator int(HServerQuery that)
		{
			return that.m_HServerQuery;
		}

		public bool Equals(HServerQuery other)
		{
			return m_HServerQuery == other.m_HServerQuery;
		}

		public int CompareTo(HServerQuery other)
		{
			return m_HServerQuery.CompareTo(other.m_HServerQuery);
		}
	}
}

using System;

namespace Steamworks
{
	[Serializable]
	public struct HSteamUser : IEquatable<HSteamUser>, IComparable<HSteamUser>
	{
		public int m_HSteamUser;

		public HSteamUser(int value)
		{
			m_HSteamUser = value;
		}

		public override string ToString()
		{
			return m_HSteamUser.ToString();
		}

		public override bool Equals(object other)
		{
			return other is HSteamUser && this == (HSteamUser)other;
		}

		public override int GetHashCode()
		{
			return m_HSteamUser.GetHashCode();
		}

		public static bool operator ==(HSteamUser x, HSteamUser y)
		{
			return x.m_HSteamUser == y.m_HSteamUser;
		}

		public static bool operator !=(HSteamUser x, HSteamUser y)
		{
			return !(x == y);
		}

		public static explicit operator HSteamUser(int value)
		{
			return new HSteamUser(value);
		}

		public static explicit operator int(HSteamUser that)
		{
			return that.m_HSteamUser;
		}

		public bool Equals(HSteamUser other)
		{
			return m_HSteamUser == other.m_HSteamUser;
		}

		public int CompareTo(HSteamUser other)
		{
			return m_HSteamUser.CompareTo(other.m_HSteamUser);
		}
	}
}

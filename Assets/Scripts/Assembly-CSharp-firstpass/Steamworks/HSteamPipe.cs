using System;

namespace Steamworks
{
	[Serializable]
	public struct HSteamPipe : IEquatable<HSteamPipe>, IComparable<HSteamPipe>
	{
		public int m_HSteamPipe;

		public HSteamPipe(int value)
		{
			m_HSteamPipe = value;
		}

		public override string ToString()
		{
			return m_HSteamPipe.ToString();
		}

		public override bool Equals(object other)
		{
			return other is HSteamPipe && this == (HSteamPipe)other;
		}

		public override int GetHashCode()
		{
			return m_HSteamPipe.GetHashCode();
		}

		public static bool operator ==(HSteamPipe x, HSteamPipe y)
		{
			return x.m_HSteamPipe == y.m_HSteamPipe;
		}

		public static bool operator !=(HSteamPipe x, HSteamPipe y)
		{
			return !(x == y);
		}

		public static explicit operator HSteamPipe(int value)
		{
			return new HSteamPipe(value);
		}

		public static explicit operator int(HSteamPipe that)
		{
			return that.m_HSteamPipe;
		}

		public bool Equals(HSteamPipe other)
		{
			return m_HSteamPipe == other.m_HSteamPipe;
		}

		public int CompareTo(HSteamPipe other)
		{
			return m_HSteamPipe.CompareTo(other.m_HSteamPipe);
		}
	}
}

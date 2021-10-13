using System;

namespace Steamworks
{
	[Serializable]
	public struct ManifestId_t : IEquatable<ManifestId_t>, IComparable<ManifestId_t>
	{
		public static readonly ManifestId_t Invalid = new ManifestId_t(0uL);

		public ulong m_ManifestId;

		public ManifestId_t(ulong value)
		{
			m_ManifestId = value;
		}

		public override string ToString()
		{
			return m_ManifestId.ToString();
		}

		public override bool Equals(object other)
		{
			return other is ManifestId_t && this == (ManifestId_t)other;
		}

		public override int GetHashCode()
		{
			return m_ManifestId.GetHashCode();
		}

		public static bool operator ==(ManifestId_t x, ManifestId_t y)
		{
			return x.m_ManifestId == y.m_ManifestId;
		}

		public static bool operator !=(ManifestId_t x, ManifestId_t y)
		{
			return !(x == y);
		}

		public static explicit operator ManifestId_t(ulong value)
		{
			return new ManifestId_t(value);
		}

		public static explicit operator ulong(ManifestId_t that)
		{
			return that.m_ManifestId;
		}

		public bool Equals(ManifestId_t other)
		{
			return m_ManifestId == other.m_ManifestId;
		}

		public int CompareTo(ManifestId_t other)
		{
			return m_ManifestId.CompareTo(other.m_ManifestId);
		}
	}
}

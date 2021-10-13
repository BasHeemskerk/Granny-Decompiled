using System;

namespace Steamworks
{
	[Serializable]
	public struct ControllerHandle_t : IEquatable<ControllerHandle_t>, IComparable<ControllerHandle_t>
	{
		public ulong m_ControllerHandle;

		public ControllerHandle_t(ulong value)
		{
			m_ControllerHandle = value;
		}

		public override string ToString()
		{
			return m_ControllerHandle.ToString();
		}

		public override bool Equals(object other)
		{
			return other is ControllerHandle_t && this == (ControllerHandle_t)other;
		}

		public override int GetHashCode()
		{
			return m_ControllerHandle.GetHashCode();
		}

		public static bool operator ==(ControllerHandle_t x, ControllerHandle_t y)
		{
			return x.m_ControllerHandle == y.m_ControllerHandle;
		}

		public static bool operator !=(ControllerHandle_t x, ControllerHandle_t y)
		{
			return !(x == y);
		}

		public static explicit operator ControllerHandle_t(ulong value)
		{
			return new ControllerHandle_t(value);
		}

		public static explicit operator ulong(ControllerHandle_t that)
		{
			return that.m_ControllerHandle;
		}

		public bool Equals(ControllerHandle_t other)
		{
			return m_ControllerHandle == other.m_ControllerHandle;
		}

		public int CompareTo(ControllerHandle_t other)
		{
			return m_ControllerHandle.CompareTo(other.m_ControllerHandle);
		}
	}
}

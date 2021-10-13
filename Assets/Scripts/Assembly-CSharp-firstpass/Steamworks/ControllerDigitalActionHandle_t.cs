using System;

namespace Steamworks
{
	[Serializable]
	public struct ControllerDigitalActionHandle_t : IEquatable<ControllerDigitalActionHandle_t>, IComparable<ControllerDigitalActionHandle_t>
	{
		public ulong m_ControllerDigitalActionHandle;

		public ControllerDigitalActionHandle_t(ulong value)
		{
			m_ControllerDigitalActionHandle = value;
		}

		public override string ToString()
		{
			return m_ControllerDigitalActionHandle.ToString();
		}

		public override bool Equals(object other)
		{
			return other is ControllerDigitalActionHandle_t && this == (ControllerDigitalActionHandle_t)other;
		}

		public override int GetHashCode()
		{
			return m_ControllerDigitalActionHandle.GetHashCode();
		}

		public static bool operator ==(ControllerDigitalActionHandle_t x, ControllerDigitalActionHandle_t y)
		{
			return x.m_ControllerDigitalActionHandle == y.m_ControllerDigitalActionHandle;
		}

		public static bool operator !=(ControllerDigitalActionHandle_t x, ControllerDigitalActionHandle_t y)
		{
			return !(x == y);
		}

		public static explicit operator ControllerDigitalActionHandle_t(ulong value)
		{
			return new ControllerDigitalActionHandle_t(value);
		}

		public static explicit operator ulong(ControllerDigitalActionHandle_t that)
		{
			return that.m_ControllerDigitalActionHandle;
		}

		public bool Equals(ControllerDigitalActionHandle_t other)
		{
			return m_ControllerDigitalActionHandle == other.m_ControllerDigitalActionHandle;
		}

		public int CompareTo(ControllerDigitalActionHandle_t other)
		{
			return m_ControllerDigitalActionHandle.CompareTo(other.m_ControllerDigitalActionHandle);
		}
	}
}

using System;

namespace Steamworks
{
	[Serializable]
	public struct ControllerAnalogActionHandle_t : IEquatable<ControllerAnalogActionHandle_t>, IComparable<ControllerAnalogActionHandle_t>
	{
		public ulong m_ControllerAnalogActionHandle;

		public ControllerAnalogActionHandle_t(ulong value)
		{
			m_ControllerAnalogActionHandle = value;
		}

		public override string ToString()
		{
			return m_ControllerAnalogActionHandle.ToString();
		}

		public override bool Equals(object other)
		{
			return other is ControllerAnalogActionHandle_t && this == (ControllerAnalogActionHandle_t)other;
		}

		public override int GetHashCode()
		{
			return m_ControllerAnalogActionHandle.GetHashCode();
		}

		public static bool operator ==(ControllerAnalogActionHandle_t x, ControllerAnalogActionHandle_t y)
		{
			return x.m_ControllerAnalogActionHandle == y.m_ControllerAnalogActionHandle;
		}

		public static bool operator !=(ControllerAnalogActionHandle_t x, ControllerAnalogActionHandle_t y)
		{
			return !(x == y);
		}

		public static explicit operator ControllerAnalogActionHandle_t(ulong value)
		{
			return new ControllerAnalogActionHandle_t(value);
		}

		public static explicit operator ulong(ControllerAnalogActionHandle_t that)
		{
			return that.m_ControllerAnalogActionHandle;
		}

		public bool Equals(ControllerAnalogActionHandle_t other)
		{
			return m_ControllerAnalogActionHandle == other.m_ControllerAnalogActionHandle;
		}

		public int CompareTo(ControllerAnalogActionHandle_t other)
		{
			return m_ControllerAnalogActionHandle.CompareTo(other.m_ControllerAnalogActionHandle);
		}
	}
}

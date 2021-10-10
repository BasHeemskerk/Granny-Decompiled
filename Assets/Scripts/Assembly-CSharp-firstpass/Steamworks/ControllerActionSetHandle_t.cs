using System;

namespace Steamworks
{
	[Serializable]
	public struct ControllerActionSetHandle_t : IEquatable<ControllerActionSetHandle_t>, IComparable<ControllerActionSetHandle_t>
	{
		public ulong m_ControllerActionSetHandle;

		public ControllerActionSetHandle_t(ulong value)
		{
			m_ControllerActionSetHandle = value;
		}

		public override string ToString()
		{
			return m_ControllerActionSetHandle.ToString();
		}

		public override bool Equals(object other)
		{
			return other is ControllerActionSetHandle_t && this == (ControllerActionSetHandle_t)other;
		}

		public override int GetHashCode()
		{
			return m_ControllerActionSetHandle.GetHashCode();
		}

		public static bool operator ==(ControllerActionSetHandle_t x, ControllerActionSetHandle_t y)
		{
			return x.m_ControllerActionSetHandle == y.m_ControllerActionSetHandle;
		}

		public static bool operator !=(ControllerActionSetHandle_t x, ControllerActionSetHandle_t y)
		{
			return !(x == y);
		}

		public static explicit operator ControllerActionSetHandle_t(ulong value)
		{
			return new ControllerActionSetHandle_t(value);
		}

		public static explicit operator ulong(ControllerActionSetHandle_t that)
		{
			return that.m_ControllerActionSetHandle;
		}

		public bool Equals(ControllerActionSetHandle_t other)
		{
			return m_ControllerActionSetHandle == other.m_ControllerActionSetHandle;
		}

		public int CompareTo(ControllerActionSetHandle_t other)
		{
			return m_ControllerActionSetHandle.CompareTo(other.m_ControllerActionSetHandle);
		}
	}
}

using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(516)]
	public struct FavoritesListAccountsUpdated_t
	{
		public const int k_iCallback = 516;

		public EResult m_eResult;
	}
}

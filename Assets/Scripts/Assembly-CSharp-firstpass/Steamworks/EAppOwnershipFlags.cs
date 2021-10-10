using System;

namespace Steamworks
{
	[Flags]
	public enum EAppOwnershipFlags
	{
		k_EAppOwnershipFlags_None = 0x0,
		k_EAppOwnershipFlags_OwnsLicense = 0x1,
		k_EAppOwnershipFlags_FreeLicense = 0x2,
		k_EAppOwnershipFlags_RegionRestricted = 0x4,
		k_EAppOwnershipFlags_LowViolence = 0x8,
		k_EAppOwnershipFlags_InvalidPlatform = 0x10,
		k_EAppOwnershipFlags_SharedLicense = 0x20,
		k_EAppOwnershipFlags_FreeWeekend = 0x40,
		k_EAppOwnershipFlags_RetailLicense = 0x80,
		k_EAppOwnershipFlags_LicenseLocked = 0x100,
		k_EAppOwnershipFlags_LicensePending = 0x200,
		k_EAppOwnershipFlags_LicenseExpired = 0x400,
		k_EAppOwnershipFlags_LicensePermanent = 0x800,
		k_EAppOwnershipFlags_LicenseRecurring = 0x1000,
		k_EAppOwnershipFlags_LicenseCanceled = 0x2000,
		k_EAppOwnershipFlags_AutoGrant = 0x4000,
		k_EAppOwnershipFlags_PendingGift = 0x8000,
		k_EAppOwnershipFlags_RentalNotActivated = 0x10000,
		k_EAppOwnershipFlags_Rental = 0x20000,
		k_EAppOwnershipFlags_SiteLicense = 0x40000
	}
}

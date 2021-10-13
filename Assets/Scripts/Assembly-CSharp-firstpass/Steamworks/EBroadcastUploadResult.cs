namespace Steamworks
{
	public enum EBroadcastUploadResult
	{
		k_EBroadcastUploadResultNone,
		k_EBroadcastUploadResultOK,
		k_EBroadcastUploadResultInitFailed,
		k_EBroadcastUploadResultFrameFailed,
		k_EBroadcastUploadResultTimeout,
		k_EBroadcastUploadResultBandwidthExceeded,
		k_EBroadcastUploadResultLowFPS,
		k_EBroadcastUploadResultMissingKeyFrames,
		k_EBroadcastUploadResultNoConnection,
		k_EBroadcastUploadResultRelayFailed,
		k_EBroadcastUploadResultSettingsChanged,
		k_EBroadcastUploadResultMissingAudio,
		k_EBroadcastUploadResultTooFarBehind,
		k_EBroadcastUploadResultTranscodeBehind
	}
}

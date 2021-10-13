using UnityEngine;

public class CNThrowableTouchpad : CNTouchpad
{
	[SerializeField]
	[HideInInspector]
	private float _speedDecay = 0.9f;

	public float SpeedDecay
	{
		get
		{
			return _speedDecay;
		}
		set
		{
			_speedDecay = value;
		}
	}

	protected override void ResetControlState()
	{
		base.IsCurrentlyTweaking = false;
		OnFingerLifted();
	}

	protected override void Update()
	{
		base.Update();
		if (base.CurrentAxisValues.sqrMagnitude <= 0.001f)
		{
			base.CurrentAxisValues = Vector2.zero;
			return;
		}
		base.CurrentAxisValues *= SpeedDecay;
		OnControllerMoved(base.CurrentAxisValues);
	}
}

using UnityEngine;

public class CNTouchpad : CNAbstractController
{
	[SerializeField]
	[HideInInspector]
	private bool _isAlwaysNormalized = true;

	public bool IsAlwaysNormalized
	{
		get
		{
			return _isAlwaysNormalized;
		}
		set
		{
			_isAlwaysNormalized = value;
		}
	}

	public Vector3 PreviousPosition { get; set; }

	protected virtual void Update()
	{
		Touch capturedTouch;
		if (!TweakIfNeeded() && IsTouchCaptured(out capturedTouch))
		{
			PreviousPosition = base.ParentCamera.ScreenToWorldPoint(capturedTouch.position);
		}
	}

	protected override void TweakControl(Vector2 touchPosition)
	{
		Vector3 vector = base.ParentCamera.ScreenToWorldPoint(touchPosition);
		Vector3 vector2 = vector - PreviousPosition;
		if (IsAlwaysNormalized)
		{
			vector2.Normalize();
		}
		base.CurrentAxisValues = vector2;
		OnControllerMoved(vector2);
		PreviousPosition = vector;
	}
}

using System;
using UnityEngine;

[Serializable]
public abstract class CNAbstractController : MonoBehaviour
{
	[Flags]
	protected enum AnchorsBase
	{
		Left = 0x1,
		Right = 0x2,
		Top = 0x4,
		Bottom = 0x8
	}

	public enum Anchors
	{
		LeftTop = 5,
		LeftBottom = 9,
		RightTop = 6,
		RightBottom = 10
	}

	private const string AxisNameHorizontal = "Horizontal";

	private const string AxisNameVertical = "Vertical";

	[SerializeField]
	[HideInInspector]
	private Anchors _anchor = Anchors.LeftBottom;

	[SerializeField]
	[HideInInspector]
	private string _axisNameX = "Horizontal";

	[SerializeField]
	[HideInInspector]
	private string _axisNameY = "Vertical";

	[SerializeField]
	[HideInInspector]
	private Vector2 _touchZoneSize = new Vector2(6f, 6f);

	[SerializeField]
	[HideInInspector]
	private Vector2 _margins = new Vector2(3f, 3f);

	public Anchors Anchor
	{
		get
		{
			return _anchor;
		}
		set
		{
			_anchor = value;
		}
	}

	public string AxisNameX
	{
		get
		{
			return _axisNameX;
		}
		set
		{
			_axisNameX = value;
		}
	}

	public string AxisNameY
	{
		get
		{
			return _axisNameY;
		}
		set
		{
			_axisNameY = value;
		}
	}

	public Vector2 Margins
	{
		get
		{
			return _margins;
		}
		set
		{
			_margins = value;
		}
	}

	public Vector2 TouchZoneSize
	{
		get
		{
			return _touchZoneSize;
		}
		set
		{
			_touchZoneSize = value;
		}
	}

	protected Transform TransformCache { get; set; }

	protected Camera ParentCamera { get; set; }

	protected Rect CalculatedTouchZone { get; set; }

	protected Vector2 CurrentAxisValues { get; set; }

	protected int CurrentFingerId { get; set; }

	protected Vector3? CalculatedPosition { get; set; }

	protected bool IsCurrentlyTweaking { get; set; }

	public event Action<Vector3, CNAbstractController> ControllerMovedEvent;

	public event Action<CNAbstractController> FingerTouchedEvent;

	public event Action<CNAbstractController> FingerLiftedEvent;

	public virtual float GetAxis(string axisName)
	{
		if (AxisNameX == null || AxisNameY == null || AxisNameX == string.Empty || AxisNameY == string.Empty)
		{
			throw new UnityException("Input Axis " + axisName + " is not setup");
		}
		if (axisName == AxisNameX)
		{
			return CurrentAxisValues.x;
		}
		if (axisName == AxisNameY)
		{
			return CurrentAxisValues.y;
		}
		throw new UnityException("Input Axis " + axisName + " is not setup");
	}

	public virtual void Disable()
	{
		CurrentAxisValues = Vector2.zero;
		base.gameObject.SetActive(false);
		base.enabled = false;
	}

	public virtual void Enable()
	{
		base.gameObject.SetActive(true);
		base.enabled = true;
	}

	public virtual void OnEnable()
	{
		TransformCache = GetComponent<Transform>();
		ParentCamera = TransformCache.parent.GetComponent<Camera>();
		TransformCache.localPosition = InitializePosition();
	}

	protected virtual Touch? GetTouchByFingerId(int fingerId)
	{
		int touchCount = Input.touchCount;
		for (int i = 0; i < touchCount; i++)
		{
			Touch touch = Input.GetTouch(i);
			if (touch.fingerId == fingerId)
			{
				return touch;
			}
		}
		return null;
	}

	protected virtual void OnControllerMoved(Vector2 input)
	{
		if (this.ControllerMovedEvent != null)
		{
			this.ControllerMovedEvent(input, this);
		}
	}

	protected virtual void OnFingerTouched()
	{
		if (this.FingerTouchedEvent != null)
		{
			this.FingerTouchedEvent(this);
		}
	}

	protected virtual void OnFingerLifted()
	{
		if (this.FingerLiftedEvent != null)
		{
			this.FingerLiftedEvent(this);
		}
	}

	protected Vector3 InitializePosition()
	{
		if (CalculatedPosition.HasValue)
		{
			return CalculatedPosition.Value;
		}
		float orthographicSize = ParentCamera.orthographicSize;
		float num = orthographicSize * ParentCamera.aspect;
		Vector3 result = new Vector3(0f, 0f, 0f);
		if ((Anchor & (Anchors)1) != 0)
		{
			result.x = 0f - num + Margins.x;
		}
		else
		{
			result.x = num - Margins.x;
		}
		if ((Anchor & (Anchors)4) != 0)
		{
			result.y = orthographicSize - Margins.y;
		}
		else
		{
			result.y = 0f - orthographicSize + Margins.y;
		}
		CalculatedTouchZone = new Rect(TransformCache.position.x - TouchZoneSize.x / 2f, TransformCache.position.y - TouchZoneSize.y / 2f, TouchZoneSize.x, TouchZoneSize.y);
		return result;
	}

	protected virtual void ResetControlState()
	{
		IsCurrentlyTweaking = false;
		CurrentAxisValues = Vector2.zero;
		OnFingerLifted();
	}

	protected virtual bool TweakIfNeeded()
	{
		if (IsCurrentlyTweaking)
		{
			Touch? touchByFingerId = GetTouchByFingerId(CurrentFingerId);
			if (!touchByFingerId.HasValue || touchByFingerId.Value.phase == TouchPhase.Ended)
			{
				ResetControlState();
				return false;
			}
			TweakControl(touchByFingerId.Value.position);
			return true;
		}
		return false;
	}

	protected virtual bool IsTouchCaptured(out Touch capturedTouch)
	{
		int touchCount = Input.touchCount;
		for (int i = 0; i < touchCount; i++)
		{
			Touch touch = Input.GetTouch(i);
			if (touch.phase == TouchPhase.Began && IsTouchInZone(touch.position))
			{
				IsCurrentlyTweaking = true;
				CurrentFingerId = touch.fingerId;
				OnFingerTouched();
				capturedTouch = touch;
				return true;
			}
		}
		capturedTouch = default(Touch);
		return false;
	}

	private bool IsTouchInZone(Vector2 touchPosition)
	{
		return CalculatedTouchZone.Contains(ParentCamera.ScreenToWorldPoint(touchPosition), false);
	}

	protected abstract void TweakControl(Vector2 touchPosition);
}

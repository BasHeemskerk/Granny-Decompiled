using System;
using UnityEngine;

[Serializable]
[RequireComponent(typeof(GUITexture))]
public class Joystick : MonoBehaviour
{
	private static Joystick[] joysticks;

	private static bool enumeratedJoysticks;

	private static float tapTimeDelta;

	public bool touchPad;

	public Rect touchZone;

	public Vector2 deadZone;

	public bool normalize;

	public Vector2 position;

	public int tapCount;

	private int lastFingerId;

	private float tapTimeWindow;

	private Vector2 fingerDownPos;

	private float fingerDownTime;

	private float firstDeltaTime;

	private GUITexture gui;

	private Rect defaultRect;

	private Boundary guiBoundary;

	private Vector2 guiTouchOffset;

	private Vector2 guiCenter;

	public bool havestopped;

	public GUITexture joystickRing;

	public GameObject footstepScriptHolder;

	public GameObject JoystickBase;

	public GameObject joystickCircle;

	public Joystick()
	{
		deadZone = Vector2.zero;
		lastFingerId = -1;
		firstDeltaTime = 0.5f;
		guiBoundary = new Boundary();
	}

	static Joystick()
	{
		tapTimeDelta = 0.3f;
	}

	public virtual void Start()
	{
		footstepScriptHolder = GameObject.Find("Main Camera");
		gui = (GUITexture)GetComponent(typeof(GUITexture));
		defaultRect = gui.pixelInset;
		defaultRect.x += base.transform.position.x * (float)Screen.width;
		defaultRect.y += base.transform.position.y * (float)Screen.height;
		float x = 0f;
		Vector3 vector = base.transform.position;
		vector.x = x;
		base.transform.position = vector;
		float y = 0f;
		Vector3 vector2 = base.transform.position;
		vector2.y = y;
		base.transform.position = vector2;
		defaultRect.width = 0.13f * (float)Screen.width;
		defaultRect.height = defaultRect.width;
		defaultRect.x = 0.09f * (float)Screen.width;
		defaultRect.y = 0.13f * (float)Screen.height;
		float width = 0.13f * (float)Screen.width;
		Rect pixelInset = joystickRing.pixelInset;
		pixelInset.width = width;
		joystickRing.pixelInset = pixelInset;
		float width2 = defaultRect.width;
		Rect pixelInset2 = joystickRing.pixelInset;
		pixelInset2.height = width2;
		joystickRing.pixelInset = pixelInset2;
		float x2 = 0.09f * (float)Screen.width;
		Rect pixelInset3 = joystickRing.pixelInset;
		pixelInset3.x = x2;
		joystickRing.pixelInset = pixelInset3;
		float y2 = 0.13f * (float)Screen.height;
		Rect pixelInset4 = joystickRing.pixelInset;
		pixelInset4.y = y2;
		joystickRing.pixelInset = pixelInset4;
		if (touchPad)
		{
			if ((bool)gui.texture)
			{
				touchZone = defaultRect;
			}
			return;
		}
		guiTouchOffset.x = defaultRect.width * 0.5f;
		guiTouchOffset.y = defaultRect.height * 0.5f;
		guiCenter.x = defaultRect.x + guiTouchOffset.x;
		guiCenter.y = defaultRect.y + guiTouchOffset.y;
		guiBoundary.min.x = defaultRect.x - guiTouchOffset.x;
		guiBoundary.max.x = defaultRect.x + guiTouchOffset.x;
		guiBoundary.min.y = defaultRect.y - guiTouchOffset.y;
		guiBoundary.max.y = defaultRect.y + guiTouchOffset.y;
	}

	public virtual void Disable()
	{
		base.gameObject.SetActive(false);
		enumeratedJoysticks = false;
	}

	public virtual void ResetJoystick()
	{
		if (!havestopped)
		{
			havestopped = true;
			((Footsteps)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
		}
		gui.pixelInset = defaultRect;
		lastFingerId = -1;
		position = Vector2.zero;
		fingerDownPos = Vector2.zero;
		if (touchPad)
		{
			float a = 0.025f;
			Color color = gui.color;
			color.a = a;
			gui.color = color;
		}
	}

	public virtual bool IsFingerDown()
	{
		return lastFingerId != -1;
	}

	public virtual void LatchedFinger(int fingerId)
	{
		if (lastFingerId == fingerId)
		{
			ResetJoystick();
		}
	}

	public virtual void Update()
	{
		if (!enumeratedJoysticks)
		{
			joysticks = (Joystick[])UnityEngine.Object.FindObjectsOfType(typeof(Joystick));
			enumeratedJoysticks = true;
		}
		int touchCount = Input.touchCount;
		if (tapTimeWindow > 0f)
		{
			tapTimeWindow -= Time.deltaTime;
			((Footsteps)footstepScriptHolder.GetComponent(typeof(Footsteps))).walk();
			havestopped = false;
		}
		else
		{
			tapCount = 0;
		}
		if (touchCount == 0)
		{
			ResetJoystick();
		}
		else
		{
			for (int i = 0; i < touchCount; i++)
			{
				Touch touch = Input.GetTouch(i);
				Vector2 vector = touch.position - guiTouchOffset;
				bool flag = false;
				if (touchPad)
				{
					if (touchZone.Contains(touch.position))
					{
						flag = true;
					}
				}
				else if (gui.HitTest(touch.position))
				{
					flag = true;
				}
				if (flag && (lastFingerId == -1 || lastFingerId != touch.fingerId))
				{
					if (touchPad)
					{
						float a = 0.15f;
						Color color = gui.color;
						color.a = a;
						gui.color = color;
						lastFingerId = touch.fingerId;
						fingerDownPos = touch.position;
						fingerDownTime = Time.time;
					}
					lastFingerId = touch.fingerId;
					if (tapTimeWindow > 0f)
					{
						tapCount++;
					}
					else
					{
						tapCount = 1;
						tapTimeWindow = tapTimeDelta;
					}
					Joystick[] array = joysticks;
					foreach (Joystick joystick in array)
					{
						if (joystick != this)
						{
							joystick.LatchedFinger(touch.fingerId);
						}
					}
				}
				if (lastFingerId == touch.fingerId)
				{
					if (touch.tapCount > tapCount)
					{
						tapCount = touch.tapCount;
					}
					if (touchPad)
					{
						position.x = Mathf.Clamp((touch.position.x - fingerDownPos.x) / (touchZone.width / 2f), -1f, 1f);
						position.y = Mathf.Clamp((touch.position.y - fingerDownPos.y) / (touchZone.height / 2f), -1f, 1f);
					}
					else
					{
						((Footsteps)footstepScriptHolder.GetComponent(typeof(Footsteps))).walk();
						float x = Mathf.Clamp(vector.x, guiBoundary.min.x * 1.09f, guiBoundary.max.x * 1.09f);
						Rect pixelInset = gui.pixelInset;
						pixelInset.x = x;
						gui.pixelInset = pixelInset;
						float y = Mathf.Clamp(vector.y, guiBoundary.min.y, guiBoundary.max.y * 1.09f);
						Rect pixelInset2 = gui.pixelInset;
						pixelInset2.y = y;
						gui.pixelInset = pixelInset2;
					}
					if (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled)
					{
						ResetJoystick();
					}
				}
			}
		}
		if (!touchPad)
		{
			position.x = (gui.pixelInset.x + guiTouchOffset.x - guiCenter.x) / guiTouchOffset.x;
			position.y = (gui.pixelInset.y + guiTouchOffset.y - guiCenter.y) / guiTouchOffset.y;
		}
		float num = Mathf.Abs(position.x);
		float num2 = Mathf.Abs(position.y);
		if (num < deadZone.x)
		{
			position.x = 0f;
		}
		else if (normalize)
		{
			position.x = Mathf.Sign(position.x) * (num - deadZone.x) / (1f - deadZone.x);
		}
		if (num2 < deadZone.y)
		{
			position.y = 0f;
		}
		else if (normalize)
		{
			position.y = Mathf.Sign(position.y) * (num2 - deadZone.y) / (1f - deadZone.y);
		}
	}
}

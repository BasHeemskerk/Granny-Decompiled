using UnityEngine;

public class CameraFollowExample : MonoBehaviour
{
	public CNAbstractController RotateJoystick;

	public float PitchSpeed = 10f;

	public float YawSpeed = 10f;

	public Transform player;

	public Transform playerHead;

	public float Pitch;

	public float yaw;

	public float rotationx;

	private Transform _transformCache;

	public Transform _parentTransformCache;

	private Vector3 clampedRotation;

	public bool touching;

	public bool test;

	public GameObject playerActive;

	public GameObject senseHolder;

	private saveSensitivityData SensData;

	private void Start()
	{
		SensData = senseHolder.GetComponent<saveSensitivityData>();
		YawSpeed = SensData.sliderValue;
		PitchSpeed = YawSpeed / 2f;
		_transformCache = GetComponent<Transform>();
		_parentTransformCache = _transformCache.parent;
	}

	private void Update()
	{
		if (!playerActive.activeSelf)
		{
			PitchSpeed = 0f;
		}
		else
		{
			PitchSpeed = YawSpeed / 2f;
		}
		SensData = senseHolder.GetComponent<saveSensitivityData>();
		YawSpeed = SensData.sliderValue;
		if (RotateJoystick != null)
		{
			Vector3 eulerAngles = _parentTransformCache.eulerAngles;
			float yAngle = RotateJoystick.GetAxis("Horizontal") * YawSpeed * 5f * Time.deltaTime;
			rotationx += RotateJoystick.GetAxis("Vertical") * PitchSpeed * 5f * Time.deltaTime;
			player.Rotate(0f, yAngle, 0f, Space.World);
			rotationx = Mathf.Clamp(rotationx, -80f, 80f);
			playerHead.localEulerAngles = new Vector3(0f - rotationx, 0f, playerHead.localEulerAngles.y);
		}
	}
}

using System.Collections;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Controller3DExample : MonoBehaviour
{
	public const float ROTATE_SPEED = 15f;

	public float movementSpeed = 5f;

	public CNAbstractController MovementJoystick;

	private CharacterController _characterController;

	private Transform _mainCameraTransform;

	private Transform _transformCache;

	private Transform _playerTransform;

	private void Start()
	{
		_characterController = GetComponent<CharacterController>();
		_mainCameraTransform = Camera.main.GetComponent<Transform>();
		_transformCache = GetComponent<Transform>();
		_playerTransform = _transformCache.Find("Cocoon");
	}

	private void Update()
	{
		Vector3 movement = new Vector3(MovementJoystick.GetAxis("Horizontal"), 0f, MovementJoystick.GetAxis("Vertical"));
		CommonMovementMethod(movement);
	}

	private void MoveWithEvent(Vector3 inputMovement)
	{
		Vector3 movement = new Vector3(inputMovement.x, 0f, inputMovement.y);
		CommonMovementMethod(movement);
	}

	private void CommonMovementMethod(Vector3 movement)
	{
		movement = _mainCameraTransform.TransformDirection(movement);
		movement.y = 0f;
		movement.Normalize();
		FaceDirection(movement);
		_characterController.Move(movement * movementSpeed * Time.deltaTime);
	}

	public void FaceDirection(Vector3 direction)
	{
		StopCoroutine("RotateCoroutine");
		StartCoroutine("RotateCoroutine", direction);
	}

	private IEnumerator RotateCoroutine(Vector3 direction)
	{
		if (!(direction == Vector3.zero))
		{
			Quaternion lookRotation = Quaternion.LookRotation(direction);
			do
			{
				_playerTransform.rotation = Quaternion.Lerp(_playerTransform.rotation, lookRotation, Time.deltaTime * 15f);
				yield return null;
			}
			while ((direction - _playerTransform.forward).sqrMagnitude > 0.2f);
		}
	}
}

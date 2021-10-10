using UnityEngine;

public class mouseLook : MonoBehaviour
{
	private void Start()
	{
	}

	private void Update()
	{
		float axis = Input.GetAxis("Mouse X");
		Vector3 eulers = new Vector3(0f, axis, 0f);
		base.transform.Rotate(eulers);
	}
}

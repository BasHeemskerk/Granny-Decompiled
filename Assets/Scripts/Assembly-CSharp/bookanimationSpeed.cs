using UnityEngine;

public class bookanimationSpeed : MonoBehaviour
{
	private void Start()
	{
		base.gameObject.GetComponent<Animation>()["BookOpen"].speed = 0.5f;
	}

	private void Update()
	{
	}
}

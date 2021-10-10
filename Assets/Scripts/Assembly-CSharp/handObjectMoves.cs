using UnityEngine;

public class handObjectMoves : MonoBehaviour
{
	private Vector3 vectOffset;

	public GameObject goFollow;

	[SerializeField]
	private float speed = 3f;

	private void Start()
	{
		vectOffset = base.transform.position - goFollow.transform.position;
	}

	private void Update()
	{
		base.transform.position = goFollow.transform.position + vectOffset;
		base.transform.rotation = Quaternion.Slerp(base.transform.rotation, goFollow.transform.rotation, speed * Time.deltaTime);
	}
}

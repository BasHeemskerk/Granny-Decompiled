using UnityEngine;

public class noPlayerColliding : MonoBehaviour
{
	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			Physics.IgnoreCollision(GetComponent<Collider>(), other.GetComponent<Collider>(), true);
		}
	}
}

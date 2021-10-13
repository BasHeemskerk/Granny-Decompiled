using System;
using UnityEngine;

[Serializable]
public class haveObjects : MonoBehaviour
{
	public bool handleOK;

	public bool ironKlumpOK;

	public bool playerStandOnPlatta;

	public GameObject handleBild;

	public GameObject ironKlumpBild;

	public bool brakedPlanka1;

	public bool brakedPlanka2;

	public bool plankaDoorTag;

	public GameObject plankaDoorHolder;

	public GameObject crowbarBild;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (handleOK && ironKlumpOK)
		{
			float x = 0.44f;
			Vector3 position = ironKlumpBild.transform.position;
			position.x = x;
			ironKlumpBild.transform.position = position;
			float x2 = 0.56f;
			Vector3 position2 = handleBild.transform.position;
			position2.x = x2;
			handleBild.transform.position = position2;
		}
		else
		{
			float x3 = 0.5f;
			Vector3 position3 = ironKlumpBild.transform.position;
			position3.x = x3;
			ironKlumpBild.transform.position = position3;
			float x4 = 0.5f;
			Vector3 position4 = handleBild.transform.position;
			position4.x = x4;
			handleBild.transform.position = position4;
		}
		if (brakedPlanka1 && brakedPlanka2)
		{
			doorTag();
		}
	}

	public virtual void doorTag()
	{
		if (!plankaDoorTag)
		{
			plankaDoorTag = true;
			plankaDoorHolder.gameObject.tag = "doorClosed";
			crowbarBild.SetActive(false);
		}
	}
}

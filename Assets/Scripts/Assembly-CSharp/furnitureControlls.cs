using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class furnitureControlls : MonoBehaviour
{
	public GameObject bordVR;

	public Transform bordVRPos;

	public GameObject lampaVR;

	public Transform lampaVRPos;

	public GameObject TavlaVR;

	public Transform TavlaVRPos;

	public GameObject TavlaRumBV;

	public Transform TavlaRumBVPos;

	public GameObject LampaRumBV;

	public Transform LampaRumBVPos;

	public GameObject LjusstakeHall;

	public Transform LjusstakeHallPos;

	public GameObject LjusstakeHall2;

	public Transform LjusstakeHallPos2;

	public GameObject LjusstakeCellar;

	public Transform LjusstakeCellarPos;

	public GameObject LitenTavla1;

	public Transform LitenTavla1Pos;

	public GameObject LitenTavla2;

	public Transform LitenTavla2Pos;

	public GameObject LitenTavla3;

	public Transform LitenTavla3Pos;

	public GameObject TavlaSR1;

	public Transform TavlaSR1Pos;

	public GameObject ChairSR1;

	public Transform ChairSR1Pos;

	public GameObject Galge;

	public Transform GalgePos;

	public GameObject LampaSR2;

	public Transform LampaSR2Pos;

	public GameObject LitetBordSR3;

	public Transform LitetBordSR3Pos;

	public GameObject TavlaSR3;

	public Transform TavlaSR3Pos;

	public GameObject TavlaKitchen;

	public Transform TavlaKitchenPos;

	public GameObject Tallrik1;

	public Transform Tallrik1Pos;

	public GameObject Tallrik2;

	public Transform Tallrik2Pos;

	public GameObject Tallrik3;

	public Transform Tallrik3Pos;

	public GameObject GallerDoor;

	public Transform GallerDoorPos;

	public GameObject WoodenBox;

	public Transform WoodenBoxPos;

	public GameObject Pedistal;

	public Transform PedistalPos;

	public GameObject Manikin;

	public Transform ManikinPos;

	public GameObject BurkOH;

	public Transform BurkOHPos;

	public virtual IEnumerator cleanUp()
	{
		if ((bool)GameObject.Find("LitetBordVR(Clone)"))
		{
			UnityEngine.Object.Destroy(GameObject.Find("LitetBordVR(Clone)"));
			UnityEngine.Object.Instantiate(bordVR, bordVRPos.position, bordVRPos.rotation);
			yield return new WaitForSeconds(0.5f);
			GameObject.Find("LitetBordVR(Clone)").transform.name = "LitetBordVR";
		}
		if ((bool)GameObject.Find("LampaVR(Clone)"))
		{
			UnityEngine.Object.Destroy(GameObject.Find("LampaVR(Clone)"));
			UnityEngine.Object.Instantiate(lampaVR, lampaVRPos.position, lampaVRPos.rotation);
			yield return new WaitForSeconds(0.5f);
			GameObject.Find("LampaVR(Clone)").transform.name = "LampaVR";
		}
		if ((bool)GameObject.Find("TavlaVR(Clone)"))
		{
			UnityEngine.Object.Destroy(GameObject.Find("TavlaVR(Clone)"));
			UnityEngine.Object.Instantiate(TavlaVR, TavlaVRPos.position, TavlaVRPos.rotation);
			yield return new WaitForSeconds(0.5f);
			GameObject.Find("TavlaVR(Clone)").transform.name = "TavlaVR";
		}
		if ((bool)GameObject.Find("RumBVTavla(Clone)"))
		{
			UnityEngine.Object.Destroy(GameObject.Find("RumBVTavla(Clone)"));
			UnityEngine.Object.Instantiate(TavlaRumBV, TavlaRumBVPos.position, TavlaRumBVPos.rotation);
			yield return new WaitForSeconds(0.5f);
			GameObject.Find("RumBVTavla(Clone)").transform.name = "RumBVTavla";
		}
		if ((bool)GameObject.Find("RumBVLampa(Clone)"))
		{
			UnityEngine.Object.Destroy(GameObject.Find("RumBVLampa(Clone)"));
			UnityEngine.Object.Instantiate(LampaRumBV, LampaRumBVPos.position, LampaRumBVPos.rotation);
			yield return new WaitForSeconds(0.5f);
			GameObject.Find("RumBVLampa(Clone)").transform.name = "RumBVLampa";
		}
		if ((bool)GameObject.Find("LjusstakeHall(Clone)"))
		{
			UnityEngine.Object.Destroy(GameObject.Find("LjusstakeHall(Clone)"));
			UnityEngine.Object.Instantiate(LjusstakeHall, LjusstakeHallPos.position, LjusstakeHallPos.rotation);
			yield return new WaitForSeconds(0.5f);
			GameObject.Find("LjusstakeHall(Clone)").transform.name = "LjusstakeHall";
		}
		if ((bool)GameObject.Find("LjusstakeHall2(Clone)"))
		{
			UnityEngine.Object.Destroy(GameObject.Find("LjusstakeHall2(Clone)"));
			UnityEngine.Object.Instantiate(LjusstakeHall2, LjusstakeHallPos2.position, LjusstakeHallPos2.rotation);
			yield return new WaitForSeconds(0.5f);
			GameObject.Find("LjusstakeHall2(Clone)").transform.name = "LjusstakeHall2";
		}
		if ((bool)GameObject.Find("LjusstakeCellar(Clone)"))
		{
			UnityEngine.Object.Destroy(GameObject.Find("LjusstakeCellar(Clone)"));
			UnityEngine.Object.Instantiate(LjusstakeCellar, LjusstakeCellarPos.position, LjusstakeCellarPos.rotation);
			yield return new WaitForSeconds(0.5f);
			GameObject.Find("LjusstakeCellar(Clone)").transform.name = "LjusstakeCellar";
		}
		if ((bool)GameObject.Find("LitenTavla1(Clone)"))
		{
			UnityEngine.Object.Destroy(GameObject.Find("LitenTavla1(Clone)"));
			UnityEngine.Object.Instantiate(LitenTavla1, LitenTavla1Pos.position, LitenTavla1Pos.rotation);
			yield return new WaitForSeconds(0.5f);
			GameObject.Find("LitenTavla1(Clone)").transform.name = "LitenTavla1";
		}
		if ((bool)GameObject.Find("LitenTavla2(Clone)"))
		{
			UnityEngine.Object.Destroy(GameObject.Find("LitenTavla2(Clone)"));
			UnityEngine.Object.Instantiate(LitenTavla2, LitenTavla2Pos.position, LitenTavla2Pos.rotation);
			yield return new WaitForSeconds(0.5f);
			GameObject.Find("LitenTavla2(Clone)").transform.name = "LitenTavla2";
		}
		if ((bool)GameObject.Find("LitenTavla3(Clone)"))
		{
			UnityEngine.Object.Destroy(GameObject.Find("LitenTavla3(Clone)"));
			UnityEngine.Object.Instantiate(LitenTavla3, LitenTavla3Pos.position, LitenTavla3Pos.rotation);
			yield return new WaitForSeconds(0.5f);
			GameObject.Find("LitenTavla3(Clone)").transform.name = "LitenTavla3";
		}
		if ((bool)GameObject.Find("TavlaSR1(Clone)"))
		{
			UnityEngine.Object.Destroy(GameObject.Find("TavlaSR1(Clone)"));
			UnityEngine.Object.Instantiate(TavlaSR1, TavlaSR1Pos.position, TavlaSR1Pos.rotation);
			yield return new WaitForSeconds(0.5f);
			GameObject.Find("TavlaSR1(Clone)").transform.name = "TavlaSR1";
		}
		if ((bool)GameObject.Find("ChairSR1(Clone)"))
		{
			UnityEngine.Object.Destroy(GameObject.Find("ChairSR1(Clone)"));
			UnityEngine.Object.Instantiate(ChairSR1, ChairSR1Pos.position, ChairSR1Pos.rotation);
			yield return new WaitForSeconds(0.5f);
			GameObject.Find("ChairSR1(Clone)").transform.name = "ChairSR1";
		}
		if ((bool)GameObject.Find("Galge(Clone)"))
		{
			UnityEngine.Object.Destroy(GameObject.Find("Galge(Clone)"));
			UnityEngine.Object.Instantiate(Galge, GalgePos.position, GalgePos.rotation);
			yield return new WaitForSeconds(0.5f);
			GameObject.Find("Galge(Clone)").transform.name = "Galge";
		}
		if ((bool)GameObject.Find("LampaSR2(Clone)"))
		{
			UnityEngine.Object.Destroy(GameObject.Find("LampaSR2(Clone)"));
			UnityEngine.Object.Instantiate(LampaSR2, LampaSR2Pos.position, LampaSR2Pos.rotation);
			yield return new WaitForSeconds(0.5f);
			GameObject.Find("LampaSR2(Clone)").transform.name = "LampaSR2";
		}
		if ((bool)GameObject.Find("LitetBordSR3(Clone)"))
		{
			UnityEngine.Object.Destroy(GameObject.Find("LitetBordSR3(Clone)"));
			UnityEngine.Object.Instantiate(LitetBordSR3, LitetBordSR3Pos.position, LitetBordSR3Pos.rotation);
			yield return new WaitForSeconds(0.5f);
			GameObject.Find("LitetBordSR3(Clone)").transform.name = "LitetBordSR3";
		}
		if ((bool)GameObject.Find("TavlaSR3(Clone)"))
		{
			UnityEngine.Object.Destroy(GameObject.Find("TavlaSR3(Clone)"));
			UnityEngine.Object.Instantiate(TavlaSR3, TavlaSR3Pos.position, TavlaSR3Pos.rotation);
			yield return new WaitForSeconds(0.5f);
			GameObject.Find("TavlaSR3(Clone)").transform.name = "TavlaSR3";
		}
		if ((bool)GameObject.Find("TavlaKitchen(Clone)"))
		{
			UnityEngine.Object.Destroy(GameObject.Find("TavlaKitchen(Clone)"));
			UnityEngine.Object.Instantiate(TavlaKitchen, TavlaKitchenPos.position, TavlaKitchenPos.rotation);
			yield return new WaitForSeconds(0.5f);
			GameObject.Find("TavlaKitchen(Clone)").transform.name = "TavlaKitchen";
		}
		if ((bool)GameObject.Find("Tallrik1(Clone)"))
		{
			UnityEngine.Object.Destroy(GameObject.Find("Tallrik1(Clone)"));
			UnityEngine.Object.Instantiate(Tallrik1, Tallrik1Pos.position, Tallrik1Pos.rotation);
			yield return new WaitForSeconds(0.5f);
			GameObject.Find("Tallrik1(Clone)").transform.name = "Tallrik1";
		}
		if ((bool)GameObject.Find("Tallrik2(Clone)"))
		{
			UnityEngine.Object.Destroy(GameObject.Find("Tallrik2(Clone)"));
			UnityEngine.Object.Instantiate(Tallrik2, Tallrik2Pos.position, Tallrik2Pos.rotation);
			yield return new WaitForSeconds(0.5f);
			GameObject.Find("Tallrik2(Clone)").transform.name = "Tallrik2";
		}
		if ((bool)GameObject.Find("Tallrik3(Clone)"))
		{
			UnityEngine.Object.Destroy(GameObject.Find("Tallrik3(Clone)"));
			UnityEngine.Object.Instantiate(Tallrik3, Tallrik3Pos.position, Tallrik3Pos.rotation);
			yield return new WaitForSeconds(0.5f);
			GameObject.Find("Tallrik3(Clone)").transform.name = "Tallrik3";
		}
		if ((bool)GameObject.Find("GallerDoor(Clone)"))
		{
			UnityEngine.Object.Destroy(GameObject.Find("GallerDoor(Clone)"));
			UnityEngine.Object.Instantiate(GallerDoor, GallerDoorPos.position, GallerDoorPos.rotation);
			yield return new WaitForSeconds(0.5f);
			GameObject.Find("GallerDoor(Clone)").transform.name = "GallerDoor";
		}
		if ((bool)GameObject.Find("WoodenBox(Clone)"))
		{
			UnityEngine.Object.Destroy(GameObject.Find("WoodenBox(Clone)"));
			UnityEngine.Object.Instantiate(WoodenBox, WoodenBoxPos.position, WoodenBoxPos.rotation);
			yield return new WaitForSeconds(0.5f);
			GameObject.Find("WoodenBox(Clone)").transform.name = "WoodenBox";
		}
		if ((bool)GameObject.Find("Pedistal(Clone)"))
		{
			UnityEngine.Object.Destroy(GameObject.Find("Pedistal(Clone)"));
			UnityEngine.Object.Instantiate(Pedistal, PedistalPos.position, PedistalPos.rotation);
			yield return new WaitForSeconds(0.5f);
			GameObject.Find("Pedistal(Clone)").transform.name = "Pedistal";
		}
		if ((bool)GameObject.Find("ManikinDoll(Clone)"))
		{
			UnityEngine.Object.Destroy(GameObject.Find("ManikinDoll(Clone)"));
			UnityEngine.Object.Instantiate(Manikin, ManikinPos.position, ManikinPos.rotation);
			yield return new WaitForSeconds(0.5f);
			GameObject.Find("ManikinDoll(Clone)").transform.name = "ManikinDoll";
		}
		if ((bool)GameObject.Find("MetalCanOuthouse(Clone)"))
		{
			UnityEngine.Object.Destroy(GameObject.Find("MetalCanOuthouse(Clone)"));
			UnityEngine.Object.Instantiate(BurkOH, BurkOHPos.position, BurkOHPos.rotation);
			yield return new WaitForSeconds(0.5f);
			GameObject.Find("MetalCanOuthouse(Clone)").transform.name = "MetalCanOuthouse";
		}
	}
}

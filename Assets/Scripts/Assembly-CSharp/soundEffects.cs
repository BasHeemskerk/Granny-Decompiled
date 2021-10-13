using System;
using UnityEngine;

[Serializable]
public class soundEffects : MonoBehaviour
{
	public AudioClip pickUpStuff;

	public AudioClip PCaught;

	public AudioClip exitDoorOpen;

	public AudioClip playerHit;

	public AudioClip hukaSig;

	public AudioClip stand;

	public AudioClip bedNer;

	public AudioClip bedUpp;

	public AudioClip manakin;

	public AudioClip crossbowShoot;

	public AudioClip crossbowLoad;

	public AudioClip inCoffin;

	public AudioClip OutCoffin;

	public AudioClip landSound;

	public AudioClip landBRSound;

	public AudioClip fallFloor;

	public AudioClip placeTavelbit;

	public AudioClip gunShot;

	public AudioClip inCar;

	public AudioClip outCar;

	public AudioClip shotgunLoad;

	public AudioClip shotgunEmpty;

	public AudioClip pickUpLoaded;

	public virtual void Start()
	{
	}

	public virtual void pickingUpStuff()
	{
		GetComponent<AudioSource>().PlayOneShot(pickUpStuff);
	}

	public virtual void playerCaught()
	{
		GetComponent<AudioSource>().PlayOneShot(PCaught);
	}

	public virtual void openExitDoor()
	{
		GetComponent<AudioSource>().PlayOneShot(exitDoorOpen);
	}

	public virtual void playerGetHit()
	{
		GetComponent<AudioSource>().PlayOneShot(playerHit);
	}

	public virtual void hukarSig()
	{
		GetComponent<AudioSource>().PlayOneShot(hukaSig);
	}

	public virtual void standUp()
	{
		GetComponent<AudioSource>().PlayOneShot(stand);
	}

	public virtual void underBed()
	{
		GetComponent<AudioSource>().PlayOneShot(bedNer);
	}

	public virtual void fromBed()
	{
		GetComponent<AudioSource>().PlayOneShot(bedUpp);
	}

	public virtual void manakinLook()
	{
		GetComponent<AudioSource>().PlayOneShot(manakin);
	}

	public virtual void CrossbowShoot()
	{
		GetComponent<AudioSource>().PlayOneShot(crossbowShoot);
	}

	public virtual void CrossbowLoad()
	{
		GetComponent<AudioSource>().PlayOneShot(crossbowLoad);
	}

	public virtual void CoffinIn()
	{
		GetComponent<AudioSource>().PlayOneShot(inCoffin);
	}

	public virtual void CoffinUt()
	{
		GetComponent<AudioSource>().PlayOneShot(OutCoffin);
	}

	public virtual void playerLandSound()
	{
		GetComponent<AudioSource>().PlayOneShot(landSound);
	}

	public virtual void playerLandBRSound()
	{
		GetComponent<AudioSource>().PlayOneShot(landBRSound);
	}

	public virtual void playerFallFloor()
	{
		GetComponent<AudioSource>().PlayOneShot(fallFloor);
	}

	public virtual void tavelbitPlace()
	{
		GetComponent<AudioSource>().PlayOneShot(placeTavelbit);
	}

	public virtual void GunShoot()
	{
		GetComponent<AudioSource>().PlayOneShot(gunShot);
	}

	public virtual void CarIn()
	{
		GetComponent<AudioSource>().PlayOneShot(inCar);
	}

	public virtual void CarOut()
	{
		GetComponent<AudioSource>().PlayOneShot(outCar);
	}

	public virtual void loadShotgun()
	{
		GetComponent<AudioSource>().PlayOneShot(shotgunLoad);
	}

	public virtual void emptyShotgun()
	{
		GetComponent<AudioSource>().PlayOneShot(shotgunEmpty);
	}

	public virtual void loadedPickup()
	{
		GetComponent<AudioSource>().PlayOneShot(pickUpLoaded);
	}
}

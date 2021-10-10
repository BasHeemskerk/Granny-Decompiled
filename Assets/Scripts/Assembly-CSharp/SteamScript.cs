using Steamworks;
using UnityEngine;

public class SteamScript : MonoBehaviour
{
	private void Start()
	{
		if (SteamManager.Initialized)
		{
			string personaName = SteamFriends.GetPersonaName();
			Debug.Log(personaName);
		}
	}
}

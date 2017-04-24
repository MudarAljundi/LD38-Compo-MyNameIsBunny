using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectNewNameGender : MonoBehaviour {

	public string newOrigin = "Syria";
	public string newGender = "Female";
	public string newName = "Sophie al-Kudmani";

	public void SetItToPlayer () {
		GameManager.playerStatsMemory.playerName = newName;
		GameManager.playerStatsMemory.gender = newGender;
		GameManager.playerStatsMemory.currentCountryOfOrigin = newOrigin;
		// we will change the player image in the inspector. Hacks awaaaay!
	}
	
}

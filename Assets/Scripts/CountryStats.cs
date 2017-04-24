using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountryStats : MonoBehaviour {

	public string countryName;
	public float wagePerMoon;
	public float entryCost;

	public Transform countryPlayerLocation;
	public Button unlockButtonOnArriving;

	public void GetSelected () {
		GetComponent<CanvasGroup>().alpha = 1;
		GetComponent<CanvasGroup>().interactable = true;
		GetComponent<CanvasGroup>().blocksRaycasts = true;
	}
	public void MoveToCountry() {

		GameManager.inWorldPlayerSprite.transform.position = countryPlayerLocation.position;
		GameManager.playerStatsMemory.money -= entryCost;
		GameManager.playerStatsMemory.currentCountryLivingIn = countryName;
		GameManager.playerStatsMemory.wagePerMoon = wagePerMoon;
		unlockButtonOnArriving.interactable = true;
	}
	public void Unselect() {
		GetComponent<CanvasGroup>().alpha = 0;
		GetComponent<CanvasGroup>().interactable = false;
		GetComponent<CanvasGroup>().blocksRaycasts = false;
	}

}

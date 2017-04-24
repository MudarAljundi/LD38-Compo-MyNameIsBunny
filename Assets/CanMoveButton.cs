using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanMoveButton : MonoBehaviour {

	public int costNeeded;
	public string thisCountryName;
	public List<string> citizenshipNeeded;

	private Button buttonComp;

	private void Start () {
		buttonComp = GetComponent<Button>();
	}
	private bool CheckCitizenship() {

		if (citizenshipNeeded.Count == 0) {
			return true;
		}

		for (int i = 0; i < citizenshipNeeded.Count; i += 1) {
			if (citizenshipNeeded[i] == GameManager.playerStatsMemory.currentCountryOfOrigin) {
				return true;
			}
		}
		return false;
	}
	private void Update () {

		if (GameManager.playerStatsMemory.currentCountryLivingIn == thisCountryName) {
			buttonComp.interactable = false;
			return;
		}
		if (GameManager.playerStatsMemory.money >= costNeeded && CheckCitizenship() == true) {
			buttonComp.interactable = true;
		} else {
			buttonComp.interactable = false;
		}
	}
	
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountryDisplayer : MonoBehaviour {

	private Text thisTextComponent;
	private string remValue;

	private void Start() {
		thisTextComponent = GetComponent<Text>();
	}

	private void Update() {
		if (remValue != GameManager.playerStatsMemory.currentCountryOfOrigin) {
			remValue = GameManager.playerStatsMemory.currentCountryOfOrigin;

			thisTextComponent.text = remValue;
		}

	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameDisplayer : MonoBehaviour {

	private Text thisTextComponent;
	private string remValue;

	private void Start() {
		thisTextComponent = GetComponent<Text>();
	}

	private void Update() {
		if (remValue != GameManager.playerStatsMemory.playerName) {
			remValue = GameManager.playerStatsMemory.playerName;

			thisTextComponent.text = remValue;
		}

	}
}

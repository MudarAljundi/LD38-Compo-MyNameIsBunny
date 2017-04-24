using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudNumberCounter: MonoBehaviour {
	
	private Text thisTextComponent;
	private float remValue = -1;

	private void Start() {
		thisTextComponent = GetComponent<Text>();
	}

	private void Update () {
		
		if (remValue != GameManager.playerStatsMemory.wagePerMoon) {
			remValue = GameManager.playerStatsMemory.wagePerMoon;

			thisTextComponent.text = "+" + remValue.ToString() + "EQ";
		}

	}
	
}

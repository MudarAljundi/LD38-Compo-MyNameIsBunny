using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyCounter : MonoBehaviour {

	private Text thisTextComponent;
	private float remValue = 0;

	private void Start() {
		thisTextComponent = GetComponent<Text>();
	}

	private void Update () {
		if (remValue != GameManager.playerStatsMemory.money) {
			remValue = GameManager.playerStatsMemory.money;

			thisTextComponent.text = remValue.ToString("F2") + "EQ";
		}

	}
	
}

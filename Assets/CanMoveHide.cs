using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanMoveHide : MonoBehaviour {
	
	public string thisCountryName;
	private Vector2 rememberOriginalPos;

	private bool hidden = false;

	private void Start () {
		rememberOriginalPos = GetComponent<RectTransform>().anchoredPosition;
	}
	private void Update () {
		
		if (hidden == false && GameManager.playerStatsMemory.currentCountryLivingIn == thisCountryName) {
			hidden = true;
			GetComponent<RectTransform>().anchoredPosition = new Vector2(-500000, -500000);
		}
		if (hidden == true && GameManager.playerStatsMemory.currentCountryLivingIn != thisCountryName) {
			hidden = false;
			GetComponent<RectTransform>().anchoredPosition = rememberOriginalPos;
		}
	}
	
}

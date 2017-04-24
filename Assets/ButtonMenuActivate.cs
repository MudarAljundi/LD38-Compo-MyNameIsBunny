using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMenuActivate : MonoBehaviour {

	//private bool none = stuff;

	public void Activate () {
		GetComponent<CanvasGroup>().alpha = 1;
		GetComponent<CanvasGroup>().interactable = true;
		GetComponent<CanvasGroup>().blocksRaycasts = true;
	}
	public void Deactivate() {
		GetComponent<CanvasGroup>().alpha = 0;
		GetComponent<CanvasGroup>().interactable = false;
		GetComponent<CanvasGroup>().blocksRaycasts = false;
	}

}

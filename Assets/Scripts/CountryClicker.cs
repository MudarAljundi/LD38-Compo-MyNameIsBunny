using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountryClicker : MonoBehaviour {

	public List<Transform> countryList;
	public bool canClick = false;

	public void canClickNow() {
		canClick = true;
	}
	private void UnselectAll() {
		for (int i = 0; i < countryList.Count; i += 1) {
			countryList[i].GetComponent<CountryStats>().Unselect();
		}
	}

	private void Update () {

		if (canClick == false) {
			return;
		}

		if (Input.GetMouseButtonUp(0) == true) {
			
			UnselectAll();
			RaycastHit hit;
			Ray clickRay = Camera.main.ScreenPointToRay(Input.mousePosition);
			Physics.Raycast(clickRay, out hit, 30f);

			if (hit.collider) {
				GetComponent<AudioSource>().Play();
				hit.collider.GetComponent<CallTheAssociatedCountryStats>().CallWhenClicked();
			}
		}
	}
	
}

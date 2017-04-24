using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatsMemory: MonoBehaviour {

	public float money = 20;
	public float wagePerMoon = 0;
	public string gender = "Female";
	public string playerName = "Sophie al-Kudmani";
	public string currentCountryOfOrigin = "Syria";
	public string currentCountryLivingIn = "Syria";
	
	public float arabicSyrianProficiency = 100;
	public float arabicAthanProficiency = 35;
	public float femaleProficiency = 50;
	public float maleProficiency = 50;
	public float rramishProficiency = 0;
	public float costumerService = 0;

	private void Update() {

		money += (wagePerMoon * Time.deltaTime) / 13f;

		if (currentCountryLivingIn == "Syria") {
			arabicSyrianProficiency += (10 * Time.deltaTime) / 13f;
			arabicAthanProficiency += (3f * Time.deltaTime) / 13f;
		}

		CapValues();
	}
	private void CapValues() {
		money = Mathf.Clamp(money, 0, 100000);
		
		arabicSyrianProficiency = Mathf.Clamp(arabicSyrianProficiency, 0, 100);
		arabicAthanProficiency = Mathf.Clamp(arabicAthanProficiency, 0, 100);

		femaleProficiency = Mathf.Clamp(femaleProficiency, 0, 100);
		maleProficiency = Mathf.Clamp(maleProficiency, 0, 100);

		rramishProficiency = Mathf.Clamp(rramishProficiency, 0, 100);
		costumerService = Mathf.Clamp(costumerService, 0, 100);

	}


	public void MoveToNewCountry(string newCountry) {
		currentCountryLivingIn = newCountry;
	}
}

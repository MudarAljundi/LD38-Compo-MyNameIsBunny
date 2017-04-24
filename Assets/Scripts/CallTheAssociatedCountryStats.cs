using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallTheAssociatedCountryStats: MonoBehaviour {

	public GameObject countryUIStats;

	public void CallWhenClicked () {
		countryUIStats.GetComponent<CountryStats>().GetSelected();
	}
	
}

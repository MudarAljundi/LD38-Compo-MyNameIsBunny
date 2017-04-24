using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwitterButton : MonoBehaviour {



	public void GoAdditionalCredits () {
		Application.ExternalEval("window.open('https://docs.google.com/document/d/10TMs_ahKOhOt1q0LVfBDMTfIfMUe77iLVGN7gM3_OVI/edit?usp=sharing');");
	}
	public void GoTwitter () {
		Application.ExternalEval("window.open('https://twitter.com/_AlexanderClay');");
	}
	
}

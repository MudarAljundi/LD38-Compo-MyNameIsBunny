using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullscreenButton : MonoBehaviour {

	//private bool none = stuff;

	public void GoFullscreen () {
		Screen.fullScreen = !Screen.fullScreen;
	}
	
}

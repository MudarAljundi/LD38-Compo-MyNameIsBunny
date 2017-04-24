using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillboardLookAtCamera : MonoBehaviour {

	//private bool none = stuff;

	private void LateUpdate () {
		transform.forward = Camera.main.transform.forward;
	}
	
}

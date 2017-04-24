using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterOffset : MonoBehaviour {

	private Renderer myRenderer;
	private float countUp = 0;

	private void Start() {
		myRenderer = GetComponent<Renderer>();
	}
	private void Update () {
		myRenderer.material.mainTextureOffset = new Vector2(0, countUp);

		countUp += Time.deltaTime * 0.25f;
		if (countUp >= 100000) {
			countUp = 0;
		}
	}
	
}

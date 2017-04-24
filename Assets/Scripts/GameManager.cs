using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager: MonoBehaviour {

	public static GameObject playerStats;
	public static PlayerStatsMemory playerStatsMemory;
	public static GameObject inWorldPlayerSprite;
	public static GameObject canvas;

	public void Start() {
		playerStats = GameObject.Find("PlayerStats - Right");
		playerStatsMemory = GameObject.Find("PlayerStats - Right").GetComponent<PlayerStatsMemory>();
		inWorldPlayerSprite = GameObject.Find("PlayerSprite");

		canvas = GameObject.Find("CanvasBackuo");
	}
	private void Update() {
		if (Input.GetKeyDown("h") == true && canvas) {
			canvas.GetComponent<Canvas>().enabled = !canvas.GetComponent<Canvas>().enabled;
		}
	}
}
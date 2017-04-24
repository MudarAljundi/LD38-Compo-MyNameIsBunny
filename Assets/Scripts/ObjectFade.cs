using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectFade : MonoBehaviour {

	public float speedMultiplier = 0.5f;

	private Image image;

	private void Awake () {
		image = GetComponent<Image>();
	}
	public void StartFadeOut() {

		StartCoroutine(FadeOut());
	}
	public IEnumerator FadeOut () {

		for (float i = 1; i >= 0; i -= Time.deltaTime * speedMultiplier) {
			// set color with i as alpha
			image.color = new Color(1, 1, 1, i);
			yield return null;
		}
	}
	public void StartFadeIn() {
		StartCoroutine(FadeIn());
	}
	public IEnumerator FadeIn() {

		for (float i = 0; i <= 1; i += Time.deltaTime * speedMultiplier) {
			// set color with i as alpha
			image.color = new Color(1, 1, 1, i);
			yield return null;
		}
	}

}

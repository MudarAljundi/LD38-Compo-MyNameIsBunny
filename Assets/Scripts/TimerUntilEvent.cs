using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimerUntilEvent : MonoBehaviour {

	public UnityEvent onTimerEnd;
	public float timeCount;

	//public bool startOnStart = true;
	private void Start() {
		StartCoroutine(StartTimer());
	}

	public IEnumerator StartTimer() {

		for (float i = 0; i <= timeCount; i += Time.deltaTime) {

			yield return null;
		}
		onTimerEnd.Invoke();
	}
}

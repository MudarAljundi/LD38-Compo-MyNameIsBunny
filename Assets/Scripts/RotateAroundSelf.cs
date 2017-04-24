using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundSelf : MonoBehaviour {

	public float rotateSpeed = 5;

	private float countup = 0;
	private Transform myTransform;

	private void Start() {
		myTransform = transform;
	}

	private void Update () {
		countup += Time.deltaTime;

		myTransform.Rotate(Vector3.up * Mathf.Cos(countup) * rotateSpeed * Time.deltaTime);
		myTransform.Rotate(Vector3.right * rotateSpeed * Time.deltaTime);

		if (countup >= 100000) {
			countup = 0;
		}
		//myTransform.Rotate(Vector3.right, rotateSpeed * Time.deltaTime);
		//myTransform.Rotate(Vector3.right + (Vector3.up * Mathf.Sin(countup)), rotateSpeed * Time.deltaTime);
	}
	
}

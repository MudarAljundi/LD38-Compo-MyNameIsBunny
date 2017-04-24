using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour {

	/*
	 * Someday, I will learn Quaternions properly
	 */

	public Transform planetTransform;
	public float rotateSpeed = 5f;
	public Vector2 clampCameraPosition;
	private Transform myTransform;

	private void Start () {
		myTransform = transform;
	}

	private void Update() {
		float h = Input.GetAxisRaw("Horizontal");
		float v = Input.GetAxisRaw("Vertical");
		
		if (h != 0) {
			myTransform.RotateAround(planetTransform.position, myTransform.up, Time.deltaTime * -h * rotateSpeed);
		}
		//if (v != 0) {
		//	myTransform.RotateAround(planetTransform.position, Vector3.left, Time.deltaTime * v * rotateSpeed);
		//}
		if (v == 1 && myTransform.position.y < clampCameraPosition.x) {
			myTransform.RotateAround(planetTransform.position, myTransform.right, Time.deltaTime * v * rotateSpeed);
		}
		if (v == -1 && myTransform.position.y > clampCameraPosition.y) {
			myTransform.RotateAround(planetTransform.position, myTransform.right, Time.deltaTime * v * rotateSpeed);
		}
		
	}
	private void LateUpdate () {
		myTransform.LookAt(planetTransform);
	}
}

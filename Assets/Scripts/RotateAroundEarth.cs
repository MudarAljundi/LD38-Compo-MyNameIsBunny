using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundEarth : MonoBehaviour {

	public Transform planetTransform;
	public float rotateSpeed = 5;
	
	private Transform myTransform;

	private void Start() {
		myTransform = transform;
	}

	private void Update () {
		
		myTransform.RotateAround(planetTransform.position, Vector3.up, rotateSpeed * Time.deltaTime);
		
		//myTransform.Rotate(Vector3.right, rotateSpeed * Time.deltaTime);
		//myTransform.Rotate(Vector3.right + (Vector3.up * Mathf.Sin(countup)), rotateSpeed * Time.deltaTime);
	}
	
}

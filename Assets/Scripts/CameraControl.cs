using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	public GameObject car;
	
	private Vector3 offset;

	// Use this for initialization
	void Start () {

		offset = transform.position - car.transform.position;
	
	}
	
	// Update is called once per frame
	void LateUpdate () {
	
		transform.position = car.transform.position + offset;
	}
}

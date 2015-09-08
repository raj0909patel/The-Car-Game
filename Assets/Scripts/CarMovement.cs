using UnityEngine;
using System.Collections;

public class CarMovement : MonoBehaviour {

	public float speed;
	public float rotate;

	private bool start = false;
	//private bool keydown = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	


		if (Input.GetButtonDown("Fire1"))
			start = true;
		if (start) {
			transform.Translate (new Vector3 (0.0f, 0.0f, -0.25f));
		}

			float moveX = Input.GetAxis ("Horizontal") * rotate;
			transform.Rotate(new Vector3 (0.0f, 1f, 0.0f),moveX);

		transform.localEulerAngles = new Vector3(transform.localEulerAngles.x,Mathf.Clamp(transform.localEulerAngles.y,145,215), transform.localEulerAngles.z);
		}
}

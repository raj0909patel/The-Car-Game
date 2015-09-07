using UnityEngine;
using System.Collections;

public class CarMovement : MonoBehaviour {

	public int speed;
	public int rotate;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		float moveX = Input.GetAxis ("Horizontal");
		float moveY = Input.GetAxis ("Vertical");

		transform.Translate(new Vector3 (0.0f, 0.0f, -moveY * speed));
		transform.Rotate(new Vector3 (0.0f, 1f, 0.0f), moveX * rotate);
		//transform.rotation = transform.rotation + Quaternion.AngleAxis(moveX * speed, new Vector3(0.0f, 1f , 0.0f));
		//transform.position = transform.position + (new Vector3 (0.0f, 0.0f, moveY));
		//transform.localPosition = transform.position + (new Vector3 (0.0f, 0.0f, moveY));

	}
}

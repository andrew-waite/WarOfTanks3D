using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour {

	public float speed = 10.0F;
	public float rotationSpeed = 100.0F;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float translation = Input.GetAxis ("Vertical") * speed;
		float rotation = Input.GetAxis ("Horizontal") * this.rotationSpeed;

		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;

		if (Input.GetKeyUp (KeyCode.R)) {
			transform.rotation = Quaternion.identity;
		}

		transform.Translate (0, 0, translation);
		transform.Rotate (0, rotation, 0);
	}
}

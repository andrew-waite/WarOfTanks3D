using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretRotation : MonoBehaviour {

	private float zRotation = 0.0F;
	private float yRotation = 90.0F;
	private Transform transformation;

	// Use this for initialization
	void Start () {
		this.transformation = this.gameObject.GetComponent<Transform> ();
		this.zRotation = this.transformation.rotation.z;
		this.yRotation = this.transformation.rotation.y;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.G)) {
			if (zRotation > -180)
				this.gameObject.GetComponent<Transform> ().Rotate (new Vector3 (0, 0, this.zRotation -= 2));
			else {
			}
		} else if (Input.GetKeyUp (KeyCode.B)) {
			if (zRotation < 0)
				this.gameObject.GetComponent<Transform> ().Rotate (new Vector3 (0, 0, this.zRotation += 2));
			else {
			}	
		} else if (Input.GetKeyUp (KeyCode.F)) {
			this.gameObject.GetComponent<Transform> ().Rotate (new Vector3 (0, yRotation -= 2, 0));
		} else if (Input.GetKeyUp (KeyCode.H)) {
			this.gameObject.GetComponent<Transform> ().Rotate (new Vector3 (0, yRotation += 2, 0));
		}

		this.zRotation = this.transformation.rotation.z;
		this.yRotation = this.transformation.rotation.y;
	}
}

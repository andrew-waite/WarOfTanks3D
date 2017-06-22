using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileFlight : MonoBehaviour {

	public GameObject turretTransform;
	private GameObject cannonball;
	// Use this for initialization
	void Start () {
		this.cannonball = Resources.Load ("Sphere") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.T)) {
			//GameObject ball = Instantiate (cannonball) as GameObject;
			//ball.transform.Rotate(new Vector3(0,90,0));
			//ball.transform.position = turretTransform.transform.position;
			//ball.GetComponent<Rigidbody> ().velocity = (turretTransform.transform.rotation * Vector3.forward) * 20;


			GameObject ball = Instantiate (cannonball, this.turretTransform.transform.position, this.turretTransform.transform.rotation) as GameObject;
			ball.GetComponent<Rigidbody> ().AddForce (1000 * -this.turretTransform.transform.right);
			Destroy (ball, 2);
		}
	}
}

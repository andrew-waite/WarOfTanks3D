using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootProjectile : MonoBehaviour {

	public GameObject turretTransform;
	public int force = 1000;
	public int forceAdjustment = 20;
	private GameObject cannonball;

	public delegate void SetText (string name);
	public static event SetText onSetText;
	// Use this for initialization

	void Start () {
		this.cannonball = Resources.Load ("LowPolySphere") as GameObject;
	}
	
	// Update is called once per frame
	public void Update () {
		if (Input.GetKeyUp (KeyCode.T)) {
			//GameObject ball = Instantiate (cannonball) as GameObject;
			//ball.transform.Rotate(new Vector3(0,90,0));
			//ball.transform.position = turretTransform.transform.position;
			//ball.GetComponent<Rigidbody> ().velocity = (turretTransform.transform.rotation * Vector3.forward) * 20;


			GameObject ball = Instantiate (cannonball, this.turretTransform.transform.position, this.turretTransform.transform.rotation) as GameObject;
			ball.GetComponent<Rigidbody> ().AddForce (this.force * -this.turretTransform.transform.right);
			Destroy (ball, 10);
		}

		if (Input.GetKeyUp (KeyCode.O)) {
			this.force -= this.forceAdjustment;
			if (onSetText != null) {
				onSetText ("Force: " + this.force.ToString ());

			}
		}

		if (Input.GetKeyUp (KeyCode.P)) {
			this.force += this.forceAdjustment;
			if (onSetText != null) {
				onSetText ("Force: " + this.force.ToString ());
		
			}
		}
	}
}

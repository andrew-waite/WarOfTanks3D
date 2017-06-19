using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

	public float jumpForce = 7.0F;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKeyDown (KeyCode.Space)){
			this.gameObject.GetComponent<Rigidbody> ().AddForce (new Vector3 (0, jumpForce, 0), ForceMode.Impulse);
			//this.gameObject.GetComponent<Rigidbody>().AddForce(playerTransform.up * jumpForce);
		}
	}
}

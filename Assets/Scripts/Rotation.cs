using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

	public Vector3 speed;

	public GameObject text;

	private string something = "Something";

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.Rotate (speed * Time.deltaTime);
		this.text.GetComponent<TextMesh> ().text = this.something;
	}
}

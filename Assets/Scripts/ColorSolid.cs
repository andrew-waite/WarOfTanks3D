using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ColorSolid : MonoBehaviour {

	public Color objectColor;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//this.gameObject.GetComponent<Renderer> ().material.color = objectColor;

		Material tempMaterial = new Material (this.gameObject.GetComponent<Renderer> ().sharedMaterial);
		tempMaterial.color = objectColor;

		this.gameObject.GetComponent<Renderer> ().sharedMaterial = tempMaterial;
			
		
	}
}

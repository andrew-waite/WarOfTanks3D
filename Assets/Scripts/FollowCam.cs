using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour {

	public Vector3 myPos;
	public Transform player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//transform.position = player.position + myPos;
		//transform.rotation = this.player.rotation;


		transform.LookAt (player);
	}
}

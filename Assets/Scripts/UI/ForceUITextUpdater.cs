using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForceUITextUpdater : MonoBehaviour {

	public Text text;

	public void OnEnable()
	{
		ShootProjectile.onSetText += setText;
		text = GetComponent<Text> ();
	}

	public void OnDisable()
	{
		ShootProjectile.onSetText -= setText;
	}

	public void setText(string name)
	{
		this.text.text = name;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentWeaponUITextUpdater : MonoBehaviour 
{

	public Text text;

	public void OnEnable()
	{
		text = GetComponent<Text> ();
		//Use += to subscribe to event
	}

	public void OnDisable()
	{
		//Use -= to unsubscribe from event
	}

	public void setText(string name)
	{
		this.text.text = name;
	}
}

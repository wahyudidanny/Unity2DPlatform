using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchs : MonoBehaviour {
	[SerializeField]
	GameObject SwitchOn;

	[SerializeField]
	GameObject SwitchOff;

	public bool isOn = false;


	void Start()
	{
		gameObject.GetComponent<SpriteRenderer> ().sprite = SwitchOff.GetComponent<SpriteRenderer> ().sprite;
	}


	void OnTriggerEnter2D(Collider2D col)
	{
		gameObject.GetComponent<SpriteRenderer> ().sprite = SwitchOn.GetComponent<SpriteRenderer> ().sprite;
		isOn = true;
	}



}

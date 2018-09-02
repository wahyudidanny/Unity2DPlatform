using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckChest : MonoBehaviour {

	private Rigidbody2D myrigidBody;
	private Animator myanimator;
	private Animation myanimation;
	private bool checktest;

	void Start () {
		//myrigidBody = GetComponent<Rigidbody2D> ();
		myanimator = GetComponent<Animator> ();
		myanimation = GetComponent<Animation> ();
		myanimator.SetBool ("checktest",false);

	}
	
	// Update is called once per frame
	void Update () {
		HandledInput();
	}


	private void test(){
		if (checktest) {
			myanimator.SetBool ("checktest",true);
		}
		myanimator.ResetTrigger ("checkChest");
	}

	private void HandledInput(){
		if (Input.GetKeyDown (KeyCode.E)) {
			myanimator.SetTrigger("checkChest");

			myanimator.SetBool ("ChestOpen",true);

		}

	}


}

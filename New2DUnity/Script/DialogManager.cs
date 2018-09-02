using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour {


	public GameObject dBoxs;
	public Text dText;
	public bool dialogActive;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (dialogActive && Input.GetKeyDown(KeyCode.E))
		{
			dBoxs.SetActive(false);
			dialogActive = false;
		}
	}

	public void ShowBox(string dialogue){
		dialogActive = true;
		dBoxs.SetActive (true);
		dText.text = dialogue;
	}

}

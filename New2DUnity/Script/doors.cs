using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class doors : MonoBehaviour {

	public string dialogue;
	private DialogManager dman;
	public static int keycount;
	public GameObject player; //1.pertama declare terlebih dahulu gameObject
	public DialogTrigger test;

	void Start(){
		test = GetComponent<DialogTrigger>();
		dman = FindObjectOfType<DialogManager> ();
	}


	void OnTriggerStay2D(Collider2D col){
		if (col.gameObject.name == "Player") {
			if (Input.GetKeyUp(KeyCode.E)) 
			{
				//Debug.Log (dialogue);	
				dman.ShowBox(dialogue);
			}

		}	
	}



	void OnTriggerEnter2D(Collider2D col)
	{
		player = GameObject.Find ("Player"); //2.Cari dengan nama Player
		Player playerScript = player.GetComponent<Player> (); // 3. access semua script didalamnya

		if (player.name == "Player" && playerScript.Keys == true) 
		{
		    Destroy (gameObject);
		}
	}

	/*

	void Update () {
		HandledInput();
	}


	private void HandledInput(){
		if (Input.GetKeyDown (KeyCode.E)) {
			dman.ShowBox (dialogue);
		}

	}
*/


}

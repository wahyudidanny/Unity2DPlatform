using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keys : MonoBehaviour {

	public static int keycount;
	private Rigidbody2D myrigidBody;
	public GameObject player;


	void OnTriggerEnter2D(Collider2D col){
		player = GameObject.Find ("Player");
		Player playerScript = player.GetComponent<Player> ();

		if (player.name == "Player") 
		{
			playerScript.Keys = true;
			Destroy (gameObject);

		}

	}

}

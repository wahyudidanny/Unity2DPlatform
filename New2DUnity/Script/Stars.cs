using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stars : MonoBehaviour {

	public static int StarsCount;
	private Rigidbody2D myrigidBody;
	public GameObject player;
	public StarsScore stars;
	public string value;

	void Start(){
		stars = FindObjectOfType<StarsScore> ();
	}


	void OnTriggerEnter2D(Collider2D col){
		player = GameObject.Find ("Player");
		Player playerScript = player.GetComponent<Player> ();

		if (player.name == "Player") 
		{
			playerScript.Stars += 1;
			//StarCount.countstars += 1;
			stars.TambahBintang (1);
			Destroy (gameObject);
		}

	}




}

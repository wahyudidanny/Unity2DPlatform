using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // import semua attribute scene

public class SpikeTrigger : MonoBehaviour {

	private Rigidbody2D rigidbody;

	[SerializeField]
	private float speed;


	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody2D> ();

	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.name.Equals ("Player")) {
			rigidbody.isKinematic = false;

		}	
	}

	/*private void SpikeSpeed(float down){
		rigidbody.velocity = new Vector2(down * speed, rigidbody.velocity.y); // Vector2.left; //x - 1, y 0 jalan kekiri
		myanimator.SetFloat ("Speed", Mathf.Abs(down));
		//setelah jalan set animation nya 
		//myanimator.set //SetFloat("Speed", Mathf.Abs(down));

	}
*/
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.name.Equals ("Player")) {

			Scene scene; 
			scene = SceneManager.GetActiveScene ();
			SceneManager.LoadScene (scene.name);
			//Debug.Log ("You dead");
			Debug.Log (scene.name);
		}	
	}


	// Update is called once per frame
	//void Update () {
		
	//}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private Rigidbody2D myrigidBody;
	private Animator myanimator;
	private bool jump;

	[SerializeField]
	private float jumpForce;

	[SerializeField]
	public bool Keys;

	[SerializeField]
	public int Stars;

	[SerializeField]
	private Transform[] groundpoints;

	[SerializeField]
	private float groundRadius;

	private bool isGrounded;


	[SerializeField]
	private LayerMask whatisGround;

	[SerializeField]
	private float speed;

	[SerializeField]
	private bool facingRight;


	void Update(){

		HandleInput ();

	}

	// Use this for initialization
	void Start () {
		facingRight = true;
		myrigidBody = GetComponent<Rigidbody2D> ();
		myanimator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float horizontal = Input.GetAxis ("Horizontal"); // untuk mengecek pergi ke edit >> project setting >>Input Manager
		isGrounded= IsGrounded();
		HandleMovement (horizontal);
		Flip(horizontal);
		HandleLayers ();
		resetValues();
	}

	private void resetValues(){

		jump = false;
	}


	private void HandleMovement(float horizontal){
	
		myrigidBody.velocity = new Vector2(horizontal * speed, myrigidBody.velocity.y); // Vector2.left; //x - 1, y 0 jalan kekiri

		//setelah jalan set animation nya 
		myanimator.SetFloat ("Speed", Mathf.Abs(horizontal));

		if (myrigidBody.velocity.y < 0) {
		
			myanimator.SetBool ("Landing", true);
		}

		if (isGrounded && jump) {
			isGrounded = false;
			myrigidBody.AddForce (new Vector2 (0, jumpForce));
			myanimator.SetTrigger ("Jump");
			//Debug.Log (isGrounded);
			//Debug.Log(jump);
			//Debug.Log(jumpForce);
		}

	}



	private void HandleInput(){
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			jump = true;
		}

	}

	private void Flip(float horizontal){ // untuk flip kiri atau kanan
	
		if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight) {

			facingRight = !facingRight;
			Vector3 theScale = transform.localScale;
			theScale.x *= -1;
			transform.localScale = theScale;
		}
	
	}


	private bool IsGrounded(){
		if (myrigidBody.velocity.y <= 0) {
		
			foreach (Transform point in groundpoints) {
				Collider2D[] colliders = Physics2D.OverlapCircleAll (point.position, groundRadius, whatisGround);

				for (int i = 0; i < colliders.Length; i++) {
					if (colliders[i].gameObject != gameObject ) {

						myanimator.ResetTrigger ("Jump");
						myanimator.SetBool ("Landing",false);
						return true;
					}
				}

			}
		
		}
		return false;
	}


	private void HandleLayers(){
	
		if (!isGrounded) {
			myanimator.SetLayerWeight (1, 1);
		} else {
			myanimator.SetLayerWeight (1, 0);
		
		}
			
	}




}

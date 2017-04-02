using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PController : MonoBehaviour {

	public float maxSpeed = 10f;

	public float delay = 0.8f;

	public static bool onFloor = false;

	private Rigidbody2D myRigidbody2D;
	private BoxCollider2D myBoxCollider2D;

	bool canJump = true;
	bool grounded = false;
	public Transform groundCheck;
	float groundRadius = 0.2f;
	public LayerMask whatIsGround;
	public float jumpForce = 700f;

	Animator myAnimator;

	// Use this for initialization
	void Start () {
		myRigidbody2D = GetComponent<Rigidbody2D> ();
		myBoxCollider2D = GetComponent<BoxCollider2D> ();
		myAnimator = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);

		float move = Input.GetAxis ("Horizontal1");

		myAnimator.SetFloat ("Speed", Mathf.Abs (move));

		myRigidbody2D.velocity = new Vector2 (move * maxSpeed, myRigidbody2D.velocity.y);


	}

	void Update ()
	{

		float jump = Input.GetAxis ("Jump1");
		if (grounded && jump > 0f && canJump) 
		{
			myAnimator.SetBool ("isJumping", true);
			myRigidbody2D.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
			StartCoroutine ("resetJump");
		}

		//float down = Input.GetAxis ("Vertical1");
		//if(down <= -1f && !onFloor)
		//{
		//	StartCoroutine("Fall");	
		//}
			
	}

	void LateUpdate() {
		if (this.gameObject.transform.position.y < -10) {
				this.gameObject.transform.position = new Vector3 (this.gameObject.transform.position.x,
					7, this.gameObject.transform.position.z);
		}
	}

	private IEnumerator Fall()
	{
		myBoxCollider2D.isTrigger = true;
		yield return new WaitForSeconds(0.5f);
		myBoxCollider2D.isTrigger = false;

	}

	private IEnumerator resetJump()
	{
		canJump = false;
		while (!canJump) 
		{
			yield return new WaitForSeconds (delay);
			if (grounded) {
				canJump = true;
				myAnimator.SetBool ("isJumping", false);
			}
		}
	}
}

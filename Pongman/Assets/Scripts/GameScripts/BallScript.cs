using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

	private Rigidbody2D myRigidBody;

	public float reflectSpeed = 5f;

	void Awake(){
		Physics2D.IgnoreLayerCollision (9, 10);
	}
	// Use this for initialization
	void Start () {
		myRigidBody = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D coll){
		myRigidBody.AddForce (myRigidBody.velocity.normalized * reflectSpeed * Time.deltaTime);

	}
}

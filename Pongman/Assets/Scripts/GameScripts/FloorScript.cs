using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}						

	void OnCollisionEnter2D( Collision2D coll) {
		//print ("wtf");
		if (coll.gameObject.tag == "Player1") {
			PController.onFloor = true;
		} else if (coll.gameObject.tag == "Player2") {
			OtherPController.onFloor = true;
		}
	}

	void OnCollisionStay2D( Collision2D coll) {
		if (coll.gameObject.tag == "Player1") {
			PController.onFloor = true;
		} else if (coll.gameObject.tag == "Player2") {
			OtherPController.onFloor = true;
		}
	}

	void OnCollisionExit2D( Collision2D coll) {
		if (coll.gameObject.tag == "Player1") {
			PController.onFloor = false;
		} else if (coll.gameObject.tag == "Player2") {
			OtherPController.onFloor = false;
		}
	}
}

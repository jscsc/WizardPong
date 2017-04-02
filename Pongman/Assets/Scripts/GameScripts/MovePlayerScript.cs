using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Player") {
			other.gameObject.transform.position = new Vector3 (other.gameObject.transform.position.x,
				7, other.gameObject.transform.position.z);
		}// else if (other.gameObject.tag == "Player2") {
			//other.gameObject.transform.position = new Vector3 (other.gameObject.transform.position.x,
			//	200, other.gameObject.transform.position.z);
		//}
	}


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other) {

		print (other.gameObject.tag);
		if (this.gameObject.tag == "Player1Goal" && other.gameObject.tag == "Ball") {
			ScoreManager.playerTwoScore++;
			TurnManager.playerOneCanShoot = true;
			TurnManager.playerTwoCanShoot = false;
		} else if (this.gameObject.tag == "Player2Goal"  && other.gameObject.tag == "Ball") {
			ScoreManager.playerOneScore++;
			TurnManager.playerOneCanShoot = false;
			TurnManager.playerTwoCanShoot = true;
		}

		if (other.gameObject.tag == "Ball")
			Destroy (other.gameObject);
	}
}

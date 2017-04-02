using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnManager : MonoBehaviour {

	public static bool playerOneCanShoot;
	public static bool playerTwoCanShoot;

	public Text playerOneTurnText;
	public Text playerTwoTurnText;

	void Awake() {
		playerOneCanShoot = false;
		playerTwoCanShoot = false;
	}

	// Use this for initialization
	void Start () {
		int turn = Random.Range (1, 3);
		//print (turn);
		if (turn == 1) {
			playerOneCanShoot = true;
			playerTwoCanShoot = false;
		} else {
			playerTwoCanShoot = true;
			playerOneCanShoot = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (playerOneCanShoot) {
			playerOneTurnText.text = "You have the shot";
			playerTwoTurnText.text = "";
		} else if (playerTwoCanShoot) {
			playerOneTurnText.text = "";
			playerTwoTurnText.text = "You have the shot";
		} else {
			playerOneTurnText.text = "";
			playerTwoTurnText.text = "";
		}
	}
}

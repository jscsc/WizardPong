using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public static int playerOneScore;

	public static int playerTwoScore;

	public Text playerOneText;
	public Text playerTwoText;

	// Use this for initialization
	void Start () {
		playerOneScore = 0;
		playerTwoScore = 0;
		print (playerOneScore.ToString ());
		playerOneText.text = playerOneScore.ToString();
		playerTwoText.text = playerTwoScore.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		playerOneText.text = playerOneScore.ToString();
		playerTwoText.text = playerTwoScore.ToString();
	}
}

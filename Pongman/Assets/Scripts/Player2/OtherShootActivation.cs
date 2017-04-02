using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherShootActivation : MonoBehaviour {

	public GameObject Pongball;

	// Use this for initialization
	void Start () {
		Pongball.gameObject.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
		float pongball = Input.GetAxis ("Fire1-2");
		if (pongball > 0f) {
			Pongball.gameObject.SetActive (true);
		} else {
			Pongball.gameObject.SetActive (false);
		}
	}
}

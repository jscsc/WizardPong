using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBarrierActivate : MonoBehaviour {

	public GameObject Barrier;

	Animator myAnimator;

	// Use this for initialization
	void Start () {
		myAnimator = GetComponent<Animator> ();
		Barrier.gameObject.SetActive (false);
	}	
	// Update is called once per frame
	void Update () {
		float barrier = Input.GetAxis ("Fire3-2");
		if (barrier > 0f) {
			Barrier.gameObject.SetActive (true);
			myAnimator.SetFloat ("Blocking", barrier);
		} else {
			Barrier.gameObject.SetActive (false);
			myAnimator.SetFloat ("Blocking", barrier);
		}
	}
}

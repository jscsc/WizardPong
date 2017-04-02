using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherPlatformSticker : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D (Collision2D coll){
		coll.gameObject.transform.parent = this.gameObject.transform;
	}

	void OnCollisionExit2D (Collision2D coll){
		coll.gameObject.transform.parent = null;
	}
}
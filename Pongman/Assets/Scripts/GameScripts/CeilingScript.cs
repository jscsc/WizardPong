using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CeilingScript : MonoBehaviour {

	void Awake(){
		Physics2D.IgnoreLayerCollision (8, 11);
		Physics2D.IgnoreLayerCollision (13, 12);
		Physics2D.IgnoreLayerCollision (13, 9);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

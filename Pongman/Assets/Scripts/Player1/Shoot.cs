﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	public GameObject projectile;

	public Animator myAnimator;

	// Use this for initialization
	void Start () {
		//myAnimator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		float shoot = Input.GetAxis ("Fire1-1");
		if(shoot > 0f && TurnManager.playerOneCanShoot && GameObject.Find("Ball") == null) {
			TurnManager.playerOneCanShoot = false;
			GameObject pongBall = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
			pongBall.GetComponent<Rigidbody2D>().AddForce(new Vector2(20.0f, 0f));
		}
		myAnimator.SetFloat ("Shooting", shoot);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherPlatformMovement : MonoBehaviour {

	public float speed = 5f;

	void Start ()
	{

	}

	private Vector2 MovingDirection = Vector3.up;

	void Update ()
	{
		gameObject.transform.Translate (MovingDirection * speed * Time.smoothDeltaTime);

		if (gameObject.transform.position.y > 5) {
			MovingDirection = Vector2.down;
		} else if (gameObject.transform.position.y < -5) {
			MovingDirection = Vector2.up;
		}
	}



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleWidthCamera : MonoBehaviour {

	public int targetWidth = 460;

	public int pixelToUnits = 100;

	private Camera gameplayCamera;

	// Use this for initialization
	void Start () {
		gameplayCamera = GetComponent<Camera> ();
	}
	
	// Update is called once per frame
	void Update () {
		int height = Mathf.RoundToInt (targetWidth / (float)Screen.width * Screen.height);
		gameplayCamera.orthographicSize = height / pixelToUnits / 2;
	}
}

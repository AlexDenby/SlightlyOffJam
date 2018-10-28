using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldInPosition : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;
	public float mouseMoveThreshold = 1.0f;
	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(player.transform.position.x + offset.x, transform.position.y, player.transform.position.z + offset.z);	
		float horizDelta = Input.GetAxis("Mouse X");

		if (Input.GetKey(KeyCode.LeftArrow)) {
			transform.RotateAround(player.transform.position, Vector3.up, -2);
			offset = transform.position - player.transform.position;
		} else if (Input.GetKey(KeyCode.RightArrow)) {
			transform.RotateAround(player.transform.position, Vector3.up, 2);
			offset = transform.position - player.transform.position;
		}
		/*if (Math.Abs(horizDelta) > mouseMoveThreshold) {
		  transform.RotateAround(player.transform.position, Vector3.up, 10 * Math.Sign(horizDelta));
			offset = transform.position - player.transform.position;
		}*/
		/*if (Input.GetKey(KeyCode.LeftBracket)) {
			transform.RotateAround(player.transform.position, Vector3.up, -2);
			offset = transform.position - player.transform.position;
		} else if (Input.GetKey(KeyCode.RightBracket)) {
			transform.RotateAround(player.transform.position, Vector3.up, 2);
			offset = transform.position - player.transform.position;
		}*/

	}
}

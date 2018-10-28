using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;
	public GameObject camTarget;
	private Rigidbody body;
	private Vector3 offset;
	private Vector3 slightlyOffset;
	private int whoaThere = 1;

	public float camSpeed = 15000000.0f;

	public float zoomSpeed = 0.01f;

	public float rotationSpeed = 1.5f;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
		body = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void FixedUpdate () {
		//transform.position = new Vector3(player.transform.position.x + offset.x, 5, player.transform.position.z + offset.z);
		body.AddForce((camTarget.transform.position - transform.position) * camSpeed * Vector3.Distance(transform.position, camTarget.transform.position));
		transform.rotation = Quaternion.LookRotation(player.transform.position - transform.position);
		/*if (Input.GetKey(KeyCode.LeftBracket)) {
			transform.RotateAround(player.transform.position, Vector3.up, -rotationSpeed);
		} else if (Input.GetKey(KeyCode.RightBracket)) {
			transform.RotateAround(player.transform.position, Vector3.up, rotationSpeed);
		}*/
		//offset.z *= (float)Math.Sin(player.transform.rotation.y);
		//offset.x *= (float)Math.Cos(player.transform.rotation.y);
		/*float xOff = 0;
		float yOff = 0;
		float zOff = 0;
		if (whoaThere == 60) {
			xOff = Random.value;
			yOff = Random.value;
			zOff = Random.value;
			whoaThere = 0;
		}
		Vector3 slightlyOffset = new Vector3(xOff,yOff,zOff);*/
//		transform.position = player.transform.position + offset;
		/*whoaThere++;
		transform.position = player.transform.position + offset;
		if (zoomSpeed > 0) {
			transform.position = Vector3.MoveTowards(transform.position,
					player.transform.position, zoomSpeed);
		} else {
			transform.position = Vector3.MoveTowards(transform.position,
					transform.position + offset, -zoomSpeed);
		}
		offset = transform.position - player.transform.position;*/

		//offset *= (1 - zoomSpeed);

		// rotate around the player in a circle
		//transform.RotateAround(player.transform.position, Vector3.up, rotationSpeed);
		//transform.LookAt(player.transform.position);

		// make sure this is after offset is calculated
		//transform.position += slightlyOffset;
	}

	
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMover : MonoBehaviour {

	public float speed;

	private Rigidbody rb;

	private GameObject camera;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		camera = GameObject.Find("Main Camera");
	}


	void FixedUpdate() {
		float moveHorizontal;
	   	if (Input.GetKey(KeyCode.A)) {
			moveHorizontal = -1.0f;
		} else if (Input.GetKey(KeyCode.D)) {
			moveHorizontal = 1.0f;
		} else {
			moveHorizontal = 0.0f;
		}

		float moveVertical;
		if (Input.GetKey(KeyCode.W)) {
			moveVertical = 1.0f;
		} else if (Input.GetKey(KeyCode.S)) {
			moveVertical = -1.0f;
		} else {
			moveVertical = 0.0f;
		}

		//Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		
		Transform camTransform = camera.transform;

		Vector3 moveDirection = new Vector3();
		moveDirection += camera.transform.right * moveHorizontal;
		moveDirection += camera.transform.forward * moveVertical;
		moveDirection.y = 0;

		/*if(moveDirection != Vector3.zero)
			transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(moveDirection), speed);*/

		rb.AddForce (moveDirection.normalized*speed);

	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Trigger")) {
			other.gameObject.SetActive (false);
		}
	}
}

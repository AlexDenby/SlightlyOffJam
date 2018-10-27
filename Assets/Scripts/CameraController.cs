using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;
	private Vector3 slightlyOffset;
	private int whoaThere = 1;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}

	// Update is called once per frame
	void LateUpdate () {
		float xOff = Random.value;
		float yOff = Random.value;
		float zOff = Random.value;
		Vector3 slightlyOffset = new Vector3(xOff/10,yOff/10,zOff/10);
		transform.position = player.transform.position + offset + slightlyOffset;		
	}
}

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
		float xOff = 0;
		float yOff = 0;
		float zOff = 0;
		if (whoaThere == 60) {
			xOff = Random.value;
			yOff = Random.value;
			zOff = Random.value;
			whoaThere = 0;
		}
		Vector3 slightlyOffset = new Vector3(xOff,yOff,zOff);
		whoaThere++;

		transform.position = player.transform.position + offset;
		transform.position = Vector3.MoveTowards(transform.position,
				player.transform.position, 0.01f) + slightlyOffset;
		offset = transform.position - player.transform.position - slightlyOffset;
	}
}

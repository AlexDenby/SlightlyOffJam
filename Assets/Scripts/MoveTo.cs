using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MoveTo : MonoBehaviour {

	public int flagNum_start = EventFlagSystem.NUM_FLAGS - 1;
	public int flagNum_end = EventFlagSystem.NUM_FLAGS - 1;

	public float moveSpeed = 5.0f;

	public GameObject target;

	private EventFlagSystem efs;

	private enum State {
		waiting,
		moving,
		done
	}

	private State currState;

	void Start() {
		efs = GameObject.Find("EventFlagSystem").GetComponent<EventFlagSystem>();
	}

	void Update() {
		if (currState == State.moving) {
			transform.position = Vector3.MoveTowards(transform.position, target.transform.position, moveSpeed * Time.deltaTime);

			if (Vector3.Distance(transform.position, target.transform.position) < 0.00001f) {
				efs.SetFlag(flagNum_end);
				currState = State.done;
			}
		}
	}
	
	public void BeginMovement() {
		currState = State.moving;
	}
}

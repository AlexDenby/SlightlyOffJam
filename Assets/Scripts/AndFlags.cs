using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndFlags : MonoBehaviour {

	public const int NUM_TEST_FLAGS = 15;
	public int[] testFlagNums;

	public int resultFlagNum = 63;

	private EventFlagSystem efs;

	// Use this for initialization
	void Start () {
		efs = GameObject.Find("EventFlagSystem").GetComponent<EventFlagSystem>();
		testFlagNums = new int[NUM_TEST_FLAGS];
		for (int i = 0; i < NUM_TEST_FLAGS - 1; i++) {
			testFlagNums[i] = EventFlagSystem.NUM_FLAGS - 1;
		}
	}
	
	public void OnFlagSet() {
		if (efs.FlagStatus(resultFlagNum)) {
			return;
		}

		// check all test flags
		bool done = true;
		for (int i = 0; i < NUM_TEST_FLAGS; i++) {
			done = done && efs.FlagStatus(testFlagNums[i]);
		}

		if (done) {
			efs.SetFlag(resultFlagNum);
		}
	}
}

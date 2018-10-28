using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndFlagsClear : MonoBehaviour {
	public int[] testFlagNums;

	public int resultFlagNum = 63;

	private EventFlagSystem efs;

	// Use this for initialization
	void Start () {
		efs = GameObject.Find("EventFlagSystem").GetComponent<EventFlagSystem>();
	}
	
	public void OnFlagSet() {
		if (efs.FlagStatus(resultFlagNum)) {
			return;
		}

		// check all test flags
		bool done = true;
		for (int i = 0; i < testFlagNums.Length; i++) {
			done = done && efs.FlagStatus(testFlagNums[i]);
		}

		if (done) {
			efs.ClearFlag(resultFlagNum);
		}
	}
}

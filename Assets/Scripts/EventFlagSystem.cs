using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public struct Flag {
	public bool status;
	public string note;
}

public class EventFlagSystem : MonoBehaviour {
	public const int NUM_FLAGS = 64;

	public	UnityEvent[] flagNumToOnSetEvents = new UnityEvent[NUM_FLAGS];
	public UnityEvent[] flagNumToOnClearEvents = new UnityEvent[NUM_FLAGS];
	public Flag[] flags = new Flag[NUM_FLAGS];
	public Flag[] flags_internal = new Flag[NUM_FLAGS];

	public void SetFlag(int flagNum) {
		if (flags[flagNum].status == true) {
			return;
		}
		flags[flagNum].status = true;
		flags_internal[flagNum].status = true;
		flagNumToOnSetEvents[flagNum].Invoke();
		Debug.Log("flag num " + flagNum + " set");
	}

	public void ClearFlag(int flagNum) {
		if (!flags[flagNum].status) {
			return;
		}
		flags[flagNum].status = false;
		flags_internal[flagNum].status = false;
		flagNumToOnClearEvents[flagNum].Invoke();
		Debug.Log("flag num " + flagNum + " clear");
	}

	public bool FlagStatus(int flagNum) {
		return flags[flagNum].status;
	}

	private void OnValidate() {
		// loop through the flags to find which one was changed in the editor
		for (int i = 0; i < NUM_FLAGS; i++) {
			if (flags[i].status != flags_internal[i].status) {
				if (flags[i].status) {
					SetFlag(i);
				} else {
					ClearFlag(i);
				}
			}
		}
	}

}

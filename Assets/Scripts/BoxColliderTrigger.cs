using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxColliderTrigger : MonoBehaviour {
	public int flagNum = EventFlagSystem.NUM_FLAGS - 1;

	private EventFlagSystem efs;

	public enum TriggerType {
		setOnEnterOnly,
		setOnExitOnly,

		clearOnEnterOnly,
		clearOnExitOnly,

		setOnEnterClearOnExit,
		setOnExitClearOnEnter
	}

	public TriggerType triggerType = TriggerType.setOnEnterOnly;

	private void Start() {
		efs = GameObject.FindWithTag("EventFlagSystem").GetComponent<EventFlagSystem>();
	}

	private void OnTriggerEnter() {
		switch (triggerType) {
			case TriggerType.setOnEnterOnly:
			case TriggerType.setOnEnterClearOnExit:
				efs.SetFlag(flagNum);
				break;
			case TriggerType.clearOnEnterOnly:
			case TriggerType.setOnExitClearOnEnter:
				efs.ClearFlag(flagNum);
				break;
		}
	}

	private void OnTriggerExit() {
		switch (triggerType) {
			case TriggerType.setOnExitOnly:
			case TriggerType.setOnExitClearOnEnter:
				efs.SetFlag(flagNum);
				break;
			case TriggerType.clearOnExitOnly:
			case TriggerType.setOnEnterClearOnExit:
				efs.ClearFlag(flagNum);
				break;
		}
	}
}

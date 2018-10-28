using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveOnSetInactiveOnClear : MonoBehaviour {
	public int flagNum = EventFlagSystem.NUM_FLAGS - 1;

	public void OnFlagSet() {
		this.gameObject.SetActive(true);
	}

	public void OnClear() {
		this.gameObject.SetActive(false);
	}
}

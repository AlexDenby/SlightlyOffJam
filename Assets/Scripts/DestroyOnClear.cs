using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnClear : MonoBehaviour {
	public void OnFlagClear() {
		Destroy(gameObject);
	}
}

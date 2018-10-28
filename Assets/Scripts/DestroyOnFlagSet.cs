using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnFlagSet : MonoBehaviour {
	public void OnFlagSet() {
		Destroy(gameObject);
	}
}

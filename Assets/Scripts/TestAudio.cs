using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAudio : MonoBehaviour {
	private AudioSource src;

	void Start() {
		src = GetComponent<AudioSource>();
	}

	public void playSrc() {
		src.Play();
	}
}

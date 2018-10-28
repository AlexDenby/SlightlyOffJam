using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {

	private const int BASE_FLAG = 50;
	private const int NUM_MUSICS = 9;

	EventFlagSystem efs;

	public AudioSource[] srcs;
	
	public int currSong = 0;
	
	void Start () {
		efs = GameObject.Find("EventFlagSystem").GetComponent<EventFlagSystem>();

		srcs[currSong].volume = 0.7f;

		currSong = 1;

		srcs[0].mute = false;
	}

	public void StartSong0() {
		Debug.Log("attempting to start song 0");
		// clear the flag
		efs.ClearFlag(BASE_FLAG + 0);

		srcs[currSong].mute = true;

		srcs[0].mute = false;

		currSong = 0;
	}

	public void StartSong1() {
		// clear the flag
		efs.ClearFlag(BASE_FLAG + 1);

		srcs[currSong].mute = true;

		srcs[1].mute = false;

		//srcs[1].Play();
		currSong = 1;
	}

	public void StartSong2() {
		// clear the flag
		efs.ClearFlag(BASE_FLAG + 2);

		srcs[currSong].mute = true;

		srcs[2].mute = false;
		//srcs[2].Play();

		currSong = 2;
	}

	public void StartSong3() {
		// clear the flag
		efs.ClearFlag(BASE_FLAG + 3);

		srcs[currSong].mute = true;

		srcs[3].mute = false;

		//srcs[3].Play();
		currSong = 3;
	}

	public void StartSong4() {
		// clear the flag
		efs.ClearFlag(BASE_FLAG + 4);

		srcs[currSong].mute = true;

		srcs[4].mute = false;

		//srcs[4].Play();
		currSong = 4;
	}

	public void StartSong5() {
		// clear the flag
		efs.ClearFlag(BASE_FLAG + 5);

		srcs[currSong].mute = true;

		srcs[5].mute = false;

		//srcs[5].Play();
		currSong = 5;
	}

	public void StartSong6() {
		// clear the flag
		efs.ClearFlag(BASE_FLAG + 6);

		srcs[currSong].mute = true;

		srcs[6].mute = false;

		//srcs[6].Play();
		currSong = 6;
	}

	public void StartSong7() {
		// clear the flag
		efs.ClearFlag(BASE_FLAG + 7);

		srcs[currSong].mute = true;

		srcs[7].mute = false;

		//srcs[7].Play();
		currSong = 7;
	}

	public void StartSong8() {
		// clear the flag
		efs.ClearFlag(BASE_FLAG + 8);

		srcs[currSong].mute = true;

		srcs[8].mute = false;

		//srcs[8].Play();
		currSong = 8;
	}
}

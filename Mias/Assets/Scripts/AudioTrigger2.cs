using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger2 : MonoBehaviour {

	public GameObject audioCue;
	public GameObject rubbleCue;
	public GameObject exitTrigger;

	[HideInInspector]
	public bool triggerPlayed;
	[HideInInspector]
	public bool rubbleOn;
	[HideInInspector]
	public bool finalCue;

	// Use this for initialization
	void Start () {
		triggerPlayed = false;
		rubbleOn = false;
		finalCue = false;
	}

	void OnTriggerEnter (Collider other) {

		if (other.tag == "Player") {
			if (triggerPlayed == false) {
				Debug.Log ("Suh d00d");
				triggerPlayed = true;
			} else if (triggerPlayed == true) {
				Debug.Log ("Kaboom");
				rubbleOn = true;
				finalCue = true;
				AudioSource sound = rubbleCue.GetComponent<AudioSource> ();
				sound.Play ();

			}
		}
	}
	// Update is called once per frame
	void Update () {
		if (finalCue == true) {
			exitTrigger.GetComponent<Exit> ().exitTrue = true;
			Debug.Log ("Times up my d00d");
		}
	}
}

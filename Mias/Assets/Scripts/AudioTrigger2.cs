using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger2 : MonoBehaviour {

	public GameObject audioCue;
	public GameObject rubbleCue;

	[HideInInspector]
	public bool triggerPlayed;
	[HideInInspector]
	public bool rubbleOn;

	// Use this for initialization
	void Start () {
		triggerPlayed = false;
		rubbleOn = false;
	}

	void OnTriggerEnter () {
		if (triggerPlayed == false){
			Debug.Log ("Suh d00d");
			triggerPlayed = true;
		AudioSource sound = audioCue.GetComponent<AudioSource>();
		sound.Play();
		} else if (triggerPlayed == true) {
			Debug.Log ("Kaboom");
			rubbleOn = true;
			AudioSource sound = rubbleCue.GetComponent<AudioSource> ();
			sound.Play ();
		}
		if (triggerPlayed == true & rubbleOn == true){
			Debug.Log ("Times up my d00d");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

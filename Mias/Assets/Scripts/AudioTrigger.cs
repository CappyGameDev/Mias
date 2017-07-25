using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour {

	public GameObject audioCue;

	private bool triggerPlayed;

	// Use this for initialization
	void Start () {
		triggerPlayed = false;
	}

	void OnTriggerEnter () {
		if (triggerPlayed == false){
			Debug.Log ("Suh d00d");
			triggerPlayed = true;
		AudioSource sound = audioCue.GetComponent<AudioSource>();
		sound.Play();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour {

	private bool triggerPlayed;

	public GameObject exit;

	// Use this for initialization
	void Start () {
		triggerPlayed = false;
	}

	void OnTriggerEnter (Collider other) {

		if (other.tag == "Player"){
		if (triggerPlayed == false){
			Debug.Log ("Suh d00d");
			triggerPlayed = true;
			AudioSource sound = gameObject.GetComponent<AudioSource>();
			sound.Play();
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		if (exit.GetComponent<Exit> ().exitTrue == true) {
			gameObject.GetComponent<AudioSource> ().volume -= Time.deltaTime;
		}
	}
}

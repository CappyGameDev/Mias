using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour {

	public GameObject audioCue;

	// Use this for initialization
	void Start () {
		AudioSource sound = audioCue.GetComponent<AudioSource>();
		sound.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

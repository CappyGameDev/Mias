using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour {

	[HideInInspector]
	public bool exitTrue;

	public GameObject exitDoor;

	// Use this for initialization
	void Start () {
		exitTrue = false;
	}
	
	// Update is called once per frame
	void Update () {
		OpenExit ();
	}

	void OpenExit() {
		if (exitTrue == true){
			exitDoor.GetComponent<MeshRenderer> ().enabled = false;
			exitDoor.GetComponent<BoxCollider> ().isTrigger = true;

		}
	}

	void OnTriggerEnter (Collider other){
		if (other.tag == "Player"){
			exitDoor.GetComponent<MeshRenderer> ().enabled = true;
			AudioSource sound = exitDoor.GetComponent<AudioSource>();
			sound.Play();
		}
	}		
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningAlarm : MonoBehaviour {

	public float spinningSpeed = 3;

	public GameObject exit;

	// Use this for initialization
	void Start () {
		AudioSource sound = gameObject.GetComponent<AudioSource>();
		sound.Play();
		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Rotate (new Vector3 (0, spinningSpeed, 0));
		if (exit.GetComponent<Exit> ().exitTrue == true) {
			gameObject.GetComponent<AudioSource> ().volume -= Time.deltaTime;
		}
	}
}

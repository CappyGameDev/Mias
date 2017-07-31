using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sandslide : MonoBehaviour {

	public GameObject playerController;

	public float alphaRate = 0.01f;
	public float fullAlpha = 1;

	private float timePassed = 1;


	private bool sandSlide;

	void Start () {
		sandSlide = false;
	}

	void Update () {
		if (sandSlide == true) {
			FadeOut ();
		}
	}

	void OnTriggerEnter (Collider other){
		if (other.tag == "Player") {
			AudioSource sound = gameObject.GetComponent<AudioSource> ();
			sound.Play ();
			sandSlide = true;
		}
	}

	void FadeOut (){

		timePassed += Time.deltaTime;

		Image fader = GameObject.Find ("Mr.Fade").GetComponent<Image> ();
		Color faderColor = fader.color;
		faderColor.a = faderColor.a + alphaRate * Time.deltaTime;
		fader.color = faderColor;

		if (timePassed >= 15) {
			Application.Quit ();
		}
	}
}
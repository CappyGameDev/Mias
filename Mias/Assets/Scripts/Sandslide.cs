using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sandslide : MonoBehaviour {

	public float alphaRate = 0.01f;

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
		Image fader = GameObject.Find ("Mr.Fade").GetComponent<Image> ();
		Color faderColor = fader.color;
		faderColor.a = faderColor.a + alphaRate * Time.deltaTime;
		fader.color = faderColor;
	}
}
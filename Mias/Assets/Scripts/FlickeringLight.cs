using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLight : MonoBehaviour {

	public Light light;

	public float minIntensity = 0.25f;
	public float maxIntensity = 0.8f;

	float random;

	// Use this for initialization
	void Start () {
		random = Random.Range (0.0f, 65535.0f);
	}
	
	// Update is called once per frame
	void Update () {
		float noise = Mathf.PerlinNoise (random, Time.time);
		light.intensity = Mathf.Lerp (minIntensity, maxIntensity, noise);
	}
}

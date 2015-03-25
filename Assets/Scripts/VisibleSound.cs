using UnityEngine;
using System.Collections;

public class VisibleSound : MonoBehaviour {

	bool isVisible;

	// Use this for initialization
	void Start () {
		if (GetComponent<Renderer>().isVisible)
			GetComponent<AudioSource>().Play();
			GetComponent<AudioSource>().Play(44100);
	
	}
	
	// Update is called once per frame
	void Update () {


	}
}

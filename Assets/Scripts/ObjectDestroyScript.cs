using UnityEngine;
using System.Collections;

public class ObjectDestroyScript : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	/*void Update () {
		Destroy (GameObject.FindWithTag("Foe"));
	
	}*/
	
	void OnTriggerEnter() {
		Destroy (gameObject);
		
		
	}
	
}
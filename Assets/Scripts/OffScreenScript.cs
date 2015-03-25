using UnityEngine;
using System.Collections;

public class OffScreenScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);
		
		if(screenPos.x < 0){
			print("Left bounds");
		}
		
		else if(screenPos.x > Screen.width)
			print("Right bounds");
	

	
	}
}



using UnityEngine;
using System.Collections;

public class ObjectDestroyScript : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame

	

	void OnCollisonEnter2D(Collision2D coll) 
	{
		if (coll.gameObject.tag == "Collider")
		{
			Destroy(gameObject);

		}
	}
	
}
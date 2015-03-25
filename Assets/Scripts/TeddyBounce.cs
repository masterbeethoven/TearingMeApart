using UnityEngine;
using System.Collections;

public class TeddyBounce : MonoBehaviour {
	
	//Vector2 basePosition = Vector2.zero;
	// Use this for initialization
	void Start () {
		
		//basePosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		//sets a baseposition variable incease along the x axis 
		//basePosition += new Vector2( 0f, 0f);
		
		//transform.position = basePosition + new Vector2(.25f, Mathf.Cos(Time.time) * 1f);
		
		transform.position = new Vector2(402f,Mathf.Sin(Time.time));
		//original bounce code, so like use this after playing around with the other.
		
		//transform.position = new Vector2(50f,0f);
		//first number is x, second is y
		
	}
}
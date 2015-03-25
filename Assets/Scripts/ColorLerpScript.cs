using UnityEngine;
using System.Collections;

public class ColorLerpScript : MonoBehaviour {
	
	/*public Color lerpedColor;
	public Color startColor;
	public Color endColor;
	public float lerpSpeed; 
	public float lerpLoop;
	//public Color actualColor;
	//public Color startColor =new Color(1,1,1,1);//white 
	//public Color endColor=new Color(1, 0, 1, 1); //magenta*/
	
	
	public Color startColor;
	public Color endColor;
	public float lerpSpeed;
	
	SpriteRenderer spriteRenderer;
	
	void Start() {
		spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	void Update(){
		spriteRenderer.color = Color.Lerp(startColor, endColor, Mathf.Sin(Time.time * Mathf.Deg2Rad * lerpSpeed));
	}
}



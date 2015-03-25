using UnityEngine;    
using System.Collections;

public class ScreenConstraints : MonoBehaviour 
{
	public float PlayerSpeed;   
	
	void Update () 
	{
		
		//Amount to move
		// Input.GetAxis MAKES MOOVEMENT LEFT TO RIGHT WITH SMOOTHING
		float amountToMove =Input.GetAxis("Horizontal") * PlayerSpeed * Time.deltaTime;
		
		//Move the Player
		transform.Translate(Vector3.right * amountToMove);
		
		//When Players reaches desired (L/R)possition make him stop
		if (transform.position.x <= -7.5f)
			transform.position = new Vector3(-7.5f, transform.position.y, transform.position.z);
		else if (transform.position.x >=7.5f)
			transform.position = new Vector3(7.5f, transform.position.y, transform.position.z);
	
	}
}

using UnityEngine;
using System.Collections;
using System.IO;

public class TimerScript : MonoBehaviour {
	public float time = 0;
	private bool isRunning = true;
	// Use this for initialization
	const string FILE_NAME = "TimeTrack.txt";
	private int bestScore = 999999999; 
	
	void Start () {

		Debug.Log("time");
		DontDestroyOnLoad(this.gameObject);
		
		StreamReader reader = new StreamReader (FILE_NAME);
		
		string content = reader.ReadLine();
		
		
		
		
		
		int bestScore = int.Parse(content);
		
		reader.Close ();
	}
	
	// Update is called once per frame
	void Update () {
		if(isRunning == true){
			time += Time.deltaTime;
			int tmpTime = (int)Mathf.Floor(time);
			this.gameObject.GetComponent<GUIText>().text = tmpTime.ToString();
		}
	}
	void EndGame(){
		Debug.Log("time");

		//end game here
		//write the time to file
		if(isRunning == true){
			isRunning = false;
			int tmpTime = (int)Mathf.Floor(time);
			//read the file, and get the value
			if(tmpTime < bestScore){
				bestScore = tmpTime;
				StreamWriter writer = new StreamWriter(FILE_NAME, false);
				writer.Write(bestScore);
				writer.Close();
			}
		}
	}
}
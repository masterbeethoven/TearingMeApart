using UnityEngine;
using System.Collections;
using System.IO;

public class SaveStatesScript: MonoBehaviour {
	
	public string fileName;
	
	const char delimiter = '|';
	
	// Use this for initialization
	void Start () {
		
		StreamReader reader = new StreamReader (fileName);
		
		string posStr = reader.ReadLine ();  //posStr == "4.76|8.3|0.1"
		
		reader.Close ();
		
		transform.position = StringToVec3 (posStr);
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown(KeyCode.Space)){
			StreamWriter writer = new StreamWriter(fileName);
			
			writer.Write("" + 
			             transform.position.x  + delimiter +
			             transform.position.y + delimiter +
			             transform.position.z);
			
			writer.Close();
		}
	}
	
	public Vector3 StringToVec3(string str){
		string[] pos = str.Split (new char[]{delimiter}); //pos =  {"4.76", "8.3", "0.1"}
		
		return new Vector3(float.Parse(pos[0]), float.Parse(pos[1]), float.Parse(pos[2]));
	}
}
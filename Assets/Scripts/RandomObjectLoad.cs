using UnityEngine;
using System.Collections;

public class RandomObjectLoad : MonoBehaviour {

	public GameObject[] prefabList;
	// Use this for initialization
	void Start () {

		CreatePrefab();
	
	}

	void CreatePrefab(){

		GameObject clone = Instantiate(prefabList[RandomNumber()])as GameObject;
	}

	int RandomNumber(){

		System.Random rand = new System.Random();
		return rand.Next(0,prefabList.Length);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

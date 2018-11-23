using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kakuritutest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float x = Random.Range(0, 6000);
		Debug.Log (x);
		if (x < 50) {
			Debug.Log ("50以下");
		}
	}
}

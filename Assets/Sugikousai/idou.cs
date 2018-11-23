using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idou : MonoBehaviour {

	public float speed = 0.1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.position += transform.forward * speed * Time.deltaTime;
			Debug.Log ("w");
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.position -= transform.forward * speed * Time.deltaTime;
			Debug.Log ("s");
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.position -= transform.right * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.position += transform.right * speed * Time.deltaTime;
		}
	}
}

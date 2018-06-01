using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretController : MonoBehaviour {

	public float speed = 0.5f;

	public Transform target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var relativePos = target.position - transform.position;
		var rotation = Quaternion.LookRotation(relativePos);
		transform.rotation =
		Quaternion.Slerp (transform.rotation, rotation, Time.deltaTime * speed);

		//StegeManager.instance.GetPlayerLookPoints (transform);
	}
}

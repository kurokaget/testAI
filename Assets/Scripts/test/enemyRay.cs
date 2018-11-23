using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyRay : MonoBehaviour {

	public Transform target;

	public float miniRotation = 0.0f;

	public float maxRotation = 360.0f;

	public LayerMask mask;

	int y = 0;

	//private int TEST = 0;

	public int test = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

		float myRotation = this.transform.rotation.y;

		transform.LookAt (target);


		Ray ray = new Ray (transform.position, transform.forward);
		float maxDistance = 500;
		Debug.DrawRay (ray.origin, ray.direction * maxDistance, Color.green, 5, false);
	
		//Debug.Log (myRotation);

		RaycastHit hit;

		int PlayerLayer = LayerMask.NameToLayer("Player");
		int WallLayer = LayerMask.NameToLayer("Wall");
		int Mask = 1<<PlayerLayer | 1<<WallLayer;

		if (Physics.Raycast (ray, out hit, Mathf.Infinity, Mask)) {

			//Debug.Log (hit.collider.tag);

			if (hit.collider.tag == "Player") {

				test = 1;
				//Debug.Log ("見つけた");
				//hit.collider.GetComponent<MeshRenderer> ().material.color = Color.red;

			}else {

				test  = 0;
				//y = y + 1;
				//Debug.Log ("見失った");

			}
		}else {

			test  = 1;
			//y = y + 1;
			//Debug.Log ("見失った");

		}

	}
}

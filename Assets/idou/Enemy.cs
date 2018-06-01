using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	public float speed = 0.1f;
	public float varSpeed = 1f;
	public float EngagementDistance = 10f;
	public Transform target;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		float distance = Vector3.Distance(transform.position, target.position);
		if (distance < EngagementDistance) {
			transform.position -= transform.forward * speed * Time.deltaTime;
		}
		transform.LookAt (target);
		transform.position += transform.forward * speed * Time.deltaTime;
	}

	void OnTriggerEnter(Collider other){
		Debug.Log ("当たった");
		if (other.gameObject.tag == "Bullet") {
			
		}
	}
}

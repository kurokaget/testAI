using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour {
	public float speed = 1f;
	public float varSpeed = 1f;
	public float EngagementDistance = 10f;
	public Transform target;
	public Transform bullet;
	public Const.AIController state;
	UnityEngine.AI.NavMeshAgent agent;

	// Use this for initialization
	void Start () {
		GameObject player = GameObject.Find ("FPSController");
		target = player.transform;
		agent = GetComponent<UnityEngine.AI.NavMeshAgent> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.P)) {
			state = Const.AIController.Assault;
		}
		switch (state) {
		case Const.AIController.Wait:
			print ("待機");
			break;
		case Const.AIController.TemporaryEvacuation:
			print ("退避");
			break;
		case Const.AIController.Assault:
			float distance = Vector3.Distance(transform.position, target.position);
			if (distance < EngagementDistance) {
				transform.position -= transform.forward * speed * Time.deltaTime;
				}
				transform.LookAt (target);
				transform.position += transform.forward * speed * Time.deltaTime;
			print ("コンギョ!");
			break;

		case Const.AIController.Advance:
			transform.LookAt (target);
			transform.position += transform.forward * speed * Time.deltaTime;
			float bulletdistance = Vector3.Distance (transform.position, bullet.position);
			if (bulletdistance < EngagementDistance) {
				state = Const.AIController.Wait;
			}
		print ("前進!!");
		break;
		}
	}
}

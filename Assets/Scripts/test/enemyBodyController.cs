using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyBodyController: MonoBehaviour {

	[SerializeField]private enemyRay RayScript;

	[SerializeField]private SearchTarget searchTarget;

	private new Vector3 enemypos;

	int i = 0;
	int search = 0;

	float j = 0.0f;

	//public Transform[] points;

	//private int destPoint = 0;

	NavMeshAgent agent;

	// Use this for initialization
	void Start () {
		//GameObject RayObject = transform.Find ("Ray").gameObject;
		//enemyRay RayScript = RayObject.GetComponent<enemyRay>();
		agent = GetComponent<NavMeshAgent> ();

		agent.autoBraking = false;

		//agent.destination = points [destPoint].position;
		//destPoint = (destPoint + 1);
		//if (destPoint >= points.Length) {
		//s	destPoint = 0;
		//}
	}

	/*void GotoNextPoint()
	{
		if (points.Length == 0) {
			return;
		}
		if (i == 1 && j > 0.5f) {
			return;
		} else {
			
			agent.destination = points [destPoint].position;
			destPoint = (destPoint + 1) % points.Length;
		}
	}*/
	
	// Update is called once per frame
	void Update () {
		enemypos = transform.position;
		//GameObject RayObject = transform.Find (Ray).gameObject;
		//enemyRay RayScript = RayObject.GetComponentInChildren<enemyRay>();
		i = RayScript.test;
		j = searchTarget.Danger;
		if (i == 1) {
			//Debug.Log ("障害物なし");
		} else {
			//Debug.Log ("障害物あり");
		}

		if (j > 0.5f) {
			//Debug.Log ("視界内に入っている");
		}else{
			//Debug.Log ("視界に入っていない");
		}

		if (i == 1 && j > 0.1f) {
			search = 1;
			//Debug.Log ("見つけている");
			agent.SetDestination(searchTarget.transform.position);
		} else {
			//Debug.Log("見失っている");
			search = 0;
			//Debug.Log (destPoint);
			//if (!agent.pathPending && agent.remainingDistance < 0.5f) {
				//agent.SetDestination(points [destPoint].position);
				//destPoint = destPoint + 1;
				//if (destPoint >= points.Length) {
					//destPoint = 0;
				//}
			//}
		}

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class bodyController : MonoBehaviour 
{
	public GameObject QueryPoint;
	NavMeshAgent agent;

	void Start () {
		//QueryPoint = StegeManager.instance.GetNearPoints (transform);
		//agent = GetComponent<NavMeshAgent> ();
		//agent.SetDestination(target.transform.position);

	}

	void Update(){
		QueryPoint = StegeManager.instance.GetNearPoints (transform);
		//StegeManager.instance.GetPlayerProgressingDirection (transform);
		agent = GetComponent<NavMeshAgent> ();
		agent.SetDestination(QueryPoint.transform.position);
	}
}
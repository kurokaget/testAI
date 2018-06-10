using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class bodyController : MonoBehaviour 
{
	[SerializeField] private QueryPoint targetPoint;
	NavMeshAgent agent;

	IEnumerator Start () {
		while (true) {
			yield return new WaitForSeconds(1.0f);
			targetPoint = StegeManager.instance.GetNearPoints (transform);
			agent = GetComponent<NavMeshAgent> ();
			agent.SetDestination(targetPoint.transform.position);
		}
	}
}
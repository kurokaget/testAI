using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class QueryPoint : MonoBehaviour {
	
	public int Danger = 0;
	public int watchingCount;
	public List<turretController> turrets = new List<turretController>();

	void Start () {
		turrets.AddRange ( GameObject.FindObjectsOfType<turretController>().ToList() );
	}

	void Update () {
		Danger = 0;
		foreach (var t in turrets) {
			var forward = t.transform.forward; 
			var toOther = Vector3.Normalize(transform.position - t.transform.position);
			var dot = Vector3.Dot(forward, toOther);
			if ( dot > 0.98f ) Danger += 1;
		}
		if (Danger == 0) {
			GetComponent<Renderer> ().material.color = Color.white;
		} else if (Danger == 1) {
			GetComponent<Renderer> ().material.color = Color.yellow;
		} else if (Danger == 2) {
			GetComponent<Renderer> ().material.color = Color.red;
		}
	}
}

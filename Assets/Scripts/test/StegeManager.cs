using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class StegeManager : MonoBehaviour {

	public static StegeManager instance;

	public GameObject queryPointPrefab;
	public List<QueryPoint> queryPoints = new List<QueryPoint> ();

	public int xMaximum = 25;
	public int yMaximum = 0;
	public int zMaximum = 25;

	public int xMinimum = -25;
	public int yMinimum = 0;
	public int zMinimum = -25;

	public int spacing = 5;

	int i,j;

	void Start () {
		instance = this;
		for (i = xMinimum; i < xMaximum; i++) {
			for (j = zMinimum; j < zMaximum; j++) { 
				var obj = Instantiate (queryPointPrefab) as GameObject;
				obj.transform.SetParent (transform);
				obj.transform.localPosition = new Vector3 (i*spacing,0,j*spacing);
				var queryPoint = obj.GetComponent<QueryPoint> ();
				queryPoints.Add (queryPoint);
				queryPoint.name = ("QueryPoint") + i +(",")+ j;
			}
		}
	}

	/*
	public void GetPlayerLookPoints (Transform Turret) {
		foreach (var q in queryPoints) {
			q.GetComponent<Renderer> ().material.color = Color.white;
			q.Danger = 0;
		}
		var points = queryPoints.Where (q => { 
			var forward = Turret.transform.forward; 
			var toOther = Vector3.Normalize(q.transform.position - Turret.position);
			var dot = Vector3.Dot(forward, toOther);
			return dot > 0.8f;
		}).ToList ();
		foreach (var q in points)
			q.GetComponent<Renderer> ().material.color = Color.red;
		foreach (var q in points)
			q.Danger += 1;
	}
*/
	//==========ここら辺製作中=============
	public void GetPlayerProgressingDirection (Transform SoldierA) {
		foreach (var q in queryPoints) {
			q.GetComponent<Renderer> ().material.color = Color.white;
			// q.Danger -= 1;
		}
		var points = queryPoints.Where (q => { 
			var forward = SoldierA.transform.forward; 
			var toOther = Vector3.Normalize(q.transform.position - SoldierA.position);
			var dot = Vector3.Dot(forward, toOther);
			return dot > 0.995f;
		})
			.Where (q => Vector3.Distance (q.transform.position, SoldierA.position) <= 50)
			.ToList ();
			foreach (var q in points)
			q.GetComponent<Renderer> ().material.color = Color.green;
	}



	public GameObject GetNearPoints (Transform SoldierA) {
		//foreach (var q in queryPoints) {
			//q.GetComponent<Renderer> ().material.color = Color.white;
		//}
		var point = queryPoints
			.Where (q => Vector3.Distance (q.transform.position, SoldierA.position) < 20f)
			.OrderBy (q => q.Danger)
			.First ();
		point.GetComponent<Renderer> ().material.color = Color.blue;
		return point.gameObject;
	}
}








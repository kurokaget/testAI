using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class QueryPoint : MonoBehaviour {
	
	[SerializeField] private float danger = 0;
	public float Danger { get{ return danger; } }
	public int watchingCount;
	public List<turretController> turrets = new List<turretController>();

	const float turretAttackRange = 150f;
	private Material material;

	void Start () {
		turrets.AddRange ( GameObject.FindObjectsOfType<turretController>().ToList() );
		material = GetComponent<Renderer>().material;
	}

	void Update () {
		danger = 0;
		foreach (var t in turrets) {
			var forward = t.transform.forward; 
			var toOther = Vector3.Normalize(transform.position - t.transform.position);
			var dot = Vector3.Dot(forward, toOther);
			var distance = Vector3.Distance(transform.position, t.transform.position);
			var d = 1f - (distance / turretAttackRange);
			if (d < 0) d = 0;
			if ( dot > 0.98f ) danger += d;
		}

		material.color = new Color(1f, 1f-danger, 1f-danger, 1);

	}
}

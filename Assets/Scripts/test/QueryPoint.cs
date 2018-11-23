using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class QueryPoint : MonoBehaviour {
	
	[SerializeField] private LayerMask obstacleMask;
	[SerializeField] private float danger = 0;
	public float Danger { get{ return danger; } }
	public float AttackPoint;
	public int watchingCount;
	public List<turretController> turrets = new List<turretController>();
	public int syougaibutu;

	private int enemynum;
	private new Vector3 enemypos;

	const float turretAttackRange = 150f;
	private Material material;

	public LayerMask mask;

	void Start () {
		turrets.AddRange ( GameObject.FindObjectsOfType<turretController>().ToList() );
		material = GetComponent<Renderer>().material;
		var meshRenderer = GetComponent<MeshRenderer> ();
		if (StegeManager.instance.showQueryPoint) {
			meshRenderer.enabled = true;
		} else {
			meshRenderer.enabled = false;
		}

		//int EnemyLayer = LayerMask.NameToLayer("Enemy");
		//int WallLayer = LayerMask.NameToLayer("Wall");
		//int Mask = 1<<EnemyLayer | 1<<WallLayer;
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

		material.color = new Color(1f, 1f-danger, 1f-danger, danger+.1f);



		enemynum = turrets.Count;
		//Debug.Log (turrets.Count);
		for (int i = 0; i < enemynum; i++) {
			//enemypos = Vector3.Angle (transform.position,turrets [i].transform.position);
			//Debug.Log (enemypos);
			var dir = turrets[i].transform.position - transform.position;
			Ray ray = new Ray (transform.position, dir);
			//float maxDistance = 500;
			//Debug.DrawRay (ray.origin, ray.direction * maxDistance, Color.blue, 5, false);

			RaycastHit hit;
			int EnemyLayer = LayerMask.NameToLayer("Enemy");
			int WallLayer = LayerMask.NameToLayer("Wall");
			int Mask = 1<<EnemyLayer | 1<<WallLayer;

			if (Physics.Raycast (ray, out hit, Mathf.Infinity, Mask)) {
				if (hit.collider.tag == "Enemy") {
					syougaibutu = 0;
				} else {
					syougaibutu = 1;
					material.color = new Color (0,0,255);
				}
			} else {
				syougaibutu = 1;
				material.color = new Color (0,0,255);
			}
		}
	}
}

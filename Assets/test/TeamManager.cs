using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeamManager : MonoBehaviour {

	public Const.TeamType teamType;
	public GameObject soldierPrefab;

	public List<SoldierController> soldiers = new List<SoldierController>();

	public int Nunber = 10;

	public Vector3 maximum = new Vector3 (1.0f, 1.0f, 1.0f);
	public Vector3 minimum = new Vector3 (-1.0f, 1.0f, -1.0f);

	private void Start () {
		for (int i = 0; i < Nunber; i++) {
			var obj = Instantiate (soldierPrefab);
			obj.transform.SetParent (transform);
			var soldier = obj.GetComponent<SoldierController> ();
			soldier.transform.position = transform.position
				+ new Vector3 (Random.Range(maximum.x, minimum.x), Random.Range(maximum.y, minimum.y),Random.Range(maximum.z, minimum.z)); 
			soldier.teamManager = this;
			soldiers.Add (soldier);
		}
	}

}

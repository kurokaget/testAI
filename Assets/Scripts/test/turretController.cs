using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretController : MonoBehaviour {

	public float speed = 0.5f;

	public Transform target;

	public new Vector3 mypos;

	// Use this for initialization
	/*IEnumerator Start () {
		
		while (true) {
			yield return new WaitForSeconds (1);
			//Debug.Log("10秒");
			target = StegeManager.instance.GetRondomPoint().transform;
			yield return new WaitForSeconds (10);
		}
	}*/
	
	// Update is called once per frame
	void Update () {
		var relativePos = target.position - transform.position;
		var rotation = Quaternion.LookRotation(relativePos);
		transform.rotation =
		Quaternion.Slerp (transform.rotation, rotation, Time.deltaTime * speed);

		Transform mypos = this.transform;
		//StegeManager.instance.GetPlayerLookPoints (transform);
	}
}

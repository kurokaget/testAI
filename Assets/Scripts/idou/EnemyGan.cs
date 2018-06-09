using UnityEngine;
using System.Collections;

public class EnemyGan : MonoBehaviour {
	public Transform target;
	public GameObject bullet;
	public float bulletSpeed = 100f;
	public float shotDestance = 30.0f;
	private float currentCoolTime;
	public float coolTime = 0.2f;
	public float dispersion = 1.0f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float distance = Vector3.Distance(transform.position, target.position);
		if (distance < shotDestance) {
			currentCoolTime -= Time.deltaTime;
			if (currentCoolTime < 0) {
				currentCoolTime += coolTime;
				Gun ();

			}
		}
	}
	void Gun () {
		Debug.Log ("敵発砲");
		float y = Random.Range(-dispersion, dispersion);
		float x = Random.Range(-dispersion, dispersion);
		transform.Rotate(new Vector3(x,y,0));
		GameObject obj = Instantiate (bullet, transform.position, transform.rotation) as GameObject;
		obj.GetComponent<Rigidbody> ().velocity = obj.transform.up * bulletSpeed;
	}
}

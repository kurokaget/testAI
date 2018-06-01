using UnityEngine;
using System.Collections;

public class EnemyBulletScript : MonoBehaviour {

	private Rigidbody rigidbody;

	private float minVelocity = 1.0f;

	private int basePower = 1;

	public int Power {
		get {
			int power = (int)(basePower * rigidbody.velocity.magnitude);
			return power;
		}
	}

	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody.velocity *= 0.89f;
		if (rigidbody.velocity.magnitude < minVelocity) {
			Destroy (this.gameObject);
		}
	}

	void OnTriggerEnter(Collider other){
		Debug.Log ("当たった");
		if (other.gameObject.tag == "Player") {
			Destroy (this.gameObject);
		}
		if (other.gameObject.tag == "Terrain") {
			Destroy (this.gameObject);
		}
	}
}

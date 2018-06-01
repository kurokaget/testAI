using UnityEngine;
using System.Collections;

public struct BulletData{

}

public class BulletScript : MonoBehaviour {
	
	private Rigidbody rigidbody;

	private float minVelocity = 1.0f;

	private int basePower = 1;


	private 

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
		if (other.gameObject.tag == "Enemy") {
			Destroy (this.gameObject);
		}
		if (other.gameObject.tag == "Terrain") {
			Destroy (this.gameObject);
		}
	}
}

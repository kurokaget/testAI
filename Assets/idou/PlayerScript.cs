using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	public float speed = 0.1f;
	public float turning = 1f;
	public float HP = 10f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			transform.position += transform.forward * speed * Time.deltaTime;
			Debug.Log ("w");
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.position -= transform.forward * speed * Time.deltaTime;
			Debug.Log ("s");
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.position -= transform.right * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.position += transform.right * speed * Time.deltaTime;
		}

		//if (HP <= 0) {
		//	Destroy (this.gameObject);
		//}
	}
	void OnTriggerEnter(Collider other){
		Debug.Log ("当たった");
		if (other.gameObject.tag == "EnemyBullet") {
			HP -= 10;
		}
	}
}

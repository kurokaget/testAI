using UnityEngine;
using System.Collections;

public class Jamp2 : MonoBehaviour {
	private Rigidbody _rigidbody;
	public float power = 500f;
	public float boostPower = 1000f;
	public float coolTime = 2f;
	private float currentCoolTime;
	int i,j;
	public float speed = 0.1f;

	private float maxVelocity = 5f;

	// Use this for initialization
	void Start () {
		_rigidbody = this.GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		if(i < 1){
			if(Input.GetKeyDown (KeyCode.Space)) {
				this._rigidbody.AddForce (Vector3.up * power);
				Debug.Log ("Jump");
				i = 1;
			}
		}
		if (Input.GetKey (KeyCode.Space)) {
			transform.position += transform.up * speed * Time.deltaTime;
			Debug.Log ("w");
		}
		currentCoolTime -= Time.deltaTime;
		if (currentCoolTime < 0) {
			
			if(Input.GetKeyDown (KeyCode.Q)) {
				this._rigidbody.AddForce (-transform.right * boostPower);
				Debug.Log ("qb");
				currentCoolTime = coolTime;
			}
			if(Input.GetKeyDown (KeyCode.E)) {
				this._rigidbody.AddForce (transform.right * boostPower);
				Debug.Log ("qb");
				currentCoolTime = coolTime;
			}

			if (_rigidbody.velocity.magnitude > maxVelocity) {
				_rigidbody.velocity = _rigidbody.velocity.normalized * maxVelocity;
			}
		}
	}
	void OnTriggerEnter(Collider other){
		Debug.Log ("当たった");
		if (other.gameObject.tag == "Terrain") {
			Debug.Log ("地面");
			i = 0;
		}
	}
}

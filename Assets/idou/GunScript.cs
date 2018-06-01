using UnityEngine;
using System.Collections;

public class GunScript : MonoBehaviour {

	public GameObject bullet;

	public float bulletSpeed = 10f;

	public float bulleNnumder = 30f;

	private float currentCoolTime;
	public float coolTime = 0.2f;

	public float LoadingTime = 3f;

	float i;

	// Use this for initialization
	void Start () {
		i += bulleNnumder;
	}

	void Update() {

		currentCoolTime -= Time.deltaTime;
		if (Input.GetKeyDown (KeyCode.R)) {
			i = bulleNnumder;
			Debug.Log (i);
		}
		if (Input.GetMouseButton (0)) {
			if (currentCoolTime < 0) {
					currentCoolTime = coolTime;
					OnMouseDown ();
			}
		}
	}

	// Update is called once per frame
	void OnMouseDown () {
		Debug.Log ("おされてる？");
		GameObject obj = Instantiate (bullet, transform.position, transform.rotation) as GameObject;
		obj.GetComponent<Rigidbody> ().velocity = obj.transform.up * bulletSpeed;
		i--;
		Debug.Log (i);
	}
}


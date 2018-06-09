using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerController : MonoBehaviour {
	public float speed = 0.1f;
	public float turning = 1f;
	[SerializeField]private MouseLook mouseLook;
	[SerializeField]private GameObject mainCamera;
	// Use this for initialization
	void Start () {
		mouseLook.Init (transform, mainCamera.transform);
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
		RotateView ();

		if (Input.GetKeyDown (KeyCode.L)) {
			StegeManager.instance.GetNearPoints (transform);
		}
		//StegeManager.instance.GetPlayerLookPoints (transform);
	}

	void FixedUpdate(){
		mouseLook.UpdateCursorLock ();
	}

	private void RotateView(){
		mouseLook.LookRotation (transform, mainCamera.transform);
	}
}
using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

	protected Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.Space)) {

			Debug.Log("Jump");

			animator.SetBool ("Jump", false);

		} else {
			animator.SetBool ("Jump", true);
		}
	}
}

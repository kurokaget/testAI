using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class TestButton : MonoBehaviour {

	// Use this for initialization
	private Button button;
	private UnityAction action;
	void Start () {
		button = GetComponent<Button> ();
		button.onClick.AddListener (() => {
			if(action == null)return;
			action();
		});
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			action = null;
		}
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			action += () => {
				print ("add up");
			};
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			action += () => {
				print("add down");
			};
		}
	}
}

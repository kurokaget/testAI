using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class GameClear : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			EditorSceneManager.LoadScene ("sugikousai_scene1");
		}
	}
}

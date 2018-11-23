using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class Goal : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			EditorSceneManager.LoadScene ("sugikousai_scene2");
		}
	}
}

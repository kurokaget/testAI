using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class testList : MonoBehaviour {



	//using System.Collections.Generic;
	void Start () {
		List<string> TestList = new List<string> ();
		TestList.Add ("honda");
		TestList.Add ("toyota");
		TestList.Add ("1");
		TestList.Add ("1145141919810");
		var test = TestList.Where(t => t.Length > 6).ToList();
		foreach (var t in test) {
			print (t);
		}

	}

	void Update () {
		//Debug.Log (TestList [1]);
	}
}
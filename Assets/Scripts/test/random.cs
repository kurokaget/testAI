using UnityEngine;
using System.Collections;

public class random : MonoBehaviour {


	//プレハブを変数に代入
	public GameObject cube;

	public float xMaximum = 1.0f;
	public float yMaximum = 1.0f;
	public float zMaximum = 1.0f;

	public float xMinimum = -1.0f;
	public float yMinimum = 0f;
	public float zMinimum = -1.0f;

	public int Nunber = 5;

	int i;

	void Start () {


		//オブジェクトの座標
		//float x = Random.Range(0.0f, x);
		//float y = Random.Range(0.0f, y);
		//float z = Random.Range(0.0f, z);

		//オブジェクトを生産
		for (i = 0; i < Nunber; i++) {
			float x = Random.Range(xMinimum, xMaximum);
			float y = Random.Range(yMinimum, yMaximum);
			float z = Random.Range(zMinimum, zMaximum);
			Instantiate (cube, new Vector3 (x, y, z), Quaternion.identity);
		}
	}

}

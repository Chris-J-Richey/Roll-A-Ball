using UnityEngine;
using System.Collections;

public class Placer : MonoBehaviour {

	float x;
	float y;
	float z;
	Vector3 pos;

	void Start(){

		x = Random.Range(-9, 9);
		y = 0.5f;
		z = Random.Range(-9, 9);
		pos = new Vector3(x, y, z);
		transform.position = pos;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteorite : MonoBehaviour {
	private float speed;

	public void Init(Vector3 _pos){
		speed = 6.0f;
		transform.position = _pos;
	}

	void Update () {
		transform.position += Vector3.down * speed * Time.deltaTime;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour {
	private float speed;

	public void Init(Vector3 _pos){
		transform.position = _pos;
		speed = 5.0f;
	}

	void Update () {
		transform.position += Vector3.down * speed * Time.deltaTime;
	}
}

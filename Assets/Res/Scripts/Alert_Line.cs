using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alert_Line : MonoBehaviour {
	private Renderer render;
	private bool isFadeIn;

	public void Init(Vector3 _pos){
		render = GetComponent<Renderer> ();
		isFadeIn = false;
		transform.position = _pos;
	}
	void Update () {
		Color color = render.material.color;

		if (isFadeIn) {
			if (color.a < 1.0f)
				color.a += 0.2f;
			else
				isFadeIn = false;
		} else {
			if (color.a > 0.0f)
				color.a -= 0.2f;
			else
				isFadeIn = true;
		}
		render.material.color = color;
	}
}

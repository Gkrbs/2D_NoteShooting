using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {
    [SerializeField] Background target;
    private float speed;
	// Use this for initialization
	void Start () {
        speed = 5.0f;
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y > -9.9f)
            transform.position += Vector3.down * speed * Time.deltaTime;
        else
            transform.position = target.transform.position + new Vector3(0.0f, 9.9f, 0.0f);
	}
}

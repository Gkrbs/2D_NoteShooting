using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {
    private float speed;

	// Use this for initialization
	void Start () {
        speed = 5.0f;	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (transform.position.y < 4.5f)
                transform.position += Vector3.up * speed * Time.deltaTime;
            else
                transform.position = new Vector3(transform.position.x, 4.5f, 0.0f);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            if (transform.position.y > -4.5f)
                transform.position += Vector3.down * speed * Time.deltaTime;
            else
                transform.position = new Vector3(transform.position.x, -4.5f, 0.0f);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x > -3.0f)
                transform.position += Vector3.left * speed * Time.deltaTime;
            else
                transform.position = new Vector3(-3.0f, transform.position.y, 0.0f);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.position.x < 3.0f)
                transform.position += Vector3.right * speed * Time.deltaTime;
            else
                transform.position = new Vector3(3.0f, transform.position.y, 0.0f);
        }
    }
}

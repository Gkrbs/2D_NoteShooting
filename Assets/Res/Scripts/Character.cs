using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {
    [SerializeField] GameObject bulletPrefab;
    private float speed;

	// Use this for initialization
	void Awake () {
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject clone = Instantiate(bulletPrefab);
            clone.transform.position = transform.position + new Vector3(0.0f, 0.8f, 0.0f);
        }
    }
}

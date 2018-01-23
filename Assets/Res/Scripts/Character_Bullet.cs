using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Bullet : MonoBehaviour {
    Rigidbody2D rigid;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        rigid.velocity = new Vector2(0.0f, 5.0f);
    }
}

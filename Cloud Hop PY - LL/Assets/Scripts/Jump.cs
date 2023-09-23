﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    Rigidbody2D rigidbody;
    public float jumpForce = 15;
    bool canJump;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rigidbody.velocity.y > -0.1 && rigidbody.velocity.y < 0.1){
            canJump = true;
        } else {
            canJump = false;
        }

        if (Input.GetButtonDown("Jump") && canJump){
            rigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}

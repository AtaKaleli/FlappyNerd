using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyNerd : MonoBehaviour
{


    private Rigidbody2D rb;


    [SerializeField] private float jumpForce;



    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void Jump()
    {
        rb.velocity = new Vector2(0, jumpForce);
    }
}

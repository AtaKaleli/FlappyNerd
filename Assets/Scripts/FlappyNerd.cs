using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyNerd : MonoBehaviour
{


    private Rigidbody2D rb;
    private Animator anim;


    [SerializeField] private float jumpForce;



    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }


        AnimationController();
    }

    private void Jump()
    {
        rb.velocity = new Vector2(0, jumpForce);
    }

    private void AnimationController()
    {
        anim.SetFloat("yVelocity", rb.velocity.y);
    }
}

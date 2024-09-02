using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyNerd : MonoBehaviour
{


    private Rigidbody2D rb;
    private Animator anim;


    [SerializeField] private float jumpForce;

    private GameManager gameManager;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameManager = GameManager.instance;
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


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "DeathZone")
        {
            Destroy(gameObject);
            gameManager.isPlayerDead = true;
            gameManager.ClearTimeScale(); 
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "ObstacleBody")
        {
            gameManager.CountPoint();
        }
        print(gameManager.point);
    }

}

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
        rb.gravityScale = 0;
        gameManager.death = PlayerPrefs.GetInt("TotalDeath");
    }


    void Update()
    {
        if (GameManager.instance.isBirdDead)
            return;

        

        
        


    }

    public void Jump()
    {
        AudioManager.instance.PlaySFX(3);
        rb.velocity = new Vector2(0, jumpForce);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "DeathZone")
        {
            GameManager.instance.isSpacePressedForMobile = true;
            gameManager.isGameStarted = false;
            gameManager.isBirdDead = true;
            PlayerPrefs.SetInt("RoundScore", gameManager.score);
            AudioManager.instance.PlaySFX(0);
            UI_Ingame.instance.ClearIngameUI(2);
            gameManager.CountDeath();
            SaveSystem.instance.SaveBestScore();
            SaveSystem.instance.SaveTotalDeath();
            Destroy(gameObject);
            Time.timeScale = 0;
        }
        if (collision.tag == "ObstacleBody")
        {
            AudioManager.instance.PlaySFX(1);
            gameManager.CountScore();
        }
    }

    

}

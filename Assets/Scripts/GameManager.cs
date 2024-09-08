using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    private FlappyNerd bird;

    public int death;
    public int score;
    public int bestScore;
    public bool isGamePaused;
    public bool isGameStarted;
    public bool isBirdDead;

    [SerializeField] private Animator groundAnim;

    private UI_Ingame inGameUI;

    private void Awake()
    {
        

        if (instance == null)
            instance = this;
        else
            Destroy(this.gameObject);

        
    }

    private void Start()
    {
        inGameUI = UI_Ingame.instance;
        bird = FindObjectOfType<FlappyNerd>(true);
        if (bird == null)
            print("null");

        
        
    }

    private void Update()
    {
        GroundAnimController();

        if (isBirdDead)
            return;


        if (!isGameStarted && Input.GetKeyDown(KeyCode.Space))
        {
            inGameUI.ClearIngameUI();
            bird.gameObject.GetComponent<SpriteRenderer>().enabled = true;
            isGameStarted = true;
            Time.timeScale = 1;
            bird.gameObject.GetComponent<Rigidbody2D>().gravityScale = 4;
            bird.Jump();
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            isGamePaused = !isGamePaused;
        }
    }

    private void GroundAnimController()
    {
        if (!isGameStarted)
            groundAnim.speed = 0;
        else
            groundAnim.speed = 1;
    }

    public void CountScore()
    {
        score++;
    }

    

    public void SetTimeScale()
    {
        Time.timeScale = 1;
    }

    public void CountDeath()
    {
        death++;
    }




}

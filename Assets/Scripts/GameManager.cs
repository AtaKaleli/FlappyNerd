using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;


    public int point;
    public bool pressToStart = false;
    public bool isBirdDead = false;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        if (instance == null)
            instance = this;
        else
            Destroy(this.gameObject);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && isBirdDead)
            RestartGame();

        if(pressToStart && Input.GetKeyDown(KeyCode.Space))
        {
            pressToStart = false;
            Time.timeScale = 1;
        }
    }

    public void CountPoint()
    {
        point++;
    }

    public void RestartGame()
    {
        point = 0;
        SceneManager.LoadScene("SampleScene");
        pressToStart = true;
        isBirdDead = false;

    }

    public void SetTimeScale()
    {
        Time.timeScale = 1;
    }

    public void ClearTimeScale()
    {
        Time.timeScale = 0;
    }




}

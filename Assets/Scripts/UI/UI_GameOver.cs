using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_GameOver : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI bestScoreText;
    




    private void Start()
    {
        scoreText.text = GameManager.instance.score.ToString();
        bestScoreText.text = PlayerPrefs.GetInt("BestScore").ToString();
    }

    

    public void QuitGame()
    {
        Application.Quit();
    }



}

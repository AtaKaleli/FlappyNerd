using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    public static SaveSystem instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this);
    }



    public void SaveBestScore()
    {
        int roundScore = PlayerPrefs.GetInt("RoundScore");
        int bestScore = PlayerPrefs.GetInt("BestScore");

        if (roundScore > bestScore)
        {
            PlayerPrefs.SetInt("BestScore", roundScore);
        }
    }

    public void SaveTotalDeath()
    {
        int death = GameManager.instance.death;
        PlayerPrefs.SetInt("TotalDeath", death);
    }

    public void SaveTotalTime()
    {

    }


}

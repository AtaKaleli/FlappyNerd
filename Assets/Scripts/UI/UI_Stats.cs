using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_Stats : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI bestScoreText;
    [SerializeField] private TextMeshProUGUI totalDeathText;
  

    private void Start()
    {
        
        bestScoreText.text = PlayerPrefs.GetInt("BestScore").ToString();
        totalDeathText.text = PlayerPrefs.GetInt("TotalDeath").ToString();
      
    }
}
